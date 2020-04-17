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
    public partial class Maintain : Form
    {
        public Maintain()
        {
            InitializeComponent();
        }

        public static int OpenState;

        public static int Countid;
        public static int dgid;
        public static string ids;

        int pageSize = 0;     //每页显示行数
        int nMax = 0;         //总记录数
        int pageCount = 0;    //页数＝总记录数/每页显示行数
        int pageCurrent = 0;   //当前页号
        int nCurrent = 0;      //当前记录行
        DataSet ds = new DataSet();
        DataTable dtInfo = new DataTable();



        private void LoadData()
        {
            
            int nStartPos = 0;   //当前页面开始记录行
            int nEndPos = 0;     //当前页面结束记录行
            DataTable dtTemp = dtInfo.Clone();   //克隆DataTable结构框架

            if (pageCurrent == pageCount)
            {
                nEndPos = nMax;
            }
            else
            {
                nEndPos = pageSize * pageCurrent;
            }

            nStartPos = nCurrent;

            if (dtInfo.Rows.Count <= 0)
            {

                this.dataGridView1.DataSource = dtInfo;
                return;
            }

            //从元数据源复制记录行
            for (int i = nStartPos; i < nEndPos; i++)
            {
                dtTemp.ImportRow(dtInfo.Rows[i]);
                nCurrent++;
            }

            this.dataGridView1.DataSource = dtTemp;

        }
        private void InitDataSet()
        {
            pageSize = 6;      //设置页面行数
            nMax = dtInfo.Rows.Count;
            pageCount = (nMax / pageSize);    //计算出总页数
            if ((nMax % pageSize) > 0) pageCount++;
            pageCurrent = 1;    //当前页数从1开始
            nCurrent = 0;       //当前记录数从0开始
            LoadData();
        }




        private void Maintain_Load(object sender, EventArgs e)
        {
            OpenState = 1;
            this.ShowIcon = false;
            freshen();
            this.ShowInTaskbar = false; 

        }

        private void bn_return_Click(object sender, EventArgs e)
        {
            OpenState = 0;
            MainForm ma = new MainForm();
            ma.Show();
            this.Visible = false;
            MainForm.Openstate = 1;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Countid = dataGridView1.SelectedRows[0].Index;
            dgid = Convert.ToInt32(dataGridView1.Rows[Countid].Cells["S_ID"].Value.ToString());
            this.textBox1.Text = dataGridView1.Rows[Countid].Cells["PhysicalPath"].Value.ToString();
            this.textBox2.Text = dataGridView1.Rows[Countid].Cells["DeviceID"].Value.ToString();
            this.tb_num.Text= dataGridView1.Rows[Countid].Cells["Num"].Value.ToString();
            this.button1.Text = "修改";
        }

        private void dataGridView1_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                CS_remove.Show(MousePosition.X, MousePosition.Y);
                textBox1.Text = string.Empty;
                textBox2.Text = string.Empty;
                this.button1.Text = "添加";
            }
        }

        private void ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //dgid = Convert.ToInt32(dataGridView1.Rows[Countid].Cells["S_ID"].Value.ToString());

            foreach (DataGridViewRow item in dataGridView1.SelectedRows)
            {
                ids += dataGridView1.Rows[item.Index].Cells["S_ID"].Value.ToString() + ",";
            }

            string[] idlist = ids.Split(',');

            //if (dgid <= 0)
            //{
            //    MessageBox.Show("未选中任何行！");
            //    return;
            //}
            int num=0;
            if (MessageBox.Show("是否删除？", "提示!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            { 
                try
                {
                   foreach (var item in idlist)
                     {
                    string sqlstr = string.Format("Delete From Storage where S_ID ={0}", item);
                    num = DBHLper.GetExecuteNonQuery(sqlstr);

                    }
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.ToString());
                }
               
                 MessageBox.Show("删除成功！");
                 freshen();
            }
            else
            {
                return;
                //MessageBox.Show("n");
            }

            
        }

        private void la_fri_Click(object sender, EventArgs e)
        {
            pageCurrent = 1;
            nCurrent = pageSize * (pageCurrent - 1);
            this.label3.Text = "第" + pageCurrent + "页" + "共" + pageCount + "页" + "共" + nMax + "条";
            LoadData();
        }

        private void la_lastpage_Click(object sender, EventArgs e)
        {
            pageCurrent--;
            if (pageCurrent == 0)
            {
                pageCurrent++;
                MessageBox.Show("已经是第一页，请点击“下一页”查看！");
                return;
            }
            else
            {
                nCurrent = pageSize * (pageCurrent - 1);
            }
            this.label3.Text = "第" + pageCurrent + "页" + "共" + pageCount + "页" + "共" + nMax + "条";
            LoadData();
        }

        private void la_nextpage_Click(object sender, EventArgs e)
        {
            pageCurrent++;
            if (pageCurrent > pageCount)
            {
                pageCurrent--;
                MessageBox.Show("已经是最后一页，请点击“上一页”查看！");
                return;
            }
            else
            {
                nCurrent = pageSize * (pageCurrent - 1);
            }
            this.label3.Text = "第" + pageCurrent + "页" + "共" + pageCount + "页" + "共" + nMax + "条";
            LoadData();
        }

        private void la_endpage_Click(object sender, EventArgs e)
        {
            pageCurrent = pageCount;
            nCurrent = pageSize * (pageCurrent - 1);
            this.label3.Text = "第" + pageCurrent + "页" + "共" + pageCount + "页" + "共" + nMax + "条";
            LoadData();
        }
        //添加
        private void button1_Click(object sender, EventArgs e)
        {
            string PhysicalPath = this.textBox1.Text;
            string StorageName = this.textBox2.Text;
            int numsum;
            if (tb_num.Text==string.Empty||tb_num==null)
            {
               numsum = 0;   
            }
            else
            {
                numsum = Convert.ToInt32(tb_num.Text);  
            } 
           
            if (PhysicalPath==string.Empty||PhysicalPath=="")
            {
                MessageBox.Show("物理路径不能为空！");
                return;
            }
            if (this.button1.Text=="添加")
            {
               string sqlstr =string.Format("insert into Storage(PhysicalPath,DeviceID,Num)" +
                "values('{0}','{1}',{2})",PhysicalPath,StorageName,numsum);
               int num = DBHLper.GetExecuteNonQuery(sqlstr);
               if (num>0)
               {
                  MessageBox.Show("添加成功!");
               }
               else
               {
                  MessageBox.Show("不能添加相同的数据!");
               }
            }
            //修改
            else
            {
                string sqlstr = string.Format("update Storage set PhysicalPath='{0}' " +
                                ",DeviceID='{1}',num={2} where S_ID={3}", PhysicalPath, StorageName, numsum, dgid);
                int num = DBHLper.GetExecuteNonQuery(sqlstr);
                if (num > 0)
                {
                    MessageBox.Show("修改成功！");
                    this.button1.Text = "添加";
                }

            }
            textBox1.Text = string.Empty;
            textBox2.Text = string.Empty;
            tb_num.Text = string.Empty;
            freshen();


        }

        public void freshen() {

            string sql = "select * from Storage order by S_ID";
            dtInfo = DBHLper.GetTable(sql);
            dataGridView1.DataSource = dtInfo;
            InitDataSet();
            this.label3.Text = "第" + pageCurrent + "页" + "共" + pageCount + "页" + "共" + nMax + "条";
            dataGridView1.AllowUserToAddRows = false;
          
        }
        //修改
        //private void button2_Click(object sender, EventArgs e)
        //{
        //    string PhysicalPath = this.textBox1.Text;
        //    string StorageName = this.textBox2.Text;
        //    string sqlstr = string.Format("update Storage set PhysicalPath='{0}' " +
        //        ",StorageName='{1}' where S_ID={2}", PhysicalPath, StorageName,dgid);
        //    int num= DBHLper.GetExecuteNonQuery(sqlstr);
        //    if (num>0)
        //    {
        //        MessageBox.Show("修改成功！");
        //    }
        //    textBox1.Text = string.Empty;
        //    textBox2.Text = string.Empty;
        //    freshen();
        //}
        //查询
        private void bn_c_Click(object sender, EventArgs e)
        {
            string url = this.tb_url.Text;
            string strsql = string.Format( "select * from Storage where PhysicalPath like '%{0}%' order by S_ID",url);
            dtInfo = DBHLper.GetTable(strsql);
            //dtInfo.Compute("PhysicalPath", url);
            dataGridView1.DataSource = dtInfo;
            InitDataSet();
            this.label3.Text = "第" + pageCurrent + "页" + "共" + pageCount + "页" + "共" + nMax + "条";
            dataGridView1.AllowUserToAddRows = false;
        }
        //刷新
        private void bn_up_Click(object sender, EventArgs e)
        {
            freshen();
            this.tb_url.Text = string.Empty;
            this.textBox1.Text = string.Empty;
            this.textBox2.Text = string.Empty;
            this.tb_num.Text= string.Empty;
        }

        private void Maintain_Deactivate(object sender, EventArgs e)
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

        private void Maintain_FormClosing(object sender, FormClosingEventArgs e)
        {
            OpenState = 0;
            Application.Exit();
        }
    }
}
