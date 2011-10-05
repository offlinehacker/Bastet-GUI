using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Reflection;
using System.Windows.Forms;
using System.Threading;

namespace TROL_MgmtGui2
{
    class BastetCommunication
    {
        private BPProtocol cBPPRotocol;
        private RawSerial cSerial;
        private Devices cDevices;
        private Form1 cForm1;//Form for invoking gui actions

        public BastetCommunication(Devices lDevices, Form1 lForm1)
        {
            cDevices=lDevices;
            cForm1 = lForm1;
        }

        /// <summary>
        /// Opens communication. This function must be called by gui thread!
        /// </summary>
        /// <returns>True on succesfully open communication, false otherwise.</returns>
        public bool Open()
        {
            cSerial = new RawSerial();
            string lSelectedSerialPort="";
            frmSelectSerPort lSelectSerialPort = new frmSelectSerPort(cSerial);
            lSelectSerialPort.ShowDialog();
            lSelectedSerialPort = lSelectSerialPort.SelectedPortName;

            cBPPRotocol = new BPProtocol();
            RegisterProtocolHanders();
            cBPPRotocol.SetLinkLayer(cSerial);
            if (!cSerial.Open(lSelectedSerialPort)) return false;

            return true;
        }

        public void Close()
        {
            cSerial.Close();
        }

        private void RegisterProtocolHanders()
        {
    #region PROTOCOL_OPERATIONS_REGISTRATION
        #region COMMUNICATION_MANAGMENT_OPERATIONS
            cBPPRotocol.AddOperation(new BPOperation("MGMT_ACK", 
                (int)MgmtCmd.MGMT_ACK, 
                -1, 
                null, 
                null, 
                new ProcessReceivedData(ProcessACK)));

            BinarySerializer lGetPeersDownlinkSerializer= new BinarySerializer(new Type[]{typeof(VarByte),typeof(Byte)});
            cBPPRotocol.AddOperation(new BPOperation("MGMT_GET_PEERS",
                (int)MgmtCmd.MGMT_GET_PEERS,
                (int)MgmtCmd.MGMT_GET_PEERS,
                null,
                lGetPeersDownlinkSerializer,
                new ProcessReceivedData(ProcessGetPeers)));

            BinarySerializer lNewPeerDownlinkSerializer = new BinarySerializer(new Type[] { typeof(Byte) });
            cBPPRotocol.AddOperation(new BPOperation("MGMT_NEW_PEER",
                (int)MgmtCmd.MGMT_NEW_PEER,
                -1,
                null,
                lNewPeerDownlinkSerializer,
                new ProcessReceivedData(ProcessNewPeer)));

            BinarySerializer lGetDeviceTypeDownlinkSerializer = new BinarySerializer(new Type[] { typeof(Byte) });
            cBPPRotocol.AddOperation(new BPOperation("MGMT_GET_DEVICE_TYPE",
                (int)MgmtCmd.MGMT_GET_DEVICE_TYPE,
                (int)MgmtCmd.MGMT_GET_DEVICE_TYPE,
                null,
                lGetDeviceTypeDownlinkSerializer,
                new ProcessReceivedData(ProcessDeviceType)));

            #endregion
        #region STATIC_OPERATIONS
            #region STATIC_CHAIR_OPERATIONS
            cBPPRotocol.AddOperation(new BPOperation("MGMT_MOTOR_UP",
                (int)MgmtCmd.MGMT_MOTOR_UP,
                (int)MgmtCmd.MGMT_MOTOR_UP,
                null,
                null,
                null));

            cBPPRotocol.AddOperation(new BPOperation("MGMT_MOTOR_DOWN",
                (int)MgmtCmd.MGMT_MOTOR_DN,
                (int)MgmtCmd.MGMT_MOTOR_DN,
                null,
                null,
                null));

            cBPPRotocol.AddOperation(new BPOperation("MGMT_MOTOR_STOP",
                (int)MgmtCmd.MGMT_MOTOR_STOP,
                (int)MgmtCmd.MGMT_MOTOR_STOP,
                null,
                null,
                null));

            BinarySerializer lGetWeight = new BinarySerializer(new Type[] { typeof(Int16), typeof(Int16) });
            cBPPRotocol.AddOperation(new BPOperation("MGMT_GET_WEIGHT",
                (int)MgmtCmd.MGMT_GET_WEIGHT,
                (int)MgmtCmd.MGMT_GET_WEIGHT,
                null,
                lGetWeight,
                new ProcessReceivedData(ProcessGetWeight),
                new string[] { "chair_read" }));

            #endregion

            cBPPRotocol.AddOperation(new BPOperation("MGMT_APP_START",
                (int)MgmtCmd.MGMT_APP_START,
                (int)MgmtCmd.MGMT_APP_START,
                null,
                null,
                null));

            cBPPRotocol.AddOperation(new BPOperation("MGMT_APP_STOP",
                (int)MgmtCmd.MGMT_APP_STOP,
                (int)MgmtCmd.MGMT_APP_STOP,
                null,
                null,
                null));

            cBPPRotocol.AddOperation(new BPOperation("MGMT_APP_INIT",
                (int)MgmtCmd.MGMT_APP_INIT,
                (int)MgmtCmd.MGMT_APP_INIT,
                null,
                null,
                null));

            cBPPRotocol.AddOperation(new BPOperation("MGMT_APP_REINIT",
                (int)MgmtCmd.MGMT_APP_REINIT,
                (int)MgmtCmd.MGMT_APP_REINIT,
                null,
                null,
                null));

            cBPPRotocol.AddOperation(new BPOperation("MGMT_SYS_RESET",
                (int)MgmtCmd.MGMT_SYS_RESET,
                (int)MgmtCmd.MGMT_SYS_RESET,
                null,
                null,
                null));

            cBPPRotocol.AddOperation(new BPOperation("MGMT_SAVE_CONFIG",
                (int)MgmtCmd.MGMT_SAVE_CONFIG,
                (int)MgmtCmd.MGMT_SAVE_CONFIG,
                null,
                null,
                null));

            BinarySerializer lMGMT_TESTSerializer = new BinarySerializer(new Type[] { typeof(UInt32) });
            cBPPRotocol.AddOperation(new BPOperation("MGMT_APP_TEST",
                (int)MgmtCmd.MGMT_APP_TEST,
                (int)MgmtCmd.MGMT_APP_TEST,
                lMGMT_TESTSerializer,
                null,
                null));

            cBPPRotocol.AddOperation(new BPOperation("MGMT_SYS_SET_FACTORY_DEFAULT",
                (int)MgmtCmd.MGMT_SYS_SET_FACTORY_DEFAULT,
                (int)MgmtCmd.MGMT_SYS_SET_FACTORY_DEFAULT,
                null,
                null,
                null));

        #endregion
        #region TABLE_GET_SET_OPERATIONS
            #region TABLE_GET_SET_CHAIR_OPERATIONS

            DatasetRowSerializer lBASYS_ADDRSerializer = new DatasetRowSerializer(cDevices.BASYS_ADDR, 1, 2);
            cBPPRotocol.AddOperation(new BPOperation("BASYS_ADDR_READ",
                (int)MgmtCmd.MGMT_T_BASYS_ADDR_R,
                (int)MgmtCmd.MGMT_T_BASYS_ADDR_R,
                null,
                lBASYS_ADDRSerializer,
                new ProcessReceivedData(ProcessTableData),
                new string[]{"chair_read","remote_read"}));
            cBPPRotocol.AddOperation(new BPOperation("BASYS_ADDR_WRITE",
                (int)MgmtCmd.MGMT_T_BASYS_ADDR_W,
                (int)MgmtCmd.MGMT_T_BASYS_ADDR_W,
                lBASYS_ADDRSerializer,
                null,null, null));

            DatasetRowSerializer lBAFS_PRRSerializer = new DatasetRowSerializer(cDevices.BAFS_PR, 1, 0);
            cBPPRotocol.AddOperation(new BPOperation("BAFS_PR_READ",
                (int)MgmtCmd.MGMT_T_BAFS_PR_R,
                (int)MgmtCmd.MGMT_T_BAFS_PR_R,
                null,
                lBAFS_PRRSerializer,
                new ProcessReceivedData(ProcessTableData),
                new string[] { "chair_read" }));
            cBPPRotocol.AddOperation(new BPOperation("BAFS_PR_WRITE",
                (int)MgmtCmd.MGMT_T_BAFS_PR_W,
                (int)MgmtCmd.MGMT_T_BAFS_PR_W,
                lBAFS_PRRSerializer,
                null,null, null));

            DatasetRowSerializer lBAFS_PSSerializer = new DatasetRowSerializer(cDevices.BAFS_PS, 1, 0);
            cBPPRotocol.AddOperation(new BPOperation("BAFS_PS_READ",
                (int)MgmtCmd.MGMT_T_BAFS_PS_R,
                (int)MgmtCmd.MGMT_T_BAFS_PS_R,
                null,
                lBAFS_PSSerializer,
                new ProcessReceivedData(ProcessTableData),
                new string[] { "chair_read" }));
            cBPPRotocol.AddOperation(new BPOperation("BAFS_PS_WRITE",
                (int)MgmtCmd.MGMT_T_BAFS_PS_W,
                (int)MgmtCmd.MGMT_T_BAFS_PS_W,
                lBAFS_PSSerializer,
                null,null, null));

            DatasetRowSerializer lZSMI31014_EESerializer = new DatasetRowSerializer(cDevices.ZSMI31014_EE, 1, 0);
            cBPPRotocol.AddOperation(new BPOperation("ZSMI31014_EE_READ",
                (int)MgmtCmd.MGMT_T_ZSMI31014_EE_R,
                (int)MgmtCmd.MGMT_T_ZSMI31014_EE_R,
                null,
                lZSMI31014_EESerializer,
                new ProcessReceivedData(ProcessTableData),
                new string[] { "chair_read" }));
            cBPPRotocol.AddOperation(new BPOperation("ZSMI31014_EE_WRITE",
                (int)MgmtCmd.MGMT_T_ZSMI31014_EE_W,
                (int)MgmtCmd.MGMT_T_ZSMI31014_EE_W,
                lZSMI31014_EESerializer,
                null, null, null));

            DatasetRowSerializer lBAMOT_PRSerializer = new DatasetRowSerializer(cDevices.BAMOT_PR, 1, 0);
            cBPPRotocol.AddOperation(new BPOperation("BAMOT_PR_READ",
                (int)MgmtCmd.MGMT_T_BAMOT_PR_R,
                (int)MgmtCmd.MGMT_T_BAMOT_PR_R,
                null,
                lBAMOT_PRSerializer,
                new ProcessReceivedData(ProcessTableData),
                new string[] { "chair_read" }));
            cBPPRotocol.AddOperation(new BPOperation("BAMOT_PR_WRITE",
                (int)MgmtCmd.MGMT_T_BAMOT_PR_W,
                (int)MgmtCmd.MGMT_T_BAMOT_PR_W,
                lBAMOT_PRSerializer,
                null, null, null));

            DatasetRowSerializer lBAMOT_PSSerializer = new DatasetRowSerializer(cDevices.BAMOT_PS, 1, 0);
            cBPPRotocol.AddOperation(new BPOperation("BAMOT_PS_READ",
                (int)MgmtCmd.MGMT_T_BAMOT_PS_R,
                (int)MgmtCmd.MGMT_T_BAMOT_PS_R,
                null,
                lBAMOT_PSSerializer,
                new ProcessReceivedData(ProcessTableData),
                new string[] { "chair_read" }));
            cBPPRotocol.AddOperation(new BPOperation("BAMOT_PS_WRITE",
                (int)MgmtCmd.MGMT_T_BAMOT_PS_W,
                (int)MgmtCmd.MGMT_T_BAMOT_PS_W,
                lBAMOT_PSSerializer,
                null, null, null));

            #endregion
            #region TABLE_GET_SET_REMOTE_OPERATIONS
            DatasetRowSerializer lBAREM_PRSerializer = new DatasetRowSerializer(cDevices.BAREM_PR, 1, 0);
            cBPPRotocol.AddOperation(new BPOperation("BAREM_PR_READ",
                (int)MgmtCmd.MGMT_T_BAREM_PR_R,
                (int)MgmtCmd.MGMT_T_BAREM_PR_R,
                null,
                lBAREM_PRSerializer,
                new ProcessReceivedData(ProcessTableData),
                new string[] { "remote_read" }));
            cBPPRotocol.AddOperation(new BPOperation("BAREM_PR_WRITE",
                (int)MgmtCmd.MGMT_T_BAREM_PR_W,
                (int)MgmtCmd.MGMT_T_BAREM_PR_W,
                lBAREM_PRSerializer,
                null, null, null));

            DatasetRowSerializer lBAREM_PSSerializer = new DatasetRowSerializer(cDevices.BAREM_PS, 1, 0);
            cBPPRotocol.AddOperation(new BPOperation("BAREM_PS_READ",
                (int)MgmtCmd.MGMT_T_BAREM_PS_R,
                (int)MgmtCmd.MGMT_T_BAREM_PS_R,
                null,
                lBAREM_PSSerializer,
                new ProcessReceivedData(ProcessTableData),
                new string[] { "remote_read" }));
            cBPPRotocol.AddOperation(new BPOperation("BAREM_PS_WRITE",
                (int)MgmtCmd.MGMT_T_BAREM_PS_W,
                (int)MgmtCmd.MGMT_T_BAREM_PS_W,
                lBAREM_PSSerializer,
                null, null, null));

            DatasetRowSerializer lBASYS_SSerializer = new DatasetRowSerializer(cDevices.BASYS_S, 1, 0);
            cBPPRotocol.AddOperation(new BPOperation("BASYS_S_READ",
                (int)MgmtCmd.MGMT_BASYS_S_R,
                (int)MgmtCmd.MGMT_BASYS_S_R,
                null,
                lBASYS_SSerializer,
                new ProcessReceivedData(ProcessTableData),
                new string[] { "chair_read" }));
            cBPPRotocol.AddOperation(new BPOperation("BASYS_S_WRITE",
                (int)MgmtCmd.MGMT_T_BAREM_PS_W,
                (int)MgmtCmd.MGMT_T_BAREM_PS_W,
                lBASYS_SSerializer,
                null, null, null));

            DatasetRowSerializer lSYS_INFOSerializer = new DatasetRowSerializer(cDevices.SYS_INFO_CHAIR, 1, 0);
            cBPPRotocol.AddOperation(new BPOperation("SYS_INFO_READ",
                (int)MgmtCmd.MGMT_T_SYS_INFO_R,
                (int)MgmtCmd.MGMT_T_SYS_INFO_R,
                null,
                lSYS_INFOSerializer,
                new ProcessReceivedData(ProcessTableData),
                new string[] { "chair_read", "remote_read" }));
            cBPPRotocol.AddOperation(new BPOperation("SYS_INFO_WRITE",
                (int)MgmtCmd.MGMT_T_SYS_INFO_W,
                (int)MgmtCmd.MGMT_T_SYS_INFO_W,
                lSYS_INFOSerializer,
                null, null, null));

            #endregion
        #endregion
    #endregion
        }

        public void GetTableInformations(int LinkId, string table_name)
        {
            cBPPRotocol.CallOperation(LinkId, table_name + "_READ");
        }

        public void Rescan()
        {
            cBPPRotocol.CallOperation(Constants.AdministrationAddress, "MGMT_GET_PEERS");
        }

    #region TYPE_AND_AVALIBLATILITY_TEST_ROUTINES

        private Devices.DeviceRow GetDeviceByLinkId(int LinkId)
        {
            DataRow[] devices = cDevices.Device.Select("LinkId=" + LinkId);
            if (devices.Count() == 0)
                return null;
            return (Devices.DeviceRow)devices[0];
        }

        private bool IsDeviceAvalible(int LinkId)
        {
            Devices.DeviceRow device = GetDeviceByLinkId(LinkId);
            if (device == null) return false;

            return true;
        }

        private bool IsDeviceChair(int LinkId)
        {
            Devices.DeviceRow device = GetDeviceByLinkId(LinkId);
            if (device == null) return false;
            if (device.DeviceType == (byte)DeviceType.Chair)
                return true;

            return false;
        }

        private bool IsDeviceRemote(int LinkId)
        {
            Devices.DeviceRow device = GetDeviceByLinkId(LinkId);
            if (device == null) return false;
            if (device.DeviceType == (byte)DeviceType.Remote)
                return true;

            return false;
        }
    #endregion
    #region TABLE_GET_AND_SET_OPERATIONS

        public void SetBAFS_PR(int LinkId, Devices.BAFS_PRRow row)
        {
            if (IsDeviceChair(LinkId))
                cBPPRotocol.CallOperation(LinkId, "BAFS_PR_WRITE", new object[] { row });
        }

        public void GetBAFS_PR(int LinkId)
        {
            if (IsDeviceChair(LinkId))
                cBPPRotocol.CallOperation(LinkId, "BAFS_PR_READ");
        }

        public void GetBAFS_PS(int LinkId)
        {
            if (IsDeviceChair(LinkId))
                cBPPRotocol.CallOperation(LinkId, "BAFS_PS_READ");
        }

        public void SetBAFS_PS(int LinkId, Devices.BAFS_PSRow row)
        {
            if (IsDeviceChair(LinkId))
                cBPPRotocol.CallOperation(LinkId, "BAFS_PS_WRITE",new object[]{row});
        }

        public void GetBAMOT_PR(int LinkId)
        {
            if (IsDeviceChair(LinkId))
                cBPPRotocol.CallOperation(LinkId, "BAMOT_PR_READ");
        }

        public void SetBAMOT_PR(int LinkId, Devices.BAMOT_PRRow row)
        {
            if (IsDeviceChair(LinkId))
                cBPPRotocol.CallOperation(LinkId, "BAMOT_PR_WRITE", new object[] { row });
        }

        public void GetBAMOT_PS(int LinkId)
        {
            if (IsDeviceChair(LinkId))
                cBPPRotocol.CallOperation(LinkId, "BAMOT_PS_READ");
        }

        public void SetBAMOT_PS(int LinkId, Devices.BAMOT_PSRow row)
        {
            if (IsDeviceChair(LinkId))
                cBPPRotocol.CallOperation(LinkId, "BAMOT_PS_WRITE", new object[] { row });
        }

        public void GetZSMI31014_EE(int LinkId)
        {
            if (IsDeviceChair(LinkId))
                cBPPRotocol.CallOperation(LinkId, "ZSMI31014_EE_READ");
        }

        public void SetZSMI31014_EE(int LinkId, Devices.ZSMI31014_EERow row)
        {
            if (IsDeviceChair(LinkId))
                cBPPRotocol.CallOperation(LinkId, "ZSMI31014_EE_WRITE", new object[] { row });
        }

        public void GetBASYS_S(int LinkId)
        {
            if (IsDeviceChair(LinkId))
                cBPPRotocol.CallOperation(LinkId, "BASYS_S_READ");
        }

        public void SetBASYS_S(int LinkId, Devices.BASYS_SRow row)
        {
            if (IsDeviceChair(LinkId))
                cBPPRotocol.CallOperation(LinkId, "BASYS_S_WRITE", new object[] { row });
        }

        public void GetBASYS_ADDR(int LinkId)
        {
            cBPPRotocol.CallOperation(LinkId, "BASYS_ADDR_READ");
        }

        public void SetBASYS_ADDR(int LinkId, Devices.BASYS_ADDRRow row)
        {
            cBPPRotocol.CallOperation(LinkId, "BASYS_ADDR_WRITE", new object[] { row });
        }

        public void GetBAREM_PR(int LinkId)
        {
            if (IsDeviceRemote(LinkId))
                cBPPRotocol.CallOperation(LinkId, "BAREM_PR_READ");
        }

        public void SetBAREM_PR(int LinkId, Devices.BAREM_PRRow row)
        {
            if (IsDeviceRemote(LinkId))
                cBPPRotocol.CallOperation(LinkId, "BAREM_PR_WRITE", new object[] { row });
        }

        public void GetBAREM_PS(int LinkId)
        {
            if (IsDeviceRemote(LinkId))
                cBPPRotocol.CallOperation(LinkId, "BAREM_PS_READ");
        }

        public void SetBAREM_PS(int LinkId, Devices.BAREM_PSRow row)
        {
            if (IsDeviceRemote(LinkId))
                cBPPRotocol.CallOperation(LinkId, "BAREM_PS_WRITE", new object[] { row });
        }

        public void GetSYS_INFO(int LinkId)
        {
            if (IsDeviceAvalible(LinkId))
                cBPPRotocol.CallOperation(LinkId, "SYS_INFO_READ");
        }

        public void SetSYS_INFO(int LinkId, DataRow row)
        {
            if (IsDeviceAvalible(LinkId))
                cBPPRotocol.CallOperation(LinkId, "SYS_INFO_WRITE", new object[] { row });
        }

    #endregion
    #region STATIC_OPERATIONS

        public void GetWeight(int LinkId)
        {
            if (IsDeviceChair(LinkId))
                cBPPRotocol.CallOperation(LinkId, "MGMT_GET_WEIGHT");
        }

        public void MotorUp(int LinkId)
        {
            if (IsDeviceChair(LinkId))
                cBPPRotocol.CallOperation(LinkId, "MGMT_MOTOR_UP");
        }

        public void MotorStop(int LinkId)
        {
            if (IsDeviceChair(LinkId))
                cBPPRotocol.CallOperation(LinkId, "MGMT_MOTOR_STOP");
        }

        public void MotorDown(int LinkId)
        {
            if (IsDeviceChair(LinkId))
                cBPPRotocol.CallOperation(LinkId, "MGMT_MOTOR_DOWN");
        }

        public void APPStart(int LinkId)
        {
            if (IsDeviceAvalible(LinkId))
                cBPPRotocol.CallOperation(LinkId, "MGMT_APP_START");
        }

        public void APPStop(int LinkId)
        {
            if (IsDeviceAvalible(LinkId))
                cBPPRotocol.CallOperation(LinkId, "MGMT_APP_STOP");
        }

        public void APPInit(int LinkId)
        {
            if (IsDeviceAvalible(LinkId))
                cBPPRotocol.CallOperation(LinkId, "MGMT_APP_INIT");
        }

        public void APPReinit(int LinkId)
        {
            if (IsDeviceAvalible(LinkId))
                cBPPRotocol.CallOperation(LinkId, "MGMT_APP_REINIT");
        }

        public void SysReset(int LinkId)
        {
            if (IsDeviceAvalible(LinkId))
                cBPPRotocol.CallOperation(LinkId, "MGMT_SYS_RESET");
        }

        public void AppWriteFlash(int LinkId)
        {
            if (IsDeviceAvalible(LinkId))
                cBPPRotocol.CallOperation(LinkId, "MGMT_SAVE_CONFIG");
        }

        public void AppTest(int LinkId, UInt32 TestId)
        {
            if (IsDeviceAvalible(LinkId))
                cBPPRotocol.CallOperation(LinkId, "MGMT_APP_TEST", new object[]{TestId});
        }

        public void SetFactoryDefaults(int LinkId)
        {
            if (IsDeviceAvalible(LinkId))
                cBPPRotocol.CallOperation(LinkId, "MGMT_SYS_SET_FACTORY_DEFAULT");
        }

     #endregion
    #region GROUP_OPERATIONS

        public void GetChairInformations(int LinkId)
        {
            if(IsDeviceChair(LinkId))
                cBPPRotocol.CallGroupOperations(LinkId, "chair_read");
        }

        public void GetRemoteInformations(int LinkId)
        {
            if (IsDeviceRemote(LinkId))
                cBPPRotocol.CallGroupOperations(LinkId, "remote_read");
        }

    #endregion
    #region RESPONSE_HANDLERS
        private void ProcessACK(string OperationName, BPProtocolHeader lProtocolHeader, object[] DeserializedData)
        {
            cSerial.AckReceived();
        }

        private void ProcessGetPeers(string OperationName, BPProtocolHeader lProtocolHeader, object[] DeserializedData)
        {
            cForm1.Invoke((MethodInvoker)delegate
            {
                cDevices.Device.Clear();
                foreach (Byte LinkId in DeserializedData.Skip(1))
                {
                    //Invoke all on gui thread, so working threa will have more time.
                    cDevices.Device.AddDeviceRow(LinkId, (Byte)DeviceType.Unknown);
                    cBPPRotocol.CallOperation(LinkId, "MGMT_GET_DEVICE_TYPE");
                }
            });
        }

        private void ProcessNewPeer(string OperationName, BPProtocolHeader lProtocolHeader, object[] DeserializedData)
        {
            cForm1.Invoke((MethodInvoker)delegate
            {
                DataRow[] rows = cDevices.Device.Select("LinkId=" + lProtocolHeader.cLinkId.ToString());
                if(rows.Count()>0)
                    return;
                cDevices.Device.AddDeviceRow(lProtocolHeader.cLinkId, (Byte)DeviceType.Unknown);
            });
        }

        private void ProcessDeviceType(string OperationName, BPProtocolHeader lProtocolHeader, object[] DeserializedData)
        {
            cForm1.Invoke((MethodInvoker)delegate
            {
                //EnumerableRowCollection<Devices.DeviceRow> rows = (from n in cDevices.Device where n.DeviceAddress == lProtocolHeader.cLinkId select n);
                DataRow[] rows = cDevices.Device.Select("LinkId=" + lProtocolHeader.cLinkId.ToString());
                if (rows.Count() == 0)
                    return;
                Devices.DeviceRow Row = (Devices.DeviceRow)rows[0];
                if (Row == null)
                    return;

                Row.DeviceType = (byte)DeserializedData[0];
                Row.AcceptChanges();
            });
        }

        private void ProcessTableData(string OperationName, BPProtocolHeader lProtocolHeader, object[] DeserializedData)
        {
            //We are dirty again, make another implementation!!!
            string TableName = OperationName.Substring(0, OperationName.Length - 5);

            bool ret = false;
            foreach (DataTable table in cDevices.Tables)
                if (table.TableName.StartsWith(TableName))
                {
                    TableName = table.TableName;
                    ret = true;
                    break;
                }

            if (!ret)
                return;

            DataRow[] BasysRows=cDevices.BASYS_ADDR.Select("IDChair=" + lProtocolHeader.cLinkId);
            if (BasysRows.Count() == 0)
                return;

            Devices.BASYS_ADDRRow Basysrow = (Devices.BASYS_ADDRRow)BasysRows[0];
            int id = Basysrow.ZapNo;

            DataRow[] tableRows= cDevices.Tables[TableName].Select("@ZapNo=" + id.ToString());
            if (tableRows.Count() == 0)
                return;

            List<object> rowData = new List<object>();
            rowData.Add(id);
            rowData.AddRange(DeserializedData);

            cForm1.Invoke((MethodInvoker)delegate
            {
                tableRows[0].ItemArray = rowData.ToArray();
                cDevices.Tables[TableName].AcceptChanges();
            });
        }

        private void ProcessGetWeight(string OperationName, BPProtocolHeader lProtocolHeader, object[] DeserializedData)
        {
            cForm1.Invoke((MethodInvoker)delegate
            {
                cForm1.SetStatusWeight((Int16)DeserializedData[0]);
                cForm1.SetWeight((Int16)DeserializedData[1]);
            });
        }

    #endregion
    }
}
