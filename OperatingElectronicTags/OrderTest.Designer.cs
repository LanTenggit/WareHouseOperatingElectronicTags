namespace OperatingElectronicTags
{
    partial class OrderTest
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
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cb_str = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Cb_int = new System.Windows.Forms.ComboBox();
            this.bu_str = new System.Windows.Forms.Button();
            this.bu_int = new System.Windows.Forms.Button();
            this.bu_all = new System.Windows.Forms.Button();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.rb_all = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tb_Addrlist = new System.Windows.Forms.TextBox();
            this.bu_Close = new System.Windows.Forms.Button();
            this.bu_Open = new System.Windows.Forms.Button();
            this.cb_ip = new System.Windows.Forms.ComboBox();
            this.tb_msg = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.bn_can = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "IP地址";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.cb_str);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.Cb_int);
            this.groupBox1.Controls.Add(this.bu_str);
            this.groupBox1.Controls.Add(this.bu_int);
            this.groupBox1.Controls.Add(this.bu_all);
            this.groupBox1.Controls.Add(this.radioButton2);
            this.groupBox1.Controls.Add(this.radioButton1);
            this.groupBox1.Controls.Add(this.rb_all);
            this.groupBox1.Location = new System.Drawing.Point(329, 52);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(219, 215);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "指令列表";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 189);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 12);
            this.label3.TabIndex = 9;
            this.label3.Text = "字符";
            // 
            // cb_str
            // 
            this.cb_str.FormattingEnabled = true;
            this.cb_str.Items.AddRange(new object[] {
            "abcde",
            "ABCDE",
            "aabbc"});
            this.cb_str.Location = new System.Drawing.Point(53, 186);
            this.cb_str.Name = "cb_str";
            this.cb_str.Size = new System.Drawing.Size(106, 20);
            this.cb_str.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 12);
            this.label2.TabIndex = 7;
            this.label2.Text = "数字";
            // 
            // Cb_int
            // 
            this.Cb_int.FormattingEnabled = true;
            this.Cb_int.Items.AddRange(new object[] {
            "8888",
            "1234",
            "6789"});
            this.Cb_int.Location = new System.Drawing.Point(53, 106);
            this.Cb_int.Name = "Cb_int";
            this.Cb_int.Size = new System.Drawing.Size(106, 20);
            this.Cb_int.TabIndex = 6;
            // 
            // bu_str
            // 
            this.bu_str.Location = new System.Drawing.Point(53, 150);
            this.bu_str.Name = "bu_str";
            this.bu_str.Size = new System.Drawing.Size(106, 23);
            this.bu_str.TabIndex = 5;
            this.bu_str.Text = "显示字符";
            this.bu_str.UseVisualStyleBackColor = true;
            this.bu_str.Click += new System.EventHandler(this.bu_str_Click);
            // 
            // bu_int
            // 
            this.bu_int.Location = new System.Drawing.Point(53, 62);
            this.bu_int.Name = "bu_int";
            this.bu_int.Size = new System.Drawing.Size(106, 23);
            this.bu_int.TabIndex = 4;
            this.bu_int.Text = "显示数字";
            this.bu_int.UseVisualStyleBackColor = true;
            this.bu_int.Click += new System.EventHandler(this.bu_int_Click);
            // 
            // bu_all
            // 
            this.bu_all.Location = new System.Drawing.Point(53, 19);
            this.bu_all.Name = "bu_all";
            this.bu_all.Size = new System.Drawing.Size(106, 23);
            this.bu_all.TabIndex = 3;
            this.bu_all.Text = "熄灭全部";
            this.bu_all.UseVisualStyleBackColor = true;
            this.bu_all.Click += new System.EventHandler(this.bu_all_Click);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(22, 155);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(14, 13);
            this.radioButton2.TabIndex = 2;
            this.radioButton2.TabStop = true;
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(22, 67);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(14, 13);
            this.radioButton1.TabIndex = 1;
            this.radioButton1.TabStop = true;
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // rb_all
            // 
            this.rb_all.AutoSize = true;
            this.rb_all.Location = new System.Drawing.Point(22, 24);
            this.rb_all.Name = "rb_all";
            this.rb_all.Size = new System.Drawing.Size(14, 13);
            this.rb_all.TabIndex = 0;
            this.rb_all.TabStop = true;
            this.rb_all.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tb_Addrlist);
            this.groupBox2.Controls.Add(this.bu_Close);
            this.groupBox2.Controls.Add(this.bu_Open);
            this.groupBox2.Location = new System.Drawing.Point(14, 43);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(223, 215);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "控制器列表";
            // 
            // tb_Addrlist
            // 
            this.tb_Addrlist.Location = new System.Drawing.Point(6, 24);
            this.tb_Addrlist.Multiline = true;
            this.tb_Addrlist.Name = "tb_Addrlist";
            this.tb_Addrlist.Size = new System.Drawing.Size(211, 82);
            this.tb_Addrlist.TabIndex = 5;
            // 
            // bu_Close
            // 
            this.bu_Close.Location = new System.Drawing.Point(21, 173);
            this.bu_Close.Name = "bu_Close";
            this.bu_Close.Size = new System.Drawing.Size(183, 30);
            this.bu_Close.TabIndex = 4;
            this.bu_Close.Text = "关闭控制器";
            this.bu_Close.UseVisualStyleBackColor = true;
            this.bu_Close.Click += new System.EventHandler(this.bu_Close_Click);
            // 
            // bu_Open
            // 
            this.bu_Open.Location = new System.Drawing.Point(21, 125);
            this.bu_Open.Name = "bu_Open";
            this.bu_Open.Size = new System.Drawing.Size(183, 30);
            this.bu_Open.TabIndex = 3;
            this.bu_Open.Text = "打开控制器";
            this.bu_Open.UseVisualStyleBackColor = true;
            this.bu_Open.Click += new System.EventHandler(this.bu_Open_Click);
            // 
            // cb_ip
            // 
            this.cb_ip.FormattingEnabled = true;
            this.cb_ip.Items.AddRange(new object[] {
            "252",
            "-252"});
            this.cb_ip.Location = new System.Drawing.Point(65, 12);
            this.cb_ip.Name = "cb_ip";
            this.cb_ip.Size = new System.Drawing.Size(121, 20);
            this.cb_ip.TabIndex = 6;
            // 
            // tb_msg
            // 
            this.tb_msg.Location = new System.Drawing.Point(6, 20);
            this.tb_msg.Multiline = true;
            this.tb_msg.Name = "tb_msg";
            this.tb_msg.Size = new System.Drawing.Size(522, 97);
            this.tb_msg.TabIndex = 7;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.tb_msg);
            this.groupBox3.Location = new System.Drawing.Point(14, 273);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(534, 127);
            this.groupBox3.TabIndex = 8;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "控制器信息";
            // 
            // bn_can
            // 
            this.bn_can.Location = new System.Drawing.Point(454, 396);
            this.bn_can.Name = "bn_can";
            this.bn_can.Size = new System.Drawing.Size(75, 23);
            this.bn_can.TabIndex = 9;
            this.bn_can.Text = "返回";
            this.bn_can.UseVisualStyleBackColor = true;
            this.bn_can.Click += new System.EventHandler(this.bn_can_Click);
            // 
            // OrderTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(567, 421);
            this.Controls.Add(this.bn_can);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.cb_ip);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "OrderTest";
            this.Text = "OrderTest";
            this.Deactivate += new System.EventHandler(this.OrderTest_Deactivate);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.OrderTest_FormClosing);
            this.Load += new System.EventHandler(this.OrderTest_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button bu_Close;
        private System.Windows.Forms.Button bu_Open;
        private System.Windows.Forms.Button bu_str;
        private System.Windows.Forms.Button bu_int;
        private System.Windows.Forms.Button bu_all;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton rb_all;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox Cb_int;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cb_str;
        private System.Windows.Forms.TextBox tb_Addrlist;
        private System.Windows.Forms.ComboBox cb_ip;
        private System.Windows.Forms.TextBox tb_msg;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button bn_can;
    }
}