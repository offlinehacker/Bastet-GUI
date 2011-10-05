using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Reflection;

namespace TROL_MgmtGui2
{
    public partial class Form1 : Form
    {
        private BastetCommunication cBastetCommunication;
        bool MotorDirection = false;

        public Form1()
        {
            InitializeComponent();
            //Adds event handler for adding new row to BASYS_ADDR
            devices.BASYS_ADDR.TableNewRow += new DataTableNewRowEventHandler(new DataTableNewRowEventHandler(BASYS_ADDR_TableNewRow));
            //Fill datasets.
            FillDataset();
            //Initializes bastet communcations.
            cBastetCommunication = new BastetCommunication(devices, this);
        }

        ~Form1()
        {
            cBastetCommunication.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (!cBastetCommunication.Open())
                MessageBox.Show("Cannot open serial port!");
            devices.BASYS_ADDR.AddBASYS_ADDRRow(0, 0, 0, 0);
        }

        private void UInt16ToHexString(object sender, ConvertEventArgs cevent)
        {
            // The method converts only to string type. Test this using the DesiredType.
            if (cevent.DesiredType != typeof(string)) return;

            // Use the ToString method to format the value as currency ("c").
            cevent.Value = "0x"+((int)cevent.Value).ToString("x");
        }

        /// <summary>
        /// Fills datasets using table adapters.
        /// </summary>
        private void FillDataset()
        {
            tableAdapterManager1.BAFS_PRTableAdapter.Fill(bastetParametersDataSet1.BAFS_PR);
            tableAdapterManager1.BAFS_PSTableAdapter.Fill(bastetParametersDataSet1.BAFS_PS);
            tableAdapterManager1.BAMOT_PRTableAdapter.Fill(bastetParametersDataSet1.BAMOT_PR);
            tableAdapterManager1.BAMOT_PSTableAdapter.Fill(bastetParametersDataSet1.BAMOT_PS);
            tableAdapterManager1.BAREM_PRTableAdapter.Fill(bastetParametersDataSet1.BAREM_PR);
            tableAdapterManager1.BAREM_PSTableAdapter.Fill(bastetParametersDataSet1.BAREM_PS);
            tableAdapterManager1.BASYS_ADDRTableAdapter.Fill(bastetParametersDataSet1.BASYS_ADDR);
            tableAdapterManager1.BASYS_STableAdapter.Fill(bastetParametersDataSet1.BASYS_S);
            tableAdapterManager1.ZSMI31014_EETableAdapter.Fill(bastetParametersDataSet1.ZSMI31014_EE);
        }

        /// <summary>
        /// Event handler if we add row to BASYS_ADDR table.
        /// We go throught all BASYS_ADDR sub tables and add a new row.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e">Info about row</param>
        public void BASYS_ADDR_TableNewRow( object sender, DataTableNewRowEventArgs e )
        {
            //Go throught all tables and add new rows.
            foreach( DataTable table in devices.Tables)
            {
                //Skip head table.
                if( table.TableName==e.Row.Table.TableName || table.TableName=="Device")
                    continue;
                //First we create new row by table's constructor.
                DataRow row = table.NewRow();
                //We set parent row
                row.SetParentRow(e.Row);
                //We add row to table.
                table.Rows.Add(row);
            }
        }

        private bool ReadData(int id)
        {
            //Clear all tables in devices, we are about to fill them with data from database.
            foreach (DataTable table in devices.Tables)
                table.Rows.Clear();

            //Goes throught all rows in database data set.
            foreach (BastetParametersDataSet.BASYS_ADDRRow row in bastetParametersDataSet1.BASYS_ADDR)
            {
                //If DBlgID matches.
                if (row.DGlbID == id)
                {
                    //Adds new parent row to devices.
                    DataRow ParentRow = devices.BASYS_ADDR.Rows.Add(new object[] { null, row.chair_addr, row.remote_addr, 0, 0 });
                    //Go throught all tables and add new rows.
                    foreach (DataTable table in devices.Tables)
                    {
                        //Skip head table.
                        if (table.TableName == row.Table.TableName)
                            continue;

                        //Goes throught all relations.
                        foreach(DataRelation HeadRelation in devices.BASYS_ADDR.ChildRelations )
                        {
                            //Goes throught all rows with speciffic relation.
                            DataRow[] RelationRows= ParentRow.GetChildRows(HeadRelation);
                            foreach( DataRow MasterRow in RelationRows )
                            {
                                //If row belongs to current table, we add it to devices d.s.
                                if( MasterRow.Table.TableName==table.TableName)
                                {
                                    DataRow ChildRow= table.NewRow();
                                    List<object> ChildRowCollumns = new List<object>();
                                    ChildRowCollumns.Add(ParentRow.Field<int>("@ZapNo"));
                                    for (int i = 2; i < MasterRow.ItemArray.Count() - 1; i++)
                                        ChildRowCollumns.Add(MasterRow.Field<object>(i));
                                    ChildRow.ItemArray = ChildRowCollumns.ToArray();
                                    ChildRow.SetParentRow(ParentRow);
                                    table.Rows.Add(ChildRow);
                                }
                            }
                        }
                    }
                }
            }

            devices.AcceptChanges();

            return true;
        }

        /// <summary>
        /// Saves data to database.
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        private bool SaveData(int id)
        {
            //Hexo for deleting data from tables.
            foreach (DataTable table in bastetParametersDataSet1.Tables)
            {
                List<object> RemoveParameters= new List<object>();
                Type TableAdapterType = Type.GetType("TROL_MgmtGui2.BastetParametersDataSetTableAdapters." + table.TableName + "TableAdapter");
                object TableAdapter= Activator.CreateInstance(TableAdapterType);
                if (TableAdapterType.GetMethod("DeleteID").GetParameters().Count() != 1)
                    return false;
                TableAdapterType.GetMethod("DeleteID").Invoke(TableAdapter, new object[] { id });
            }
            //Refill dataset.
            FillDataset();

            foreach (Devices.BASYS_ADDRRow HeadRow in devices.BASYS_ADDR.Rows)
            {
                BastetParametersDataSet.BASYS_ADDRRow ParentRow= bastetParametersDataSet1.BASYS_ADDR.AddBASYS_ADDRRow(id, HeadRow.chair_addr, HeadRow.remote_addr, "a");
                //Gets child rows for Remote and Chair.
                foreach (DataRelation HeadRelation in devices.BASYS_ADDR.ChildRelations)
                {
                    DataRow RelationRow= HeadRow.GetChildRows(HeadRelation).First();
                    DataTable RelationTableName= HeadRelation.ChildTable;
                    if (RelationTableName.TableName.StartsWith("SYS_INFO"))
                        continue;
                    DataRow ChildRow = bastetParametersDataSet1.Tables[RelationTableName.TableName].NewRow();
                    List<object> RowElements= new List<object>();
                    RowElements.Add(id);
                    RowElements.Add(ParentRow.ZapNo);
                    RowElements.AddRange(RelationRow.ItemArray.Skip(1));
                    RowElements.Add("a");
                    ChildRow.ItemArray = RowElements.ToArray();
                    ChildRow.SetParentRow(ParentRow);
                    bastetParametersDataSet1.Tables[RelationTableName.TableName].Rows.Add(ChildRow);

                    //Type RowTableType = Type.GetType("BastetParametersDataSet." + RelationTableName + "DataTable");
                }
            }

            tableAdapterManager1.UpdateAll(bastetParametersDataSet1);
            return true;
        }

        /// <summary>
        /// Executes when we are about to read data from database.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            int lSaveID;
            if (!int.TryParse(SaveID.Text, out lSaveID)) return;
            //Reads data with speciffic DGblID
            ReadData(lSaveID);
        }

        /// <summary>
        /// Executes when we are about to save data to database.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            int lSaveID;
            if (!int.TryParse(SaveID.Text, out lSaveID)) return;
            //Save data to database on DBglbID
            SaveData(lSaveID);
        }

        /// <summary>
        /// Executes when we enter database mode or local mode.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            //If we are about to enter database mode.
            if (toolStripButton1.Checked)
            {
                //Add ID collumn to GridView.
                DataGridViewColumn collumn= new DataGridViewColumn();
                ZapNo = new DataGridViewTextBoxColumn();
                ZapNo.DataPropertyName = "@DGlbID";
                ZapNo.HeaderText = "ID";

                //Change data source to database.
                bASYS_ADDRBindingSource.DataSource = bastetParametersDataSet1;

                //Insert new collumn and enable safe button.
                bASYS_ADDRDataGridView.Columns.Insert(0, this.ZapNo);
                bASYS_ADDRBindingNavigatorSaveItem.Enabled = true;

                bASYS_ADDRDataGridView.Columns["IDChair"].Visible = false;
                bASYS_ADDRDataGridView.Columns["IDRemote"].Visible = false;

            }
            //If we are about to enter local mode.
            else
            {
                //Change data source to local database
                bASYS_ADDRBindingSource.DataSource = devices;

                //Removes ID collumn and enables save button.
                bASYS_ADDRDataGridView.Columns.Remove(ZapNo);
                bASYS_ADDRBindingNavigatorSaveItem.Enabled = false;

                bASYS_ADDRDataGridView.Columns["IDChair"].Visible = true;
                bASYS_ADDRDataGridView.Columns["IDRemote"].Visible = true;
            }
        }

        /// <summary>
        /// Saves changes to database.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bASYS_ADDRBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            tableAdapterManager1.UpdateAll(bastetParametersDataSet1);
        }

        private void Add_Click(object sender, EventArgs e)
        {
            if( devices.Device[deviceListBox.SelectedIndex].DeviceType==(int)DeviceType.Unknown )
            {
                MessageBox.Show("Device type is not set!");
                return;
            }

            //Database mode
            if (toolStripButton1.Checked)
            {
                MessageBox.Show("You cannot add devices in database mode!");
                return;
            }
            else
            {
                if (bASYS_ADDRDataGridView.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Row is not selected!");
                    return;
                }
                if (devices.Device[deviceListBox.SelectedIndex].DeviceType == (int)DeviceType.Chair)
                {
                    int index = bASYS_ADDRDataGridView.SelectedRows[0].Index;
                    devices.BASYS_ADDR[index].IDChair = devices.Device[deviceListBox.SelectedIndex].LinkId;
                    cBastetCommunication.GetChairInformations(devices.Device[deviceListBox.SelectedIndex].LinkId);
                }
                else
                {
                    int index = bASYS_ADDRDataGridView.SelectedRows[0].Index;
                    devices.BASYS_ADDR[index].IDRemote = devices.Device[deviceListBox.SelectedIndex].LinkId;
                    cBastetCommunication.GetRemoteInformations(devices.Device[deviceListBox.SelectedIndex].LinkId);
                }
            }
        }

        private void buttonRescan_Click(object sender, EventArgs e)
        {
            cBastetCommunication.Rescan();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cBastetCommunication.Close();
            Application.Exit();
        }

        private void deviceListBox_Format(object sender, ListControlConvertEventArgs e)
        {
            try
            {

                Devices.DeviceRow row = (Devices.DeviceRow)((DataRowView)(e.ListItem)).Row;
                string sDeviceType="";
                switch(row.DeviceType)
                {
                    case (byte)DeviceType.Chair:
                        sDeviceType="chair";
                        break;
                    case (byte)DeviceType.Remote:
                        sDeviceType="remote";
                        break;
                    default:
                        sDeviceType="unknown";
                        break;
                }
                e.Value = String.Format("{0} - {1}",
                    row.LinkId,
                    sDeviceType
                    );
            }
            catch (Exception exc)
            {
            }
        }

        private Devices.BASYS_ADDRRow GetCurrentBasysaddrRow()
        {
            if (bASYS_ADDRDataGridView.CurrentRow.Index + 1 > devices.BASYS_ADDR.Count)
                return null;
            Devices.BASYS_ADDRRow row = (Devices.BASYS_ADDRRow)devices.BASYS_ADDR.Rows[bASYS_ADDRDataGridView.CurrentRow.Index];
            return row;
        }

        private void WeightUpdateTimer_Tick(object sender, EventArgs e)
        {
            Devices.BASYS_ADDRRow row = GetCurrentBasysaddrRow();
            if (row == null)
            {
                MessageBox.Show("Device is not selected!");
                return;
            }
            cBastetCommunication.GetWeight(row.IDChair);
            cBastetCommunication.GetBASYS_S(row.IDChair);
        }

        private void chair_statusTextBox_TextChanged(object sender, EventArgs e)
        {
            devices.AcceptChanges();
        }

        public void SetStatusWeight(int weight)
        {
            this.weightStatusTextBox.IntValue = weight;
        }

        public void SetWeight(int weight)
        {
            this.CurrentWeightBox.Text = weight.ToString();
            this.remoteView1.weight = weight;
        }

        private void checkBoxWeightAutoUpdate_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxWeightAutoUpdate.Checked)
            {
                WeightUpdateTimer.Start();
            }
            else
            {
                WeightUpdateTimer.Stop();
            }
        }

#region TABLE_GET_SET_HANDLERS

    #region CHAIR_GET_SET_HANDLERS

        private void BAFS_PR_Get_Click(object sender, EventArgs e)
        {
            Devices.BASYS_ADDRRow row = GetCurrentBasysaddrRow();
            if (row == null)
            {
                MessageBox.Show("Device is not selected!");
                return;
            }
            cBastetCommunication.GetBAFS_PR(row.IDChair);
        }

        private void BAFS_PR_Set_Click(object sender, EventArgs e)
        {
            Devices.BASYS_ADDRRow row = GetCurrentBasysaddrRow();
            if (row == null)
            {
                MessageBox.Show("Device is not selected!");
                return;
            }
            cBastetCommunication.SetBAFS_PR(row.IDChair, row.GetBAFS_PRRows()[0]);
        }

        private void BAFS_PS_GET_Click(object sender, EventArgs e)
        {
            Devices.BASYS_ADDRRow row = GetCurrentBasysaddrRow();
            if (row == null)
            {
                MessageBox.Show("Device is not selected!");
                return;
            }
            cBastetCommunication.GetBAFS_PS(row.IDChair);
        }

        private void BAFS_PS_Set_Click(object sender, EventArgs e)
        {
            Devices.BASYS_ADDRRow row = GetCurrentBasysaddrRow();
            if (row == null)
            {
                MessageBox.Show("Device is not selected!");
                return;
            }
            cBastetCommunication.SetBAFS_PS(row.IDChair, row.GetBAFS_PSRows()[0]);
        }

        private void BAMOT_PR_GET_Click(object sender, EventArgs e)
        {
            Devices.BASYS_ADDRRow row = GetCurrentBasysaddrRow();
            if (row == null)
            {
                MessageBox.Show("Device is not selected!");
                return;
            }
            cBastetCommunication.GetBAMOT_PR(row.IDChair);
        }

        private void BAMOT_PR_SET_Click(object sender, EventArgs e)
        {
            Devices.BASYS_ADDRRow row = GetCurrentBasysaddrRow();
            if (row == null)
            {
                MessageBox.Show("Device is not selected!");
                return;
            }
            cBastetCommunication.SetBAMOT_PR(row.IDChair, row.GetBAMOT_PRRows()[0]);
        }

        private void BAMOT_PS_GET_Click(object sender, EventArgs e)
        {
            Devices.BASYS_ADDRRow row = GetCurrentBasysaddrRow();
            if (row == null)
            {
                MessageBox.Show("Device is not selected!");
                return;
            }
            cBastetCommunication.GetBAMOT_PS(row.IDChair);
        }

        private void BAMOT_PS_SET_Click(object sender, EventArgs e)
        {
            Devices.BASYS_ADDRRow row = GetCurrentBasysaddrRow();
            if (row == null)
            {
                MessageBox.Show("Device is not selected!");
                return;
            }
            cBastetCommunication.SetBAMOT_PS(row.IDChair, row.GetBAMOT_PSRows()[0]);
        }

        private void BASYS_S_GET_Click(object sender, EventArgs e)
        {
            Devices.BASYS_ADDRRow row = GetCurrentBasysaddrRow();
            if (row == null)
            {
                MessageBox.Show("Device is not selected!");
                return;
            }
            cBastetCommunication.GetBASYS_S(row.IDChair);
        }

        private void BASYS_S_SET_Click(object sender, EventArgs e)
        {
            Devices.BASYS_ADDRRow row = GetCurrentBasysaddrRow();
            if (row == null)
            {
                MessageBox.Show("Device is not selected!");
                return;
            }
            cBastetCommunication.SetBASYS_S(row.IDChair, row.GetBASYS_SRows()[0]);
        }

        private void SYS_INFO_GET_Click(object sender, EventArgs e)
        {
            Devices.BASYS_ADDRRow row = GetCurrentBasysaddrRow();
            if (row == null)
            {
                MessageBox.Show("Device is not selected!");
                return;
            }
            cBastetCommunication.GetSYS_INFO(row.IDChair);
        }

        private void SYS_INFO_SET_Click(object sender, EventArgs e)
        {
            Devices.BASYS_ADDRRow row = GetCurrentBasysaddrRow();
            if (row == null)
            {
                MessageBox.Show("Device is not selected!");
                return;
            }
            cBastetCommunication.SetSYS_INFO(row.IDChair, row.GetSYS_INFO_CHAIRRows()[0]);
        }

        private void SYS_INFO_REMOTE_GET_Click(object sender, EventArgs e)
        {
            Devices.BASYS_ADDRRow row = GetCurrentBasysaddrRow();
            if (row == null)
            {
                MessageBox.Show("Device is not selected!");
                return;
            }
            cBastetCommunication.GetSYS_INFO(row.IDRemote);
        }

        private void SYS_INFO_REMOTE_SET_Click(object sender, EventArgs e)
        {
            Devices.BASYS_ADDRRow row = GetCurrentBasysaddrRow();
            if (row == null)
            {
                MessageBox.Show("Device is not selected!");
                return;
            }
            cBastetCommunication.SetSYS_INFO(row.IDRemote, row.GetSYS_INFO_REMOTERows()[0]);
        }

    #endregion

    #region CHAIR_AND_REMOTE_GET_SET_HANDLERS

        private void BASYS_ADDR_GET_Click(object sender, EventArgs e)
        {
            Devices.BASYS_ADDRRow row = GetCurrentBasysaddrRow();
            if (row == null)
            {
                MessageBox.Show("Device is not selected!");
                return;
            }
            cBastetCommunication.GetBASYS_ADDR(row.IDChair);
        }

        private void BASYS_ADDR_SET_Click(object sender, EventArgs e)
        {
            Devices.BASYS_ADDRRow row = GetCurrentBasysaddrRow();
            if (row == null)
            {
                MessageBox.Show("Device is not selected!");
                return;
            }
            cBastetCommunication.SetBASYS_ADDR(row.IDChair, row);
        }

    #endregion

    #region REMOTE_GET_SET_HANDLERS

        private void BAREM_PR_GET_Click(object sender, EventArgs e)
        {
            Devices.BASYS_ADDRRow row = GetCurrentBasysaddrRow();
            if (row == null)
            {
                MessageBox.Show("Device is not selected!");
                return;
            }
            cBastetCommunication.GetBAREM_PR(row.IDRemote);
        }

        private void BAREM_PR_SET_Click(object sender, EventArgs e)
        {
            Devices.BASYS_ADDRRow row = GetCurrentBasysaddrRow();
            if (row == null)
            {
                MessageBox.Show("Device is not selected!");
                return;
            }
            cBastetCommunication.SetBAREM_PR(row.IDRemote, row.GetBAREM_PRRows()[0]);
        }

        private void BAREM_PS_GET_Click(object sender, EventArgs e)
        {
            Devices.BASYS_ADDRRow row = GetCurrentBasysaddrRow();
            if (row == null)
            {
                MessageBox.Show("Device is not selected!");
                return;
            }
            cBastetCommunication.GetBAREM_PS(row.IDRemote);
        }

        private void BAREM_PS_SET_Click(object sender, EventArgs e)
        {
            Devices.BASYS_ADDRRow row = GetCurrentBasysaddrRow();
            if (row == null)
            {
                MessageBox.Show("Device is not selected!");
                return;
            }
            cBastetCommunication.SetBAREM_PS(row.IDRemote, row.GetBAREM_PSRows()[0]);
        }

        private void ZSMI31014_EE_GET_Click(object sender, EventArgs e)
        {
            Devices.BASYS_ADDRRow row = GetCurrentBasysaddrRow();
            if (row == null)
            {
                MessageBox.Show("Device is not selected!");
                return;
            }
            cBastetCommunication.GetZSMI31014_EE(row.IDChair);
        }

        private void ZSMI31014_EE_SET_Click(object sender, EventArgs e)
        {
            Devices.BASYS_ADDRRow row = GetCurrentBasysaddrRow();
            if (row == null)
            {
                MessageBox.Show("Device is not selected!");
                return;
            }
            cBastetCommunication.SetZSMI31014_EE(row.IDChair, row.GetZSMI31014_EERows()[0]);
        }

    #endregion

#endregion

#region APP_HANDLERS

    #region CHAIR_APP_HANDLERS

        private void buttonMotorUp_Click(object sender, EventArgs e)
        {
            MotorDirection = true;
            MotorUpdateTimer.Start();
        }

        private void buttonMotorDown_Click(object sender, EventArgs e)
        {
            MotorDirection = false;
            MotorUpdateTimer.Start();
        }

        private void buttonMotorStop_Click(object sender, EventArgs e)
        {
            MotorUpdateTimer.Stop();
        }

        private void GetWeightButton_Click(object sender, EventArgs e)
        {
            Devices.BASYS_ADDRRow row = GetCurrentBasysaddrRow();
            if (row == null)
            {
                MessageBox.Show("Device is not selected!");
                return;
            }
            cBastetCommunication.GetWeight(row.IDChair);
        }

        private void buttonChairAppStart_Click(object sender, EventArgs e)
        {
            Devices.BASYS_ADDRRow row = GetCurrentBasysaddrRow();
            if (row == null)
            {
                MessageBox.Show("Device is not selected!");
                return;
            }
            cBastetCommunication.APPStart(row.IDChair);
        }

        private void buttonChairAppStop_Click(object sender, EventArgs e)
        {
            Devices.BASYS_ADDRRow row = GetCurrentBasysaddrRow();
            if (row == null)
            {
                MessageBox.Show("Device is not selected!");
                return;
            }
            cBastetCommunication.APPStop(row.IDChair);
        }

        private void buttonChairAppInit_Click(object sender, EventArgs e)
        {
            Devices.BASYS_ADDRRow row = GetCurrentBasysaddrRow();
            if (row == null)
            {
                MessageBox.Show("Device is not selected!");
                return;
            }
            cBastetCommunication.APPInit(row.IDChair);
        }

        private void buttonChairAppReinit_Click(object sender, EventArgs e)
        {
            Devices.BASYS_ADDRRow row = GetCurrentBasysaddrRow();
            if (row == null)
            {
                MessageBox.Show("Device is not selected!");
                return;
            }
            cBastetCommunication.APPReinit(row.IDChair);
        }

        private void buttonChairReset_Click(object sender, EventArgs e)
        {
            Devices.BASYS_ADDRRow row = GetCurrentBasysaddrRow();
            if (row == null)
            {
                MessageBox.Show("Device is not selected!");
                return;
            }
            cBastetCommunication.SysReset(row.IDChair);
        }

        private void buttonChairAppWriteFlash_Click(object sender, EventArgs e)
        {
            Devices.BASYS_ADDRRow row = GetCurrentBasysaddrRow();
            if (row == null)
            {
                MessageBox.Show("Device is not selected!");
                return;
            }
            cBastetCommunication.AppWriteFlash(row.IDChair);
        }

        private void buttonChairTest_Click(object sender, EventArgs e)
        {
            Devices.BASYS_ADDRRow row = GetCurrentBasysaddrRow();
            if (row == null)
            {
                MessageBox.Show("Device is not selected!");
                return;
            }
            cBastetCommunication.AppTest(row.IDChair, (uint)this.textChairTestId.IntValue);
        }

        private void buttonChairFactoryDefaults_Click(object sender, EventArgs e)
        {
            Devices.BASYS_ADDRRow row = GetCurrentBasysaddrRow();
            if (row == null)
            {
                MessageBox.Show("Device is not selected!");
                return;
            }
            cBastetCommunication.SetFactoryDefaults(row.IDChair);
        }

    #endregion
    #region Remote_APP_HANDLERS

        private void buttonRemoteAppStart_Click(object sender, EventArgs e)
        {
            Devices.BASYS_ADDRRow row = GetCurrentBasysaddrRow();
            if (row == null)
            {
                MessageBox.Show("Device is not selected!");
                return;
            }
            cBastetCommunication.APPStart(row.IDRemote);
        }

        private void buttonRemoteAppStop_Click(object sender, EventArgs e)
        {
            Devices.BASYS_ADDRRow row = GetCurrentBasysaddrRow();
            if (row == null)
            {
                MessageBox.Show("Device is not selected!");
                return;
            }
            cBastetCommunication.APPStop(row.IDRemote);
        }

        private void buttonRemoteAppInit_Click(object sender, EventArgs e)
        {
            Devices.BASYS_ADDRRow row = GetCurrentBasysaddrRow();
            if (row == null)
            {
                MessageBox.Show("Device is not selected!");
                return;
            }
            cBastetCommunication.APPInit(row.IDRemote);
        }

        private void buttonRemoteAppReinit_Click(object sender, EventArgs e)
        {
            Devices.BASYS_ADDRRow row = GetCurrentBasysaddrRow();
            if (row == null)
            {
                MessageBox.Show("Device is not selected!");
                return;
            }
            cBastetCommunication.APPReinit(row.IDRemote);
        }

        private void buttonRemoteAppReset_Click(object sender, EventArgs e)
        {
            Devices.BASYS_ADDRRow row = GetCurrentBasysaddrRow();
            if (row == null)
            {
                MessageBox.Show("Device is not selected!");
                return;
            }
            cBastetCommunication.SysReset(row.IDRemote);
        }

        private void buttonRemoteWriteFlash_Click(object sender, EventArgs e)
        {
            Devices.BASYS_ADDRRow row = GetCurrentBasysaddrRow();
            if (row == null)
            {
                MessageBox.Show("Device is not selected!");
                return;
            }
            cBastetCommunication.AppWriteFlash(row.IDRemote);
        }

        private void buttonRemoteTest_Click(object sender, EventArgs e)
        {
            Devices.BASYS_ADDRRow row = GetCurrentBasysaddrRow();
            if (row == null)
            {
                MessageBox.Show("Device is not selected!");
                return;
            }
            cBastetCommunication.AppTest(row.IDRemote, uint.Parse(this.textRemoteTestId.Text));
        }

        private void buttonRemoteFactoryDefaults_Click(object sender, EventArgs e)
        {
            Devices.BASYS_ADDRRow row = GetCurrentBasysaddrRow();
            if (row == null)
            {
                MessageBox.Show("Device is not selected!");
                return;
            }
            cBastetCommunication.SetFactoryDefaults(row.IDRemote);
        }

    #endregion

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            cBastetCommunication.Close();
            Application.Exit();
        }

#endregion

        private void MotorUpdateTimer_Tick(object sender, EventArgs e)
        {
            Devices.BASYS_ADDRRow row = GetCurrentBasysaddrRow();
            if (row == null)
            {
                MessageBox.Show("Device is not selected!");
                return;
            }

            if (MotorDirection)
                cBastetCommunication.MotorUp(row.IDChair);
            else
                cBastetCommunication.MotorDown(row.IDChair);
        }

        private void panel1_Scroll(object sender, ScrollEventArgs e)
        {
            panel1.Refresh();
        }
    }
}
