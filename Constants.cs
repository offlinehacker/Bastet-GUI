using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TROL_MgmtGui2
{
    class Constants
    {
        public static int AdministrationAddress = 0xFF;
    }

    public enum MgmtCmd : byte
    {
        MGMT_ACK = 0x01,
        MGMT_GET_PEERS = 0x02,
        MGMT_DELETE_PEER = 0x03,
        MGMT_NEW_PEER = 0x04,
        MGMT_GET_DEVICE_TYPE = 0x11,

        MGMT_GET_CHAIR_ADDR = 0x12,//Deprecated operation
        MGMT_GET_REMOTE_ADDR = 0x13,//Deprecated operation
        MGMT_SET_CHAIR_ADDR = 0x14,//Deprecated operation
        MGMT_SET_REMOTE_ADDR = 0x15,//Deprecated operation

        MGMT_SAVE_CONFIG = 0x16,

        MGMT_GET_WEIGHT = 0x41,
        MGMT_MOTOR_UP = 0x42,
        MGMT_MOTOR_DN = 0x43,
        MGMT_MOTOR_STOP = 0x44,

        MGMT_SET_WEIGHT_CAL = 0x45,//Deprecated operation
        MGMT_GET_WEIGHT_CAL = 0x46,//Deprecated operation
        MGMT_ZMD31014_SET_CUSTID = 0x47,//Deprecated operation
        MGMT_ZMD31014_GET_CUSTID = 0x48,//Deprecated operation
        MGMT_ZMD31014_GOTONOM = 0x49,//Deprecated operation

        // xxx_R - read parameter block. Looking from Mgmt(PC) side 
        // Device (chair, remote) writes data for this command
        // Opposite is true for xxx_W
        MGMT_T_BAMOT_PS_R = 0x50,
        MGMT_T_BAMOT_PS_W = 0x51,
        MGMT_T_BAMOT_PR_R = 0x52,
        MGMT_T_BAMOT_PR_W = 0x53,

        MGMT_T_BASYS_ADDR_R = 0x54,
        MGMT_T_BASYS_ADDR_W = 0x55,

        MGMT_T_BAFS_PS_R = 0x56,
        MGMT_T_BAFS_PS_W = 0x57,
        MGMT_T_BAFS_PR_R = 0x58,
        MGMT_T_BAFS_PR_W = 0x59,

        MGMT_T_BAREM_PS_R = 0x5a,
        MGMT_T_BAREM_PS_W = 0x5b,
        MGMT_T_BAREM_PR_R = 0x5c,
        MGMT_T_BAREM_PR_W = 0x5d,

        MGMT_T_ZSMI31014_EE_R = 0x5e,
        MGMT_T_ZSMI31014_EE_W = 0x5f,

        MGMT_BASYS_S_R = 0x60, // read system info flags (also communication status)
        MGMT_BASYS_S_W = 0x61,

        MGMT_T_SYS_INFO_R = 0x62,
        MGMT_T_SYS_INFO_W = 0x63,

        // commands
        MGMT_SYS_RESET = 0x70,
        MGMT_APP_STOP = 0x71,
        MGMT_APP_START = 0x72,
        MGMT_APP_INIT = 0x73,
        MGMT_APP_REINIT = 0x74,
        MGMT_APP_TEST = 0x75,
        MGMT_SYS_SET_FACTORY_DEFAULT = 0x76
    }

    public enum DeviceType : byte
    {
        Chair = 0x80,
        Remote = 0x40,
        Managment= 0xC0,
        Unknown
    }

    public enum RemoteViewBits : ushort
    {
        STATUS_MOTOR_DIR_UP_BIT = 0x0001,
        STATUS_MOTOR_DIR_DN_BIT = 0x0002,
        STATUS_MOTOR_LIM_UP_BIT = 0x0004,
        STATUS_MOTOR_LIM_DN_BIT = 0x0008,
        STATUS_LOCAL_BIT = 0x0010,
        STATUS_230V_OK_BIT = 0x0020,
        STATUS_ACCU_BIT = 0x0040,
        STATUS_MOTOR_TEMP_BIT = 0x0080,

        STATUS_GENETAL_ERROR_BIT = 0x0100,
        STATUS_WEIGHT_SET_BIT = 0x0200,
        STATUS_WEIGHT_HI1_BIT = 0x0400,
        STATUS_WEIGHT_HI2_BIT = 0x0800,
        STATUS_WEIGHT_HI3_BIT = 0x1000,
        STATUS_WEIGHT_LO1_BIT = 0x2000,
        STATUS_WEIGHT_LO2_BIT = 0x4000,
        STATUS_WEIGHT_LO3_BIT = 0x8000
    }
}
