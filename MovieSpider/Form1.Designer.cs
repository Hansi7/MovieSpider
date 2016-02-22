namespace MovieSpider
{
    partial class Form1
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
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.txt_PageNumber = new System.Windows.Forms.TextBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pb_Youku = new System.Windows.Forms.ProgressBar();
            this.lbl_youkuStatus = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_Tag = new System.Windows.Forms.TextBox();
            this.txt_pageNumberEnd = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_tudouCancle = new System.Windows.Forms.Button();
            this.lbl_tudou_page = new System.Windows.Forms.Label();
            this.pb_Tudou = new System.Windows.Forms.ProgressBar();
            this.lbl_tuDouStatus = new System.Windows.Forms.Label();
            this.txt_ResultTudou = new System.Windows.Forms.TextBox();
            this.cbType = new System.Windows.Forms.ComboBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txt_baoFengResult = new System.Windows.Forms.TextBox();
            this.btn_BaofengGOGOGOG = new System.Windows.Forms.Button();
            this.lbl_Baofeng = new System.Windows.Forms.Label();
            this.pb_Baofeng = new System.Windows.Forms.ProgressBar();
            this.txt_Baofeng = new System.Windows.Forms.TextBox();
            this.btn_Baofeng = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.statusStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(157, 51);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Youku!";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.Location = new System.Drawing.Point(16, 20);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(786, 25);
            this.textBox1.TabIndex = 2;
            this.textBox1.Text = "http://www.youku.com/v_olist/c_96_g__a_%E7%BE%8E%E5%9B%BD_sg__mt__lg__q__s_1_r_0_" +
                "u_0_pt_0_av_0_ag_0_sg__pr__h__d_1_p_###.html";
            this.textBox1.WordWrap = false;
            // 
            // textBox2
            // 
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox2.Location = new System.Drawing.Point(16, 95);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox2.Size = new System.Drawing.Size(786, 62);
            this.textBox2.TabIndex = 3;
            this.textBox2.WordWrap = false;
            // 
            // txt_PageNumber
            // 
            this.txt_PageNumber.Location = new System.Drawing.Point(64, 53);
            this.txt_PageNumber.Name = "txt_PageNumber";
            this.txt_PageNumber.Size = new System.Drawing.Size(27, 21);
            this.txt_PageNumber.TabIndex = 4;
            this.txt_PageNumber.Text = "1";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel2});
            this.statusStrip1.Location = new System.Drawing.Point(0, 377);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(897, 22);
            this.statusStrip1.TabIndex = 5;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(109, 17);
            this.toolStripStatusLabel2.Text = "Code By Shenjian";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 6;
            this.label1.Text = "页码";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(157, 17);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 7;
            this.button2.Text = "Tudou!";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(449, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 12);
            this.label2.TabIndex = 8;
            this.label2.Text = "使用###代替URL中的页码";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pb_Youku);
            this.groupBox1.Controls.Add(this.lbl_youkuStatus);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txt_Tag);
            this.groupBox1.Controls.Add(this.txt_pageNumberEnd);
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txt_PageNumber);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Location = new System.Drawing.Point(18, 22);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(820, 221);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "优酷";
            // 
            // pb_Youku
            // 
            this.pb_Youku.Location = new System.Drawing.Point(16, 175);
            this.pb_Youku.Name = "pb_Youku";
            this.pb_Youku.Size = new System.Drawing.Size(443, 23);
            this.pb_Youku.TabIndex = 14;
            // 
            // lbl_youkuStatus
            // 
            this.lbl_youkuStatus.AutoSize = true;
            this.lbl_youkuStatus.Location = new System.Drawing.Point(17, 160);
            this.lbl_youkuStatus.Name = "lbl_youkuStatus";
            this.lbl_youkuStatus.Size = new System.Drawing.Size(41, 12);
            this.lbl_youkuStatus.TabIndex = 13;
            this.lbl_youkuStatus.Text = "label4";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(97, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(11, 12);
            this.label3.TabIndex = 12;
            this.label3.Text = "-";
            // 
            // txt_Tag
            // 
            this.txt_Tag.Location = new System.Drawing.Point(677, 53);
            this.txt_Tag.Name = "txt_Tag";
            this.txt_Tag.Size = new System.Drawing.Size(119, 21);
            this.txt_Tag.TabIndex = 11;
            this.txt_Tag.Text = "美国电影";
            // 
            // txt_pageNumberEnd
            // 
            this.txt_pageNumberEnd.Location = new System.Drawing.Point(114, 53);
            this.txt_pageNumberEnd.Name = "txt_pageNumberEnd";
            this.txt_pageNumberEnd.Size = new System.Drawing.Size(37, 21);
            this.txt_pageNumberEnd.TabIndex = 10;
            this.txt_pageNumberEnd.Text = "29";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn_tudouCancle);
            this.groupBox2.Controls.Add(this.lbl_tudou_page);
            this.groupBox2.Controls.Add(this.pb_Tudou);
            this.groupBox2.Controls.Add(this.lbl_tuDouStatus);
            this.groupBox2.Controls.Add(this.txt_ResultTudou);
            this.groupBox2.Controls.Add(this.cbType);
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Location = new System.Drawing.Point(18, 19);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(828, 204);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "土豆";
            // 
            // btn_tudouCancle
            // 
            this.btn_tudouCancle.Location = new System.Drawing.Point(238, 17);
            this.btn_tudouCancle.Name = "btn_tudouCancle";
            this.btn_tudouCancle.Size = new System.Drawing.Size(75, 23);
            this.btn_tudouCancle.TabIndex = 16;
            this.btn_tudouCancle.Text = "停止！";
            this.btn_tudouCancle.UseVisualStyleBackColor = true;
            this.btn_tudouCancle.Click += new System.EventHandler(this.btn_tudouCancle_Click);
            // 
            // lbl_tudou_page
            // 
            this.lbl_tudou_page.AutoSize = true;
            this.lbl_tudou_page.Location = new System.Drawing.Point(465, 164);
            this.lbl_tudou_page.Name = "lbl_tudou_page";
            this.lbl_tudou_page.Size = new System.Drawing.Size(29, 12);
            this.lbl_tudou_page.TabIndex = 15;
            this.lbl_tudou_page.Text = "页码";
            // 
            // pb_Tudou
            // 
            this.pb_Tudou.Location = new System.Drawing.Point(16, 158);
            this.pb_Tudou.Name = "pb_Tudou";
            this.pb_Tudou.Size = new System.Drawing.Size(443, 23);
            this.pb_Tudou.TabIndex = 14;
            // 
            // lbl_tuDouStatus
            // 
            this.lbl_tuDouStatus.AutoSize = true;
            this.lbl_tuDouStatus.Location = new System.Drawing.Point(17, 143);
            this.lbl_tuDouStatus.Name = "lbl_tuDouStatus";
            this.lbl_tuDouStatus.Size = new System.Drawing.Size(41, 12);
            this.lbl_tuDouStatus.TabIndex = 13;
            this.lbl_tuDouStatus.Text = "label4";
            // 
            // txt_ResultTudou
            // 
            this.txt_ResultTudou.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_ResultTudou.Location = new System.Drawing.Point(16, 46);
            this.txt_ResultTudou.Multiline = true;
            this.txt_ResultTudou.Name = "txt_ResultTudou";
            this.txt_ResultTudou.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txt_ResultTudou.Size = new System.Drawing.Size(786, 92);
            this.txt_ResultTudou.TabIndex = 9;
            this.txt_ResultTudou.WordWrap = false;
            // 
            // cbType
            // 
            this.cbType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbType.FormattingEnabled = true;
            this.cbType.Location = new System.Drawing.Point(16, 19);
            this.cbType.Name = "cbType";
            this.cbType.Size = new System.Drawing.Size(135, 20);
            this.cbType.TabIndex = 8;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txt_baoFengResult);
            this.groupBox3.Controls.Add(this.btn_BaofengGOGOGOG);
            this.groupBox3.Controls.Add(this.lbl_Baofeng);
            this.groupBox3.Controls.Add(this.pb_Baofeng);
            this.groupBox3.Controls.Add(this.txt_Baofeng);
            this.groupBox3.Controls.Add(this.btn_Baofeng);
            this.groupBox3.Location = new System.Drawing.Point(6, 19);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(241, 182);
            this.groupBox3.TabIndex = 12;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "暴风";
            // 
            // txt_baoFengResult
            // 
            this.txt_baoFengResult.Location = new System.Drawing.Point(13, 124);
            this.txt_baoFengResult.Multiline = true;
            this.txt_baoFengResult.Name = "txt_baoFengResult";
            this.txt_baoFengResult.Size = new System.Drawing.Size(149, 41);
            this.txt_baoFengResult.TabIndex = 5;
            // 
            // btn_BaofengGOGOGOG
            // 
            this.btn_BaofengGOGOGOG.Location = new System.Drawing.Point(125, 47);
            this.btn_BaofengGOGOGOG.Name = "btn_BaofengGOGOGOG";
            this.btn_BaofengGOGOGOG.Size = new System.Drawing.Size(107, 23);
            this.btn_BaofengGOGOGOG.TabIndex = 4;
            this.btn_BaofengGOGOGOG.Text = "暴风 开始！";
            this.btn_BaofengGOGOGOG.UseVisualStyleBackColor = true;
            this.btn_BaofengGOGOGOG.Click += new System.EventHandler(this.btn_BaofengGOGOGOG_Click);
            // 
            // lbl_Baofeng
            // 
            this.lbl_Baofeng.AutoSize = true;
            this.lbl_Baofeng.Location = new System.Drawing.Point(14, 106);
            this.lbl_Baofeng.Name = "lbl_Baofeng";
            this.lbl_Baofeng.Size = new System.Drawing.Size(41, 12);
            this.lbl_Baofeng.TabIndex = 3;
            this.lbl_Baofeng.Text = "label4";
            // 
            // pb_Baofeng
            // 
            this.pb_Baofeng.Location = new System.Drawing.Point(13, 77);
            this.pb_Baofeng.Name = "pb_Baofeng";
            this.pb_Baofeng.Size = new System.Drawing.Size(219, 23);
            this.pb_Baofeng.TabIndex = 2;
            // 
            // txt_Baofeng
            // 
            this.txt_Baofeng.Location = new System.Drawing.Point(13, 20);
            this.txt_Baofeng.Name = "txt_Baofeng";
            this.txt_Baofeng.Size = new System.Drawing.Size(219, 21);
            this.txt_Baofeng.TabIndex = 1;
            // 
            // btn_Baofeng
            // 
            this.btn_Baofeng.Location = new System.Drawing.Point(13, 47);
            this.btn_Baofeng.Name = "btn_Baofeng";
            this.btn_Baofeng.Size = new System.Drawing.Size(107, 23);
            this.btn_Baofeng.TabIndex = 0;
            this.btn_Baofeng.Text = "列表获取";
            this.btn_Baofeng.UseVisualStyleBackColor = true;
            this.btn_Baofeng.Click += new System.EventHandler(this.btn_Baofeng_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(875, 348);
            this.tabControl1.TabIndex = 13;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(867, 322);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "优酷";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.groupBox2);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(867, 322);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "土豆";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.groupBox3);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(867, 322);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "暴风";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(897, 399);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.statusStrip1);
            this.Name = "Form1";
            this.Text = "优酷土豆电影库页面~爬爬虫~";
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox txt_PageNumber;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txt_pageNumberEnd;
        private System.Windows.Forms.TextBox txt_Tag;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cbType;
        private System.Windows.Forms.TextBox txt_ResultTudou;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ProgressBar pb_Youku;
        private System.Windows.Forms.Label lbl_youkuStatus;
        private System.Windows.Forms.ProgressBar pb_Tudou;
        private System.Windows.Forms.Label lbl_tuDouStatus;
        private System.Windows.Forms.Label lbl_tudou_page;
        private System.Windows.Forms.Button btn_tudouCancle;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label lbl_Baofeng;
        private System.Windows.Forms.ProgressBar pb_Baofeng;
        private System.Windows.Forms.TextBox txt_Baofeng;
        private System.Windows.Forms.Button btn_Baofeng;
        private System.Windows.Forms.Button btn_BaofengGOGOGOG;
        private System.Windows.Forms.TextBox txt_baoFengResult;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
    }
}

