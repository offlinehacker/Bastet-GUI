namespace TROL_MgmtGui2
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label measureFSMTickLabel;
            System.Windows.Forms.Label weightMinWeightLimitLabel;
            System.Windows.Forms.Label zmd_Cust_ID2Label;
            System.Windows.Forms.Label zmd_CustI_D1Label;
            System.Windows.Forms.Label weightMaxAlarmLimitLabel;
            System.Windows.Forms.Label zmd_CustI_D0Label;
            System.Windows.Forms.Label weightDeltaSetLabel;
            System.Windows.Forms.Label zmd_Gain_BLabel;
            System.Windows.Forms.Label weightDeltaAlarm1Label;
            System.Windows.Forms.Label zmd_Offset_BLabel;
            System.Windows.Forms.Label weightDeltaAlarm2Label;
            System.Windows.Forms.Label weightWorkFiltLenLabel;
            System.Windows.Forms.Label weightDeltaAlarm3Label;
            System.Windows.Forms.Label weightSetpointFiltLenLabel;
            System.Windows.Forms.Label motorStartupTimeout_msLabel;
            System.Windows.Forms.Label motorStartupPWMLabel;
            System.Windows.Forms.Label motorFSMTick_usLabel;
            System.Windows.Forms.Label currLimitFilterLen_msLabel;
            System.Windows.Forms.Label currentLimit_ALabel;
            System.Windows.Forms.Label dispModeLabel;
            System.Windows.Forms.Label oled_BackgroundColorLabel;
            System.Windows.Forms.Label oled_ForegroundColorLabel;
            System.Windows.Forms.Label oled_ArrowColorLabel;
            System.Windows.Forms.Label oled_MotorOKColorLabel;
            System.Windows.Forms.Label oled_MotorLimitColorLabel;
            System.Windows.Forms.Label oled_BatColorLabel;
            System.Windows.Forms.Label oled_IndicatorLim1ColorLabel;
            System.Windows.Forms.Label oled_IndicatorLim2ColorLabel;
            System.Windows.Forms.Label oled_IndicatorLim3ColorLabel;
            System.Windows.Forms.Label oled_WeightSetColorLabel;
            System.Windows.Forms.Label oled_ErrorColorLabel;
            System.Windows.Forms.Label oled_SignOnColorLabel;
            System.Windows.Forms.Label oled_SignOnBackColorLabel;
            System.Windows.Forms.Label autoPowerOff_sLabel;
            System.Windows.Forms.Label autoRepeat_msLabel;
            System.Windows.Forms.Label forceRefresh_msLabel;
            System.Windows.Forms.Label chair_addrLabel;
            System.Windows.Forms.Label remote_addrLabel;
            System.Windows.Forms.Label forceLabel;
            System.Windows.Forms.Label chair_statusLabel;
            System.Windows.Forms.Label sys_statusLabel;
            System.Windows.Forms.Label cust_ID0Label;
            System.Windows.Forms.Label zMD_Config_1Label;
            System.Windows.Forms.Label zMD_Config_2Label;
            System.Windows.Forms.Label offset_BLabel;
            System.Windows.Forms.Label gain_BLabel;
            System.Windows.Forms.Label tcgLabel;
            System.Windows.Forms.Label tcoLabel;
            System.Windows.Forms.Label sOT_tcoLabel;
            System.Windows.Forms.Label sOT_tcgLabel;
            System.Windows.Forms.Label sOT_bridgeLabel;
            System.Windows.Forms.Label offset_TLabel;
            System.Windows.Forms.Label gain_TLabel;
            System.Windows.Forms.Label sOT_TLabel;
            System.Windows.Forms.Label t_SETLLabel;
            System.Windows.Forms.Label cust_ID1Label;
            System.Windows.Forms.Label b_ConfigLabel;
            System.Windows.Forms.Label t_ConfigLabel;
            System.Windows.Forms.Label osc_TrimLabel;
            System.Windows.Forms.Label signatureLabel;
            System.Windows.Forms.Label cust_ID2Label;
            System.Windows.Forms.Label serNoLabel;
            System.Windows.Forms.Label hW_VerLabel;
            System.Windows.Forms.Label sW_VerLabel;
            System.Windows.Forms.Label serNoLabel1;
            System.Windows.Forms.Label hW_VerLabel1;
            System.Windows.Forms.Label sW_VerLabel1;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.devices = new TROL_MgmtGui2.Devices();
            this.bASYS_ADDRBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bASYS_ADDRBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bASYS_ADDRBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.SaveID = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.bASYS_ADDRDataGridView = new System.Windows.Forms.DataGridView();
            this.IDChair = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IDRemote = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bAFS_PRBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bAFS_PSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bAMOT_PRBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bAMOT_PSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bAREM_PRBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bAREM_PSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bASYS_SBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.measureFSMTickTextBox = new System.Windows.Forms.TextBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.groupBox15 = new System.Windows.Forms.GroupBox();
            this.versionControl2 = new TROL_MgmtGui2.VersionControl();
            this.sYS_INFO_CHAIRBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.versionControl1 = new TROL_MgmtGui2.VersionControl();
            this.serNoTextBox = new System.Windows.Forms.TextBox();
            this.SYS_INFO_SET = new System.Windows.Forms.Button();
            this.SYS_INFO_GET = new System.Windows.Forms.Button();
            this.groupBox11 = new System.Windows.Forms.GroupBox();
            this.buttonChairReset = new System.Windows.Forms.Button();
            this.textChairTestId = new TROL_MgmtGui2.HexControl();
            this.buttonChairFactoryDefaults = new System.Windows.Forms.Button();
            this.buttonTestChair = new System.Windows.Forms.Button();
            this.buttonAppWriteFlash = new System.Windows.Forms.Button();
            this.buttonChairAppReinit = new System.Windows.Forms.Button();
            this.buttonChairAppInit = new System.Windows.Forms.Button();
            this.buttonChairAppStop = new System.Windows.Forms.Button();
            this.buttonChairAppStart = new System.Windows.Forms.Button();
            this.groupBox10 = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ZSMI31014_EE_SET = new System.Windows.Forms.Button();
            this.ZSMI31014_EE_GET = new System.Windows.Forms.Button();
            this.cust_ID0TextBox = new System.Windows.Forms.TextBox();
            this.zSMI31014_EEBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.zMD_Config_1TextBox = new System.Windows.Forms.TextBox();
            this.zMD_Config_2TextBox = new System.Windows.Forms.TextBox();
            this.offset_BTextBox = new System.Windows.Forms.TextBox();
            this.gain_BTextBox = new System.Windows.Forms.TextBox();
            this.tcgTextBox = new System.Windows.Forms.TextBox();
            this.tcoTextBox = new System.Windows.Forms.TextBox();
            this.sOT_tcoTextBox = new System.Windows.Forms.TextBox();
            this.sOT_tcgTextBox = new System.Windows.Forms.TextBox();
            this.sOT_bridgeTextBox = new System.Windows.Forms.TextBox();
            this.offset_TTextBox = new System.Windows.Forms.TextBox();
            this.gain_TTextBox = new System.Windows.Forms.TextBox();
            this.sOT_TTextBox = new System.Windows.Forms.TextBox();
            this.t_SETLTextBox = new System.Windows.Forms.TextBox();
            this.cust_ID1TextBox = new System.Windows.Forms.TextBox();
            this.b_ConfigTextBox = new System.Windows.Forms.TextBox();
            this.t_ConfigTextBox = new System.Windows.Forms.TextBox();
            this.osc_TrimTextBox = new System.Windows.Forms.TextBox();
            this.signatureTextBox = new System.Windows.Forms.TextBox();
            this.cust_ID2TextBox = new System.Windows.Forms.TextBox();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.weightStatusTextBox = new TROL_MgmtGui2.HexControl();
            this.checkBoxWeightAutoUpdate = new System.Windows.Forms.CheckBox();
            this.GetWeightButton = new System.Windows.Forms.Button();
            this.CurrentWeightBox = new System.Windows.Forms.TextBox();
            this.Weight = new System.Windows.Forms.Label();
            this.sWeight = new System.Windows.Forms.Label();
            this.BASYS_ADDR = new System.Windows.Forms.GroupBox();
            this.remote_addrTextBox = new TROL_MgmtGui2.MacControl();
            this.chair_addrTextBox = new TROL_MgmtGui2.MacControl();
            this.BASYS_ADDR_SET = new System.Windows.Forms.Button();
            this.BASYS_ADDR_GET = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.sysStatusTextBox = new TROL_MgmtGui2.HexControl();
            this.chairStatusTextBox = new TROL_MgmtGui2.HexControl();
            this.forceTextBox = new System.Windows.Forms.TextBox();
            this.BASYS_S_SET = new System.Windows.Forms.Button();
            this.BASYS_S_GET = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.BAMOT_PS_Set = new System.Windows.Forms.Button();
            this.BAMOT_PS_Get = new System.Windows.Forms.Button();
            this.motorFSMTick_usTextBox = new System.Windows.Forms.TextBox();
            this.currLimitFilterLen_msTextBox = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.BAMOT_PR_SET = new System.Windows.Forms.Button();
            this.BAMOT_PR_GET = new System.Windows.Forms.Button();
            this.motorStartupTimeout_msTextBox = new System.Windows.Forms.TextBox();
            this.motorStartupPWMTextBox = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.BAFS_PS_Set = new System.Windows.Forms.Button();
            this.BAFS_PS_GET = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.BAFS_PR_Set = new System.Windows.Forms.Button();
            this.BAFS_PR_Get = new System.Windows.Forms.Button();
            this.zmd_Cust_ID2TextBox = new System.Windows.Forms.TextBox();
            this.zmd_CustI_D1TextBox = new System.Windows.Forms.TextBox();
            this.weightMinWeightLimitTextBox = new System.Windows.Forms.TextBox();
            this.zmd_CustI_D0TextBox = new System.Windows.Forms.TextBox();
            this.weightMaxAlarmLimitTextBox = new System.Windows.Forms.TextBox();
            this.zmd_Gain_BTextBox = new System.Windows.Forms.TextBox();
            this.weightDeltaSetTextBox = new System.Windows.Forms.TextBox();
            this.zmd_Offset_BTextBox = new System.Windows.Forms.TextBox();
            this.weightDeltaAlarm1TextBox = new System.Windows.Forms.TextBox();
            this.weightWorkFiltLenTextBox = new System.Windows.Forms.TextBox();
            this.weightDeltaAlarm2TextBox = new System.Windows.Forms.TextBox();
            this.weightSetpointFiltLenTextBox = new System.Windows.Forms.TextBox();
            this.weightDeltaAlarm3TextBox = new System.Windows.Forms.TextBox();
            this.tabPage9 = new System.Windows.Forms.TabPage();
            this.groupBox16 = new System.Windows.Forms.GroupBox();
            this.sW_verTextBox1 = new TROL_MgmtGui2.HexControl();
            this.hW_verTextBox1 = new TROL_MgmtGui2.HexControl();
            this.serNoTextBox1 = new System.Windows.Forms.TextBox();
            this.sYS_INFO_REMOTEBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.SYS_INFO_REMOTE_SET = new System.Windows.Forms.Button();
            this.SYS_INFO_REMTE_GET = new System.Windows.Forms.Button();
            this.groupBox12 = new System.Windows.Forms.GroupBox();
            this.buttonRemoteAppReset = new System.Windows.Forms.Button();
            this.buttonRemoteFactoryDefaults = new System.Windows.Forms.Button();
            this.textRemoteTestId = new System.Windows.Forms.TextBox();
            this.buttonRemoteTest = new System.Windows.Forms.Button();
            this.buttonRemoteWriteFlash = new System.Windows.Forms.Button();
            this.buttonRemoteAppReinit = new System.Windows.Forms.Button();
            this.buttonRemoteAppInit = new System.Windows.Forms.Button();
            this.buttonRemoteAppStop = new System.Windows.Forms.Button();
            this.buttonRemoteAppStart = new System.Windows.Forms.Button();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.BAREM_PS_SET = new System.Windows.Forms.Button();
            this.BAREM_PS_GET = new System.Windows.Forms.Button();
            this.autoPowerOff_sTextBox = new System.Windows.Forms.TextBox();
            this.autoRepeat_msTextBox = new System.Windows.Forms.TextBox();
            this.forceRefresh_msTextBox = new System.Windows.Forms.TextBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.BAREM_PR_SET = new System.Windows.Forms.Button();
            this.BAREM_PR_GET = new System.Windows.Forms.Button();
            this.dispModeTextBox = new System.Windows.Forms.TextBox();
            this.oled_BackgroundColorTextBox = new System.Windows.Forms.TextBox();
            this.oled_ForegroundColorTextBox = new System.Windows.Forms.TextBox();
            this.oled_ArrowColorTextBox = new System.Windows.Forms.TextBox();
            this.oled_MotorOKColorTextBox = new System.Windows.Forms.TextBox();
            this.oled_MotorLimitColorTextBox = new System.Windows.Forms.TextBox();
            this.oled_BatColorTextBox = new System.Windows.Forms.TextBox();
            this.oled_IndicatorLim1ColorTextBox = new System.Windows.Forms.TextBox();
            this.oled_IndicatorLim2ColorTextBox = new System.Windows.Forms.TextBox();
            this.oled_IndicatorLim3ColorTextBox = new System.Windows.Forms.TextBox();
            this.oled_WeightSetColorTextBox = new System.Windows.Forms.TextBox();
            this.oled_ErrorColorTextBox = new System.Windows.Forms.TextBox();
            this.oled_SignOnColorTextBox = new System.Windows.Forms.TextBox();
            this.oled_SignOnBackColorTextBox = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bastetParametersDataSet1 = new TROL_MgmtGui2.BastetParametersDataSet();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.tableAdapterManager1 = new TROL_MgmtGui2.BastetParametersDataSetTableAdapters.TableAdapterManager();
            this.bafS_PRTableAdapter1 = new TROL_MgmtGui2.BastetParametersDataSetTableAdapters.BAFS_PRTableAdapter();
            this.bafS_PSTableAdapter1 = new TROL_MgmtGui2.BastetParametersDataSetTableAdapters.BAFS_PSTableAdapter();
            this.bamoT_PRTableAdapter1 = new TROL_MgmtGui2.BastetParametersDataSetTableAdapters.BAMOT_PRTableAdapter();
            this.bamoT_PSTableAdapter1 = new TROL_MgmtGui2.BastetParametersDataSetTableAdapters.BAMOT_PSTableAdapter();
            this.bareM_PRTableAdapter1 = new TROL_MgmtGui2.BastetParametersDataSetTableAdapters.BAREM_PRTableAdapter();
            this.bareM_PSTableAdapter1 = new TROL_MgmtGui2.BastetParametersDataSetTableAdapters.BAREM_PSTableAdapter();
            this.basyS_ADDRTableAdapter1 = new TROL_MgmtGui2.BastetParametersDataSetTableAdapters.BASYS_ADDRTableAdapter();
            this.basyS_STableAdapter1 = new TROL_MgmtGui2.BastetParametersDataSetTableAdapters.BASYS_STableAdapter();
            this.zsmI31014_EETableAdapter1 = new TROL_MgmtGui2.BastetParametersDataSetTableAdapters.ZSMI31014_EETableAdapter();
            this.deviceBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.deviceListBox = new System.Windows.Forms.ListBox();
            this.buttonRescan = new System.Windows.Forms.Button();
            this.AddButton = new System.Windows.Forms.Button();
            this.WeightUpdateTimer = new System.Windows.Forms.Timer(this.components);
            this.groupBox9 = new System.Windows.Forms.GroupBox();
            this.groupBox13 = new System.Windows.Forms.GroupBox();
            this.remoteView1 = new TROL_MgmtGui2.RemoteView();
            this.buttonMotorStop = new System.Windows.Forms.Button();
            this.buttonMotorDown = new System.Windows.Forms.Button();
            this.buttonMotorUp = new System.Windows.Forms.Button();
            this.groupBox14 = new System.Windows.Forms.GroupBox();
            this.MotorUpdateTimer = new System.Windows.Forms.Timer(this.components);
            measureFSMTickLabel = new System.Windows.Forms.Label();
            weightMinWeightLimitLabel = new System.Windows.Forms.Label();
            zmd_Cust_ID2Label = new System.Windows.Forms.Label();
            zmd_CustI_D1Label = new System.Windows.Forms.Label();
            weightMaxAlarmLimitLabel = new System.Windows.Forms.Label();
            zmd_CustI_D0Label = new System.Windows.Forms.Label();
            weightDeltaSetLabel = new System.Windows.Forms.Label();
            zmd_Gain_BLabel = new System.Windows.Forms.Label();
            weightDeltaAlarm1Label = new System.Windows.Forms.Label();
            zmd_Offset_BLabel = new System.Windows.Forms.Label();
            weightDeltaAlarm2Label = new System.Windows.Forms.Label();
            weightWorkFiltLenLabel = new System.Windows.Forms.Label();
            weightDeltaAlarm3Label = new System.Windows.Forms.Label();
            weightSetpointFiltLenLabel = new System.Windows.Forms.Label();
            motorStartupTimeout_msLabel = new System.Windows.Forms.Label();
            motorStartupPWMLabel = new System.Windows.Forms.Label();
            motorFSMTick_usLabel = new System.Windows.Forms.Label();
            currLimitFilterLen_msLabel = new System.Windows.Forms.Label();
            currentLimit_ALabel = new System.Windows.Forms.Label();
            dispModeLabel = new System.Windows.Forms.Label();
            oled_BackgroundColorLabel = new System.Windows.Forms.Label();
            oled_ForegroundColorLabel = new System.Windows.Forms.Label();
            oled_ArrowColorLabel = new System.Windows.Forms.Label();
            oled_MotorOKColorLabel = new System.Windows.Forms.Label();
            oled_MotorLimitColorLabel = new System.Windows.Forms.Label();
            oled_BatColorLabel = new System.Windows.Forms.Label();
            oled_IndicatorLim1ColorLabel = new System.Windows.Forms.Label();
            oled_IndicatorLim2ColorLabel = new System.Windows.Forms.Label();
            oled_IndicatorLim3ColorLabel = new System.Windows.Forms.Label();
            oled_WeightSetColorLabel = new System.Windows.Forms.Label();
            oled_ErrorColorLabel = new System.Windows.Forms.Label();
            oled_SignOnColorLabel = new System.Windows.Forms.Label();
            oled_SignOnBackColorLabel = new System.Windows.Forms.Label();
            autoPowerOff_sLabel = new System.Windows.Forms.Label();
            autoRepeat_msLabel = new System.Windows.Forms.Label();
            forceRefresh_msLabel = new System.Windows.Forms.Label();
            chair_addrLabel = new System.Windows.Forms.Label();
            remote_addrLabel = new System.Windows.Forms.Label();
            forceLabel = new System.Windows.Forms.Label();
            chair_statusLabel = new System.Windows.Forms.Label();
            sys_statusLabel = new System.Windows.Forms.Label();
            cust_ID0Label = new System.Windows.Forms.Label();
            zMD_Config_1Label = new System.Windows.Forms.Label();
            zMD_Config_2Label = new System.Windows.Forms.Label();
            offset_BLabel = new System.Windows.Forms.Label();
            gain_BLabel = new System.Windows.Forms.Label();
            tcgLabel = new System.Windows.Forms.Label();
            tcoLabel = new System.Windows.Forms.Label();
            sOT_tcoLabel = new System.Windows.Forms.Label();
            sOT_tcgLabel = new System.Windows.Forms.Label();
            sOT_bridgeLabel = new System.Windows.Forms.Label();
            offset_TLabel = new System.Windows.Forms.Label();
            gain_TLabel = new System.Windows.Forms.Label();
            sOT_TLabel = new System.Windows.Forms.Label();
            t_SETLLabel = new System.Windows.Forms.Label();
            cust_ID1Label = new System.Windows.Forms.Label();
            b_ConfigLabel = new System.Windows.Forms.Label();
            t_ConfigLabel = new System.Windows.Forms.Label();
            osc_TrimLabel = new System.Windows.Forms.Label();
            signatureLabel = new System.Windows.Forms.Label();
            cust_ID2Label = new System.Windows.Forms.Label();
            serNoLabel = new System.Windows.Forms.Label();
            hW_VerLabel = new System.Windows.Forms.Label();
            sW_VerLabel = new System.Windows.Forms.Label();
            serNoLabel1 = new System.Windows.Forms.Label();
            hW_VerLabel1 = new System.Windows.Forms.Label();
            sW_VerLabel1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.devices)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bASYS_ADDRBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bASYS_ADDRBindingNavigator)).BeginInit();
            this.bASYS_ADDRBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bASYS_ADDRDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bAFS_PRBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bAFS_PSBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bAMOT_PRBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bAMOT_PSBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bAREM_PRBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bAREM_PSBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bASYS_SBindingSource)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage5.SuspendLayout();
            this.groupBox15.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sYS_INFO_CHAIRBindingSource)).BeginInit();
            this.groupBox11.SuspendLayout();
            this.groupBox10.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.zSMI31014_EEBindingSource)).BeginInit();
            this.groupBox8.SuspendLayout();
            this.BASYS_ADDR.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabPage9.SuspendLayout();
            this.groupBox16.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sYS_INFO_REMOTEBindingSource)).BeginInit();
            this.groupBox12.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bastetParametersDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deviceBindingSource)).BeginInit();
            this.groupBox9.SuspendLayout();
            this.groupBox13.SuspendLayout();
            this.groupBox14.SuspendLayout();
            this.SuspendLayout();
            // 
            // measureFSMTickLabel
            // 
            measureFSMTickLabel.AutoSize = true;
            measureFSMTickLabel.Location = new System.Drawing.Point(6, 29);
            measureFSMTickLabel.Name = "measureFSMTickLabel";
            measureFSMTickLabel.Size = new System.Drawing.Size(97, 13);
            measureFSMTickLabel.TabIndex = 2;
            measureFSMTickLabel.Text = "Measure FSMTick:";
            // 
            // weightMinWeightLimitLabel
            // 
            weightMinWeightLimitLabel.AutoSize = true;
            weightMinWeightLimitLabel.Location = new System.Drawing.Point(6, 16);
            weightMinWeightLimitLabel.Name = "weightMinWeightLimitLabel";
            weightMinWeightLimitLabel.Size = new System.Drawing.Size(125, 13);
            weightMinWeightLimitLabel.TabIndex = 30;
            weightMinWeightLimitLabel.Text = "Weight Min Weight Limit:";
            // 
            // zmd_Cust_ID2Label
            // 
            zmd_Cust_ID2Label.AutoSize = true;
            zmd_Cust_ID2Label.Location = new System.Drawing.Point(6, 325);
            zmd_Cust_ID2Label.Name = "zmd_Cust_ID2Label";
            zmd_Cust_ID2Label.Size = new System.Drawing.Size(75, 13);
            zmd_Cust_ID2Label.TabIndex = 54;
            zmd_Cust_ID2Label.Text = "Zmd Cust ID2:";
            // 
            // zmd_CustI_D1Label
            // 
            zmd_CustI_D1Label.AutoSize = true;
            zmd_CustI_D1Label.Location = new System.Drawing.Point(6, 302);
            zmd_CustI_D1Label.Name = "zmd_CustI_D1Label";
            zmd_CustI_D1Label.Size = new System.Drawing.Size(78, 13);
            zmd_CustI_D1Label.TabIndex = 52;
            zmd_CustI_D1Label.Text = "Zmd Cust I D1:";
            // 
            // weightMaxAlarmLimitLabel
            // 
            weightMaxAlarmLimitLabel.AutoSize = true;
            weightMaxAlarmLimitLabel.Location = new System.Drawing.Point(6, 42);
            weightMaxAlarmLimitLabel.Name = "weightMaxAlarmLimitLabel";
            weightMaxAlarmLimitLabel.Size = new System.Drawing.Size(120, 13);
            weightMaxAlarmLimitLabel.TabIndex = 32;
            weightMaxAlarmLimitLabel.Text = "Weight Max Alarm Limit:";
            // 
            // zmd_CustI_D0Label
            // 
            zmd_CustI_D0Label.AutoSize = true;
            zmd_CustI_D0Label.Location = new System.Drawing.Point(6, 276);
            zmd_CustI_D0Label.Name = "zmd_CustI_D0Label";
            zmd_CustI_D0Label.Size = new System.Drawing.Size(78, 13);
            zmd_CustI_D0Label.TabIndex = 50;
            zmd_CustI_D0Label.Text = "Zmd Cust I D0:";
            // 
            // weightDeltaSetLabel
            // 
            weightDeltaSetLabel.AutoSize = true;
            weightDeltaSetLabel.Location = new System.Drawing.Point(6, 68);
            weightDeltaSetLabel.Name = "weightDeltaSetLabel";
            weightDeltaSetLabel.Size = new System.Drawing.Size(91, 13);
            weightDeltaSetLabel.TabIndex = 34;
            weightDeltaSetLabel.Text = "Weight Delta Set:";
            // 
            // zmd_Gain_BLabel
            // 
            zmd_Gain_BLabel.AutoSize = true;
            zmd_Gain_BLabel.Location = new System.Drawing.Point(6, 250);
            zmd_Gain_BLabel.Name = "zmd_Gain_BLabel";
            zmd_Gain_BLabel.Size = new System.Drawing.Size(66, 13);
            zmd_Gain_BLabel.TabIndex = 48;
            zmd_Gain_BLabel.Text = "Zmd Gain B:";
            // 
            // weightDeltaAlarm1Label
            // 
            weightDeltaAlarm1Label.AutoSize = true;
            weightDeltaAlarm1Label.Location = new System.Drawing.Point(6, 94);
            weightDeltaAlarm1Label.Name = "weightDeltaAlarm1Label";
            weightDeltaAlarm1Label.Size = new System.Drawing.Size(107, 13);
            weightDeltaAlarm1Label.TabIndex = 36;
            weightDeltaAlarm1Label.Text = "Weight Delta Alarm1:";
            // 
            // zmd_Offset_BLabel
            // 
            zmd_Offset_BLabel.AutoSize = true;
            zmd_Offset_BLabel.Location = new System.Drawing.Point(6, 224);
            zmd_Offset_BLabel.Name = "zmd_Offset_BLabel";
            zmd_Offset_BLabel.Size = new System.Drawing.Size(72, 13);
            zmd_Offset_BLabel.TabIndex = 46;
            zmd_Offset_BLabel.Text = "Zmd Offset B:";
            // 
            // weightDeltaAlarm2Label
            // 
            weightDeltaAlarm2Label.AutoSize = true;
            weightDeltaAlarm2Label.Location = new System.Drawing.Point(6, 120);
            weightDeltaAlarm2Label.Name = "weightDeltaAlarm2Label";
            weightDeltaAlarm2Label.Size = new System.Drawing.Size(107, 13);
            weightDeltaAlarm2Label.TabIndex = 38;
            weightDeltaAlarm2Label.Text = "Weight Delta Alarm2:";
            // 
            // weightWorkFiltLenLabel
            // 
            weightWorkFiltLenLabel.AutoSize = true;
            weightWorkFiltLenLabel.Location = new System.Drawing.Point(6, 198);
            weightWorkFiltLenLabel.Name = "weightWorkFiltLenLabel";
            weightWorkFiltLenLabel.Size = new System.Drawing.Size(110, 13);
            weightWorkFiltLenLabel.TabIndex = 44;
            weightWorkFiltLenLabel.Text = "Weight Work Filt Len:";
            // 
            // weightDeltaAlarm3Label
            // 
            weightDeltaAlarm3Label.AutoSize = true;
            weightDeltaAlarm3Label.Location = new System.Drawing.Point(6, 146);
            weightDeltaAlarm3Label.Name = "weightDeltaAlarm3Label";
            weightDeltaAlarm3Label.Size = new System.Drawing.Size(107, 13);
            weightDeltaAlarm3Label.TabIndex = 40;
            weightDeltaAlarm3Label.Text = "Weight Delta Alarm3:";
            // 
            // weightSetpointFiltLenLabel
            // 
            weightSetpointFiltLenLabel.AutoSize = true;
            weightSetpointFiltLenLabel.Location = new System.Drawing.Point(6, 172);
            weightSetpointFiltLenLabel.Name = "weightSetpointFiltLenLabel";
            weightSetpointFiltLenLabel.Size = new System.Drawing.Size(123, 13);
            weightSetpointFiltLenLabel.TabIndex = 42;
            weightSetpointFiltLenLabel.Text = "Weight Setpoint Filt Len:";
            // 
            // motorStartupTimeout_msLabel
            // 
            motorStartupTimeout_msLabel.AutoSize = true;
            motorStartupTimeout_msLabel.Location = new System.Drawing.Point(6, 26);
            motorStartupTimeout_msLabel.Name = "motorStartupTimeout_msLabel";
            motorStartupTimeout_msLabel.Size = new System.Drawing.Size(131, 13);
            motorStartupTimeout_msLabel.TabIndex = 6;
            motorStartupTimeout_msLabel.Text = "Motor Startup Timeout ms:";
            // 
            // motorStartupPWMLabel
            // 
            motorStartupPWMLabel.AutoSize = true;
            motorStartupPWMLabel.Location = new System.Drawing.Point(6, 52);
            motorStartupPWMLabel.Name = "motorStartupPWMLabel";
            motorStartupPWMLabel.Size = new System.Drawing.Size(104, 13);
            motorStartupPWMLabel.TabIndex = 8;
            motorStartupPWMLabel.Text = "Motor Startup PWM:";
            // 
            // motorFSMTick_usLabel
            // 
            motorFSMTick_usLabel.AutoSize = true;
            motorFSMTick_usLabel.Location = new System.Drawing.Point(5, 26);
            motorFSMTick_usLabel.Name = "motorFSMTick_usLabel";
            motorFSMTick_usLabel.Size = new System.Drawing.Size(97, 13);
            motorFSMTick_usLabel.TabIndex = 8;
            motorFSMTick_usLabel.Text = "Motor FSMTick us:";
            // 
            // currLimitFilterLen_msLabel
            // 
            currLimitFilterLen_msLabel.AutoSize = true;
            currLimitFilterLen_msLabel.Location = new System.Drawing.Point(5, 52);
            currLimitFilterLen_msLabel.Name = "currLimitFilterLen_msLabel";
            currLimitFilterLen_msLabel.Size = new System.Drawing.Size(115, 13);
            currLimitFilterLen_msLabel.TabIndex = 10;
            currLimitFilterLen_msLabel.Text = "Curr Limit Filter Len ms:";
            // 
            // currentLimit_ALabel
            // 
            currentLimit_ALabel.AutoSize = true;
            currentLimit_ALabel.Location = new System.Drawing.Point(5, 78);
            currentLimit_ALabel.Name = "currentLimit_ALabel";
            currentLimit_ALabel.Size = new System.Drawing.Size(78, 13);
            currentLimit_ALabel.TabIndex = 12;
            currentLimit_ALabel.Text = "Current Limit A:";
            // 
            // dispModeLabel
            // 
            dispModeLabel.AutoSize = true;
            dispModeLabel.Location = new System.Drawing.Point(6, 16);
            dispModeLabel.Name = "dispModeLabel";
            dispModeLabel.Size = new System.Drawing.Size(61, 13);
            dispModeLabel.TabIndex = 30;
            dispModeLabel.Text = "Disp Mode:";
            // 
            // oled_BackgroundColorLabel
            // 
            oled_BackgroundColorLabel.AutoSize = true;
            oled_BackgroundColorLabel.Location = new System.Drawing.Point(6, 42);
            oled_BackgroundColorLabel.Name = "oled_BackgroundColorLabel";
            oled_BackgroundColorLabel.Size = new System.Drawing.Size(118, 13);
            oled_BackgroundColorLabel.TabIndex = 32;
            oled_BackgroundColorLabel.Text = "oled Background Color:";
            // 
            // oled_ForegroundColorLabel
            // 
            oled_ForegroundColorLabel.AutoSize = true;
            oled_ForegroundColorLabel.Location = new System.Drawing.Point(6, 68);
            oled_ForegroundColorLabel.Name = "oled_ForegroundColorLabel";
            oled_ForegroundColorLabel.Size = new System.Drawing.Size(114, 13);
            oled_ForegroundColorLabel.TabIndex = 34;
            oled_ForegroundColorLabel.Text = "oled Foreground Color:";
            // 
            // oled_ArrowColorLabel
            // 
            oled_ArrowColorLabel.AutoSize = true;
            oled_ArrowColorLabel.Location = new System.Drawing.Point(6, 94);
            oled_ArrowColorLabel.Name = "oled_ArrowColorLabel";
            oled_ArrowColorLabel.Size = new System.Drawing.Size(87, 13);
            oled_ArrowColorLabel.TabIndex = 36;
            oled_ArrowColorLabel.Text = "oled Arrow Color:";
            // 
            // oled_MotorOKColorLabel
            // 
            oled_MotorOKColorLabel.AutoSize = true;
            oled_MotorOKColorLabel.Location = new System.Drawing.Point(6, 120);
            oled_MotorOKColorLabel.Name = "oled_MotorOKColorLabel";
            oled_MotorOKColorLabel.Size = new System.Drawing.Size(102, 13);
            oled_MotorOKColorLabel.TabIndex = 38;
            oled_MotorOKColorLabel.Text = "oled Motor OKColor:";
            // 
            // oled_MotorLimitColorLabel
            // 
            oled_MotorLimitColorLabel.AutoSize = true;
            oled_MotorLimitColorLabel.Location = new System.Drawing.Point(6, 146);
            oled_MotorLimitColorLabel.Name = "oled_MotorLimitColorLabel";
            oled_MotorLimitColorLabel.Size = new System.Drawing.Size(111, 13);
            oled_MotorLimitColorLabel.TabIndex = 40;
            oled_MotorLimitColorLabel.Text = "oled Motor Limit Color:";
            // 
            // oled_BatColorLabel
            // 
            oled_BatColorLabel.AutoSize = true;
            oled_BatColorLabel.Location = new System.Drawing.Point(6, 172);
            oled_BatColorLabel.Name = "oled_BatColorLabel";
            oled_BatColorLabel.Size = new System.Drawing.Size(76, 13);
            oled_BatColorLabel.TabIndex = 42;
            oled_BatColorLabel.Text = "oled Bat Color:";
            // 
            // oled_IndicatorLim1ColorLabel
            // 
            oled_IndicatorLim1ColorLabel.AutoSize = true;
            oled_IndicatorLim1ColorLabel.Location = new System.Drawing.Point(6, 198);
            oled_IndicatorLim1ColorLabel.Name = "oled_IndicatorLim1ColorLabel";
            oled_IndicatorLim1ColorLabel.Size = new System.Drawing.Size(123, 13);
            oled_IndicatorLim1ColorLabel.TabIndex = 44;
            oled_IndicatorLim1ColorLabel.Text = "oled Indicator Lim1Color:";
            // 
            // oled_IndicatorLim2ColorLabel
            // 
            oled_IndicatorLim2ColorLabel.AutoSize = true;
            oled_IndicatorLim2ColorLabel.Location = new System.Drawing.Point(6, 224);
            oled_IndicatorLim2ColorLabel.Name = "oled_IndicatorLim2ColorLabel";
            oled_IndicatorLim2ColorLabel.Size = new System.Drawing.Size(123, 13);
            oled_IndicatorLim2ColorLabel.TabIndex = 46;
            oled_IndicatorLim2ColorLabel.Text = "oled Indicator Lim2Color:";
            // 
            // oled_IndicatorLim3ColorLabel
            // 
            oled_IndicatorLim3ColorLabel.AutoSize = true;
            oled_IndicatorLim3ColorLabel.Location = new System.Drawing.Point(6, 250);
            oled_IndicatorLim3ColorLabel.Name = "oled_IndicatorLim3ColorLabel";
            oled_IndicatorLim3ColorLabel.Size = new System.Drawing.Size(123, 13);
            oled_IndicatorLim3ColorLabel.TabIndex = 48;
            oled_IndicatorLim3ColorLabel.Text = "oled Indicator Lim3Color:";
            // 
            // oled_WeightSetColorLabel
            // 
            oled_WeightSetColorLabel.AutoSize = true;
            oled_WeightSetColorLabel.Location = new System.Drawing.Point(6, 276);
            oled_WeightSetColorLabel.Name = "oled_WeightSetColorLabel";
            oled_WeightSetColorLabel.Size = new System.Drawing.Size(113, 13);
            oled_WeightSetColorLabel.TabIndex = 50;
            oled_WeightSetColorLabel.Text = "oled Weight Set Color:";
            // 
            // oled_ErrorColorLabel
            // 
            oled_ErrorColorLabel.AutoSize = true;
            oled_ErrorColorLabel.Location = new System.Drawing.Point(6, 302);
            oled_ErrorColorLabel.Name = "oled_ErrorColorLabel";
            oled_ErrorColorLabel.Size = new System.Drawing.Size(82, 13);
            oled_ErrorColorLabel.TabIndex = 52;
            oled_ErrorColorLabel.Text = "oled Error Color:";
            // 
            // oled_SignOnColorLabel
            // 
            oled_SignOnColorLabel.AutoSize = true;
            oled_SignOnColorLabel.Location = new System.Drawing.Point(6, 328);
            oled_SignOnColorLabel.Name = "oled_SignOnColorLabel";
            oled_SignOnColorLabel.Size = new System.Drawing.Size(98, 13);
            oled_SignOnColorLabel.TabIndex = 54;
            oled_SignOnColorLabel.Text = "oled Sign On Color:";
            // 
            // oled_SignOnBackColorLabel
            // 
            oled_SignOnBackColorLabel.AutoSize = true;
            oled_SignOnBackColorLabel.Location = new System.Drawing.Point(6, 351);
            oled_SignOnBackColorLabel.Name = "oled_SignOnBackColorLabel";
            oled_SignOnBackColorLabel.Size = new System.Drawing.Size(126, 13);
            oled_SignOnBackColorLabel.TabIndex = 56;
            oled_SignOnBackColorLabel.Text = "oled Sign On Back Color:";
            // 
            // autoPowerOff_sLabel
            // 
            autoPowerOff_sLabel.AutoSize = true;
            autoPowerOff_sLabel.Location = new System.Drawing.Point(6, 20);
            autoPowerOff_sLabel.Name = "autoPowerOff_sLabel";
            autoPowerOff_sLabel.Size = new System.Drawing.Size(90, 13);
            autoPowerOff_sLabel.TabIndex = 8;
            autoPowerOff_sLabel.Text = "Auto Power Off s:";
            // 
            // autoRepeat_msLabel
            // 
            autoRepeat_msLabel.AutoSize = true;
            autoRepeat_msLabel.Location = new System.Drawing.Point(6, 46);
            autoRepeat_msLabel.Name = "autoRepeat_msLabel";
            autoRepeat_msLabel.Size = new System.Drawing.Size(86, 13);
            autoRepeat_msLabel.TabIndex = 10;
            autoRepeat_msLabel.Text = "Auto Repeat ms:";
            // 
            // forceRefresh_msLabel
            // 
            forceRefresh_msLabel.AutoSize = true;
            forceRefresh_msLabel.Location = new System.Drawing.Point(6, 72);
            forceRefresh_msLabel.Name = "forceRefresh_msLabel";
            forceRefresh_msLabel.Size = new System.Drawing.Size(93, 13);
            forceRefresh_msLabel.TabIndex = 12;
            forceRefresh_msLabel.Text = "Force Refresh ms:";
            // 
            // chair_addrLabel
            // 
            chair_addrLabel.AutoSize = true;
            chair_addrLabel.Location = new System.Drawing.Point(11, 26);
            chair_addrLabel.Name = "chair_addrLabel";
            chair_addrLabel.Size = new System.Drawing.Size(57, 13);
            chair_addrLabel.TabIndex = 2;
            chair_addrLabel.Text = "chair addr:";
            // 
            // remote_addrLabel
            // 
            remote_addrLabel.AutoSize = true;
            remote_addrLabel.Location = new System.Drawing.Point(11, 52);
            remote_addrLabel.Name = "remote_addrLabel";
            remote_addrLabel.Size = new System.Drawing.Size(66, 13);
            remote_addrLabel.TabIndex = 4;
            remote_addrLabel.Text = "remote addr:";
            // 
            // forceLabel
            // 
            forceLabel.AutoSize = true;
            forceLabel.Location = new System.Drawing.Point(13, 17);
            forceLabel.Name = "forceLabel";
            forceLabel.Size = new System.Drawing.Size(34, 13);
            forceLabel.TabIndex = 15;
            forceLabel.Text = "force:";
            // 
            // chair_statusLabel
            // 
            chair_statusLabel.AutoSize = true;
            chair_statusLabel.Location = new System.Drawing.Point(13, 43);
            chair_statusLabel.Name = "chair_statusLabel";
            chair_statusLabel.Size = new System.Drawing.Size(64, 13);
            chair_statusLabel.TabIndex = 17;
            chair_statusLabel.Text = "chair status:";
            // 
            // sys_statusLabel
            // 
            sys_statusLabel.AutoSize = true;
            sys_statusLabel.Location = new System.Drawing.Point(13, 69);
            sys_statusLabel.Name = "sys_statusLabel";
            sys_statusLabel.Size = new System.Drawing.Size(56, 13);
            sys_statusLabel.TabIndex = 19;
            sys_statusLabel.Text = "sys status:";
            // 
            // cust_ID0Label
            // 
            cust_ID0Label.AutoSize = true;
            cust_ID0Label.Location = new System.Drawing.Point(3, 13);
            cust_ID0Label.Name = "cust_ID0Label";
            cust_ID0Label.Size = new System.Drawing.Size(51, 13);
            cust_ID0Label.TabIndex = 4;
            cust_ID0Label.Text = "Cust ID0:";
            // 
            // zMD_Config_1Label
            // 
            zMD_Config_1Label.AutoSize = true;
            zMD_Config_1Label.Location = new System.Drawing.Point(3, 39);
            zMD_Config_1Label.Name = "zMD_Config_1Label";
            zMD_Config_1Label.Size = new System.Drawing.Size(76, 13);
            zMD_Config_1Label.TabIndex = 6;
            zMD_Config_1Label.Text = "ZMD Config 1:";
            // 
            // zMD_Config_2Label
            // 
            zMD_Config_2Label.AutoSize = true;
            zMD_Config_2Label.Location = new System.Drawing.Point(3, 65);
            zMD_Config_2Label.Name = "zMD_Config_2Label";
            zMD_Config_2Label.Size = new System.Drawing.Size(76, 13);
            zMD_Config_2Label.TabIndex = 8;
            zMD_Config_2Label.Text = "ZMD Config 2:";
            // 
            // offset_BLabel
            // 
            offset_BLabel.AutoSize = true;
            offset_BLabel.Location = new System.Drawing.Point(3, 91);
            offset_BLabel.Name = "offset_BLabel";
            offset_BLabel.Size = new System.Drawing.Size(48, 13);
            offset_BLabel.TabIndex = 10;
            offset_BLabel.Text = "Offset B:";
            // 
            // gain_BLabel
            // 
            gain_BLabel.AutoSize = true;
            gain_BLabel.Location = new System.Drawing.Point(3, 117);
            gain_BLabel.Name = "gain_BLabel";
            gain_BLabel.Size = new System.Drawing.Size(42, 13);
            gain_BLabel.TabIndex = 12;
            gain_BLabel.Text = "Gain B:";
            // 
            // tcgLabel
            // 
            tcgLabel.AutoSize = true;
            tcgLabel.Location = new System.Drawing.Point(3, 143);
            tcgLabel.Name = "tcgLabel";
            tcgLabel.Size = new System.Drawing.Size(29, 13);
            tcgLabel.TabIndex = 14;
            tcgLabel.Text = "Tcg:";
            // 
            // tcoLabel
            // 
            tcoLabel.AutoSize = true;
            tcoLabel.Location = new System.Drawing.Point(3, 169);
            tcoLabel.Name = "tcoLabel";
            tcoLabel.Size = new System.Drawing.Size(29, 13);
            tcoLabel.TabIndex = 16;
            tcoLabel.Text = "Tco:";
            // 
            // sOT_tcoLabel
            // 
            sOT_tcoLabel.AutoSize = true;
            sOT_tcoLabel.Location = new System.Drawing.Point(3, 195);
            sOT_tcoLabel.Name = "sOT_tcoLabel";
            sOT_tcoLabel.Size = new System.Drawing.Size(50, 13);
            sOT_tcoLabel.TabIndex = 18;
            sOT_tcoLabel.Text = "SOT tco:";
            // 
            // sOT_tcgLabel
            // 
            sOT_tcgLabel.AutoSize = true;
            sOT_tcgLabel.Location = new System.Drawing.Point(3, 221);
            sOT_tcgLabel.Name = "sOT_tcgLabel";
            sOT_tcgLabel.Size = new System.Drawing.Size(50, 13);
            sOT_tcgLabel.TabIndex = 20;
            sOT_tcgLabel.Text = "SOT tcg:";
            // 
            // sOT_bridgeLabel
            // 
            sOT_bridgeLabel.AutoSize = true;
            sOT_bridgeLabel.Location = new System.Drawing.Point(3, 247);
            sOT_bridgeLabel.Name = "sOT_bridgeLabel";
            sOT_bridgeLabel.Size = new System.Drawing.Size(64, 13);
            sOT_bridgeLabel.TabIndex = 22;
            sOT_bridgeLabel.Text = "SOT bridge:";
            // 
            // offset_TLabel
            // 
            offset_TLabel.AutoSize = true;
            offset_TLabel.Location = new System.Drawing.Point(3, 273);
            offset_TLabel.Name = "offset_TLabel";
            offset_TLabel.Size = new System.Drawing.Size(48, 13);
            offset_TLabel.TabIndex = 24;
            offset_TLabel.Text = "Offset T:";
            // 
            // gain_TLabel
            // 
            gain_TLabel.AutoSize = true;
            gain_TLabel.Location = new System.Drawing.Point(3, 299);
            gain_TLabel.Name = "gain_TLabel";
            gain_TLabel.Size = new System.Drawing.Size(42, 13);
            gain_TLabel.TabIndex = 26;
            gain_TLabel.Text = "Gain T:";
            // 
            // sOT_TLabel
            // 
            sOT_TLabel.AutoSize = true;
            sOT_TLabel.Location = new System.Drawing.Point(3, 325);
            sOT_TLabel.Name = "sOT_TLabel";
            sOT_TLabel.Size = new System.Drawing.Size(42, 13);
            sOT_TLabel.TabIndex = 28;
            sOT_TLabel.Text = "SOT T:";
            // 
            // t_SETLLabel
            // 
            t_SETLLabel.AutoSize = true;
            t_SETLLabel.Location = new System.Drawing.Point(3, 351);
            t_SETLLabel.Name = "t_SETLLabel";
            t_SETLLabel.Size = new System.Drawing.Size(47, 13);
            t_SETLLabel.TabIndex = 30;
            t_SETLLabel.Text = "T SETL:";
            // 
            // cust_ID1Label
            // 
            cust_ID1Label.AutoSize = true;
            cust_ID1Label.Location = new System.Drawing.Point(3, 377);
            cust_ID1Label.Name = "cust_ID1Label";
            cust_ID1Label.Size = new System.Drawing.Size(51, 13);
            cust_ID1Label.TabIndex = 32;
            cust_ID1Label.Text = "Cust ID1:";
            // 
            // b_ConfigLabel
            // 
            b_ConfigLabel.AutoSize = true;
            b_ConfigLabel.Location = new System.Drawing.Point(3, 403);
            b_ConfigLabel.Name = "b_ConfigLabel";
            b_ConfigLabel.Size = new System.Drawing.Size(50, 13);
            b_ConfigLabel.TabIndex = 34;
            b_ConfigLabel.Text = "B Config:";
            // 
            // t_ConfigLabel
            // 
            t_ConfigLabel.AutoSize = true;
            t_ConfigLabel.Location = new System.Drawing.Point(3, 429);
            t_ConfigLabel.Name = "t_ConfigLabel";
            t_ConfigLabel.Size = new System.Drawing.Size(50, 13);
            t_ConfigLabel.TabIndex = 36;
            t_ConfigLabel.Text = "T Config:";
            // 
            // osc_TrimLabel
            // 
            osc_TrimLabel.AutoSize = true;
            osc_TrimLabel.Location = new System.Drawing.Point(3, 455);
            osc_TrimLabel.Name = "osc_TrimLabel";
            osc_TrimLabel.Size = new System.Drawing.Size(52, 13);
            osc_TrimLabel.TabIndex = 38;
            osc_TrimLabel.Text = "Osc Trim:";
            // 
            // signatureLabel
            // 
            signatureLabel.AutoSize = true;
            signatureLabel.Location = new System.Drawing.Point(3, 481);
            signatureLabel.Name = "signatureLabel";
            signatureLabel.Size = new System.Drawing.Size(55, 13);
            signatureLabel.TabIndex = 40;
            signatureLabel.Text = "Signature:";
            // 
            // cust_ID2Label
            // 
            cust_ID2Label.AutoSize = true;
            cust_ID2Label.Location = new System.Drawing.Point(3, 507);
            cust_ID2Label.Name = "cust_ID2Label";
            cust_ID2Label.Size = new System.Drawing.Size(51, 13);
            cust_ID2Label.TabIndex = 42;
            cust_ID2Label.Text = "Cust ID2:";
            // 
            // serNoLabel
            // 
            serNoLabel.AutoSize = true;
            serNoLabel.Location = new System.Drawing.Point(15, 25);
            serNoLabel.Name = "serNoLabel";
            serNoLabel.Size = new System.Drawing.Size(43, 13);
            serNoLabel.TabIndex = 10;
            serNoLabel.Text = "Ser No:";
            // 
            // hW_VerLabel
            // 
            hW_VerLabel.AutoSize = true;
            hW_VerLabel.Location = new System.Drawing.Point(15, 51);
            hW_VerLabel.Name = "hW_VerLabel";
            hW_VerLabel.Size = new System.Drawing.Size(48, 13);
            hW_VerLabel.TabIndex = 12;
            hW_VerLabel.Text = "HW Ver:";
            // 
            // sW_VerLabel
            // 
            sW_VerLabel.AutoSize = true;
            sW_VerLabel.Location = new System.Drawing.Point(15, 77);
            sW_VerLabel.Name = "sW_VerLabel";
            sW_VerLabel.Size = new System.Drawing.Size(47, 13);
            sW_VerLabel.TabIndex = 14;
            sW_VerLabel.Text = "SW Ver:";
            // 
            // serNoLabel1
            // 
            serNoLabel1.AutoSize = true;
            serNoLabel1.Location = new System.Drawing.Point(6, 23);
            serNoLabel1.Name = "serNoLabel1";
            serNoLabel1.Size = new System.Drawing.Size(43, 13);
            serNoLabel1.TabIndex = 10;
            serNoLabel1.Text = "Ser No:";
            // 
            // hW_VerLabel1
            // 
            hW_VerLabel1.AutoSize = true;
            hW_VerLabel1.Location = new System.Drawing.Point(6, 49);
            hW_VerLabel1.Name = "hW_VerLabel1";
            hW_VerLabel1.Size = new System.Drawing.Size(48, 13);
            hW_VerLabel1.TabIndex = 12;
            hW_VerLabel1.Text = "HW Ver:";
            // 
            // sW_VerLabel1
            // 
            sW_VerLabel1.AutoSize = true;
            sW_VerLabel1.Location = new System.Drawing.Point(6, 75);
            sW_VerLabel1.Name = "sW_VerLabel1";
            sW_VerLabel1.Size = new System.Drawing.Size(47, 13);
            sW_VerLabel1.TabIndex = 14;
            sW_VerLabel1.Text = "SW Ver:";
            // 
            // devices
            // 
            this.devices.DataSetName = "Devices";
            this.devices.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bASYS_ADDRBindingSource
            // 
            this.bASYS_ADDRBindingSource.DataMember = "BASYS_ADDR";
            this.bASYS_ADDRBindingSource.DataSource = this.devices;
            // 
            // bASYS_ADDRBindingNavigator
            // 
            this.bASYS_ADDRBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.bASYS_ADDRBindingNavigator.BindingSource = this.bASYS_ADDRBindingSource;
            this.bASYS_ADDRBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.bASYS_ADDRBindingNavigator.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bASYS_ADDRBindingSource, "@ZapNo", true));
            this.bASYS_ADDRBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.bASYS_ADDRBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.bASYS_ADDRBindingNavigatorSaveItem,
            this.toolStripSeparator1,
            this.toolStripButton1,
            this.SaveID,
            this.toolStripButton3,
            this.toolStripButton2});
            this.bASYS_ADDRBindingNavigator.Location = new System.Drawing.Point(0, 24);
            this.bASYS_ADDRBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bASYS_ADDRBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bASYS_ADDRBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bASYS_ADDRBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bASYS_ADDRBindingNavigator.Name = "bASYS_ADDRBindingNavigator";
            this.bASYS_ADDRBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.bASYS_ADDRBindingNavigator.Size = new System.Drawing.Size(1018, 25);
            this.bASYS_ADDRBindingNavigator.TabIndex = 0;
            this.bASYS_ADDRBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // bASYS_ADDRBindingNavigatorSaveItem
            // 
            this.bASYS_ADDRBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bASYS_ADDRBindingNavigatorSaveItem.Enabled = false;
            this.bASYS_ADDRBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("bASYS_ADDRBindingNavigatorSaveItem.Image")));
            this.bASYS_ADDRBindingNavigatorSaveItem.Name = "bASYS_ADDRBindingNavigatorSaveItem";
            this.bASYS_ADDRBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.bASYS_ADDRBindingNavigatorSaveItem.Text = "Save Data";
            this.bASYS_ADDRBindingNavigatorSaveItem.Click += new System.EventHandler(this.bASYS_ADDRBindingNavigatorSaveItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.CheckOnClick = true;
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = global::TROL_MgmtGui2.Properties.Resources.WorkMode;
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton1.Text = "toolStripButton1";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // SaveID
            // 
            this.SaveID.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30"});
            this.SaveID.Name = "SaveID";
            this.SaveID.Size = new System.Drawing.Size(121, 25);
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton3.Image = global::TROL_MgmtGui2.Properties.Resources.ToDatabase;
            this.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton3.Text = "toolStripButton3";
            this.toolStripButton3.Click += new System.EventHandler(this.toolStripButton3_Click);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton2.Image = global::TROL_MgmtGui2.Properties.Resources.FromDatabasee;
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton2.Text = "toolStripButton2";
            this.toolStripButton2.Click += new System.EventHandler(this.toolStripButton2_Click);
            // 
            // bASYS_ADDRDataGridView
            // 
            this.bASYS_ADDRDataGridView.AutoGenerateColumns = false;
            this.bASYS_ADDRDataGridView.BackgroundColor = System.Drawing.SystemColors.Menu;
            this.bASYS_ADDRDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.bASYS_ADDRDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.bASYS_ADDRDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IDChair,
            this.IDRemote,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.bASYS_ADDRDataGridView.DataSource = this.bASYS_ADDRBindingSource;
            this.bASYS_ADDRDataGridView.Location = new System.Drawing.Point(12, 57);
            this.bASYS_ADDRDataGridView.Name = "bASYS_ADDRDataGridView";
            this.bASYS_ADDRDataGridView.Size = new System.Drawing.Size(451, 156);
            this.bASYS_ADDRDataGridView.TabIndex = 1;
            // 
            // IDChair
            // 
            this.IDChair.DataPropertyName = "IDChair";
            dataGridViewCellStyle5.Format = "x";
            dataGridViewCellStyle5.NullValue = null;
            this.IDChair.DefaultCellStyle = dataGridViewCellStyle5;
            this.IDChair.HeaderText = "IDChair";
            this.IDChair.Name = "IDChair";
            // 
            // IDRemote
            // 
            this.IDRemote.DataPropertyName = "IDRemote";
            dataGridViewCellStyle6.Format = "x";
            dataGridViewCellStyle6.NullValue = null;
            this.IDRemote.DefaultCellStyle = dataGridViewCellStyle6;
            this.IDRemote.HeaderText = "IDRemote";
            this.IDRemote.Name = "IDRemote";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "chair_addr";
            this.dataGridViewTextBoxColumn2.HeaderText = "Chair Address  ";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "remote_addr";
            this.dataGridViewTextBoxColumn3.HeaderText = "Remote address";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // bAFS_PRBindingSource
            // 
            this.bAFS_PRBindingSource.AllowNew = true;
            this.bAFS_PRBindingSource.DataMember = "BASYS_ADDR_BAFS_PR";
            this.bAFS_PRBindingSource.DataSource = this.bASYS_ADDRBindingSource;
            // 
            // bAFS_PSBindingSource
            // 
            this.bAFS_PSBindingSource.DataMember = "BASYS_ADDR_BAFS_PS";
            this.bAFS_PSBindingSource.DataSource = this.bASYS_ADDRBindingSource;
            // 
            // bAMOT_PRBindingSource
            // 
            this.bAMOT_PRBindingSource.DataMember = "BASYS_ADDR_BAMOT_PR";
            this.bAMOT_PRBindingSource.DataSource = this.bASYS_ADDRBindingSource;
            // 
            // bAMOT_PSBindingSource
            // 
            this.bAMOT_PSBindingSource.DataMember = "BASYS_ADDR_BAMOT_PS";
            this.bAMOT_PSBindingSource.DataSource = this.bASYS_ADDRBindingSource;
            // 
            // bAREM_PRBindingSource
            // 
            this.bAREM_PRBindingSource.DataMember = "BASYS_ADDR_BAREM_PR";
            this.bAREM_PRBindingSource.DataSource = this.bASYS_ADDRBindingSource;
            // 
            // bAREM_PSBindingSource
            // 
            this.bAREM_PSBindingSource.DataMember = "BASYS_ADDR_BAREM_PS";
            this.bAREM_PSBindingSource.DataSource = this.bASYS_ADDRBindingSource;
            // 
            // bASYS_SBindingSource
            // 
            this.bASYS_SBindingSource.DataMember = "BASYS_ADDR_BASYS_S";
            this.bASYS_SBindingSource.DataSource = this.bASYS_ADDRBindingSource;
            // 
            // measureFSMTickTextBox
            // 
            this.measureFSMTickTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bAFS_PSBindingSource, "MeasureFSMTick", true));
            this.measureFSMTickTextBox.Location = new System.Drawing.Point(109, 26);
            this.measureFSMTickTextBox.Name = "measureFSMTickTextBox";
            this.measureFSMTickTextBox.Size = new System.Drawing.Size(134, 20);
            this.measureFSMTickTextBox.TabIndex = 3;
            this.measureFSMTickTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage5);
            this.tabControl1.Controls.Add(this.tabPage9);
            this.tabControl1.Location = new System.Drawing.Point(0, 221);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1015, 497);
            this.tabControl1.TabIndex = 31;
            // 
            // tabPage5
            // 
            this.tabPage5.AutoScroll = true;
            this.tabPage5.Controls.Add(this.groupBox15);
            this.tabPage5.Controls.Add(this.groupBox11);
            this.tabPage5.Controls.Add(this.groupBox10);
            this.tabPage5.Controls.Add(this.groupBox8);
            this.tabPage5.Controls.Add(this.BASYS_ADDR);
            this.tabPage5.Controls.Add(this.groupBox5);
            this.tabPage5.Controls.Add(this.groupBox4);
            this.tabPage5.Controls.Add(this.groupBox3);
            this.tabPage5.Controls.Add(this.groupBox2);
            this.tabPage5.Controls.Add(this.groupBox1);
            this.tabPage5.Location = new System.Drawing.Point(4, 22);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(1007, 471);
            this.tabPage5.TabIndex = 0;
            this.tabPage5.Text = "Chair";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // groupBox15
            // 
            this.groupBox15.Controls.Add(this.versionControl2);
            this.groupBox15.Controls.Add(this.versionControl1);
            this.groupBox15.Controls.Add(serNoLabel);
            this.groupBox15.Controls.Add(this.serNoTextBox);
            this.groupBox15.Controls.Add(hW_VerLabel);
            this.groupBox15.Controls.Add(sW_VerLabel);
            this.groupBox15.Controls.Add(this.SYS_INFO_SET);
            this.groupBox15.Controls.Add(this.SYS_INFO_GET);
            this.groupBox15.Location = new System.Drawing.Point(801, 285);
            this.groupBox15.Name = "groupBox15";
            this.groupBox15.Size = new System.Drawing.Size(200, 136);
            this.groupBox15.TabIndex = 9;
            this.groupBox15.TabStop = false;
            this.groupBox15.Text = "SYS info";
            // 
            // versionControl2
            // 
            this.versionControl2.AllowInternalTab = false;
            this.versionControl2.AutoHeight = true;
            this.versionControl2.BackColor = System.Drawing.SystemColors.Window;
            this.versionControl2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.versionControl2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.versionControl2.DataBindings.Add(new System.Windows.Forms.Binding("IntValue", this.sYS_INFO_CHAIRBindingSource, "SW_Ver", true, System.Windows.Forms.DataSourceUpdateMode.Never));
            this.versionControl2.FieldCount = 5;
            this.versionControl2.Location = new System.Drawing.Point(78, 75);
            this.versionControl2.Name = "versionControl2";
            this.versionControl2.ReadOnly = false;
            this.versionControl2.Size = new System.Drawing.Size(100, 20);
            this.versionControl2.TabIndex = 19;
            this.versionControl2.Text = "----";
            // 
            // sYS_INFO_CHAIRBindingSource
            // 
            this.sYS_INFO_CHAIRBindingSource.DataMember = "BASYS_ADDR_SYS_INFO_CHAIR";
            this.sYS_INFO_CHAIRBindingSource.DataSource = this.bASYS_ADDRBindingSource;
            // 
            // versionControl1
            // 
            this.versionControl1.AllowInternalTab = false;
            this.versionControl1.AutoHeight = true;
            this.versionControl1.BackColor = System.Drawing.SystemColors.Window;
            this.versionControl1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.versionControl1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.versionControl1.DataBindings.Add(new System.Windows.Forms.Binding("IntValue", this.sYS_INFO_CHAIRBindingSource, "HW_Ver", true, System.Windows.Forms.DataSourceUpdateMode.Never));
            this.versionControl1.FieldCount = 5;
            this.versionControl1.Location = new System.Drawing.Point(78, 48);
            this.versionControl1.Name = "versionControl1";
            this.versionControl1.ReadOnly = false;
            this.versionControl1.Size = new System.Drawing.Size(100, 20);
            this.versionControl1.TabIndex = 18;
            this.versionControl1.Text = "----";
            // 
            // serNoTextBox
            // 
            this.serNoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sYS_INFO_CHAIRBindingSource, "SerNo", true));
            this.serNoTextBox.Location = new System.Drawing.Point(78, 22);
            this.serNoTextBox.Name = "serNoTextBox";
            this.serNoTextBox.Size = new System.Drawing.Size(100, 20);
            this.serNoTextBox.TabIndex = 11;
            // 
            // SYS_INFO_SET
            // 
            this.SYS_INFO_SET.Location = new System.Drawing.Point(111, 107);
            this.SYS_INFO_SET.Name = "SYS_INFO_SET";
            this.SYS_INFO_SET.Size = new System.Drawing.Size(75, 23);
            this.SYS_INFO_SET.TabIndex = 8;
            this.SYS_INFO_SET.Text = "Set";
            this.SYS_INFO_SET.UseVisualStyleBackColor = true;
            this.SYS_INFO_SET.Click += new System.EventHandler(this.SYS_INFO_SET_Click);
            // 
            // SYS_INFO_GET
            // 
            this.SYS_INFO_GET.Location = new System.Drawing.Point(18, 108);
            this.SYS_INFO_GET.Name = "SYS_INFO_GET";
            this.SYS_INFO_GET.Size = new System.Drawing.Size(75, 23);
            this.SYS_INFO_GET.TabIndex = 7;
            this.SYS_INFO_GET.Text = "Get";
            this.SYS_INFO_GET.UseVisualStyleBackColor = true;
            this.SYS_INFO_GET.Click += new System.EventHandler(this.SYS_INFO_GET_Click);
            // 
            // groupBox11
            // 
            this.groupBox11.Controls.Add(this.buttonChairReset);
            this.groupBox11.Controls.Add(this.textChairTestId);
            this.groupBox11.Controls.Add(this.buttonChairFactoryDefaults);
            this.groupBox11.Controls.Add(this.buttonTestChair);
            this.groupBox11.Controls.Add(this.buttonAppWriteFlash);
            this.groupBox11.Controls.Add(this.buttonChairAppReinit);
            this.groupBox11.Controls.Add(this.buttonChairAppInit);
            this.groupBox11.Controls.Add(this.buttonChairAppStop);
            this.groupBox11.Controls.Add(this.buttonChairAppStart);
            this.groupBox11.Location = new System.Drawing.Point(16, 423);
            this.groupBox11.Name = "groupBox11";
            this.groupBox11.Size = new System.Drawing.Size(985, 45);
            this.groupBox11.TabIndex = 8;
            this.groupBox11.TabStop = false;
            this.groupBox11.Text = "APP control";
            // 
            // buttonChairReset
            // 
            this.buttonChairReset.Location = new System.Drawing.Point(337, 16);
            this.buttonChairReset.Name = "buttonChairReset";
            this.buttonChairReset.Size = new System.Drawing.Size(75, 23);
            this.buttonChairReset.TabIndex = 52;
            this.buttonChairReset.Text = "Reset";
            this.buttonChairReset.UseVisualStyleBackColor = true;
            this.buttonChairReset.Click += new System.EventHandler(this.buttonChairReset_Click);
            // 
            // textChairTestId
            // 
            this.textChairTestId.AllowInternalTab = false;
            this.textChairTestId.AutoHeight = true;
            this.textChairTestId.BackColor = System.Drawing.SystemColors.Window;
            this.textChairTestId.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.textChairTestId.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textChairTestId.FieldCount = 1;
            this.textChairTestId.IntValue = 0;
            this.textChairTestId.Location = new System.Drawing.Point(578, 15);
            this.textChairTestId.Name = "textChairTestId";
            this.textChairTestId.ReadOnly = false;
            this.textChairTestId.Size = new System.Drawing.Size(123, 20);
            this.textChairTestId.TabIndex = 51;
            this.textChairTestId.Text = "0x";
            // 
            // buttonChairFactoryDefaults
            // 
            this.buttonChairFactoryDefaults.Location = new System.Drawing.Point(709, 17);
            this.buttonChairFactoryDefaults.Name = "buttonChairFactoryDefaults";
            this.buttonChairFactoryDefaults.Size = new System.Drawing.Size(93, 23);
            this.buttonChairFactoryDefaults.TabIndex = 50;
            this.buttonChairFactoryDefaults.Text = "Factory defaults";
            this.buttonChairFactoryDefaults.UseVisualStyleBackColor = true;
            this.buttonChairFactoryDefaults.Click += new System.EventHandler(this.buttonChairFactoryDefaults_Click);
            // 
            // buttonTestChair
            // 
            this.buttonTestChair.Location = new System.Drawing.Point(497, 16);
            this.buttonTestChair.Name = "buttonTestChair";
            this.buttonTestChair.Size = new System.Drawing.Size(75, 23);
            this.buttonTestChair.TabIndex = 48;
            this.buttonTestChair.Text = "Test";
            this.buttonTestChair.UseVisualStyleBackColor = true;
            this.buttonTestChair.Click += new System.EventHandler(this.buttonChairTest_Click);
            // 
            // buttonAppWriteFlash
            // 
            this.buttonAppWriteFlash.Location = new System.Drawing.Point(417, 16);
            this.buttonAppWriteFlash.Name = "buttonAppWriteFlash";
            this.buttonAppWriteFlash.Size = new System.Drawing.Size(75, 23);
            this.buttonAppWriteFlash.TabIndex = 47;
            this.buttonAppWriteFlash.Text = "Write flash";
            this.buttonAppWriteFlash.UseVisualStyleBackColor = true;
            this.buttonAppWriteFlash.Click += new System.EventHandler(this.buttonChairAppWriteFlash_Click);
            // 
            // buttonChairAppReinit
            // 
            this.buttonChairAppReinit.Location = new System.Drawing.Point(256, 17);
            this.buttonChairAppReinit.Name = "buttonChairAppReinit";
            this.buttonChairAppReinit.Size = new System.Drawing.Size(75, 23);
            this.buttonChairAppReinit.TabIndex = 46;
            this.buttonChairAppReinit.Text = "App reinit";
            this.buttonChairAppReinit.UseVisualStyleBackColor = true;
            this.buttonChairAppReinit.Click += new System.EventHandler(this.buttonChairAppReinit_Click);
            // 
            // buttonChairAppInit
            // 
            this.buttonChairAppInit.Location = new System.Drawing.Point(175, 17);
            this.buttonChairAppInit.Name = "buttonChairAppInit";
            this.buttonChairAppInit.Size = new System.Drawing.Size(75, 23);
            this.buttonChairAppInit.TabIndex = 45;
            this.buttonChairAppInit.Text = "App init";
            this.buttonChairAppInit.UseVisualStyleBackColor = true;
            this.buttonChairAppInit.Click += new System.EventHandler(this.buttonChairAppInit_Click);
            // 
            // buttonChairAppStop
            // 
            this.buttonChairAppStop.Location = new System.Drawing.Point(90, 16);
            this.buttonChairAppStop.Name = "buttonChairAppStop";
            this.buttonChairAppStop.Size = new System.Drawing.Size(75, 23);
            this.buttonChairAppStop.TabIndex = 44;
            this.buttonChairAppStop.Text = "App stop";
            this.buttonChairAppStop.UseVisualStyleBackColor = true;
            this.buttonChairAppStop.Click += new System.EventHandler(this.buttonChairAppStop_Click);
            // 
            // buttonChairAppStart
            // 
            this.buttonChairAppStart.Location = new System.Drawing.Point(9, 16);
            this.buttonChairAppStart.Name = "buttonChairAppStart";
            this.buttonChairAppStart.Size = new System.Drawing.Size(75, 23);
            this.buttonChairAppStart.TabIndex = 43;
            this.buttonChairAppStart.Text = "App start";
            this.buttonChairAppStart.UseVisualStyleBackColor = true;
            this.buttonChairAppStart.Click += new System.EventHandler(this.buttonChairAppStart_Click);
            // 
            // groupBox10
            // 
            this.groupBox10.Controls.Add(this.panel1);
            this.groupBox10.Location = new System.Drawing.Point(801, 16);
            this.groupBox10.Name = "groupBox10";
            this.groupBox10.Size = new System.Drawing.Size(200, 263);
            this.groupBox10.TabIndex = 7;
            this.groupBox10.TabStop = false;
            this.groupBox10.Text = "ZSMI31014_EE";
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.Controls.Add(this.ZSMI31014_EE_SET);
            this.panel1.Controls.Add(this.ZSMI31014_EE_GET);
            this.panel1.Controls.Add(cust_ID0Label);
            this.panel1.Controls.Add(this.cust_ID0TextBox);
            this.panel1.Controls.Add(zMD_Config_1Label);
            this.panel1.Controls.Add(this.zMD_Config_1TextBox);
            this.panel1.Controls.Add(zMD_Config_2Label);
            this.panel1.Controls.Add(this.zMD_Config_2TextBox);
            this.panel1.Controls.Add(offset_BLabel);
            this.panel1.Controls.Add(this.offset_BTextBox);
            this.panel1.Controls.Add(gain_BLabel);
            this.panel1.Controls.Add(this.gain_BTextBox);
            this.panel1.Controls.Add(tcgLabel);
            this.panel1.Controls.Add(this.tcgTextBox);
            this.panel1.Controls.Add(tcoLabel);
            this.panel1.Controls.Add(this.tcoTextBox);
            this.panel1.Controls.Add(sOT_tcoLabel);
            this.panel1.Controls.Add(this.sOT_tcoTextBox);
            this.panel1.Controls.Add(sOT_tcgLabel);
            this.panel1.Controls.Add(this.sOT_tcgTextBox);
            this.panel1.Controls.Add(sOT_bridgeLabel);
            this.panel1.Controls.Add(this.sOT_bridgeTextBox);
            this.panel1.Controls.Add(offset_TLabel);
            this.panel1.Controls.Add(this.offset_TTextBox);
            this.panel1.Controls.Add(gain_TLabel);
            this.panel1.Controls.Add(this.gain_TTextBox);
            this.panel1.Controls.Add(sOT_TLabel);
            this.panel1.Controls.Add(this.sOT_TTextBox);
            this.panel1.Controls.Add(t_SETLLabel);
            this.panel1.Controls.Add(this.t_SETLTextBox);
            this.panel1.Controls.Add(cust_ID1Label);
            this.panel1.Controls.Add(this.cust_ID1TextBox);
            this.panel1.Controls.Add(b_ConfigLabel);
            this.panel1.Controls.Add(this.b_ConfigTextBox);
            this.panel1.Controls.Add(t_ConfigLabel);
            this.panel1.Controls.Add(this.t_ConfigTextBox);
            this.panel1.Controls.Add(osc_TrimLabel);
            this.panel1.Controls.Add(this.osc_TrimTextBox);
            this.panel1.Controls.Add(signatureLabel);
            this.panel1.Controls.Add(this.signatureTextBox);
            this.panel1.Controls.Add(cust_ID2Label);
            this.panel1.Controls.Add(this.cust_ID2TextBox);
            this.panel1.Location = new System.Drawing.Point(-3, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(206, 267);
            this.panel1.TabIndex = 8;
            this.panel1.Scroll += new System.Windows.Forms.ScrollEventHandler(this.panel1_Scroll);
            // 
            // ZSMI31014_EE_SET
            // 
            this.ZSMI31014_EE_SET.Location = new System.Drawing.Point(102, 535);
            this.ZSMI31014_EE_SET.Name = "ZSMI31014_EE_SET";
            this.ZSMI31014_EE_SET.Size = new System.Drawing.Size(75, 23);
            this.ZSMI31014_EE_SET.TabIndex = 45;
            this.ZSMI31014_EE_SET.Text = "Set";
            this.ZSMI31014_EE_SET.UseVisualStyleBackColor = true;
            this.ZSMI31014_EE_SET.Click += new System.EventHandler(this.ZSMI31014_EE_SET_Click);
            // 
            // ZSMI31014_EE_GET
            // 
            this.ZSMI31014_EE_GET.Location = new System.Drawing.Point(9, 537);
            this.ZSMI31014_EE_GET.Name = "ZSMI31014_EE_GET";
            this.ZSMI31014_EE_GET.Size = new System.Drawing.Size(75, 23);
            this.ZSMI31014_EE_GET.TabIndex = 44;
            this.ZSMI31014_EE_GET.Text = "Get";
            this.ZSMI31014_EE_GET.UseVisualStyleBackColor = true;
            this.ZSMI31014_EE_GET.Click += new System.EventHandler(this.ZSMI31014_EE_GET_Click);
            // 
            // cust_ID0TextBox
            // 
            this.cust_ID0TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.zSMI31014_EEBindingSource, "Cust_ID0", true));
            this.cust_ID0TextBox.Location = new System.Drawing.Point(89, 10);
            this.cust_ID0TextBox.Name = "cust_ID0TextBox";
            this.cust_ID0TextBox.Size = new System.Drawing.Size(100, 20);
            this.cust_ID0TextBox.TabIndex = 5;
            // 
            // zSMI31014_EEBindingSource
            // 
            this.zSMI31014_EEBindingSource.DataMember = "BASYS_ADDR_ZSMI31014_EE";
            this.zSMI31014_EEBindingSource.DataSource = this.bASYS_ADDRBindingSource;
            // 
            // zMD_Config_1TextBox
            // 
            this.zMD_Config_1TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.zSMI31014_EEBindingSource, "ZMD_Config_1", true));
            this.zMD_Config_1TextBox.Location = new System.Drawing.Point(89, 36);
            this.zMD_Config_1TextBox.Name = "zMD_Config_1TextBox";
            this.zMD_Config_1TextBox.Size = new System.Drawing.Size(100, 20);
            this.zMD_Config_1TextBox.TabIndex = 7;
            // 
            // zMD_Config_2TextBox
            // 
            this.zMD_Config_2TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.zSMI31014_EEBindingSource, "ZMD_Config_2", true));
            this.zMD_Config_2TextBox.Location = new System.Drawing.Point(89, 62);
            this.zMD_Config_2TextBox.Name = "zMD_Config_2TextBox";
            this.zMD_Config_2TextBox.Size = new System.Drawing.Size(100, 20);
            this.zMD_Config_2TextBox.TabIndex = 9;
            // 
            // offset_BTextBox
            // 
            this.offset_BTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.zSMI31014_EEBindingSource, "Offset_B", true));
            this.offset_BTextBox.Location = new System.Drawing.Point(89, 88);
            this.offset_BTextBox.Name = "offset_BTextBox";
            this.offset_BTextBox.Size = new System.Drawing.Size(100, 20);
            this.offset_BTextBox.TabIndex = 11;
            // 
            // gain_BTextBox
            // 
            this.gain_BTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.zSMI31014_EEBindingSource, "Gain_B", true));
            this.gain_BTextBox.Location = new System.Drawing.Point(89, 114);
            this.gain_BTextBox.Name = "gain_BTextBox";
            this.gain_BTextBox.Size = new System.Drawing.Size(100, 20);
            this.gain_BTextBox.TabIndex = 13;
            // 
            // tcgTextBox
            // 
            this.tcgTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.zSMI31014_EEBindingSource, "Tcg", true));
            this.tcgTextBox.Location = new System.Drawing.Point(89, 140);
            this.tcgTextBox.Name = "tcgTextBox";
            this.tcgTextBox.Size = new System.Drawing.Size(100, 20);
            this.tcgTextBox.TabIndex = 15;
            // 
            // tcoTextBox
            // 
            this.tcoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.zSMI31014_EEBindingSource, "Tco", true));
            this.tcoTextBox.Location = new System.Drawing.Point(89, 166);
            this.tcoTextBox.Name = "tcoTextBox";
            this.tcoTextBox.Size = new System.Drawing.Size(100, 20);
            this.tcoTextBox.TabIndex = 17;
            // 
            // sOT_tcoTextBox
            // 
            this.sOT_tcoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.zSMI31014_EEBindingSource, "SOT_tco", true));
            this.sOT_tcoTextBox.Location = new System.Drawing.Point(89, 192);
            this.sOT_tcoTextBox.Name = "sOT_tcoTextBox";
            this.sOT_tcoTextBox.Size = new System.Drawing.Size(100, 20);
            this.sOT_tcoTextBox.TabIndex = 19;
            // 
            // sOT_tcgTextBox
            // 
            this.sOT_tcgTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.zSMI31014_EEBindingSource, "SOT_tcg", true));
            this.sOT_tcgTextBox.Location = new System.Drawing.Point(89, 218);
            this.sOT_tcgTextBox.Name = "sOT_tcgTextBox";
            this.sOT_tcgTextBox.Size = new System.Drawing.Size(100, 20);
            this.sOT_tcgTextBox.TabIndex = 21;
            // 
            // sOT_bridgeTextBox
            // 
            this.sOT_bridgeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.zSMI31014_EEBindingSource, "SOT_bridge", true));
            this.sOT_bridgeTextBox.Location = new System.Drawing.Point(89, 244);
            this.sOT_bridgeTextBox.Name = "sOT_bridgeTextBox";
            this.sOT_bridgeTextBox.Size = new System.Drawing.Size(100, 20);
            this.sOT_bridgeTextBox.TabIndex = 23;
            // 
            // offset_TTextBox
            // 
            this.offset_TTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.zSMI31014_EEBindingSource, "Offset_T", true));
            this.offset_TTextBox.Location = new System.Drawing.Point(89, 270);
            this.offset_TTextBox.Name = "offset_TTextBox";
            this.offset_TTextBox.Size = new System.Drawing.Size(100, 20);
            this.offset_TTextBox.TabIndex = 25;
            // 
            // gain_TTextBox
            // 
            this.gain_TTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.zSMI31014_EEBindingSource, "Gain_T", true));
            this.gain_TTextBox.Location = new System.Drawing.Point(89, 296);
            this.gain_TTextBox.Name = "gain_TTextBox";
            this.gain_TTextBox.Size = new System.Drawing.Size(100, 20);
            this.gain_TTextBox.TabIndex = 27;
            // 
            // sOT_TTextBox
            // 
            this.sOT_TTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.zSMI31014_EEBindingSource, "SOT_T", true));
            this.sOT_TTextBox.Location = new System.Drawing.Point(89, 322);
            this.sOT_TTextBox.Name = "sOT_TTextBox";
            this.sOT_TTextBox.Size = new System.Drawing.Size(100, 20);
            this.sOT_TTextBox.TabIndex = 29;
            // 
            // t_SETLTextBox
            // 
            this.t_SETLTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.zSMI31014_EEBindingSource, "T_SETL", true));
            this.t_SETLTextBox.Location = new System.Drawing.Point(89, 348);
            this.t_SETLTextBox.Name = "t_SETLTextBox";
            this.t_SETLTextBox.Size = new System.Drawing.Size(100, 20);
            this.t_SETLTextBox.TabIndex = 31;
            // 
            // cust_ID1TextBox
            // 
            this.cust_ID1TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.zSMI31014_EEBindingSource, "Cust_ID1", true));
            this.cust_ID1TextBox.Location = new System.Drawing.Point(89, 374);
            this.cust_ID1TextBox.Name = "cust_ID1TextBox";
            this.cust_ID1TextBox.Size = new System.Drawing.Size(100, 20);
            this.cust_ID1TextBox.TabIndex = 33;
            // 
            // b_ConfigTextBox
            // 
            this.b_ConfigTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.zSMI31014_EEBindingSource, "B_Config", true));
            this.b_ConfigTextBox.Location = new System.Drawing.Point(89, 400);
            this.b_ConfigTextBox.Name = "b_ConfigTextBox";
            this.b_ConfigTextBox.Size = new System.Drawing.Size(100, 20);
            this.b_ConfigTextBox.TabIndex = 35;
            // 
            // t_ConfigTextBox
            // 
            this.t_ConfigTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.zSMI31014_EEBindingSource, "T_Config", true));
            this.t_ConfigTextBox.Location = new System.Drawing.Point(89, 426);
            this.t_ConfigTextBox.Name = "t_ConfigTextBox";
            this.t_ConfigTextBox.Size = new System.Drawing.Size(100, 20);
            this.t_ConfigTextBox.TabIndex = 37;
            // 
            // osc_TrimTextBox
            // 
            this.osc_TrimTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.zSMI31014_EEBindingSource, "Osc_Trim", true));
            this.osc_TrimTextBox.Location = new System.Drawing.Point(89, 452);
            this.osc_TrimTextBox.Name = "osc_TrimTextBox";
            this.osc_TrimTextBox.Size = new System.Drawing.Size(100, 20);
            this.osc_TrimTextBox.TabIndex = 39;
            // 
            // signatureTextBox
            // 
            this.signatureTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.zSMI31014_EEBindingSource, "Signature", true));
            this.signatureTextBox.Location = new System.Drawing.Point(89, 478);
            this.signatureTextBox.Name = "signatureTextBox";
            this.signatureTextBox.Size = new System.Drawing.Size(100, 20);
            this.signatureTextBox.TabIndex = 41;
            // 
            // cust_ID2TextBox
            // 
            this.cust_ID2TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.zSMI31014_EEBindingSource, "Cust_ID2", true));
            this.cust_ID2TextBox.Location = new System.Drawing.Point(89, 504);
            this.cust_ID2TextBox.Name = "cust_ID2TextBox";
            this.cust_ID2TextBox.Size = new System.Drawing.Size(100, 20);
            this.cust_ID2TextBox.TabIndex = 43;
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.weightStatusTextBox);
            this.groupBox8.Controls.Add(this.checkBoxWeightAutoUpdate);
            this.groupBox8.Controls.Add(this.GetWeightButton);
            this.groupBox8.Controls.Add(this.CurrentWeightBox);
            this.groupBox8.Controls.Add(this.Weight);
            this.groupBox8.Controls.Add(this.sWeight);
            this.groupBox8.Location = new System.Drawing.Point(563, 285);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(216, 136);
            this.groupBox8.TabIndex = 6;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "Weight status";
            // 
            // weightStatusTextBox
            // 
            this.weightStatusTextBox.AllowInternalTab = false;
            this.weightStatusTextBox.AutoHeight = true;
            this.weightStatusTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.weightStatusTextBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.weightStatusTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.weightStatusTextBox.FieldCount = 1;
            this.weightStatusTextBox.IntValue = 0;
            this.weightStatusTextBox.Location = new System.Drawing.Point(91, 18);
            this.weightStatusTextBox.Name = "weightStatusTextBox";
            this.weightStatusTextBox.ReadOnly = false;
            this.weightStatusTextBox.Size = new System.Drawing.Size(105, 20);
            this.weightStatusTextBox.TabIndex = 6;
            this.weightStatusTextBox.Text = "0x";
            // 
            // checkBoxWeightAutoUpdate
            // 
            this.checkBoxWeightAutoUpdate.AutoSize = true;
            this.checkBoxWeightAutoUpdate.Location = new System.Drawing.Point(102, 98);
            this.checkBoxWeightAutoUpdate.Name = "checkBoxWeightAutoUpdate";
            this.checkBoxWeightAutoUpdate.Size = new System.Drawing.Size(84, 17);
            this.checkBoxWeightAutoUpdate.TabIndex = 5;
            this.checkBoxWeightAutoUpdate.Text = "Auto update";
            this.checkBoxWeightAutoUpdate.UseVisualStyleBackColor = true;
            this.checkBoxWeightAutoUpdate.CheckedChanged += new System.EventHandler(this.checkBoxWeightAutoUpdate_CheckedChanged);
            // 
            // GetWeightButton
            // 
            this.GetWeightButton.Location = new System.Drawing.Point(6, 94);
            this.GetWeightButton.Name = "GetWeightButton";
            this.GetWeightButton.Size = new System.Drawing.Size(75, 23);
            this.GetWeightButton.TabIndex = 4;
            this.GetWeightButton.Text = "Get weight";
            this.GetWeightButton.UseVisualStyleBackColor = true;
            this.GetWeightButton.Click += new System.EventHandler(this.GetWeightButton_Click);
            // 
            // CurrentWeightBox
            // 
            this.CurrentWeightBox.Location = new System.Drawing.Point(91, 49);
            this.CurrentWeightBox.Name = "CurrentWeightBox";
            this.CurrentWeightBox.Size = new System.Drawing.Size(105, 20);
            this.CurrentWeightBox.TabIndex = 3;
            this.CurrentWeightBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Weight
            // 
            this.Weight.AutoSize = true;
            this.Weight.Location = new System.Drawing.Point(10, 52);
            this.Weight.Name = "Weight";
            this.Weight.Size = new System.Drawing.Size(75, 13);
            this.Weight.TabIndex = 1;
            this.Weight.Text = "Current weight";
            // 
            // sWeight
            // 
            this.sWeight.AutoSize = true;
            this.sWeight.Location = new System.Drawing.Point(10, 21);
            this.sWeight.Name = "sWeight";
            this.sWeight.Size = new System.Drawing.Size(72, 13);
            this.sWeight.TabIndex = 0;
            this.sWeight.Text = "Weight status";
            // 
            // BASYS_ADDR
            // 
            this.BASYS_ADDR.Controls.Add(this.remote_addrTextBox);
            this.BASYS_ADDR.Controls.Add(this.chair_addrTextBox);
            this.BASYS_ADDR.Controls.Add(this.BASYS_ADDR_SET);
            this.BASYS_ADDR.Controls.Add(this.BASYS_ADDR_GET);
            this.BASYS_ADDR.Controls.Add(chair_addrLabel);
            this.BASYS_ADDR.Controls.Add(remote_addrLabel);
            this.BASYS_ADDR.Location = new System.Drawing.Point(562, 158);
            this.BASYS_ADDR.Name = "BASYS_ADDR";
            this.BASYS_ADDR.Size = new System.Drawing.Size(217, 121);
            this.BASYS_ADDR.TabIndex = 5;
            this.BASYS_ADDR.TabStop = false;
            this.BASYS_ADDR.Text = "BASYS_ADDR";
            // 
            // remote_addrTextBox
            // 
            this.remote_addrTextBox.AllowInternalTab = false;
            this.remote_addrTextBox.AutoHeight = true;
            this.remote_addrTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.remote_addrTextBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.remote_addrTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.remote_addrTextBox.DataBindings.Add(new System.Windows.Forms.Binding("IntValue", this.bASYS_ADDRBindingSource, "remote_addr", true));
            this.remote_addrTextBox.FieldCount = 4;
            this.remote_addrTextBox.Location = new System.Drawing.Point(85, 52);
            this.remote_addrTextBox.Name = "remote_addrTextBox";
            this.remote_addrTextBox.ReadOnly = false;
            this.remote_addrTextBox.Size = new System.Drawing.Size(112, 20);
            this.remote_addrTextBox.TabIndex = 9;
            this.remote_addrTextBox.Text = ":::";
            // 
            // chair_addrTextBox
            // 
            this.chair_addrTextBox.AllowInternalTab = false;
            this.chair_addrTextBox.AutoHeight = true;
            this.chair_addrTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.chair_addrTextBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.chair_addrTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.chair_addrTextBox.DataBindings.Add(new System.Windows.Forms.Binding("IntValue", this.bASYS_ADDRBindingSource, "chair_addr", true));
            this.chair_addrTextBox.FieldCount = 4;
            this.chair_addrTextBox.Location = new System.Drawing.Point(85, 26);
            this.chair_addrTextBox.Name = "chair_addrTextBox";
            this.chair_addrTextBox.ReadOnly = false;
            this.chair_addrTextBox.Size = new System.Drawing.Size(112, 20);
            this.chair_addrTextBox.TabIndex = 8;
            this.chair_addrTextBox.Text = ":::";
            // 
            // BASYS_ADDR_SET
            // 
            this.BASYS_ADDR_SET.Location = new System.Drawing.Point(117, 78);
            this.BASYS_ADDR_SET.Name = "BASYS_ADDR_SET";
            this.BASYS_ADDR_SET.Size = new System.Drawing.Size(75, 23);
            this.BASYS_ADDR_SET.TabIndex = 7;
            this.BASYS_ADDR_SET.Text = "Set";
            this.BASYS_ADDR_SET.UseVisualStyleBackColor = true;
            this.BASYS_ADDR_SET.Click += new System.EventHandler(this.BASYS_ADDR_SET_Click);
            // 
            // BASYS_ADDR_GET
            // 
            this.BASYS_ADDR_GET.Location = new System.Drawing.Point(7, 78);
            this.BASYS_ADDR_GET.Name = "BASYS_ADDR_GET";
            this.BASYS_ADDR_GET.Size = new System.Drawing.Size(75, 23);
            this.BASYS_ADDR_GET.TabIndex = 6;
            this.BASYS_ADDR_GET.Text = "Get";
            this.BASYS_ADDR_GET.UseVisualStyleBackColor = true;
            this.BASYS_ADDR_GET.Click += new System.EventHandler(this.BASYS_ADDR_GET_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.sysStatusTextBox);
            this.groupBox5.Controls.Add(this.chairStatusTextBox);
            this.groupBox5.Controls.Add(forceLabel);
            this.groupBox5.Controls.Add(this.forceTextBox);
            this.groupBox5.Controls.Add(chair_statusLabel);
            this.groupBox5.Controls.Add(sys_statusLabel);
            this.groupBox5.Controls.Add(this.BASYS_S_SET);
            this.groupBox5.Controls.Add(this.BASYS_S_GET);
            this.groupBox5.Location = new System.Drawing.Point(560, 16);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(225, 137);
            this.groupBox5.TabIndex = 4;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "BASYS_S";
            // 
            // sysStatusTextBox
            // 
            this.sysStatusTextBox.AllowInternalTab = false;
            this.sysStatusTextBox.AutoHeight = true;
            this.sysStatusTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.sysStatusTextBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.sysStatusTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.sysStatusTextBox.DataBindings.Add(new System.Windows.Forms.Binding("IntValue", this.bASYS_SBindingSource, "sys_status", true));
            this.sysStatusTextBox.FieldCount = 1;
            this.sysStatusTextBox.IntValue = 0;
            this.sysStatusTextBox.Location = new System.Drawing.Point(99, 68);
            this.sysStatusTextBox.Name = "sysStatusTextBox";
            this.sysStatusTextBox.ReadOnly = false;
            this.sysStatusTextBox.Size = new System.Drawing.Size(100, 20);
            this.sysStatusTextBox.TabIndex = 22;
            this.sysStatusTextBox.Text = "0x";
            // 
            // chairStatusTextBox
            // 
            this.chairStatusTextBox.AllowInternalTab = false;
            this.chairStatusTextBox.AutoHeight = true;
            this.chairStatusTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.chairStatusTextBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.chairStatusTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.chairStatusTextBox.DataBindings.Add(new System.Windows.Forms.Binding("IntValue", this.bASYS_SBindingSource, "chair_status", true));
            this.chairStatusTextBox.FieldCount = 1;
            this.chairStatusTextBox.IntValue = 0;
            this.chairStatusTextBox.Location = new System.Drawing.Point(99, 42);
            this.chairStatusTextBox.Name = "chairStatusTextBox";
            this.chairStatusTextBox.ReadOnly = false;
            this.chairStatusTextBox.Size = new System.Drawing.Size(100, 20);
            this.chairStatusTextBox.TabIndex = 21;
            this.chairStatusTextBox.Text = "0x";
            // 
            // forceTextBox
            // 
            this.forceTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bASYS_SBindingSource, "force", true));
            this.forceTextBox.Location = new System.Drawing.Point(99, 14);
            this.forceTextBox.Name = "forceTextBox";
            this.forceTextBox.Size = new System.Drawing.Size(100, 20);
            this.forceTextBox.TabIndex = 16;
            this.forceTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // BASYS_S_SET
            // 
            this.BASYS_S_SET.Location = new System.Drawing.Point(119, 94);
            this.BASYS_S_SET.Name = "BASYS_S_SET";
            this.BASYS_S_SET.Size = new System.Drawing.Size(75, 23);
            this.BASYS_S_SET.TabIndex = 11;
            this.BASYS_S_SET.Text = "Set";
            this.BASYS_S_SET.UseVisualStyleBackColor = true;
            this.BASYS_S_SET.Click += new System.EventHandler(this.BASYS_S_SET_Click);
            // 
            // BASYS_S_GET
            // 
            this.BASYS_S_GET.Location = new System.Drawing.Point(13, 94);
            this.BASYS_S_GET.Name = "BASYS_S_GET";
            this.BASYS_S_GET.Size = new System.Drawing.Size(75, 23);
            this.BASYS_S_GET.TabIndex = 10;
            this.BASYS_S_GET.Text = "Get";
            this.BASYS_S_GET.UseVisualStyleBackColor = true;
            this.BASYS_S_GET.Click += new System.EventHandler(this.BASYS_S_GET_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.textBox1);
            this.groupBox4.Controls.Add(this.BAMOT_PS_Set);
            this.groupBox4.Controls.Add(this.BAMOT_PS_Get);
            this.groupBox4.Controls.Add(motorFSMTick_usLabel);
            this.groupBox4.Controls.Add(this.motorFSMTick_usTextBox);
            this.groupBox4.Controls.Add(this.currLimitFilterLen_msTextBox);
            this.groupBox4.Controls.Add(currLimitFilterLen_msLabel);
            this.groupBox4.Controls.Add(currentLimit_ALabel);
            this.groupBox4.Location = new System.Drawing.Point(291, 266);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(253, 155);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "BAMOT_PS";
            // 
            // textBox1
            // 
            this.textBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bAMOT_PSBindingSource, "CurrentLimit_A", true));
            this.textBox1.Location = new System.Drawing.Point(126, 75);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(116, 20);
            this.textBox1.TabIndex = 16;
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // BAMOT_PS_Set
            // 
            this.BAMOT_PS_Set.Location = new System.Drawing.Point(142, 113);
            this.BAMOT_PS_Set.Name = "BAMOT_PS_Set";
            this.BAMOT_PS_Set.Size = new System.Drawing.Size(75, 23);
            this.BAMOT_PS_Set.TabIndex = 15;
            this.BAMOT_PS_Set.Text = "Set";
            this.BAMOT_PS_Set.UseVisualStyleBackColor = true;
            this.BAMOT_PS_Set.Click += new System.EventHandler(this.BAMOT_PS_SET_Click);
            // 
            // BAMOT_PS_Get
            // 
            this.BAMOT_PS_Get.Location = new System.Drawing.Point(18, 113);
            this.BAMOT_PS_Get.Name = "BAMOT_PS_Get";
            this.BAMOT_PS_Get.Size = new System.Drawing.Size(75, 23);
            this.BAMOT_PS_Get.TabIndex = 14;
            this.BAMOT_PS_Get.Text = "Get";
            this.BAMOT_PS_Get.UseVisualStyleBackColor = true;
            this.BAMOT_PS_Get.Click += new System.EventHandler(this.BAMOT_PS_GET_Click);
            // 
            // motorFSMTick_usTextBox
            // 
            this.motorFSMTick_usTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bAMOT_PSBindingSource, "MotorFSMTick_us", true));
            this.motorFSMTick_usTextBox.Location = new System.Drawing.Point(126, 23);
            this.motorFSMTick_usTextBox.Name = "motorFSMTick_usTextBox";
            this.motorFSMTick_usTextBox.Size = new System.Drawing.Size(116, 20);
            this.motorFSMTick_usTextBox.TabIndex = 9;
            this.motorFSMTick_usTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // currLimitFilterLen_msTextBox
            // 
            this.currLimitFilterLen_msTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bAMOT_PSBindingSource, "CurrLimitFilterLen_ms", true));
            this.currLimitFilterLen_msTextBox.Location = new System.Drawing.Point(126, 49);
            this.currLimitFilterLen_msTextBox.Name = "currLimitFilterLen_msTextBox";
            this.currLimitFilterLen_msTextBox.Size = new System.Drawing.Size(116, 20);
            this.currLimitFilterLen_msTextBox.TabIndex = 11;
            this.currLimitFilterLen_msTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.BAMOT_PR_SET);
            this.groupBox3.Controls.Add(this.BAMOT_PR_GET);
            this.groupBox3.Controls.Add(motorStartupTimeout_msLabel);
            this.groupBox3.Controls.Add(this.motorStartupTimeout_msTextBox);
            this.groupBox3.Controls.Add(this.motorStartupPWMTextBox);
            this.groupBox3.Controls.Add(motorStartupPWMLabel);
            this.groupBox3.Location = new System.Drawing.Point(290, 136);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(254, 121);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "BAMOT_PR";
            // 
            // BAMOT_PR_SET
            // 
            this.BAMOT_PR_SET.Location = new System.Drawing.Point(143, 78);
            this.BAMOT_PR_SET.Name = "BAMOT_PR_SET";
            this.BAMOT_PR_SET.Size = new System.Drawing.Size(75, 23);
            this.BAMOT_PR_SET.TabIndex = 11;
            this.BAMOT_PR_SET.Text = "Set";
            this.BAMOT_PR_SET.UseVisualStyleBackColor = true;
            this.BAMOT_PR_SET.Click += new System.EventHandler(this.BAMOT_PR_SET_Click);
            // 
            // BAMOT_PR_GET
            // 
            this.BAMOT_PR_GET.Location = new System.Drawing.Point(19, 78);
            this.BAMOT_PR_GET.Name = "BAMOT_PR_GET";
            this.BAMOT_PR_GET.Size = new System.Drawing.Size(75, 23);
            this.BAMOT_PR_GET.TabIndex = 10;
            this.BAMOT_PR_GET.Text = "Get";
            this.BAMOT_PR_GET.UseVisualStyleBackColor = true;
            this.BAMOT_PR_GET.Click += new System.EventHandler(this.BAMOT_PR_GET_Click);
            // 
            // motorStartupTimeout_msTextBox
            // 
            this.motorStartupTimeout_msTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bAMOT_PRBindingSource, "MotorStartupTimeout_ms", true));
            this.motorStartupTimeout_msTextBox.Location = new System.Drawing.Point(143, 23);
            this.motorStartupTimeout_msTextBox.Name = "motorStartupTimeout_msTextBox";
            this.motorStartupTimeout_msTextBox.Size = new System.Drawing.Size(100, 20);
            this.motorStartupTimeout_msTextBox.TabIndex = 7;
            this.motorStartupTimeout_msTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // motorStartupPWMTextBox
            // 
            this.motorStartupPWMTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bAMOT_PRBindingSource, "MotorStartupPWM", true));
            this.motorStartupPWMTextBox.Location = new System.Drawing.Point(143, 49);
            this.motorStartupPWMTextBox.Name = "motorStartupPWMTextBox";
            this.motorStartupPWMTextBox.Size = new System.Drawing.Size(100, 20);
            this.motorStartupPWMTextBox.TabIndex = 9;
            this.motorStartupPWMTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.BAFS_PS_Set);
            this.groupBox2.Controls.Add(this.BAFS_PS_GET);
            this.groupBox2.Controls.Add(measureFSMTickLabel);
            this.groupBox2.Controls.Add(this.measureFSMTickTextBox);
            this.groupBox2.Location = new System.Drawing.Point(290, 16);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(254, 111);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "BAFS_PS";
            // 
            // BAFS_PS_Set
            // 
            this.BAFS_PS_Set.Location = new System.Drawing.Point(143, 68);
            this.BAFS_PS_Set.Name = "BAFS_PS_Set";
            this.BAFS_PS_Set.Size = new System.Drawing.Size(75, 23);
            this.BAFS_PS_Set.TabIndex = 5;
            this.BAFS_PS_Set.Text = "Set";
            this.BAFS_PS_Set.UseVisualStyleBackColor = true;
            this.BAFS_PS_Set.Click += new System.EventHandler(this.BAFS_PS_Set_Click);
            // 
            // BAFS_PS_GET
            // 
            this.BAFS_PS_GET.Location = new System.Drawing.Point(19, 68);
            this.BAFS_PS_GET.Name = "BAFS_PS_GET";
            this.BAFS_PS_GET.Size = new System.Drawing.Size(75, 23);
            this.BAFS_PS_GET.TabIndex = 4;
            this.BAFS_PS_GET.Text = "Get";
            this.BAFS_PS_GET.UseVisualStyleBackColor = true;
            this.BAFS_PS_GET.Click += new System.EventHandler(this.BAFS_PS_GET_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.BAFS_PR_Set);
            this.groupBox1.Controls.Add(this.BAFS_PR_Get);
            this.groupBox1.Controls.Add(weightMinWeightLimitLabel);
            this.groupBox1.Controls.Add(zmd_Cust_ID2Label);
            this.groupBox1.Controls.Add(this.zmd_Cust_ID2TextBox);
            this.groupBox1.Controls.Add(this.zmd_CustI_D1TextBox);
            this.groupBox1.Controls.Add(this.weightMinWeightLimitTextBox);
            this.groupBox1.Controls.Add(this.zmd_CustI_D0TextBox);
            this.groupBox1.Controls.Add(this.weightMaxAlarmLimitTextBox);
            this.groupBox1.Controls.Add(this.zmd_Gain_BTextBox);
            this.groupBox1.Controls.Add(this.weightDeltaSetTextBox);
            this.groupBox1.Controls.Add(this.zmd_Offset_BTextBox);
            this.groupBox1.Controls.Add(this.weightDeltaAlarm1TextBox);
            this.groupBox1.Controls.Add(this.weightWorkFiltLenTextBox);
            this.groupBox1.Controls.Add(this.weightDeltaAlarm2TextBox);
            this.groupBox1.Controls.Add(this.weightSetpointFiltLenTextBox);
            this.groupBox1.Controls.Add(this.weightDeltaAlarm3TextBox);
            this.groupBox1.Controls.Add(zmd_CustI_D1Label);
            this.groupBox1.Controls.Add(weightMaxAlarmLimitLabel);
            this.groupBox1.Controls.Add(zmd_CustI_D0Label);
            this.groupBox1.Controls.Add(weightDeltaSetLabel);
            this.groupBox1.Controls.Add(zmd_Gain_BLabel);
            this.groupBox1.Controls.Add(weightDeltaAlarm1Label);
            this.groupBox1.Controls.Add(zmd_Offset_BLabel);
            this.groupBox1.Controls.Add(weightDeltaAlarm2Label);
            this.groupBox1.Controls.Add(weightWorkFiltLenLabel);
            this.groupBox1.Controls.Add(weightDeltaAlarm3Label);
            this.groupBox1.Controls.Add(weightSetpointFiltLenLabel);
            this.groupBox1.Location = new System.Drawing.Point(16, 16);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(252, 405);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "BAFS_PR";
            // 
            // BAFS_PR_Set
            // 
            this.BAFS_PR_Set.Location = new System.Drawing.Point(137, 363);
            this.BAFS_PR_Set.Name = "BAFS_PR_Set";
            this.BAFS_PR_Set.Size = new System.Drawing.Size(75, 23);
            this.BAFS_PR_Set.TabIndex = 57;
            this.BAFS_PR_Set.Text = "Set";
            this.BAFS_PR_Set.UseVisualStyleBackColor = true;
            this.BAFS_PR_Set.Click += new System.EventHandler(this.BAFS_PR_Set_Click);
            // 
            // BAFS_PR_Get
            // 
            this.BAFS_PR_Get.Location = new System.Drawing.Point(9, 363);
            this.BAFS_PR_Get.Name = "BAFS_PR_Get";
            this.BAFS_PR_Get.Size = new System.Drawing.Size(75, 23);
            this.BAFS_PR_Get.TabIndex = 56;
            this.BAFS_PR_Get.Text = "Get";
            this.BAFS_PR_Get.UseVisualStyleBackColor = true;
            this.BAFS_PR_Get.Click += new System.EventHandler(this.BAFS_PR_Get_Click);
            // 
            // zmd_Cust_ID2TextBox
            // 
            this.zmd_Cust_ID2TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bAFS_PRBindingSource, "Zmd_Cust_ID2", true));
            this.zmd_Cust_ID2TextBox.Location = new System.Drawing.Point(137, 322);
            this.zmd_Cust_ID2TextBox.Name = "zmd_Cust_ID2TextBox";
            this.zmd_Cust_ID2TextBox.Size = new System.Drawing.Size(100, 20);
            this.zmd_Cust_ID2TextBox.TabIndex = 55;
            this.zmd_Cust_ID2TextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // zmd_CustI_D1TextBox
            // 
            this.zmd_CustI_D1TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bAFS_PRBindingSource, "Zmd_CustI_D1", true));
            this.zmd_CustI_D1TextBox.Location = new System.Drawing.Point(137, 299);
            this.zmd_CustI_D1TextBox.Name = "zmd_CustI_D1TextBox";
            this.zmd_CustI_D1TextBox.Size = new System.Drawing.Size(100, 20);
            this.zmd_CustI_D1TextBox.TabIndex = 53;
            this.zmd_CustI_D1TextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // weightMinWeightLimitTextBox
            // 
            this.weightMinWeightLimitTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bAFS_PRBindingSource, "WeightMinWeightLimit", true));
            this.weightMinWeightLimitTextBox.Location = new System.Drawing.Point(137, 13);
            this.weightMinWeightLimitTextBox.Name = "weightMinWeightLimitTextBox";
            this.weightMinWeightLimitTextBox.Size = new System.Drawing.Size(100, 20);
            this.weightMinWeightLimitTextBox.TabIndex = 31;
            this.weightMinWeightLimitTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // zmd_CustI_D0TextBox
            // 
            this.zmd_CustI_D0TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bAFS_PRBindingSource, "Zmd_CustI_D0", true));
            this.zmd_CustI_D0TextBox.Location = new System.Drawing.Point(137, 273);
            this.zmd_CustI_D0TextBox.Name = "zmd_CustI_D0TextBox";
            this.zmd_CustI_D0TextBox.Size = new System.Drawing.Size(100, 20);
            this.zmd_CustI_D0TextBox.TabIndex = 51;
            this.zmd_CustI_D0TextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // weightMaxAlarmLimitTextBox
            // 
            this.weightMaxAlarmLimitTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bAFS_PRBindingSource, "WeightMaxAlarmLimit", true));
            this.weightMaxAlarmLimitTextBox.Location = new System.Drawing.Point(137, 39);
            this.weightMaxAlarmLimitTextBox.Name = "weightMaxAlarmLimitTextBox";
            this.weightMaxAlarmLimitTextBox.Size = new System.Drawing.Size(100, 20);
            this.weightMaxAlarmLimitTextBox.TabIndex = 33;
            this.weightMaxAlarmLimitTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // zmd_Gain_BTextBox
            // 
            this.zmd_Gain_BTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bAFS_PRBindingSource, "Zmd_Gain_B", true));
            this.zmd_Gain_BTextBox.Location = new System.Drawing.Point(137, 247);
            this.zmd_Gain_BTextBox.Name = "zmd_Gain_BTextBox";
            this.zmd_Gain_BTextBox.Size = new System.Drawing.Size(100, 20);
            this.zmd_Gain_BTextBox.TabIndex = 49;
            this.zmd_Gain_BTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // weightDeltaSetTextBox
            // 
            this.weightDeltaSetTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bAFS_PRBindingSource, "WeightDeltaSet", true));
            this.weightDeltaSetTextBox.Location = new System.Drawing.Point(137, 65);
            this.weightDeltaSetTextBox.Name = "weightDeltaSetTextBox";
            this.weightDeltaSetTextBox.Size = new System.Drawing.Size(100, 20);
            this.weightDeltaSetTextBox.TabIndex = 35;
            this.weightDeltaSetTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // zmd_Offset_BTextBox
            // 
            this.zmd_Offset_BTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bAFS_PRBindingSource, "Zmd_Offset_B", true));
            this.zmd_Offset_BTextBox.Location = new System.Drawing.Point(137, 221);
            this.zmd_Offset_BTextBox.Name = "zmd_Offset_BTextBox";
            this.zmd_Offset_BTextBox.Size = new System.Drawing.Size(100, 20);
            this.zmd_Offset_BTextBox.TabIndex = 47;
            this.zmd_Offset_BTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // weightDeltaAlarm1TextBox
            // 
            this.weightDeltaAlarm1TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bAFS_PRBindingSource, "WeightDeltaAlarm1", true));
            this.weightDeltaAlarm1TextBox.Location = new System.Drawing.Point(137, 91);
            this.weightDeltaAlarm1TextBox.Name = "weightDeltaAlarm1TextBox";
            this.weightDeltaAlarm1TextBox.Size = new System.Drawing.Size(100, 20);
            this.weightDeltaAlarm1TextBox.TabIndex = 37;
            this.weightDeltaAlarm1TextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // weightWorkFiltLenTextBox
            // 
            this.weightWorkFiltLenTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bAFS_PRBindingSource, "WeightWorkFiltLen", true));
            this.weightWorkFiltLenTextBox.Location = new System.Drawing.Point(137, 195);
            this.weightWorkFiltLenTextBox.Name = "weightWorkFiltLenTextBox";
            this.weightWorkFiltLenTextBox.Size = new System.Drawing.Size(100, 20);
            this.weightWorkFiltLenTextBox.TabIndex = 45;
            this.weightWorkFiltLenTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // weightDeltaAlarm2TextBox
            // 
            this.weightDeltaAlarm2TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bAFS_PRBindingSource, "WeightDeltaAlarm2", true));
            this.weightDeltaAlarm2TextBox.Location = new System.Drawing.Point(137, 117);
            this.weightDeltaAlarm2TextBox.Name = "weightDeltaAlarm2TextBox";
            this.weightDeltaAlarm2TextBox.Size = new System.Drawing.Size(100, 20);
            this.weightDeltaAlarm2TextBox.TabIndex = 39;
            this.weightDeltaAlarm2TextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // weightSetpointFiltLenTextBox
            // 
            this.weightSetpointFiltLenTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bAFS_PRBindingSource, "WeightSetpointFiltLen", true));
            this.weightSetpointFiltLenTextBox.Location = new System.Drawing.Point(137, 169);
            this.weightSetpointFiltLenTextBox.Name = "weightSetpointFiltLenTextBox";
            this.weightSetpointFiltLenTextBox.Size = new System.Drawing.Size(100, 20);
            this.weightSetpointFiltLenTextBox.TabIndex = 43;
            this.weightSetpointFiltLenTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // weightDeltaAlarm3TextBox
            // 
            this.weightDeltaAlarm3TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bAFS_PRBindingSource, "WeightDeltaAlarm3", true));
            this.weightDeltaAlarm3TextBox.Location = new System.Drawing.Point(137, 143);
            this.weightDeltaAlarm3TextBox.Name = "weightDeltaAlarm3TextBox";
            this.weightDeltaAlarm3TextBox.Size = new System.Drawing.Size(100, 20);
            this.weightDeltaAlarm3TextBox.TabIndex = 41;
            this.weightDeltaAlarm3TextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tabPage9
            // 
            this.tabPage9.Controls.Add(this.groupBox16);
            this.tabPage9.Controls.Add(this.groupBox12);
            this.tabPage9.Controls.Add(this.groupBox7);
            this.tabPage9.Controls.Add(this.groupBox6);
            this.tabPage9.Location = new System.Drawing.Point(4, 22);
            this.tabPage9.Name = "tabPage9";
            this.tabPage9.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage9.Size = new System.Drawing.Size(1007, 471);
            this.tabPage9.TabIndex = 1;
            this.tabPage9.Text = "Remote";
            this.tabPage9.UseVisualStyleBackColor = true;
            // 
            // groupBox16
            // 
            this.groupBox16.Controls.Add(this.sW_verTextBox1);
            this.groupBox16.Controls.Add(this.hW_verTextBox1);
            this.groupBox16.Controls.Add(serNoLabel1);
            this.groupBox16.Controls.Add(this.serNoTextBox1);
            this.groupBox16.Controls.Add(hW_VerLabel1);
            this.groupBox16.Controls.Add(sW_VerLabel1);
            this.groupBox16.Controls.Add(this.SYS_INFO_REMOTE_SET);
            this.groupBox16.Controls.Add(this.SYS_INFO_REMTE_GET);
            this.groupBox16.Location = new System.Drawing.Point(307, 159);
            this.groupBox16.Name = "groupBox16";
            this.groupBox16.Size = new System.Drawing.Size(244, 151);
            this.groupBox16.TabIndex = 10;
            this.groupBox16.TabStop = false;
            this.groupBox16.Text = "SYS info";
            // 
            // sW_verTextBox1
            // 
            this.sW_verTextBox1.AllowInternalTab = false;
            this.sW_verTextBox1.AutoHeight = true;
            this.sW_verTextBox1.BackColor = System.Drawing.SystemColors.Window;
            this.sW_verTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.sW_verTextBox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.sW_verTextBox1.FieldCount = 1;
            this.sW_verTextBox1.IntValue = 0;
            this.sW_verTextBox1.Location = new System.Drawing.Point(69, 71);
            this.sW_verTextBox1.Name = "sW_verTextBox1";
            this.sW_verTextBox1.ReadOnly = false;
            this.sW_verTextBox1.Size = new System.Drawing.Size(100, 20);
            this.sW_verTextBox1.TabIndex = 17;
            this.sW_verTextBox1.Text = "0x";
            // 
            // hW_verTextBox1
            // 
            this.hW_verTextBox1.AllowInternalTab = false;
            this.hW_verTextBox1.AutoHeight = true;
            this.hW_verTextBox1.BackColor = System.Drawing.SystemColors.Window;
            this.hW_verTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.hW_verTextBox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.hW_verTextBox1.FieldCount = 1;
            this.hW_verTextBox1.IntValue = 0;
            this.hW_verTextBox1.Location = new System.Drawing.Point(69, 46);
            this.hW_verTextBox1.Name = "hW_verTextBox1";
            this.hW_verTextBox1.ReadOnly = false;
            this.hW_verTextBox1.Size = new System.Drawing.Size(100, 20);
            this.hW_verTextBox1.TabIndex = 16;
            this.hW_verTextBox1.Text = "0x";
            // 
            // serNoTextBox1
            // 
            this.serNoTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sYS_INFO_REMOTEBindingSource, "SerNo", true));
            this.serNoTextBox1.Location = new System.Drawing.Point(69, 20);
            this.serNoTextBox1.Name = "serNoTextBox1";
            this.serNoTextBox1.Size = new System.Drawing.Size(100, 20);
            this.serNoTextBox1.TabIndex = 11;
            // 
            // sYS_INFO_REMOTEBindingSource
            // 
            this.sYS_INFO_REMOTEBindingSource.DataMember = "BASYS_ADDR_SYS_INFO_REMOTE";
            this.sYS_INFO_REMOTEBindingSource.DataSource = this.bASYS_ADDRBindingSource;
            // 
            // SYS_INFO_REMOTE_SET
            // 
            this.SYS_INFO_REMOTE_SET.Location = new System.Drawing.Point(111, 107);
            this.SYS_INFO_REMOTE_SET.Name = "SYS_INFO_REMOTE_SET";
            this.SYS_INFO_REMOTE_SET.Size = new System.Drawing.Size(75, 23);
            this.SYS_INFO_REMOTE_SET.TabIndex = 8;
            this.SYS_INFO_REMOTE_SET.Text = "Set";
            this.SYS_INFO_REMOTE_SET.UseVisualStyleBackColor = true;
            this.SYS_INFO_REMOTE_SET.Click += new System.EventHandler(this.SYS_INFO_REMOTE_SET_Click);
            // 
            // SYS_INFO_REMTE_GET
            // 
            this.SYS_INFO_REMTE_GET.Location = new System.Drawing.Point(18, 108);
            this.SYS_INFO_REMTE_GET.Name = "SYS_INFO_REMTE_GET";
            this.SYS_INFO_REMTE_GET.Size = new System.Drawing.Size(75, 23);
            this.SYS_INFO_REMTE_GET.TabIndex = 7;
            this.SYS_INFO_REMTE_GET.Text = "Get";
            this.SYS_INFO_REMTE_GET.UseVisualStyleBackColor = true;
            this.SYS_INFO_REMTE_GET.Click += new System.EventHandler(this.SYS_INFO_REMOTE_GET_Click);
            // 
            // groupBox12
            // 
            this.groupBox12.Controls.Add(this.buttonRemoteAppReset);
            this.groupBox12.Controls.Add(this.buttonRemoteFactoryDefaults);
            this.groupBox12.Controls.Add(this.textRemoteTestId);
            this.groupBox12.Controls.Add(this.buttonRemoteTest);
            this.groupBox12.Controls.Add(this.buttonRemoteWriteFlash);
            this.groupBox12.Controls.Add(this.buttonRemoteAppReinit);
            this.groupBox12.Controls.Add(this.buttonRemoteAppInit);
            this.groupBox12.Controls.Add(this.buttonRemoteAppStop);
            this.groupBox12.Controls.Add(this.buttonRemoteAppStart);
            this.groupBox12.Location = new System.Drawing.Point(6, 423);
            this.groupBox12.Name = "groupBox12";
            this.groupBox12.Size = new System.Drawing.Size(880, 45);
            this.groupBox12.TabIndex = 9;
            this.groupBox12.TabStop = false;
            this.groupBox12.Text = "APP control";
            // 
            // buttonRemoteAppReset
            // 
            this.buttonRemoteAppReset.Location = new System.Drawing.Point(337, 16);
            this.buttonRemoteAppReset.Name = "buttonRemoteAppReset";
            this.buttonRemoteAppReset.Size = new System.Drawing.Size(75, 23);
            this.buttonRemoteAppReset.TabIndex = 51;
            this.buttonRemoteAppReset.Text = "Reset";
            this.buttonRemoteAppReset.UseVisualStyleBackColor = true;
            this.buttonRemoteAppReset.Click += new System.EventHandler(this.buttonRemoteAppReset_Click);
            // 
            // buttonRemoteFactoryDefaults
            // 
            this.buttonRemoteFactoryDefaults.Location = new System.Drawing.Point(678, 17);
            this.buttonRemoteFactoryDefaults.Name = "buttonRemoteFactoryDefaults";
            this.buttonRemoteFactoryDefaults.Size = new System.Drawing.Size(93, 23);
            this.buttonRemoteFactoryDefaults.TabIndex = 50;
            this.buttonRemoteFactoryDefaults.Text = "Factory defaults";
            this.buttonRemoteFactoryDefaults.UseVisualStyleBackColor = true;
            this.buttonRemoteFactoryDefaults.Click += new System.EventHandler(this.buttonRemoteFactoryDefaults_Click);
            // 
            // textRemoteTestId
            // 
            this.textRemoteTestId.Location = new System.Drawing.Point(579, 19);
            this.textRemoteTestId.Name = "textRemoteTestId";
            this.textRemoteTestId.Size = new System.Drawing.Size(93, 20);
            this.textRemoteTestId.TabIndex = 49;
            // 
            // buttonRemoteTest
            // 
            this.buttonRemoteTest.Location = new System.Drawing.Point(498, 16);
            this.buttonRemoteTest.Name = "buttonRemoteTest";
            this.buttonRemoteTest.Size = new System.Drawing.Size(75, 23);
            this.buttonRemoteTest.TabIndex = 48;
            this.buttonRemoteTest.Text = "Test";
            this.buttonRemoteTest.UseVisualStyleBackColor = true;
            this.buttonRemoteTest.Click += new System.EventHandler(this.buttonRemoteTest_Click);
            // 
            // buttonRemoteWriteFlash
            // 
            this.buttonRemoteWriteFlash.Location = new System.Drawing.Point(418, 16);
            this.buttonRemoteWriteFlash.Name = "buttonRemoteWriteFlash";
            this.buttonRemoteWriteFlash.Size = new System.Drawing.Size(75, 23);
            this.buttonRemoteWriteFlash.TabIndex = 47;
            this.buttonRemoteWriteFlash.Text = "Write flash";
            this.buttonRemoteWriteFlash.UseVisualStyleBackColor = true;
            this.buttonRemoteWriteFlash.Click += new System.EventHandler(this.buttonRemoteWriteFlash_Click);
            // 
            // buttonRemoteAppReinit
            // 
            this.buttonRemoteAppReinit.Location = new System.Drawing.Point(256, 17);
            this.buttonRemoteAppReinit.Name = "buttonRemoteAppReinit";
            this.buttonRemoteAppReinit.Size = new System.Drawing.Size(75, 23);
            this.buttonRemoteAppReinit.TabIndex = 46;
            this.buttonRemoteAppReinit.Text = "App reinit";
            this.buttonRemoteAppReinit.UseVisualStyleBackColor = true;
            this.buttonRemoteAppReinit.Click += new System.EventHandler(this.buttonRemoteAppReinit_Click);
            // 
            // buttonRemoteAppInit
            // 
            this.buttonRemoteAppInit.Location = new System.Drawing.Point(175, 17);
            this.buttonRemoteAppInit.Name = "buttonRemoteAppInit";
            this.buttonRemoteAppInit.Size = new System.Drawing.Size(75, 23);
            this.buttonRemoteAppInit.TabIndex = 45;
            this.buttonRemoteAppInit.Text = "App init";
            this.buttonRemoteAppInit.UseVisualStyleBackColor = true;
            this.buttonRemoteAppInit.Click += new System.EventHandler(this.buttonRemoteAppInit_Click);
            // 
            // buttonRemoteAppStop
            // 
            this.buttonRemoteAppStop.Location = new System.Drawing.Point(90, 16);
            this.buttonRemoteAppStop.Name = "buttonRemoteAppStop";
            this.buttonRemoteAppStop.Size = new System.Drawing.Size(75, 23);
            this.buttonRemoteAppStop.TabIndex = 44;
            this.buttonRemoteAppStop.Text = "App stop";
            this.buttonRemoteAppStop.UseVisualStyleBackColor = true;
            this.buttonRemoteAppStop.Click += new System.EventHandler(this.buttonRemoteAppStop_Click);
            // 
            // buttonRemoteAppStart
            // 
            this.buttonRemoteAppStart.Location = new System.Drawing.Point(9, 16);
            this.buttonRemoteAppStart.Name = "buttonRemoteAppStart";
            this.buttonRemoteAppStart.Size = new System.Drawing.Size(75, 23);
            this.buttonRemoteAppStart.TabIndex = 43;
            this.buttonRemoteAppStart.Text = "App start";
            this.buttonRemoteAppStart.UseVisualStyleBackColor = true;
            this.buttonRemoteAppStart.Click += new System.EventHandler(this.buttonRemoteAppStart_Click);
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.BAREM_PS_SET);
            this.groupBox7.Controls.Add(this.BAREM_PS_GET);
            this.groupBox7.Controls.Add(autoPowerOff_sLabel);
            this.groupBox7.Controls.Add(this.autoPowerOff_sTextBox);
            this.groupBox7.Controls.Add(this.autoRepeat_msTextBox);
            this.groupBox7.Controls.Add(this.forceRefresh_msTextBox);
            this.groupBox7.Controls.Add(autoRepeat_msLabel);
            this.groupBox7.Controls.Add(forceRefresh_msLabel);
            this.groupBox7.Location = new System.Drawing.Point(307, 6);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(236, 137);
            this.groupBox7.TabIndex = 1;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "BAREM_PS";
            // 
            // BAREM_PS_SET
            // 
            this.BAREM_PS_SET.Location = new System.Drawing.Point(117, 94);
            this.BAREM_PS_SET.Name = "BAREM_PS_SET";
            this.BAREM_PS_SET.Size = new System.Drawing.Size(75, 23);
            this.BAREM_PS_SET.TabIndex = 15;
            this.BAREM_PS_SET.Text = "Set";
            this.BAREM_PS_SET.UseVisualStyleBackColor = true;
            this.BAREM_PS_SET.Click += new System.EventHandler(this.BAREM_PS_SET_Click);
            // 
            // BAREM_PS_GET
            // 
            this.BAREM_PS_GET.Location = new System.Drawing.Point(9, 94);
            this.BAREM_PS_GET.Name = "BAREM_PS_GET";
            this.BAREM_PS_GET.Size = new System.Drawing.Size(75, 23);
            this.BAREM_PS_GET.TabIndex = 14;
            this.BAREM_PS_GET.Text = "Get";
            this.BAREM_PS_GET.UseVisualStyleBackColor = true;
            this.BAREM_PS_GET.Click += new System.EventHandler(this.BAREM_PS_GET_Click);
            // 
            // autoPowerOff_sTextBox
            // 
            this.autoPowerOff_sTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bAREM_PSBindingSource, "AutoPowerOff_s", true));
            this.autoPowerOff_sTextBox.Location = new System.Drawing.Point(105, 17);
            this.autoPowerOff_sTextBox.Name = "autoPowerOff_sTextBox";
            this.autoPowerOff_sTextBox.Size = new System.Drawing.Size(100, 20);
            this.autoPowerOff_sTextBox.TabIndex = 9;
            // 
            // autoRepeat_msTextBox
            // 
            this.autoRepeat_msTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bAREM_PSBindingSource, "AutoRepeat_ms", true));
            this.autoRepeat_msTextBox.Location = new System.Drawing.Point(105, 43);
            this.autoRepeat_msTextBox.Name = "autoRepeat_msTextBox";
            this.autoRepeat_msTextBox.Size = new System.Drawing.Size(100, 20);
            this.autoRepeat_msTextBox.TabIndex = 11;
            // 
            // forceRefresh_msTextBox
            // 
            this.forceRefresh_msTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bAREM_PSBindingSource, "ForceRefresh_ms", true));
            this.forceRefresh_msTextBox.Location = new System.Drawing.Point(105, 69);
            this.forceRefresh_msTextBox.Name = "forceRefresh_msTextBox";
            this.forceRefresh_msTextBox.Size = new System.Drawing.Size(100, 20);
            this.forceRefresh_msTextBox.TabIndex = 13;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.BAREM_PR_SET);
            this.groupBox6.Controls.Add(this.BAREM_PR_GET);
            this.groupBox6.Controls.Add(dispModeLabel);
            this.groupBox6.Controls.Add(this.dispModeTextBox);
            this.groupBox6.Controls.Add(this.oled_BackgroundColorTextBox);
            this.groupBox6.Controls.Add(this.oled_ForegroundColorTextBox);
            this.groupBox6.Controls.Add(this.oled_ArrowColorTextBox);
            this.groupBox6.Controls.Add(this.oled_MotorOKColorTextBox);
            this.groupBox6.Controls.Add(this.oled_MotorLimitColorTextBox);
            this.groupBox6.Controls.Add(this.oled_BatColorTextBox);
            this.groupBox6.Controls.Add(this.oled_IndicatorLim1ColorTextBox);
            this.groupBox6.Controls.Add(this.oled_IndicatorLim2ColorTextBox);
            this.groupBox6.Controls.Add(this.oled_IndicatorLim3ColorTextBox);
            this.groupBox6.Controls.Add(this.oled_WeightSetColorTextBox);
            this.groupBox6.Controls.Add(this.oled_ErrorColorTextBox);
            this.groupBox6.Controls.Add(this.oled_SignOnColorTextBox);
            this.groupBox6.Controls.Add(this.oled_SignOnBackColorTextBox);
            this.groupBox6.Controls.Add(oled_BackgroundColorLabel);
            this.groupBox6.Controls.Add(oled_ForegroundColorLabel);
            this.groupBox6.Controls.Add(oled_ArrowColorLabel);
            this.groupBox6.Controls.Add(oled_MotorOKColorLabel);
            this.groupBox6.Controls.Add(oled_MotorLimitColorLabel);
            this.groupBox6.Controls.Add(oled_BatColorLabel);
            this.groupBox6.Controls.Add(oled_IndicatorLim1ColorLabel);
            this.groupBox6.Controls.Add(oled_IndicatorLim2ColorLabel);
            this.groupBox6.Controls.Add(oled_IndicatorLim3ColorLabel);
            this.groupBox6.Controls.Add(oled_WeightSetColorLabel);
            this.groupBox6.Controls.Add(oled_ErrorColorLabel);
            this.groupBox6.Controls.Add(oled_SignOnColorLabel);
            this.groupBox6.Controls.Add(oled_SignOnBackColorLabel);
            this.groupBox6.Location = new System.Drawing.Point(6, 6);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(279, 415);
            this.groupBox6.TabIndex = 0;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "BAREM_PR";
            // 
            // BAREM_PR_SET
            // 
            this.BAREM_PR_SET.Location = new System.Drawing.Point(138, 377);
            this.BAREM_PR_SET.Name = "BAREM_PR_SET";
            this.BAREM_PR_SET.Size = new System.Drawing.Size(75, 23);
            this.BAREM_PR_SET.TabIndex = 59;
            this.BAREM_PR_SET.Text = "Set";
            this.BAREM_PR_SET.UseVisualStyleBackColor = true;
            this.BAREM_PR_SET.Click += new System.EventHandler(this.BAREM_PR_SET_Click);
            // 
            // BAREM_PR_GET
            // 
            this.BAREM_PR_GET.Location = new System.Drawing.Point(9, 377);
            this.BAREM_PR_GET.Name = "BAREM_PR_GET";
            this.BAREM_PR_GET.Size = new System.Drawing.Size(75, 23);
            this.BAREM_PR_GET.TabIndex = 58;
            this.BAREM_PR_GET.Text = "Get";
            this.BAREM_PR_GET.UseVisualStyleBackColor = true;
            this.BAREM_PR_GET.Click += new System.EventHandler(this.BAREM_PR_GET_Click);
            // 
            // dispModeTextBox
            // 
            this.dispModeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bAREM_PRBindingSource, "DispMode", true));
            this.dispModeTextBox.Location = new System.Drawing.Point(138, 13);
            this.dispModeTextBox.Name = "dispModeTextBox";
            this.dispModeTextBox.Size = new System.Drawing.Size(100, 20);
            this.dispModeTextBox.TabIndex = 31;
            // 
            // oled_BackgroundColorTextBox
            // 
            this.oled_BackgroundColorTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bAREM_PRBindingSource, "oled_BackgroundColor", true));
            this.oled_BackgroundColorTextBox.Location = new System.Drawing.Point(138, 39);
            this.oled_BackgroundColorTextBox.Name = "oled_BackgroundColorTextBox";
            this.oled_BackgroundColorTextBox.Size = new System.Drawing.Size(100, 20);
            this.oled_BackgroundColorTextBox.TabIndex = 33;
            // 
            // oled_ForegroundColorTextBox
            // 
            this.oled_ForegroundColorTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bAREM_PRBindingSource, "oled_ForegroundColor", true));
            this.oled_ForegroundColorTextBox.Location = new System.Drawing.Point(138, 65);
            this.oled_ForegroundColorTextBox.Name = "oled_ForegroundColorTextBox";
            this.oled_ForegroundColorTextBox.Size = new System.Drawing.Size(100, 20);
            this.oled_ForegroundColorTextBox.TabIndex = 35;
            // 
            // oled_ArrowColorTextBox
            // 
            this.oled_ArrowColorTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bAREM_PRBindingSource, "oled_ArrowColor", true));
            this.oled_ArrowColorTextBox.Location = new System.Drawing.Point(138, 91);
            this.oled_ArrowColorTextBox.Name = "oled_ArrowColorTextBox";
            this.oled_ArrowColorTextBox.Size = new System.Drawing.Size(100, 20);
            this.oled_ArrowColorTextBox.TabIndex = 37;
            // 
            // oled_MotorOKColorTextBox
            // 
            this.oled_MotorOKColorTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bAREM_PRBindingSource, "oled_MotorOKColor", true));
            this.oled_MotorOKColorTextBox.Location = new System.Drawing.Point(138, 117);
            this.oled_MotorOKColorTextBox.Name = "oled_MotorOKColorTextBox";
            this.oled_MotorOKColorTextBox.Size = new System.Drawing.Size(100, 20);
            this.oled_MotorOKColorTextBox.TabIndex = 39;
            // 
            // oled_MotorLimitColorTextBox
            // 
            this.oled_MotorLimitColorTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bAREM_PRBindingSource, "oled_MotorLimitColor", true));
            this.oled_MotorLimitColorTextBox.Location = new System.Drawing.Point(138, 143);
            this.oled_MotorLimitColorTextBox.Name = "oled_MotorLimitColorTextBox";
            this.oled_MotorLimitColorTextBox.Size = new System.Drawing.Size(100, 20);
            this.oled_MotorLimitColorTextBox.TabIndex = 41;
            // 
            // oled_BatColorTextBox
            // 
            this.oled_BatColorTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bAREM_PRBindingSource, "oled_BatColor", true));
            this.oled_BatColorTextBox.Location = new System.Drawing.Point(138, 169);
            this.oled_BatColorTextBox.Name = "oled_BatColorTextBox";
            this.oled_BatColorTextBox.Size = new System.Drawing.Size(100, 20);
            this.oled_BatColorTextBox.TabIndex = 43;
            // 
            // oled_IndicatorLim1ColorTextBox
            // 
            this.oled_IndicatorLim1ColorTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bAREM_PRBindingSource, "oled_IndicatorLim1Color", true));
            this.oled_IndicatorLim1ColorTextBox.Location = new System.Drawing.Point(138, 195);
            this.oled_IndicatorLim1ColorTextBox.Name = "oled_IndicatorLim1ColorTextBox";
            this.oled_IndicatorLim1ColorTextBox.Size = new System.Drawing.Size(100, 20);
            this.oled_IndicatorLim1ColorTextBox.TabIndex = 45;
            // 
            // oled_IndicatorLim2ColorTextBox
            // 
            this.oled_IndicatorLim2ColorTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bAREM_PRBindingSource, "oled_IndicatorLim2Color", true));
            this.oled_IndicatorLim2ColorTextBox.Location = new System.Drawing.Point(138, 221);
            this.oled_IndicatorLim2ColorTextBox.Name = "oled_IndicatorLim2ColorTextBox";
            this.oled_IndicatorLim2ColorTextBox.Size = new System.Drawing.Size(100, 20);
            this.oled_IndicatorLim2ColorTextBox.TabIndex = 47;
            // 
            // oled_IndicatorLim3ColorTextBox
            // 
            this.oled_IndicatorLim3ColorTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bAREM_PRBindingSource, "oled_IndicatorLim3Color", true));
            this.oled_IndicatorLim3ColorTextBox.Location = new System.Drawing.Point(138, 247);
            this.oled_IndicatorLim3ColorTextBox.Name = "oled_IndicatorLim3ColorTextBox";
            this.oled_IndicatorLim3ColorTextBox.Size = new System.Drawing.Size(100, 20);
            this.oled_IndicatorLim3ColorTextBox.TabIndex = 49;
            // 
            // oled_WeightSetColorTextBox
            // 
            this.oled_WeightSetColorTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bAREM_PRBindingSource, "oled_WeightSetColor", true));
            this.oled_WeightSetColorTextBox.Location = new System.Drawing.Point(138, 273);
            this.oled_WeightSetColorTextBox.Name = "oled_WeightSetColorTextBox";
            this.oled_WeightSetColorTextBox.Size = new System.Drawing.Size(100, 20);
            this.oled_WeightSetColorTextBox.TabIndex = 51;
            // 
            // oled_ErrorColorTextBox
            // 
            this.oled_ErrorColorTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bAREM_PRBindingSource, "oled_ErrorColor", true));
            this.oled_ErrorColorTextBox.Location = new System.Drawing.Point(138, 299);
            this.oled_ErrorColorTextBox.Name = "oled_ErrorColorTextBox";
            this.oled_ErrorColorTextBox.Size = new System.Drawing.Size(100, 20);
            this.oled_ErrorColorTextBox.TabIndex = 53;
            // 
            // oled_SignOnColorTextBox
            // 
            this.oled_SignOnColorTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bAREM_PRBindingSource, "oled_SignOnColor", true));
            this.oled_SignOnColorTextBox.Location = new System.Drawing.Point(138, 325);
            this.oled_SignOnColorTextBox.Name = "oled_SignOnColorTextBox";
            this.oled_SignOnColorTextBox.Size = new System.Drawing.Size(100, 20);
            this.oled_SignOnColorTextBox.TabIndex = 55;
            // 
            // oled_SignOnBackColorTextBox
            // 
            this.oled_SignOnBackColorTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bAREM_PRBindingSource, "oled_SignOnBackColor", true));
            this.oled_SignOnBackColorTextBox.Location = new System.Drawing.Point(138, 348);
            this.oled_SignOnBackColorTextBox.Name = "oled_SignOnBackColorTextBox";
            this.oled_SignOnBackColorTextBox.Size = new System.Drawing.Size(100, 20);
            this.oled_SignOnBackColorTextBox.TabIndex = 57;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1018, 24);
            this.menuStrip1.TabIndex = 32;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(92, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // bastetParametersDataSet1
            // 
            this.bastetParametersDataSet1.DataSetName = "BastetParametersDataSet";
            this.bastetParametersDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bindingSource1
            // 
            this.bindingSource1.DataMember = "BASYS_ADDR";
            this.bindingSource1.DataSource = this.bastetParametersDataSet1;
            // 
            // tableAdapterManager1
            // 
            this.tableAdapterManager1.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager1.BAFS_PRTableAdapter = this.bafS_PRTableAdapter1;
            this.tableAdapterManager1.BAFS_PSTableAdapter = this.bafS_PSTableAdapter1;
            this.tableAdapterManager1.BAMOT_PRTableAdapter = this.bamoT_PRTableAdapter1;
            this.tableAdapterManager1.BAMOT_PSTableAdapter = this.bamoT_PSTableAdapter1;
            this.tableAdapterManager1.BAREM_PRTableAdapter = this.bareM_PRTableAdapter1;
            this.tableAdapterManager1.BAREM_PSTableAdapter = this.bareM_PSTableAdapter1;
            this.tableAdapterManager1.BASYS_ADDRTableAdapter = this.basyS_ADDRTableAdapter1;
            this.tableAdapterManager1.BASYS_STableAdapter = this.basyS_STableAdapter1;
            this.tableAdapterManager1.UpdateOrder = TROL_MgmtGui2.BastetParametersDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager1.ZSMI31014_EETableAdapter = this.zsmI31014_EETableAdapter1;
            // 
            // bafS_PRTableAdapter1
            // 
            this.bafS_PRTableAdapter1.ClearBeforeFill = true;
            // 
            // bafS_PSTableAdapter1
            // 
            this.bafS_PSTableAdapter1.ClearBeforeFill = true;
            // 
            // bamoT_PRTableAdapter1
            // 
            this.bamoT_PRTableAdapter1.ClearBeforeFill = true;
            // 
            // bamoT_PSTableAdapter1
            // 
            this.bamoT_PSTableAdapter1.ClearBeforeFill = true;
            // 
            // bareM_PRTableAdapter1
            // 
            this.bareM_PRTableAdapter1.ClearBeforeFill = true;
            // 
            // bareM_PSTableAdapter1
            // 
            this.bareM_PSTableAdapter1.ClearBeforeFill = true;
            // 
            // basyS_ADDRTableAdapter1
            // 
            this.basyS_ADDRTableAdapter1.ClearBeforeFill = true;
            // 
            // basyS_STableAdapter1
            // 
            this.basyS_STableAdapter1.ClearBeforeFill = true;
            // 
            // zsmI31014_EETableAdapter1
            // 
            this.zsmI31014_EETableAdapter1.ClearBeforeFill = true;
            // 
            // deviceBindingSource
            // 
            this.deviceBindingSource.DataMember = "Device";
            this.deviceBindingSource.DataSource = this.devices;
            // 
            // deviceListBox
            // 
            this.deviceListBox.DataSource = this.deviceBindingSource;
            this.deviceListBox.DisplayMember = "DeviceAddress";
            this.deviceListBox.FormattingEnabled = true;
            this.deviceListBox.Location = new System.Drawing.Point(6, 19);
            this.deviceListBox.Name = "deviceListBox";
            this.deviceListBox.Size = new System.Drawing.Size(187, 108);
            this.deviceListBox.TabIndex = 32;
            this.deviceListBox.ValueMember = "DeviceAddress";
            this.deviceListBox.Format += new System.Windows.Forms.ListControlConvertEventHandler(this.deviceListBox_Format);
            // 
            // buttonRescan
            // 
            this.buttonRescan.Location = new System.Drawing.Point(6, 133);
            this.buttonRescan.Name = "buttonRescan";
            this.buttonRescan.Size = new System.Drawing.Size(80, 23);
            this.buttonRescan.TabIndex = 34;
            this.buttonRescan.Text = "Rescan";
            this.buttonRescan.UseVisualStyleBackColor = true;
            this.buttonRescan.Click += new System.EventHandler(this.buttonRescan_Click);
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(110, 133);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(83, 23);
            this.AddButton.TabIndex = 35;
            this.AddButton.Text = "Add";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.Add_Click);
            // 
            // WeightUpdateTimer
            // 
            this.WeightUpdateTimer.Interval = 700;
            this.WeightUpdateTimer.Tick += new System.EventHandler(this.WeightUpdateTimer_Tick);
            // 
            // groupBox9
            // 
            this.groupBox9.BackColor = System.Drawing.SystemColors.Window;
            this.groupBox9.Controls.Add(this.deviceListBox);
            this.groupBox9.Controls.Add(this.AddButton);
            this.groupBox9.Controls.Add(this.buttonRescan);
            this.groupBox9.Location = new System.Drawing.Point(469, 57);
            this.groupBox9.Name = "groupBox9";
            this.groupBox9.Size = new System.Drawing.Size(201, 158);
            this.groupBox9.TabIndex = 36;
            this.groupBox9.TabStop = false;
            this.groupBox9.Text = "Active devices";
            // 
            // groupBox13
            // 
            this.groupBox13.BackColor = System.Drawing.SystemColors.Window;
            this.groupBox13.Controls.Add(this.remoteView1);
            this.groupBox13.Location = new System.Drawing.Point(690, 57);
            this.groupBox13.Name = "groupBox13";
            this.groupBox13.Size = new System.Drawing.Size(157, 158);
            this.groupBox13.TabIndex = 37;
            this.groupBox13.TabStop = false;
            this.groupBox13.Text = "Remote view";
            // 
            // remoteView1
            // 
            this.remoteView1.chair_status = ((ushort)(0));
            this.remoteView1.DataBindings.Add(new System.Windows.Forms.Binding("chair_status", this.bASYS_SBindingSource, "chair_status", true, System.Windows.Forms.DataSourceUpdateMode.Never));
            this.remoteView1.DataBindings.Add(new System.Windows.Forms.Binding("sys_status", this.bASYS_SBindingSource, "sys_status", true, System.Windows.Forms.DataSourceUpdateMode.Never));
            this.remoteView1.Location = new System.Drawing.Point(0, 12);
            this.remoteView1.Name = "remoteView1";
            this.remoteView1.Size = new System.Drawing.Size(157, 146);
            this.remoteView1.sys_status = ((ushort)(0));
            this.remoteView1.TabIndex = 0;
            this.remoteView1.weight = 0;
            // 
            // buttonMotorStop
            // 
            this.buttonMotorStop.Location = new System.Drawing.Point(18, 102);
            this.buttonMotorStop.Name = "buttonMotorStop";
            this.buttonMotorStop.Size = new System.Drawing.Size(75, 23);
            this.buttonMotorStop.TabIndex = 43;
            this.buttonMotorStop.Text = "Motor stop";
            this.buttonMotorStop.UseVisualStyleBackColor = true;
            this.buttonMotorStop.Click += new System.EventHandler(this.buttonMotorStop_Click);
            // 
            // buttonMotorDown
            // 
            this.buttonMotorDown.Location = new System.Drawing.Point(18, 73);
            this.buttonMotorDown.Name = "buttonMotorDown";
            this.buttonMotorDown.Size = new System.Drawing.Size(75, 23);
            this.buttonMotorDown.TabIndex = 42;
            this.buttonMotorDown.Text = "Motor down";
            this.buttonMotorDown.UseVisualStyleBackColor = true;
            this.buttonMotorDown.Click += new System.EventHandler(this.buttonMotorDown_Click);
            // 
            // buttonMotorUp
            // 
            this.buttonMotorUp.Location = new System.Drawing.Point(18, 46);
            this.buttonMotorUp.Name = "buttonMotorUp";
            this.buttonMotorUp.Size = new System.Drawing.Size(75, 23);
            this.buttonMotorUp.TabIndex = 41;
            this.buttonMotorUp.Text = "Motor up";
            this.buttonMotorUp.UseVisualStyleBackColor = true;
            this.buttonMotorUp.Click += new System.EventHandler(this.buttonMotorUp_Click);
            // 
            // groupBox14
            // 
            this.groupBox14.BackColor = System.Drawing.SystemColors.Window;
            this.groupBox14.Controls.Add(this.buttonMotorUp);
            this.groupBox14.Controls.Add(this.buttonMotorStop);
            this.groupBox14.Controls.Add(this.buttonMotorDown);
            this.groupBox14.Location = new System.Drawing.Point(886, 57);
            this.groupBox14.Name = "groupBox14";
            this.groupBox14.Size = new System.Drawing.Size(120, 158);
            this.groupBox14.TabIndex = 44;
            this.groupBox14.TabStop = false;
            this.groupBox14.Text = "Motor control";
            // 
            // MotorUpdateTimer
            // 
            this.MotorUpdateTimer.Interval = 150;
            this.MotorUpdateTimer.Tick += new System.EventHandler(this.MotorUpdateTimer_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1018, 730);
            this.Controls.Add(this.groupBox14);
            this.Controls.Add(this.groupBox13);
            this.Controls.Add(this.groupBox9);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.bASYS_ADDRDataGridView);
            this.Controls.Add(this.bASYS_ADDRBindingNavigator);
            this.Controls.Add(this.menuStrip1);
            this.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bAFS_PRBindingSource, "@ZapNo", true));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.devices)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bASYS_ADDRBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bASYS_ADDRBindingNavigator)).EndInit();
            this.bASYS_ADDRBindingNavigator.ResumeLayout(false);
            this.bASYS_ADDRBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bASYS_ADDRDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bAFS_PRBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bAFS_PSBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bAMOT_PRBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bAMOT_PSBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bAREM_PRBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bAREM_PSBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bASYS_SBindingSource)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage5.ResumeLayout(false);
            this.groupBox15.ResumeLayout(false);
            this.groupBox15.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sYS_INFO_CHAIRBindingSource)).EndInit();
            this.groupBox11.ResumeLayout(false);
            this.groupBox10.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.zSMI31014_EEBindingSource)).EndInit();
            this.groupBox8.ResumeLayout(false);
            this.groupBox8.PerformLayout();
            this.BASYS_ADDR.ResumeLayout(false);
            this.BASYS_ADDR.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPage9.ResumeLayout(false);
            this.groupBox16.ResumeLayout(false);
            this.groupBox16.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sYS_INFO_REMOTEBindingSource)).EndInit();
            this.groupBox12.ResumeLayout(false);
            this.groupBox12.PerformLayout();
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bastetParametersDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deviceBindingSource)).EndInit();
            this.groupBox9.ResumeLayout(false);
            this.groupBox13.ResumeLayout(false);
            this.groupBox14.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private BastetParametersDataSetTableAdapters.BAFS_PRTableAdapter bAFS_PRTableAdapter;
        private Devices devices;
        private System.Windows.Forms.BindingSource bASYS_ADDRBindingSource;
        private System.Windows.Forms.BindingNavigator bASYS_ADDRBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton bASYS_ADDRBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView bASYS_ADDRDataGridView;
        private System.Windows.Forms.BindingSource bAFS_PRBindingSource;
        private System.Windows.Forms.BindingSource bAFS_PSBindingSource;
        private System.Windows.Forms.BindingSource bAMOT_PRBindingSource;
        private System.Windows.Forms.BindingSource bAMOT_PSBindingSource;
        private System.Windows.Forms.BindingSource bAREM_PRBindingSource;
        private System.Windows.Forms.BindingSource bAREM_PSBindingSource;
        private System.Windows.Forms.TextBox measureFSMTickTextBox;
        private System.Windows.Forms.BindingSource bASYS_SBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn @ZapNo;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox motorStartupTimeout_msTextBox;
        private System.Windows.Forms.TextBox motorStartupPWMTextBox;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox zmd_Cust_ID2TextBox;
        private System.Windows.Forms.TextBox zmd_CustI_D1TextBox;
        private System.Windows.Forms.TextBox weightMinWeightLimitTextBox;
        private System.Windows.Forms.TextBox zmd_CustI_D0TextBox;
        private System.Windows.Forms.TextBox weightMaxAlarmLimitTextBox;
        private System.Windows.Forms.TextBox zmd_Gain_BTextBox;
        private System.Windows.Forms.TextBox weightDeltaSetTextBox;
        private System.Windows.Forms.TextBox zmd_Offset_BTextBox;
        private System.Windows.Forms.TextBox weightDeltaAlarm1TextBox;
        private System.Windows.Forms.TextBox weightWorkFiltLenTextBox;
        private System.Windows.Forms.TextBox weightDeltaAlarm2TextBox;
        private System.Windows.Forms.TextBox weightSetpointFiltLenTextBox;
        private System.Windows.Forms.TextBox weightDeltaAlarm3TextBox;
        private System.Windows.Forms.TabPage tabPage9;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox motorFSMTick_usTextBox;
        private System.Windows.Forms.TextBox currLimitFilterLen_msTextBox;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.TextBox dispModeTextBox;
        private System.Windows.Forms.TextBox oled_BackgroundColorTextBox;
        private System.Windows.Forms.TextBox oled_ForegroundColorTextBox;
        private System.Windows.Forms.TextBox oled_ArrowColorTextBox;
        private System.Windows.Forms.TextBox oled_MotorOKColorTextBox;
        private System.Windows.Forms.TextBox oled_MotorLimitColorTextBox;
        private System.Windows.Forms.TextBox oled_BatColorTextBox;
        private System.Windows.Forms.TextBox oled_IndicatorLim1ColorTextBox;
        private System.Windows.Forms.TextBox oled_IndicatorLim2ColorTextBox;
        private System.Windows.Forms.TextBox oled_IndicatorLim3ColorTextBox;
        private System.Windows.Forms.TextBox oled_WeightSetColorTextBox;
        private System.Windows.Forms.TextBox oled_ErrorColorTextBox;
        private System.Windows.Forms.TextBox oled_SignOnColorTextBox;
        private System.Windows.Forms.TextBox oled_SignOnBackColorTextBox;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.TextBox autoPowerOff_sTextBox;
        private System.Windows.Forms.TextBox autoRepeat_msTextBox;
        private System.Windows.Forms.TextBox forceRefresh_msTextBox;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private BastetParametersDataSet bastetParametersDataSet1;
        private System.Windows.Forms.BindingSource bindingSource1;
        private BastetParametersDataSetTableAdapters.TableAdapterManager tableAdapterManager1;
        private BastetParametersDataSetTableAdapters.BAFS_PRTableAdapter bafS_PRTableAdapter1;
        private BastetParametersDataSetTableAdapters.BAFS_PSTableAdapter bafS_PSTableAdapter1;
        private BastetParametersDataSetTableAdapters.BAMOT_PRTableAdapter bamoT_PRTableAdapter1;
        private BastetParametersDataSetTableAdapters.BAMOT_PSTableAdapter bamoT_PSTableAdapter1;
        private BastetParametersDataSetTableAdapters.BAREM_PRTableAdapter bareM_PRTableAdapter1;
        private BastetParametersDataSetTableAdapters.BAREM_PSTableAdapter bareM_PSTableAdapter1;
        private BastetParametersDataSetTableAdapters.BASYS_ADDRTableAdapter basyS_ADDRTableAdapter1;
        private BastetParametersDataSetTableAdapters.BASYS_STableAdapter basyS_STableAdapter1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripComboBox SaveID;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.BindingSource deviceBindingSource;
        private System.Windows.Forms.ListBox deviceListBox;
        private System.Windows.Forms.Button buttonRescan;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDChair;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDRemote;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.GroupBox BASYS_ADDR;
        private System.Windows.Forms.Button BAFS_PR_Get;
        private System.Windows.Forms.Button BAFS_PR_Set;
        private System.Windows.Forms.Button BAFS_PS_Set;
        private System.Windows.Forms.Button BAFS_PS_GET;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.Label Weight;
        private System.Windows.Forms.Label sWeight;
        private System.Windows.Forms.TextBox CurrentWeightBox;
        private System.Windows.Forms.Button GetWeightButton;
        private System.Windows.Forms.Button BAMOT_PR_SET;
        private System.Windows.Forms.Button BAMOT_PR_GET;
        private System.Windows.Forms.Button BAMOT_PS_Get;
        private System.Windows.Forms.Button BAMOT_PS_Set;
        private System.Windows.Forms.Button BASYS_S_GET;
        private System.Windows.Forms.Button BASYS_S_SET;
        private System.Windows.Forms.Button BASYS_ADDR_GET;
        private System.Windows.Forms.Button BASYS_ADDR_SET;
        private System.Windows.Forms.Button BAREM_PR_GET;
        private System.Windows.Forms.Button BAREM_PR_SET;
        private System.Windows.Forms.Button BAREM_PS_GET;
        private System.Windows.Forms.Button BAREM_PS_SET;
        private System.Windows.Forms.TextBox forceTextBox;
        private System.Windows.Forms.GroupBox groupBox10;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox cust_ID0TextBox;
        private System.Windows.Forms.BindingSource zSMI31014_EEBindingSource;
        private System.Windows.Forms.TextBox zMD_Config_1TextBox;
        private System.Windows.Forms.TextBox zMD_Config_2TextBox;
        private System.Windows.Forms.TextBox offset_BTextBox;
        private System.Windows.Forms.TextBox gain_BTextBox;
        private System.Windows.Forms.TextBox tcgTextBox;
        private System.Windows.Forms.TextBox tcoTextBox;
        private System.Windows.Forms.TextBox sOT_tcoTextBox;
        private System.Windows.Forms.TextBox sOT_tcgTextBox;
        private System.Windows.Forms.TextBox sOT_bridgeTextBox;
        private System.Windows.Forms.TextBox offset_TTextBox;
        private System.Windows.Forms.TextBox gain_TTextBox;
        private System.Windows.Forms.TextBox sOT_TTextBox;
        private System.Windows.Forms.TextBox t_SETLTextBox;
        private System.Windows.Forms.TextBox cust_ID1TextBox;
        private System.Windows.Forms.TextBox b_ConfigTextBox;
        private System.Windows.Forms.TextBox t_ConfigTextBox;
        private System.Windows.Forms.TextBox osc_TrimTextBox;
        private System.Windows.Forms.TextBox signatureTextBox;
        private System.Windows.Forms.TextBox cust_ID2TextBox;
        private System.Windows.Forms.GroupBox groupBox11;
        private System.Windows.Forms.Button buttonChairAppReinit;
        private System.Windows.Forms.Button buttonChairAppInit;
        private System.Windows.Forms.Button buttonChairAppStop;
        private System.Windows.Forms.Button buttonChairAppStart;
        private System.Windows.Forms.Button ZSMI31014_EE_GET;
        private System.Windows.Forms.Button ZSMI31014_EE_SET;
        private System.Windows.Forms.CheckBox checkBoxWeightAutoUpdate;
        private System.Windows.Forms.Timer WeightUpdateTimer;
        private BastetParametersDataSetTableAdapters.ZSMI31014_EETableAdapter zsmI31014_EETableAdapter1;
        private System.Windows.Forms.Button buttonAppWriteFlash;
        private System.Windows.Forms.GroupBox groupBox9;
        private System.Windows.Forms.GroupBox groupBox13;
        private RemoteView remoteView1;
        private System.Windows.Forms.Button buttonMotorStop;
        private System.Windows.Forms.Button buttonMotorDown;
        private System.Windows.Forms.Button buttonMotorUp;
        private System.Windows.Forms.GroupBox groupBox14;
        private System.Windows.Forms.Button buttonTestChair;
        private System.Windows.Forms.Button buttonChairFactoryDefaults;
        private System.Windows.Forms.GroupBox groupBox12;
        private System.Windows.Forms.Button buttonRemoteFactoryDefaults;
        private System.Windows.Forms.TextBox textRemoteTestId;
        private System.Windows.Forms.Button buttonRemoteTest;
        private System.Windows.Forms.Button buttonRemoteWriteFlash;
        private System.Windows.Forms.Button buttonRemoteAppReinit;
        private System.Windows.Forms.Button buttonRemoteAppInit;
        private System.Windows.Forms.Button buttonRemoteAppStop;
        private System.Windows.Forms.Button buttonRemoteAppStart;
        private HexControl textChairTestId;
        private System.Windows.Forms.TextBox textBox1;
        private HexControl sysStatusTextBox;
        private HexControl chairStatusTextBox;
        private HexControl weightStatusTextBox;
        private System.Windows.Forms.GroupBox groupBox15;
        private System.Windows.Forms.Button SYS_INFO_SET;
        private System.Windows.Forms.Button SYS_INFO_GET;
        private System.Windows.Forms.GroupBox groupBox16;
        private System.Windows.Forms.Button SYS_INFO_REMOTE_SET;
        private System.Windows.Forms.Button SYS_INFO_REMTE_GET;
        private System.Windows.Forms.TextBox serNoTextBox;
        private System.Windows.Forms.BindingSource sYS_INFO_CHAIRBindingSource;
        private System.Windows.Forms.TextBox serNoTextBox1;
        private System.Windows.Forms.BindingSource sYS_INFO_REMOTEBindingSource;
        private HexControl sW_verTextBox1;
        private HexControl hW_verTextBox1;
        private MacControl remote_addrTextBox;
        private MacControl chair_addrTextBox;
        private VersionControl versionControl2;
        private VersionControl versionControl1;
        private System.Windows.Forms.Timer MotorUpdateTimer;
        private System.Windows.Forms.Button buttonChairReset;
        private System.Windows.Forms.Button buttonRemoteAppReset;
    }
}

