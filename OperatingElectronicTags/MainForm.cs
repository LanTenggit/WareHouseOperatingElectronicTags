using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Messaging;
using System.Configuration;
using Newtonsoft.Json;
using MQTTnet.Core.Server;
using MQTTnet;
using System.Threading;
using System.IO.Ports;
using System.IO;
using Newtonsoft.Json.Linq;
using System.Xml;

namespace OperatingElectronicTags
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
           
        }

        public static int Openstate;
        public struct Diagnosis
        {
            public string[] Port;

            public void Init(int count)
            {
                Port = new string[count];
            }
        }
        //文件路径
        String currentpath  = System.IO.Directory.GetCurrentDirectory();

        public const string sMessageConnectionString = @".\Private$\TMSMQ";
        private delegate void FlushClient(); //代理
        //Thread thread = null;
        //uint DateTemp;
        //uint Datefalg = 0;
        //uint counter = 0;
        //uint DateTemp1 = 0;
        //uint TMP1;
        //uint RH1;
        //uint PRESS1;
        //double TMP;
        //double RH;
        //double PRESS;


        delegate void ShowMsgCallback(string text);
        SerialPort s = new SerialPort();



        bool bAPIOpen;
        int GWCount, iNumData;
        int[] GWID = new int[1000];
        Diagnosis[] diagnosis = new Diagnosis[1000];
        short iLEDInterval, iNodeAddr;
        byte iDigitPoint = 0, iTagMode, iCountingNum;

        private void bn_maintain_Click(object sender, EventArgs e)
        {
            Openstate = 0;
            Maintain ma = new Maintain();
            ma.Show();
            this.Visible = false;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            Openstate = 1;
            //this.Icon. = false;
            //this.ShowIcon = false;
            String currentpath;
            currentpath = System.IO.Directory.GetCurrentDirectory();
            this.tb_msg.Text = currentpath;

            Maintain ma = new Maintain();
            ma.MdiParent = this;
            
            OrderTest ot = new OrderTest();
            ot.MdiParent = this;


            #region
            ////串口启动
            ////thread = new Thread(CrossThreadFlush);
            ////thread.IsBackground = true;
            ////thread.Start();
            //int[] bit = new int[2];
            //bit[0] = 9600;
            //bit[1] = 115200;
            //foreach (var item in bit)
            //{
            //    this.cb_bit.Items.Add(item);
            //}
            //this.cb_bit.SelectedItem = bit[0];
            //string[] ports = SerialPort.GetPortNames();
            //foreach (var item in ports)
            //{
            //    this.cb_duankou.Items.Add(item);
            //}
            //cb_duankou.SelectedItem = ports[0];

            //this.ShowInTaskbar = false;

            //string jiaoyan = "NONE,ODD,EVEN,MARK,SPACE";
            //string[] jystr = jiaoyan.Split(',');
            //foreach (var item in jystr)
            //{
            //    cb_jiaoyan.Items.Add(item);
            //}
            //cb_jiaoyan.SelectedItem = jystr[0];



            //string shuju = "5,6,7,8";
            //string[] sjstr = shuju.Split(',');
            //foreach (var item in sjstr)
            //{
            //    cb_shuju.Items.Add(item);
            //}
            //cb_shuju.SelectedItem = sjstr[0];

            //string stop = "1,1.5,2";
            //string[] stopstr = stop.Split(',');
            //foreach (var item in stopstr)
            //{
            //    cb_stop.Items.Add(item);
            //}
            //cb_stop.SelectedItem = stopstr[0];

            #endregion

            //任务栏显示窗体
            this.ShowInTaskbar = false;
            ++DBHLper.count;
            if (DBHLper.count < 2)
            {
               
                this.myIcon.Visible = true;
            }
            else
            {
                this.myIcon.Visible = false;
            }
            //var options = new MqttServerOptions();
            //var mqttServer = new MqttServerFactory().CreateMqttServer(options);



        }

        private void bn_test_Click(object sender, EventArgs e)
        {
            Openstate = 0;
             OrderTest ot = new OrderTest();
            this.Visible = false;
            ot.Show();
            
        }
        //发送
        private void bn_send_Click(object sender, EventArgs e)
        {
            if (tb_meg.Text.Trim() == "")
            {
                MessageBox.Show("请输入要发送的message!");
                tb_meg.Focus();
                return;
            }

            //完整队列格式为：  计算机名\private$\队列名称 (专用队列)
            MessageQueue mqQue = new MessageQueue(sMessageConnectionString);
            mqQue.MessageReadPropertyFilter.SetAll();
            System.Messaging.Message msg = new System.Messaging.Message();
            //消息主体
            //List<string> list = new List<string>();
            //list.Add("212");
            //msg.Body = list;
            msg.Body = tb_meg.Text.Trim();
            //用描述设置ID
            msg.Label = ID.Text;
            //将消息加入到发送队列
            msg.ResponseQueue = mqQue;
            msg.AttachSenderId = true;
            msg.Formatter = new System.Messaging.XmlMessageFormatter(new Type[] { typeof(string) });
            try
            {
                //发送
                //mqQue.GetLifetimeService();
                mqQue.Send(msg);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
                return;
            }

            MessageBox.Show("发送成功！" + DateTime.Now.ToString());

        }

        #region
        /// 清除消息队列
        //private void btnClear_Click(object sender, EventArgs e)
        //{
        //    MessageQueue mqQue = null;
        //    if (MessageQueue.Exists(sMessageConnectionString))
        //    {
        //        //清除所有消息
        //        mqQue = new System.Messaging.MessageQueue(sMessageConnectionString);
        //        mqQue.Purge();
        //    }
        //}

        /// 接收
       
        //private void receive_Click(object sender, EventArgs e)
        //{
        //    MessageQueue mqQue = null;
        //    if (MessageQueue.Exists(sMessageConnectionString))
        //    {
        //        mqQue = new System.Messaging.MessageQueue(sMessageConnectionString);
        //    }
        //    //得到所有消息
        //    System.Messaging.Message[] messages = mqQue.GetAllMessages();
        //    if (messages.Length > 0)
        //    {
        //        foreach (System.Messaging.Message msgVal in messages)
        //        {
        //            //根据ID得到消息(这个ID放在消息的label中)
        //            if (msgVal.Label == tb_JID.Text)
        //            {
        //                //同步接收，直到得到一条消息为止，如果消息队列为空，会一直阻塞
        //                System.Messaging.Message msg = mqQue.Receive();
        //                msg.Formatter = new System.Messaging.XmlMessageFormatter(new Type[] { typeof(string) });
        //                //消息的内容
        //                tb_receive.Text = msg.Body.ToString();
        //                break;
        //            }
        //            else
        //            {
        //                tb_receive.Text = "没有找到指定ID的Message";
        //            }
        //        }

        //    }
        //    else
        //    {
        //        tb_receive.Text = "没有读取到数据！";
        //    }

        //}
        #endregion
        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
           
            if (e.CloseReason == CloseReason.UserClosing)//当用户点击窗体右上角X按钮或(Alt + F4)时 发生          
            {
                Openstate = 0;
                e.Cancel = true;
                this.ShowInTaskbar = false;
                this.myIcon.Icon = this.Icon;
                this.Visible = false;
                Application.Exit();
            }


        }

        private void myIcon_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                myMenu.Show();
            }

            if (e.Button == MouseButtons.Left)
            {
                if (this.Visible==false)
                {
                    if ((OrderTest.OpenState == 0)&& (Maintain.OpenState==0)&& Openstate==0)
                     {
                      this.Visible = true;
                      this.WindowState = FormWindowState.Normal;
                     }

                }
              
              

                //if (this.Visible == false)
                //{
                //    this.Visible = true;
                //    this.WindowState = FormWindowState.Normal;
                //}


            }
        }


        //退出
        private void ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
      
        private void bn_sendmessage_Click(object sender, EventArgs e)
        {
       
            TagClear();
            Dap_Close();


            MessageQueue mqQue = null;
            if (MessageQueue.Exists(sMessageConnectionString))
            {
                mqQue = new System.Messaging.MessageQueue(sMessageConnectionString);
            }
            if (mqQue==null)
            {
                MessageBox.Show("消息队列获取失败！");
                return;
            }
            //得到所有消息
            System.Messaging.Message[] messages = mqQue.GetAllMessages();
            if (messages.Length > 0)
            {
                foreach (System.Messaging.Message msgVal in messages)
                {
                    //根据ID得到消息(这个ID放在消息的label中)
                    if (msgVal.Label == tb_JID.Text)
                    {
                        //同步接收，直到得到一条消息为止，如果消息队列为空，会一直阻塞
                        System.Messaging.Message msg = mqQue.Receive();
                        msg.Formatter = new System.Messaging.XmlMessageFormatter(new Type[] { typeof(string) });
                        //消息的内容
                        tb_receive.Text = msg.Body.ToString();
                        string tagID = msg.Body.ToString();
                        string[] ip = tagID.Split('-');
                        string a = ip[0];
                        string IPstr="";
                        IPstr= GetIP(a);
                        string name = "";
                      
                        //switch (a)
                        //{
                        //    case "1":
                        //        IPstr = "1 4660 10.0.50.111";
                        //        break;
                        //    case "2":
                        //        IPstr = "1 4660 10.0.50.112";
                        //        //name = "IPTWOINDEX";
                        //        break;
                        //    case "3":
                        //        IPstr = "1 4660 10.0.50.113";
                        //        //name = "IPTHREEINDEX";
                        //        break;
                        //    case "4":
                        //        IPstr = "1 4660 10.0.50.114";
                        //        //name = "IPFOURINDEX";
                        //        break;
                        //    default:
                        //        MessageBox.Show("控制器不存在！");
                        //        return;
                        //}
                        //Writejson(IPstr); 
                        //name = "IPindex.json";
                        name = "IPindex.xml";
                        Dap_Open(name,IPstr);
                        GetGWStatus();
                        //string b = ip[1];
                        iNodeAddr =short.Parse(ip[1]);
                        iNumData =Convert.ToInt32(ip[2]);
                        try
                        {

                            for (int i = 0; i < GWCount; i++)
                            {
                                if (iNodeAddr != 0)
                                { 
                                    Dapapi.AB_LB_DspNum(GWID[i], iNodeAddr, iNumData, iDigitPoint, iLEDInterval);
                                    Bigling(iNodeAddr, i);
                                }
                                else
                                {
                                    Dapapi.AB_LB_DspNum(GWID[i], -252, iNumData, iDigitPoint, iLEDInterval);
                                    Dapapi.AB_LB_DspNum(GWID[i], 252, iNumData, iDigitPoint, iLEDInterval);
                                }
                            }
                            
                           
                        }
                        catch (Exception ex)
                        {

                            MessageBox.Show(ex.Message.ToString());
                        }
                        break;
                    }
                    else
                     {
                        tb_receive.Text = "没有找到指定ID的Message";
                     }
                }
            }
            else
            {
                tb_receive.Text = "没有读取到数据！";
            }
        }
        //打开控制器
        private void bu_Open_Click(object sender, EventArgs e)
        {
            //this.tb_msg.Text = currentpath;
            //this.bu_Open.Enabled = false;
            //this.bu_Close.Enabled = true;
            //Dap_Open("IPALLINDEX");
            //GetGWStatus();
        }
        //关闭控制器
        private void bu_Close_Click(object sender, EventArgs e)
        {
            //this.bu_Open.Enabled = true;
            //this.bu_Close.Enabled = false;
            //TagClear();
            //Dap_Close();
            //this.tb_Addrlist.Clear();
            //this.tb_msg.Clear();
        }

        /// <summary>
        /// 控制器打开
        /// </summary>
        /// <returns></returns>
        private int Dap_Open(string name,string IP)
        {
            int posspace, postab, pos;

            tb_Addrlist.Clear();

            GWCount = 0;
            if (!System.IO.File.Exists(name))
            {
                MessageBox.Show("JSON文件不存在!");
                return -1;
            }
            try
            {
                using (System.IO.StreamReader sr = new System.IO.StreamReader(name))
                {

                    String line;
                    // Read and display lines from the file until the end of 
                    // the file is reached.
                    //StreamReader file = File.OpenText("IPindex.json");
                    //JsonTextReader reader = new JsonTextReader(file);
                    //JObject jsonObject = (JObject)JToken.ReadFrom(reader);
                    //line = (string)jsonObject["IP"];
                    //file.Close();
                    line = IP;

                    //while ((line = sr.ReadLine()) != null)
                        if (line != null)
                        {
                        GWCount++;
                        posspace = line.IndexOf(" ");   //find space
                        postab = line.IndexOf((char)9); //find tab

                        if (posspace <= 0) posspace = postab;
                        if (postab <= 0) postab = posspace;
                        pos = System.Math.Min(posspace, postab);
                        if (pos <= 0)
                        {
                            MessageBox.Show("JSON格式错误!");
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
                MessageBox.Show("读取文件JSON失败!" + e.Message);
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
                    this.tb_msg.Text += "\r\n Gateway ID:" + GWID[i] + " success connected, status return :" + ret;
                }
                else
                {
                    this.tb_msg.Text += "\r\n Gateway ID:" + GWID[i] + " failed to connected, status return :" + ret;
                }

            }
        }

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

        private void groupBox4_Enter(object sender, EventArgs e)
        {

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

        private void MainForm_Deactivate(object sender, EventArgs e)
        {
            //当窗体为最小化状态时
            if (this.WindowState == FormWindowState.Minimized)
            {
                Openstate = 0;
                this.myIcon.Visible = true; //显示托盘图标
                this.Hide();//隐藏窗体
                this.ShowInTaskbar = false;//图标不显示在任务栏
            }
          
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
            int i=    Dapapi.AB_API_Close();
                bAPIOpen = false;
                return 1;
            }
            else
                return 0;
        }
        /// <summary>
        /// 排灯
        /// </summary>
        /// <param name="iNodeAddr"></param>
        /// <param name="i"></param>
        public void Bigling(int  iNodeAddr,int i) {
            if (iNodeAddr > 90)
            {
                Dapapi.AB_LB_DspNum(GWID[i], 120, iNumData, iDigitPoint, iLEDInterval);
            }
            else if (iNodeAddr >60)
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


        /// <summary>
        /// getjson配置文件
        /// </summary>
        public void Writejson(string IPstr) {
            string json = File.ReadAllText("IPindex.json");
            dynamic jsonObj = Newtonsoft.Json.JsonConvert.DeserializeObject(json);
            jsonObj["IP"] = IPstr.ToString();
            string output = Newtonsoft.Json.JsonConvert.SerializeObject(jsonObj, Newtonsoft.Json.Formatting.Indented);
            File.WriteAllText("IPindex.json", output);
        }



        public string GetIP(string a)
        {
            string path;
            path = System.IO.Path.GetFullPath("../../../IPIndex.xml");
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.Load(path);
            XmlNode xn;
            xn = xmlDoc.SelectSingleNode("IPConfig");
            XmlNodeList xnl = xn.ChildNodes;
            XmlNode xnc = xn.SelectSingleNode("AreaIP");
            string IP = "";
            for (int i = 0; i < xn.ChildNodes.Count ; i++)
            {
            
                if (xn.ChildNodes[i].ChildNodes[0].InnerText==a)
                {
                    IP = xn.ChildNodes[i].ChildNodes[1].InnerText;
                }
            }


            return IP;

        }



    }
}
