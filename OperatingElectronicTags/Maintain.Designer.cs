namespace OperatingElectronicTags
{
    partial class Maintain
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.S_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PhysicalPath = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DeviceID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Num = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bn_return = new System.Windows.Forms.Button();
            this.CS_remove = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label3 = new System.Windows.Forms.Label();
            this.la_fri = new System.Windows.Forms.Label();
            this.la_lastpage = new System.Windows.Forms.Label();
            this.la_nextpage = new System.Windows.Forms.Label();
            this.la_endpage = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tb_url = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.bn_c = new System.Windows.Forms.Button();
            this.bn_up = new System.Windows.Forms.Button();
            this.tb_num = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.CS_remove.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 280);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "物理路径";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(82, 277);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 21);
            this.textBox1.TabIndex = 1;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(252, 277);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 21);
            this.textBox2.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(202, 280);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "设备地址";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(107, 325);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "添加";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.S_ID,
            this.PhysicalPath,
            this.DeviceID,
            this.Num});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView1.Location = new System.Drawing.Point(25, 70);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(479, 164);
            this.dataGridView1.TabIndex = 6;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellMouseDown += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_CellMouseDown);
            // 
            // S_ID
            // 
            this.S_ID.DataPropertyName = "S_ID";
            this.S_ID.HeaderText = "ID";
            this.S_ID.Name = "S_ID";
            this.S_ID.Width = 85;
            // 
            // PhysicalPath
            // 
            this.PhysicalPath.DataPropertyName = "PhysicalPath";
            this.PhysicalPath.HeaderText = "物理路径";
            this.PhysicalPath.Name = "PhysicalPath";
            // 
            // DeviceID
            // 
            this.DeviceID.DataPropertyName = "DeviceID";
            this.DeviceID.HeaderText = "设备地址";
            this.DeviceID.Name = "DeviceID";
            this.DeviceID.Width = 150;
            // 
            // Num
            // 
            this.Num.DataPropertyName = "Num";
            this.Num.HeaderText = "数量";
            this.Num.Name = "Num";
            // 
            // bn_return
            // 
            this.bn_return.Location = new System.Drawing.Point(378, 325);
            this.bn_return.Name = "bn_return";
            this.bn_return.Size = new System.Drawing.Size(75, 23);
            this.bn_return.TabIndex = 8;
            this.bn_return.Text = "返回";
            this.bn_return.UseVisualStyleBackColor = true;
            this.bn_return.Click += new System.EventHandler(this.bn_return_Click);
            // 
            // CS_remove
            // 
            this.CS_remove.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItem});
            this.CS_remove.Name = "CS_remove";
            this.CS_remove.Size = new System.Drawing.Size(101, 26);
            // 
            // ToolStripMenuItem
            // 
            this.ToolStripMenuItem.Name = "ToolStripMenuItem";
            this.ToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.ToolStripMenuItem.Text = "删除";
            this.ToolStripMenuItem.Click += new System.EventHandler(this.ToolStripMenuItem_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 237);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 12);
            this.label3.TabIndex = 9;
            this.label3.Text = "label3";
            // 
            // la_fri
            // 
            this.la_fri.AutoSize = true;
            this.la_fri.Location = new System.Drawing.Point(131, 237);
            this.la_fri.Name = "la_fri";
            this.la_fri.Size = new System.Drawing.Size(29, 12);
            this.la_fri.TabIndex = 10;
            this.la_fri.Text = "首页";
            this.la_fri.Click += new System.EventHandler(this.la_fri_Click);
            // 
            // la_lastpage
            // 
            this.la_lastpage.AutoSize = true;
            this.la_lastpage.Location = new System.Drawing.Point(221, 237);
            this.la_lastpage.Name = "la_lastpage";
            this.la_lastpage.Size = new System.Drawing.Size(41, 12);
            this.la_lastpage.TabIndex = 12;
            this.la_lastpage.Text = "上一页";
            this.la_lastpage.Click += new System.EventHandler(this.la_lastpage_Click);
            // 
            // la_nextpage
            // 
            this.la_nextpage.AutoSize = true;
            this.la_nextpage.Location = new System.Drawing.Point(322, 237);
            this.la_nextpage.Name = "la_nextpage";
            this.la_nextpage.Size = new System.Drawing.Size(41, 12);
            this.la_nextpage.TabIndex = 11;
            this.la_nextpage.Text = "下一页";
            this.la_nextpage.Click += new System.EventHandler(this.la_nextpage_Click);
            // 
            // la_endpage
            // 
            this.la_endpage.AutoSize = true;
            this.la_endpage.Location = new System.Drawing.Point(422, 237);
            this.la_endpage.Name = "la_endpage";
            this.la_endpage.Size = new System.Drawing.Size(29, 12);
            this.la_endpage.TabIndex = 13;
            this.la_endpage.Text = "尾页";
            this.la_endpage.Click += new System.EventHandler(this.la_endpage_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("华文中宋", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(185, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 23);
            this.label4.TabIndex = 14;
            this.label4.Text = "维护界面";
            // 
            // tb_url
            // 
            this.tb_url.Location = new System.Drawing.Point(122, 43);
            this.tb_url.Name = "tb_url";
            this.tb_url.Size = new System.Drawing.Size(100, 21);
            this.tb_url.TabIndex = 16;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(63, 46);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 12);
            this.label5.TabIndex = 15;
            this.label5.Text = "物理路径";
            // 
            // bn_c
            // 
            this.bn_c.Location = new System.Drawing.Point(240, 41);
            this.bn_c.Name = "bn_c";
            this.bn_c.Size = new System.Drawing.Size(75, 23);
            this.bn_c.TabIndex = 17;
            this.bn_c.Text = "查询";
            this.bn_c.UseVisualStyleBackColor = true;
            this.bn_c.Click += new System.EventHandler(this.bn_c_Click);
            // 
            // bn_up
            // 
            this.bn_up.Location = new System.Drawing.Point(341, 41);
            this.bn_up.Name = "bn_up";
            this.bn_up.Size = new System.Drawing.Size(75, 23);
            this.bn_up.TabIndex = 18;
            this.bn_up.Text = "刷新";
            this.bn_up.UseVisualStyleBackColor = true;
            this.bn_up.Click += new System.EventHandler(this.bn_up_Click);
            // 
            // tb_num
            // 
            this.tb_num.Location = new System.Drawing.Point(402, 277);
            this.tb_num.Name = "tb_num";
            this.tb_num.Size = new System.Drawing.Size(100, 21);
            this.tb_num.TabIndex = 20;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(376, 280);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 12);
            this.label6.TabIndex = 19;
            this.label6.Text = "数量";
            // 
            // Maintain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(541, 379);
            this.Controls.Add(this.tb_num);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.bn_up);
            this.Controls.Add(this.bn_c);
            this.Controls.Add(this.tb_url);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.la_endpage);
            this.Controls.Add(this.la_lastpage);
            this.Controls.Add(this.la_nextpage);
            this.Controls.Add(this.la_fri);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.bn_return);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Maintain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Maintain";
            this.Deactivate += new System.EventHandler(this.Maintain_Deactivate);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Maintain_FormClosing);
            this.Load += new System.EventHandler(this.Maintain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.CS_remove.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button bn_return;
        private System.Windows.Forms.ContextMenuStrip CS_remove;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label la_fri;
        private System.Windows.Forms.Label la_lastpage;
        private System.Windows.Forms.Label la_nextpage;
        private System.Windows.Forms.Label la_endpage;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tb_url;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button bn_c;
        private System.Windows.Forms.Button bn_up;
        private System.Windows.Forms.TextBox tb_num;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridViewTextBoxColumn S_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn PhysicalPath;
        private System.Windows.Forms.DataGridViewTextBoxColumn DeviceID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Num;
    }
}