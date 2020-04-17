using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace OperatingElectronicTags
{
    class Dapapi
    {
        [StructLayout(LayoutKind.Sequential, Pack = 0, Size = 258)]
        public struct Tccb
        {
            public short len;
            public byte msgtype;
            public byte dstnote;
            public byte srcnote;
            public byte cmdtype;
            public byte sumcmd;
            public byte subnode;
            public byte[] data;
        }

        [DllImport("ProTCPUDP.dll", CallingConvention = CallingConvention.StdCall)]
        public static extern int INITClient(StringBuilder ip, int port);

        [DllImport("ProTCPUDP.dll")]
        public static extern int DiscnnSrv(StringBuilder ip, int port);

        [DllImport("Dapapi.dll")]
        public static extern int AB_API_Open();


        //intial gateway
        //[DllImport("Dapapi.dll")]
        //public static extern short AB_API_Open();

        [DllImport("Dapapi.dll")]
        public static extern int AB_API_Close();

        [DllImport("Dapapi.dll")]
        public static extern int AB_GW_Open(int Gateway_ID);

        [DllImport("Dapapi.dll")]
        public static extern int AB_GW_Close(int Gateway_ID);

        [DllImport("Dapapi.dll")]
        public static extern int AB_GW_Cnt();

        [DllImport("Dapapi.dll")]
        public static extern int AB_GW_Conf(int Ndx, int Gateway_ID, Byte Ip, int Port);

        [DllImport("Dapapi.dll")]
        public static extern int AB_GW_Ndx2ID(int Ndx);

        [DllImport("Dapapi.dll")]
        public static extern int AB_GW_ID2Ndx(int Gateway_ID);

        [DllImport("Dapapi.dll")]
        public static extern int AB_GW_InsConf(int Gateway_ID, Byte Ip, int Port);

        [DllImport("Dapapi.dll")]
        public static extern int AB_GW_UpdConf(int Gateway_ID, Byte Ip, int Port);

        [DllImport("Dapapi.dll")]
        public static extern int AB_GW_DelConf(int Gateway_ID);

        //Get Gateway Status
        [DllImport("Dapapi.dll")]
        public static extern int AB_GW_Status(int Gateway_ID);
        [DllImport("Dapapi.dll")]
        public static extern int AB_GW_AllStatus(ref Byte Status);
        [DllImport("Dapapi.dll")]
        public static extern int AB_GW_TagDiag(int ateway_ID, int Port_ID);

        // Get/Send message from/to Gateway
        [DllImport("Dapapi.dll")]
        public static extern int AB_GW_RcvMsg(int Gateway_ID, byte[] cdata);

        [DllImport("Dapapi.dll")]
        public static extern int AB_Tag_RcvUIDMsg(ref int Gateway_ID, ref int Node_addr, ref short SubCmd, ref short msg_type, ref int Buf_index, ref int Arrow_Index, byte[] data, byte[] UID, ref int Data_Cnt);

        [DllImport("Dapapi.dll")]
        public static extern int AB_GW_SndMsg(int Gateway_ID, StringBuilder Data);
        [DllImport("Dapapi.dll")]
        public static extern int AB_GW_RcvReady(int Gateway_ID);
        [DllImport("Dapapi.dll")]
        public static extern int AB_GW_RcvButton(byte[] Data, ref int Data_Cnt);
        [DllImport("Dapapi.dll")]
        public static extern int AB_GW_SetPollRang(int Gateway_ID, short Node_Range);

        //Send Message to picking tag
        [DllImport("Dapapi.dll")]
        public static extern int AB_Tag_RcvMsg(ref int Gateway_ID, ref int Node_Addr, ref short Subcmd, ref short Msg_Type, byte[] Data, ref short Data_Cnt);
        [DllImport("Dapapi.dll")]
        public static extern int AB_Tag_ChgAddr(int Gateway_ID, int Node_Addr, short New_Tag);
        [DllImport("Dapapi.dll")]
        public static extern int AB_BUZ_On(int Gateway_ID, int Node_Addr, Byte Buzzer_Type);
        [DllImport("Dapapi.dll")]
        public static extern int AB_LB_DspNum(int Gateway_ID, int Node_Addr, int Dsp_Int, Byte Dot, short Interval);
        [DllImport("Dapapi.dll")]
        public static extern int AB_LB_DspStr(int Gateway_ID, int Node_Addr, String Dsp_Str, Byte Dot, short Interval);
        [DllImport("Dapapi.dll")]
        public static extern int AB_LB_SetMode(int Gateway_ID, int Node_Addr, Byte Pick_Mode);
        [DllImport("Dapapi.dll")]
        public static extern int AB_LB_Simulate(int Gateway_ID, int Node_Addr, Byte Simulate_Mode);
        [DllImport("Dapapi.dll")]
        public static extern int AB_LB_SetLock(int Gateway_ID, int Node_Addr, Byte Lock_State, Byte Lock_Key);
        [DllImport("Dapapi.dll")]
        public static extern int AB_All_Simple(int Gateway_ID, Byte Lamp_STA, Byte Gw_Port);
        [DllImport("Dapapi.dll")]
        public static extern int AB_LB_DspAddr(int Gateway_ID, int Node_Addr);
        [DllImport("Dapapi.dll")]
        public static extern int AB_TAG_Reset(int Gateway_ID, int Node_Addr);
        [DllImport("Dapapi.dll")]
        public static extern int AB_TAG_mode(int Gateway_ID, int Node_Addr, short Save_Mode, Byte Mode_Type);
        [DllImport("Dapapi.dll")]
        public static extern int AB_TAG_CountDigit(int Gateway_ID, int Node_Addr, short CountDigit);
        [DllImport("Dapapi.dll")]
        public static extern int AB_LED_Dsp(int Gateway_ID, int Node_Addr, Byte Lamp_STA, Byte Interval);
        [DllImport("Dapapi.dll")]
        public static extern int AB_LED_Status(int Gateway_ID, int Node_Addr, Byte Lamp_Color, Byte Lamp_STA);
        [DllImport("Dapapi.dll")]
        public static extern int AB_TAG_Complete(int Gateway_ID, int Node_Addr, Byte Complete_STA);
        [DllImport("Dapapi.dll")]
        public static extern int AB_TAG_ButtonDelay(int Gateway_ID, int Node_Addr, Byte Delay_Time);

        [DllImport("Dapapi.dll")]
        public static extern int AB_TAG_CycleEdit(int Gateway_ID, int Node_Addr, Byte On_Off);



        // 12-digits A;phanumerical display
        [DllImport("Dapapi.dll")]
        public static extern int AB_AHA_DspStr(int Gateway_ID, int Node_Addr, String Disp_Str, Byte BeConfirm, Byte DigitSta);
        [DllImport("Dapapi.dll")]
        public static extern int AB_LBC_DspStr(int Gateway_ID, int Node_Addr, String Disp_Str, int INTERVAL);
        [DllImport("Dapapi.dll")]
        public static extern int AB_TAG_DspMsgBulk(int Gateway_ID, int Node_Addr, String Disp_Str, int nFollow);
        [DllImport("Dapapi.dll")]
        public static extern int AB_AHA_ClrDsp(int Gateway_ID, int Node_Addr);
        [DllImport("Dapapi.dll")]
        public static extern int AB_AHA_ReDsp(int Gateway_ID, int Node_Addr);
        [DllImport("Dapapi.dll")]
        public static extern int AB_AHA_LED_Dsp(int Gateway_ID, int Node_Addr, Byte Lamp_Type, Byte Lamp_STA);
        [DllImport("Dapapi.dll")]
        public static extern int AB_AHA_BUZ_On(int Gateway_ID, int Node_Addr, short Buzzer_Type);

        // 3-digit directional and 2-digit vertical & directional pick  tag(AT503A&AT502V) 
        [DllImport("Dapapi.dll")]
        public static extern int AB_AV_LB_DspNum(int Gateway_ID, int Node_Addr, int Disp_Data, Byte Arrow, Byte Dot, short Interval);

        // 6-digit,3 separated windows pick tag(AT506-3W-123)
        [DllImport("Dapapi.dll")]
        public static extern int AB_3W_LB_DspNum(int Gateway_ID, int Node_Addr, String Row, String Col, int Disp_INT, Byte Dot, int Interval);

        // Melody completion indicator (AT510M)
        [DllImport("Dapapi.dll")]
        public static extern int AB_Melody_On(int Gateway_ID, int Node_Addr, Byte Song, Byte Buzzer_Type);
        [DllImport("Dapapi.dll")]
        public static extern int AB_Melody_Volume(int Gateway_ID, int Node_Addr, Byte Volume);

        // Cable-less picking tag set up node address automatically.
        [DllImport("Dapapi.dll")]
        public static extern int AB_CLTAG_DspAddr(int Gateway_ID, short Port, Byte Mode);

        [DllImport("Dapapi.dll")]
        public static extern int AB_CLTAG_SetAddr(int Gateway_ID, int Node_Addr, Byte Set_Mode);


        //AT702S
        [DllImport("Dapapi.dll")]
        public static extern int AB_SNR_AutoWarn(int Gateway_ID, int Node_addr, int AutoWarn);
        [DllImport("Dapapi.dll")]
        public static extern int AB_SNR_SetRange(int Gateway_ID, int Node_addr, byte WorkingRange, byte savemode);
        [DllImport("Dapapi.dll")]
        public static extern int AB_SNR_AutoRange(int Gateway_ID, int Node_addr);
        [DllImport("Dapapi.dll")]
        public static extern int AB_SNR_ResidualDSP(int Gateway_ID, int Node_addr, byte nResidual);
        [DllImport("Dapapi.dll")]
        public static extern int AB_SNR_Control(int Gateway_ID, int Node_addr, byte ncontrol, byte savemode);
        [DllImport("Dapapi.dll")]
        public static extern int AB_SNR_DetectTime(int Gateway_ID, int Node_addr, byte DetectTime, byte savemode);

        [DllImport("Dapapi.dll")]
        public static extern int AB_DIO_SetDO(int Gateway_ID, int Node_addr, int channel, int status);

        //设置自动反馈DI
        [DllImport("Dapapi.dll")]
        public static extern int AB_DIO_SetDiRspMode(int Gateway_ID, int Node_addr, int channel, int status);


        #region AT705-RFID

        [DllImport("Dapapi.dll")]
        public static extern int AB_TAG_RFID(int Gateway, int Node_addr, byte RFID_ON, byte Save_mode);

        [DllImport("Dapapi.dll")]
        public static extern int AB_Register_Single_UID(int Gateway, int Node_addr, string UID_code);

        [DllImport("Dapapi.dll")]
        public static extern int AB_Register_Multi_UID(int Gateway, int Node_addr, byte Buffer_Idx, string UID_code);

        [DllImport("Dapapi.dll")]
        public static extern int AB_Delete_UID(int Gateway, int Node_addr, byte Buffer_Idx);

        [DllImport("Dapapi.dll")]
        public static extern int AB_4K_Prompt_Flash(int Gateway, int Node_addr, short Buffer_Idx);

        [DllImport("Dapapi.dll")]
        public static extern int AB_4K_RFID_Dsp(int Gateway, int Node_addr, string Disp_Str, int qty, byte Buffer_Idx, byte Auto_Rtv, byte LED_Sta1, byte led_sta2, byte arrow, byte dot);

        #endregion

        #region AT708
        [DllImport("Dapapi.dll")]
        public static extern int AB_LB_DspStr2(int Gateway_ID, int Node_Addr, String Dsp_Str, Byte Dot, int Interval);
        #endregion

        #region AT70D/AT70D-3K
        [DllImport("Dapapi.dll")]
        public static extern int AB_LCD_Dsp(int Gateway_ID, int Node_Addr, String Dsp_Str);

        [DllImport("Dapapi.dll")]
        public static extern int AB_LCD_DspNum(int Gateway_ID, int Node_Addr, int Disp_INT);

        [DllImport("Dapapi.dll")]
        public static extern int AB_LCD_DspMsg(int Gateway_ID, int Node_Addr, String Dsp_Str);

        [DllImport("Dapapi.dll")]
        public static extern int AB_TAG_OFF(int Gateway_ID, int Node_Addr);
        #endregion

        //关闭alive功能
        [DllImport("Dapapi.dll")]
        public static extern int AB_TAG_AliveIndicate(int Gateway_ID, int Node_Addr, byte on_off, byte Save_mode);

    }
}
