namespace OperatingElectronicTags
{
    partial class MainForm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.bn_send = new System.Windows.Forms.Button();
            this.bn_maintain = new System.Windows.Forms.Button();
            this.bn_test = new System.Windows.Forms.Button();
            this.messageQueue1 = new System.Messaging.MessageQueue();
            this.tb_meg = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ID = new System.Windows.Forms.TextBox();
            this.myIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.myMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.退出ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tb_receive = new System.Windows.Forms.TextBox();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.bn_sendmessage = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.tb_JID = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.tb_Addrlist = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.tb_msg = new System.Windows.Forms.TextBox();
            this.myMenu.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // bn_send
            // 
            this.bn_send.Location = new System.Drawing.Point(217, 11);
            this.bn_send.Name = "bn_send";
            this.bn_send.Size = new System.Drawing.Size(48, 72);
            this.bn_send.TabIndex = 2;
            this.bn_send.Text = "发送";
            this.bn_send.UseVisualStyleBackColor = true;
            this.bn_send.Click += new System.EventHandler(this.bn_send_Click);
            // 
            // bn_maintain
            // 
            this.bn_maintain.BackColor = System.Drawing.SystemColors.Control;
            this.bn_maintain.Location = new System.Drawing.Point(514, 420);
            this.bn_maintain.Name = "bn_maintain";
            this.bn_maintain.Size = new System.Drawing.Size(82, 48);
            this.bn_maintain.TabIndex = 3;
            this.bn_maintain.Text = "维护";
            this.bn_maintain.UseVisualStyleBackColor = false;
            this.bn_maintain.Click += new System.EventHandler(this.bn_maintain_Click);
            // 
            // bn_test
            // 
            this.bn_test.BackColor = System.Drawing.SystemColors.Control;
            this.bn_test.Location = new System.Drawing.Point(37, 420);
            this.bn_test.Name = "bn_test";
            this.bn_test.Size = new System.Drawing.Size(82, 48);
            this.bn_test.TabIndex = 4;
            this.bn_test.Text = "测试";
            this.bn_test.UseVisualStyleBackColor = false;
            this.bn_test.Click += new System.EventHandler(this.bn_test_Click);
            // 
            // messageQueue1
            // 
            this.messageQueue1.MessageReadPropertyFilter.LookupId = true;
            this.messageQueue1.SynchronizingObject = this;
            // 
            // tb_meg
            // 
            this.tb_meg.Location = new System.Drawing.Point(59, 36);
            this.tb_meg.Multiline = true;
            this.tb_meg.Name = "tb_meg";
            this.tb_meg.Size = new System.Drawing.Size(152, 47);
            this.tb_meg.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 8;
            this.label2.Text = "描述ID";
            // 
            // ID
            // 
            this.ID.BackColor = System.Drawing.Color.White;
            this.ID.Location = new System.Drawing.Point(59, 11);
            this.ID.Name = "ID";
            this.ID.Size = new System.Drawing.Size(152, 21);
            this.ID.TabIndex = 9;
            // 
            // myIcon
            // 
            this.myIcon.ContextMenuStrip = this.myMenu;
            this.myIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("myIcon.Icon")));
            this.myIcon.Text = "亮灯系统";
            this.myIcon.Visible = true;
            this.myIcon.MouseClick += new System.Windows.Forms.MouseEventHandler(this.myIcon_MouseClick);
            // 
            // myMenu
            // 
            this.myMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.退出ToolStripMenuItem});
            this.myMenu.Name = "myMenu";
            this.myMenu.Size = new System.Drawing.Size(101, 24);
            // 
            // 退出ToolStripMenuItem
            // 
            this.退出ToolStripMenuItem.Name = "退出ToolStripMenuItem";
            this.退出ToolStripMenuItem.Padding = new System.Windows.Forms.Padding(0);
            this.退出ToolStripMenuItem.Size = new System.Drawing.Size(100, 20);
            this.退出ToolStripMenuItem.Text = "退出";
            this.退出ToolStripMenuItem.Click += new System.EventHandler(this.ToolStripMenuItem_Click);
            // 
            // tb_receive
            // 
            this.tb_receive.Location = new System.Drawing.Point(59, 42);
            this.tb_receive.Multiline = true;
            this.tb_receive.Name = "tb_receive";
            this.tb_receive.Size = new System.Drawing.Size(152, 47);
            this.tb_receive.TabIndex = 6;
            // 
            // bn_sendmessage
            // 
            this.bn_sendmessage.Location = new System.Drawing.Point(217, 16);
            this.bn_sendmessage.Name = "bn_sendmessage";
            this.bn_sendmessage.Size = new System.Drawing.Size(49, 73);
            this.bn_sendmessage.TabIndex = 11;
            this.bn_sendmessage.Text = "发送指令";
            this.bn_sendmessage.UseVisualStyleBackColor = true;
            this.bn_sendmessage.Click += new System.EventHandler(this.bn_sendmessage_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.label5.Font = new System.Drawing.Font("华文中宋", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.Location = new System.Drawing.Point(266, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 23);
            this.label5.TabIndex = 16;
            this.label5.Text = "指令界面";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.tb_meg);
            this.groupBox1.Controls.Add(this.bn_send);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.ID);
            this.groupBox1.Location = new System.Drawing.Point(31, 60);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(272, 91);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "发送";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 50);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 12);
            this.label8.TabIndex = 10;
            this.label8.Text = "消息主体";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.tb_JID);
            this.groupBox2.Controls.Add(this.tb_receive);
            this.groupBox2.Controls.Add(this.bn_sendmessage);
            this.groupBox2.Location = new System.Drawing.Point(31, 157);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(272, 96);
            this.groupBox2.TabIndex = 18;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "接收";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 59);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(53, 12);
            this.label10.TabIndex = 12;
            this.label10.Text = "消息主体";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(13, 22);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(41, 12);
            this.label9.TabIndex = 10;
            this.label9.Text = "描述ID";
            // 
            // tb_JID
            // 
            this.tb_JID.Location = new System.Drawing.Point(59, 16);
            this.tb_JID.Name = "tb_JID";
            this.tb_JID.Size = new System.Drawing.Size(152, 21);
            this.tb_JID.TabIndex = 11;
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.groupBox3.Controls.Add(this.tb_Addrlist);
            this.groupBox3.Location = new System.Drawing.Point(367, 70);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(223, 183);
            this.groupBox3.TabIndex = 19;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "控制器列表";
            // 
            // tb_Addrlist
            // 
            this.tb_Addrlist.Location = new System.Drawing.Point(6, 22);
            this.tb_Addrlist.Multiline = true;
            this.tb_Addrlist.Name = "tb_Addrlist";
            this.tb_Addrlist.Size = new System.Drawing.Size(211, 149);
            this.tb_Addrlist.TabIndex = 5;
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.groupBox4.Controls.Add(this.tb_msg);
            this.groupBox4.Location = new System.Drawing.Point(25, 287);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(572, 127);
            this.groupBox4.TabIndex = 20;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "控制器信息";
            this.groupBox4.Enter += new System.EventHandler(this.groupBox4_Enter);
            // 
            // tb_msg
            // 
            this.tb_msg.Location = new System.Drawing.Point(6, 20);
            this.tb_msg.Multiline = true;
            this.tb_msg.Name = "tb_msg";
            this.tb_msg.Size = new System.Drawing.Size(559, 97);
            this.tb_msg.TabIndex = 7;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(627, 480);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.bn_test);
            this.Controls.Add(this.bn_maintain);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.Name = "MainForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Order";
            this.TransparencyKey = System.Drawing.Color.White;
            this.Deactivate += new System.EventHandler(this.MainForm_Deactivate);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.myMenu.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button bn_send;
        private System.Windows.Forms.Button bn_maintain;
        private System.Windows.Forms.Button bn_test;
        private System.Messaging.MessageQueue messageQueue1;
        private System.Windows.Forms.TextBox tb_meg;
        private System.Windows.Forms.TextBox ID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NotifyIcon myIcon;
        private System.Windows.Forms.ContextMenuStrip myMenu;
        private System.Windows.Forms.ToolStripMenuItem 退出ToolStripMenuItem;
        private System.Windows.Forms.TextBox tb_receive;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Button bn_sendmessage;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tb_JID;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox tb_Addrlist;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox tb_msg;
    }
}

