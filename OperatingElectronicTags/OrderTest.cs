using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OperatingElectronicTags
{
    public partial class OrderTest : Form
    {
        public OrderTest()
        {
            InitializeComponent();
        }

        public static int OpenState;

        public struct Diagnosis
        {
            public string[] Port;

            public void Init(int count)
            {
                Port = new string[count];
            }
        }

        bool bAPIOpen;
        int GWCount, iNumData;
        int[] GWID = new int[1000];
        Diagnosis[] diagnosis = new Diagnosis[1000];
        short iLEDInterval, iNodeAddr;
        byte iDigitPoint = 0, iTagMode, iCountingNum;

        //发送指令
        private void button1_Click(object sender, EventArgs e)
        {
            Dapapi.AB_API_Open();
            string ip = this.cb_ip.Text;
            string  [] list = ip.Split('-');
            //int[] a =Convert.ToInt32( list[0]);
            try
            {
            int a=    Dapapi.AB_LB_DspNum(Convert.ToInt32(list[0]), Convert.ToInt32(list[1]), Convert.ToInt32(list[2]), 0, 0);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
           
        }
        //打开控制器
        private void bu_Open_Click(object sender, EventArgs e)
        {
            this.bu_Open.Enabled = false;
            this.bu_Close.Enabled = true;
            Dap_Open();
            GetGWStatus();

        }
        //关闭控制器
        private void bu_Close_Click(object sender, EventArgs e)
        {
            this.bu_Open.Enabled = true;
            this.bu_Close.Enabled = false;
            TagClear();
            Dap_Close();
            this.tb_Addrlist.Clear();
            this.tb_msg.Clear();

        }

        /// <summary>
        /// 控制器打开
        /// </summary>
        /// <returns></returns>
        private  int Dap_Open()
        {
            int posspace, postab, pos;

            tb_Addrlist.Clear();

            GWCount = 0;
            if (!System.IO.File.Exists("IPINDEX"))
            {
                MessageBox.Show("文件IPINDEX不存在!");
                return -1;
            }
            try
            {
                using (System.IO.StreamReader sr = new System.IO.StreamReader("IPINDEX"))
                {
                    String line;
                    // Read and display lines from the file until the end of 
                    // the file is reached.
                    while ((line = sr.ReadLine()) != null)
                    {
                        GWCount++;
                        posspace = line.IndexOf(" ");   //find space
                        postab = line.IndexOf((char)9); //find tab

                        if (posspace <= 0) posspace = postab;
                        if (postab <= 0) postab = posspace;
                        pos = System.Math.Min(posspace, postab);
                        if (pos <= 0)
                        {
                            MessageBox.Show("IPINDEX格式错误!");
                            return -1;
                        }

                        tb_Addrlist.AppendText(line + "\r\n");

                        GWID[GWCount - 1] = int.Parse(line.Substring(0, pos));
                        diagnosis[GWCount - 1].Init(2);
                    }

                }
            }
            catch (Exception e)
            {
                MessageBox.Show("读取文件IPINDEX失败!" + e.Message);
                return -1;
            }

            if (APIOpen() < 0)
            {
                MessageBox.Show("初始化API失败!");
                return -1;
            }

            MessageBox.Show("API Open Success!");

            for (int i = 0; i < GWCount; i++)
            {
                if (Dapapi.AB_GW_Open(GWID[i]) < 0)
                {
                    MessageBox.Show("控制器'" + GWID[i] + "'打开失败!");
                }
            }

            return 1;
        }

        /// <summary>
        /// 控制器关闭
        /// </summary>
        private void Dap_Close()
        {
            //TagClear
            APIClose();
        }
        /// <summary>
        /// API注销
        /// </summary>
        /// <returns></returns>
        private int APIClose()
        {
            if (bAPIOpen)
            {
                Dapapi.AB_API_Close();
                bAPIOpen = false;
                return 1;
            }
            else
                return 0;
        }
        //熄灭全部
        private void bu_all_Click(object sender, EventArgs e)
        {

            TagClear();
            this.rb_all.Enabled = false;
        }


        /// <summary>
        /// 让功能对应的选相显示特殊的颜色
        /// </summary>
        /// <param name="indexvalue"></param>
        #region
        //private void ShowFunColor(int indexvalue)
        //{
        //    Color normalColor, indicatorColor;
        //    normalColor = Color.Black;
        //    indicatorColor = Color.Red;

        //    lbNodeAddr.ForeColor = normalColor;
        //    lbNumeric.ForeColor = normalColor;
        //    lbString.ForeColor = normalColor;
        //    lbLEDInterval.ForeColor = normalColor;
        //    lbLampState.ForeColor = normalColor;
        //    lbLampColor.ForeColor = normalColor;
        //    lbBuzzerType.ForeColor = normalColor;
        //    lbMaxNode.ForeColor = normalColor;
        //    gbDigit.ForeColor = normalColor;

        //    lbAHABeConfirm.ForeColor = normalColor;
        //    lbAHALEDState.ForeColor = normalColor;
        //    lbAHALAMPType.ForeColor = normalColor;
        //    //lbAHALEDState.ForeColor = normalColor;
        //    lbAHABuzzerType.ForeColor = normalColor;
        //    lbSetMode.ForeColor = normalColor;
        //    lbCountingdigit.ForeColor = normalColor;
        //    lbLockState.ForeColor = normalColor;
        //    lbLockKey.ForeColor = normalColor;
        //    lbSimulateMode.ForeColor = normalColor;
        //    lbCompleteState.ForeColor = normalColor;
        //    lbDelayTime.ForeColor = normalColor;
        //    lbMelodySong.ForeColor = normalColor;
        //    lbVolume.ForeColor = normalColor;
        //    lbAVArrow.ForeColor = normalColor;
        //    lb3WRow.ForeColor = normalColor;
        //    lb3WColumn.ForeColor = normalColor;
        //    lbSaveMode.ForeColor = normalColor;
        //    gbTagMode.ForeColor = normalColor;

        //    lblShowChars_AT80C.ForeColor = normalColor;
        //    lblControlChars_AT80C.ForeColor = normalColor;
        //    lblSelectRoll_AT80C.ForeColor = normalColor;
        //    lblBuzzerState_AT80C.ForeColor = normalColor;

        //    lblBuzzerState2_AT80C.ForeColor = normalColor;
        //    lblBuzzerCount2_AT80C.ForeColor = normalColor;
        //    switch (indexvalue - 1)
        //    {
        //        case 1:
        //            lbNodeAddr.ForeColor = indicatorColor;
        //            lbNumeric.ForeColor = indicatorColor;
        //            gbDigit.ForeColor = indicatorColor;
        //            lbLEDInterval.ForeColor = indicatorColor;
        //            break;
        //        case 2:
        //            lbNodeAddr.ForeColor = indicatorColor;
        //            lbString.ForeColor = indicatorColor;
        //            gbDigit.ForeColor = indicatorColor;
        //            lbLEDInterval.ForeColor = indicatorColor;
        //            break;
        //        case 3:
        //            lbNodeAddr.ForeColor = indicatorColor;
        //            break;
        //        case 4:
        //            lbNodeAddr.ForeColor = indicatorColor;
        //            lbLampState.ForeColor = indicatorColor;
        //            lbLEDInterval.ForeColor = indicatorColor;
        //            break;
        //        case 5:
        //            lbNodeAddr.ForeColor = indicatorColor;
        //            lbLampState.ForeColor = indicatorColor;
        //            lbLampColor.ForeColor = indicatorColor;
        //            break;
        //        case 6:
        //            lbNodeAddr.ForeColor = indicatorColor;
        //            lbBuzzerType.ForeColor = indicatorColor;
        //            break;
        //        case 7:
        //            lbNodeAddr.ForeColor = indicatorColor;
        //            break;
        //        case 8:
        //            lbMaxNode.ForeColor = indicatorColor;
        //            break;
        //        case 9:
        //            lbNodeAddr.ForeColor = indicatorColor;
        //            lbSetMode.ForeColor = indicatorColor;
        //            break;
        //        case 10:
        //            lbNodeAddr.ForeColor = indicatorColor;
        //            lbNumeric.ForeColor = indicatorColor;
        //            lbCountingdigit.ForeColor = indicatorColor;
        //            break;
        //        case 11:
        //            lbNodeAddr.ForeColor = indicatorColor;
        //            lbLockState.ForeColor = indicatorColor;
        //            lbLockKey.ForeColor = indicatorColor;
        //            break;
        //        case 12:
        //            lbNodeAddr.ForeColor = indicatorColor;
        //            lbSimulateMode.ForeColor = indicatorColor;
        //            break;
        //        case 13:
        //            lbNodeAddr.ForeColor = indicatorColor;
        //            gbTagMode.ForeColor = indicatorColor;
        //            lbSaveMode.ForeColor = indicatorColor;
        //            break;
        //        case 14:
        //            lbNodeAddr.ForeColor = indicatorColor;
        //            lbCompleteState.ForeColor = indicatorColor;
        //            break;
        //        case 15:
        //            lbNodeAddr.ForeColor = indicatorColor;
        //            lbDelayTime.ForeColor = indicatorColor;
        //            break;
        //        case 16:
        //            lbNodeAddr.ForeColor = indicatorColor;
        //            lbString.ForeColor = indicatorColor;
        //            lbAHABeConfirm.ForeColor = indicatorColor;
        //            lbAHALEDState.ForeColor = indicatorColor;
        //            break;
        //        case 17:
        //            lbNodeAddr.ForeColor = indicatorColor;
        //            break;
        //        case 18:
        //            lbNodeAddr.ForeColor = indicatorColor;
        //            lbAHALAMPType.ForeColor = indicatorColor;
        //            lbAHALAMPState.ForeColor = indicatorColor;
        //            break;
        //        case 19:
        //            lbNodeAddr.ForeColor = indicatorColor;
        //            lbAHABuzzerType.ForeColor = indicatorColor;
        //            break;
        //        case 20:
        //            lbNodeAddr.ForeColor = indicatorColor;
        //            lbBuzzerType.ForeColor = indicatorColor;
        //            lbMelodySong.ForeColor = indicatorColor;
        //            break;
        //        case 21:
        //            lbNodeAddr.ForeColor = indicatorColor;
        //            lbVolume.ForeColor = indicatorColor;
        //            break;
        //        case 22:
        //            lbNodeAddr.ForeColor = indicatorColor;
        //            lbNumeric.ForeColor = indicatorColor;
        //            gbDigit.ForeColor = indicatorColor;
        //            lbLEDInterval.ForeColor = indicatorColor;
        //            lbAVArrow.ForeColor = indicatorColor;
        //            break;
        //        case 23:
        //            lbNumeric.ForeColor = indicatorColor;
        //            lbNumeric.ForeColor = indicatorColor;
        //            gbDigit.ForeColor = indicatorColor;
        //            lbLEDInterval.ForeColor = indicatorColor;
        //            lb3WRow.ForeColor = indicatorColor;
        //            lb3WColumn.ForeColor = indicatorColor;
        //            break;
        //        case 24:
        //            lblShowChars_AT80C.ForeColor = indicatorColor;
        //            lblControlChars_AT80C.ForeColor = indicatorColor;
        //            break;
        //        case 25:
        //            lblShowChars_AT80C.ForeColor = indicatorColor;
        //            lblSelectRoll_AT80C.ForeColor = indicatorColor;
        //            break;
        //        case 26:
        //            lblBuzzerState_AT80C.ForeColor = indicatorColor;
        //            break;
        //        case 27:
        //            lblBuzzerState2_AT80C.ForeColor = indicatorColor;
        //            lblBuzzerCount2_AT80C.ForeColor = indicatorColor;
        //            break;


        //        default:
        //            break;
        //    }

        //}
        #endregion


        /// <summary>
        /// API 函数初始化
        /// </summary>
        /// <returns></returns>
        private int APIOpen()
        {
            if (!bAPIOpen)
            {
                int ret;
                try
                {
                    ret = Dapapi.AB_API_Open();
                    if (ret < 0)
                        return -1;
                    else
                    {
                        bAPIOpen = true;
                        return 1;
                    }
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message);
                }

            }
            return 0;
        }

        /// <summary>
        /// 显示数字
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bu_int_Click(object sender, EventArgs e)
        {
            TagClear();
            iNodeAddr =short.Parse(cb_ip.Text);
            iNumData =Convert.ToInt32( this.Cb_int.Text);
            this.Cb_int.ForeColor = Color.Red;
            this.radioButton1.Checked = true;
            //this.Cb_int.Enabled = false;
            if (this.Cb_int.Text==string.Empty||this.Cb_int.Text=="")
            {
                MessageBox.Show("请选择数字！");
                return;
            }

            for (int i = 0; i < GWCount; i++)
            {
                if (iNodeAddr != 0)
                {
                    Dapapi.AB_LB_DspNum(GWID[i], iNodeAddr, iNumData, iDigitPoint, iLEDInterval);
                    Bigling(GWID[i],i);

                }
                else
                {
                    Dapapi.AB_LB_DspNum(GWID[i], -252, iNumData, iDigitPoint, iLEDInterval);
                    Dapapi.AB_LB_DspNum(GWID[i], 252, iNumData, iDigitPoint, iLEDInterval);
                }
            }

        }

        private void bn_can_Click(object sender, EventArgs e)
        {
            MainForm mf = new MainForm();
            mf.Show();
            this.Visible = false;
            OpenState = 0;
            MainForm.Openstate = 1;
        }

        private void OrderTest_Load(object sender, EventArgs e)
        {
            OpenState = 1;
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            //获取运行路径
            String currentpath;
            currentpath = System.IO.Directory.GetCurrentDirectory();
            this.tb_msg.Text = currentpath;
            this.Cb_int.SelectedItem = this.Cb_int.Items[0];
            this.cb_str.SelectedItem = this.cb_str.Items[0];
            this.cb_ip.SelectedItem = this.cb_ip.Items[0];
        }

        private void OrderTest_Deactivate(object sender, EventArgs e)
        {
            //当窗体为最小化状态时
            if (this.WindowState == FormWindowState.Minimized)
            {
                OpenState = 0;
                //this.myIcon.Visible = true; //显示托盘图标
                this.Hide();//隐藏窗体
                this.ShowInTaskbar = false;//图标不显示在任务栏
                
            }
           
        }
        //关闭窗体
        private void OrderTest_FormClosing(object sender, FormClosingEventArgs e)
        {
            OpenState = 0;
            Application.Exit();
        }

        /// <summary>
        /// 显示字符
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bu_str_Click(object sender, EventArgs e)
        {
            iNodeAddr =short.Parse( this.cb_ip.Text);
            this.cb_str.ForeColor = Color.Red;
            this.radioButton2.Checked = true;
            //this.cb_str.Enabled = false;
            if (this.cb_str.Text == string.Empty || this.cb_str.Text == "")
            {
                MessageBox.Show("请选择字符！");
                return;
            }
            string sShowData;

            radioButton2.Checked = true;
            //ShowFunColor(3);

            //if (CheckNodeAddr() == -1) return;
            //if (CheckNumeric() == -1) return;
            //if (CheckLEDInterval() == -1) return;

            sShowData = cb_str.Text/*.Trim()*/;
            if (sShowData.Length > 6)
            {
                sShowData = sShowData.Substring(0, 6);
            }
            else
            {
                sShowData = sShowData.PadLeft(6);
            }

            for (int i = 0; i < GWCount; i++)
            {
                if (iNodeAddr != 0)
                {
                    Dapapi.AB_LB_DspStr(GWID[i], iNodeAddr, sShowData, iDigitPoint, iLEDInterval);
                    Bigling(GWID[i], i);
                }
                    
                else
                {
                    Dapapi.AB_LB_DspStr(GWID[i], -252, sShowData, iDigitPoint, iLEDInterval);
                    Dapapi.AB_LB_DspStr(GWID[i], 252, sShowData, iDigitPoint, iLEDInterval);
                }
            }


        }
        /// <summary>
        /// 获取控制器状态
        /// </summary>
        private void GetGWStatus()
        {
            bool bGoOn;
            int ret, timeStart;

            for (int i = 0; i < GWCount; i++)
            {
                Dapapi.AB_GW_Open(GWID[i]);
                ret = Dapapi.AB_GW_Status(GWID[i]);

                if (ret != 7)
                {
                    bGoOn = true;
                    timeStart = System.Environment.TickCount;
                    while (bGoOn)
                    {
                        ret = Dapapi.AB_GW_Status(GWID[i]);
                        if (ret == 7)
                            bGoOn = false;
                        else if (System.Environment.TickCount - timeStart > 3000)
                        {
                            bGoOn = false;
                        }
                    }
                }

                if (ret == 7)
                {
                    this.tb_msg.Text+= "\r\n Gateway ID:" + GWID[i] + " success connected, status return :" + ret;
                }
                else
                {
                    this.tb_msg.Text+= "\r\n Gateway ID:" + GWID[i] + " failed to connected, status return :" + ret;
                }

            }
        }

        /// <summary>
        /// 熄灭所有标签
        /// </summary>
        private void TagClear()
        {
            for (int i = 0; i < GWCount; i++)
            {
                if (Dapapi.AB_GW_Status(GWID[i]) == 7)
                {
                    Dapapi.AB_LB_DspNum(GWID[i], -252, 0, 0, -3);
                    Dapapi.AB_LB_DspNum(GWID[i], 252, 0, 0, -3);
                    Dapapi.AB_LED_Dsp(GWID[i], -252, 0, 0);
                    Dapapi.AB_LED_Dsp(GWID[i], 252, 0, 0);
                    Dapapi.AB_BUZ_On(GWID[i], -252, 0);
                    Dapapi.AB_BUZ_On(GWID[i], 252, 0);
                    Dapapi.AB_LB_DspStr(GWID[i], -252, "", 0, -3);
                    Dapapi.AB_LB_DspStr(GWID[i], 252, "", 0, -3);

                    //12-digits Alphanumerical display
                    Dapapi.AB_AHA_ClrDsp(GWID[i], -252);
                    Dapapi.AB_AHA_ClrDsp(GWID[i], 252);
                    Dapapi.AB_AHA_BUZ_On(GWID[i], -252, 0);
                    Dapapi.AB_AHA_BUZ_On(GWID[i], 252, 0);
                }
            }
        }

        /// <summary>
        /// 排灯
        /// </summary>
        /// <param name="iNodeAddr"></param>
        /// <param name="i"></param>
        public void Bigling(int iNodeAddr, int i)
        {
            if (iNodeAddr > 90)
            {
                Dapapi.AB_LB_DspNum(GWID[i], 120, iNumData, iDigitPoint, iLEDInterval);
            }
            else if (iNodeAddr > 60)
            {
                Dapapi.AB_LB_DspNum(GWID[i], 90, iNumData, iDigitPoint, iLEDInterval);
            }
            else if (iNodeAddr > 30)
            {
                Dapapi.AB_LB_DspNum(GWID[i], 60, iNumData, iDigitPoint, iLEDInterval);
            }
            else if (iNodeAddr > 0)
            {
                Dapapi.AB_LB_DspNum(GWID[i], 30, iNumData, iDigitPoint, iLEDInterval);
            }










        }
    }
}
