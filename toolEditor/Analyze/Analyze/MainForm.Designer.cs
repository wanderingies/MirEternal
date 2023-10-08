namespace Analyze
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            menuStrip = new MenuStrip();
            文件ToolStripMenuItem = new ToolStripMenuItem();
            编辑ToolStripMenuItem = new ToolStripMenuItem();
            视图ToolStripMenuItem = new ToolStripMenuItem();
            捕获ToolStripMenuItem = new ToolStripMenuItem();
            设备ToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator1 = new ToolStripSeparator();
            分析ToolStripMenuItem = new ToolStripMenuItem();
            分析器ToolStripMenuItem = new ToolStripMenuItem();
            十六进制分析器ToolStripMenuItem = new ToolStripMenuItem();
            工具ToolStripMenuItem = new ToolStripMenuItem();
            帮助ToolStripMenuItem = new ToolStripMenuItem();
            帮助ToolStripMenuItem1 = new ToolStripMenuItem();
            toolStripSeparator2 = new ToolStripSeparator();
            关于ToolStripMenuItem = new ToolStripMenuItem();
            groupBox1 = new GroupBox();
            checkedListBox = new CheckedListBox();
            groupBox5 = new GroupBox();
            toolStrip1 = new ToolStrip();
            toolStripButtonStart = new ToolStripButton();
            toolStripButtonPause = new ToolStripButton();
            toolStripButtonStop = new ToolStripButton();
            toolStripButtonAdd = new ToolStripButton();
            toolStripButtonMoney = new ToolStripButton();
            groupBox4 = new GroupBox();
            conditionAdd = new CheckBox();
            conditionRegular = new CheckBox();
            conditionOther = new TextBox();
            conditionServer = new CheckBox();
            conditionClient = new CheckBox();
            textBox4 = new TextBox();
            label3 = new Label();
            textBox3 = new TextBox();
            label2 = new Label();
            textBox1 = new TextBox();
            button1 = new Button();
            groupBox2 = new GroupBox();
            label1 = new Label();
            radioButton2 = new RadioButton();
            radioButton1 = new RadioButton();
            groupBox3 = new GroupBox();
            listBoxData = new ListBox();
            textBox2 = new TextBox();
            打开文件ToolStripMenuItem = new ToolStripMenuItem();
            保存文件ToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator3 = new ToolStripSeparator();
            导出文件ToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator4 = new ToolStripSeparator();
            退出ToolStripMenuItem = new ToolStripMenuItem();
            menuStrip.SuspendLayout();
            groupBox1.SuspendLayout();
            groupBox5.SuspendLayout();
            toolStrip1.SuspendLayout();
            groupBox4.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip
            // 
            menuStrip.Items.AddRange(new ToolStripItem[] { 文件ToolStripMenuItem, 编辑ToolStripMenuItem, 视图ToolStripMenuItem, 捕获ToolStripMenuItem, 分析ToolStripMenuItem, 工具ToolStripMenuItem, 帮助ToolStripMenuItem });
            menuStrip.Location = new Point(0, 0);
            menuStrip.Name = "menuStrip";
            menuStrip.Size = new Size(800, 25);
            menuStrip.TabIndex = 0;
            menuStrip.Text = "menuStrip1";
            // 
            // 文件ToolStripMenuItem
            // 
            文件ToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { 打开文件ToolStripMenuItem, 保存文件ToolStripMenuItem, toolStripSeparator3, 导出文件ToolStripMenuItem, toolStripSeparator4, 退出ToolStripMenuItem });
            文件ToolStripMenuItem.Name = "文件ToolStripMenuItem";
            文件ToolStripMenuItem.Size = new Size(44, 21);
            文件ToolStripMenuItem.Text = "文件";
            // 
            // 编辑ToolStripMenuItem
            // 
            编辑ToolStripMenuItem.Name = "编辑ToolStripMenuItem";
            编辑ToolStripMenuItem.Size = new Size(44, 21);
            编辑ToolStripMenuItem.Text = "编辑";
            // 
            // 视图ToolStripMenuItem
            // 
            视图ToolStripMenuItem.Name = "视图ToolStripMenuItem";
            视图ToolStripMenuItem.Size = new Size(44, 21);
            视图ToolStripMenuItem.Text = "视图";
            // 
            // 捕获ToolStripMenuItem
            // 
            捕获ToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { 设备ToolStripMenuItem, toolStripSeparator1 });
            捕获ToolStripMenuItem.Name = "捕获ToolStripMenuItem";
            捕获ToolStripMenuItem.Size = new Size(44, 21);
            捕获ToolStripMenuItem.Text = "捕获";
            // 
            // 设备ToolStripMenuItem
            // 
            设备ToolStripMenuItem.Enabled = false;
            设备ToolStripMenuItem.Font = new Font("Microsoft YaHei UI", 8F, FontStyle.Italic, GraphicsUnit.Point);
            设备ToolStripMenuItem.Name = "设备ToolStripMenuItem";
            设备ToolStripMenuItem.Size = new Size(180, 22);
            设备ToolStripMenuItem.Text = "设备";
            设备ToolStripMenuItem.TextImageRelation = TextImageRelation.TextBeforeImage;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(177, 6);
            // 
            // 分析ToolStripMenuItem
            // 
            分析ToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { 分析器ToolStripMenuItem, 十六进制分析器ToolStripMenuItem });
            分析ToolStripMenuItem.Name = "分析ToolStripMenuItem";
            分析ToolStripMenuItem.Size = new Size(44, 21);
            分析ToolStripMenuItem.Text = "分析";
            // 
            // 分析器ToolStripMenuItem
            // 
            分析器ToolStripMenuItem.Name = "分析器ToolStripMenuItem";
            分析器ToolStripMenuItem.Size = new Size(180, 22);
            分析器ToolStripMenuItem.Text = "协议分析器";
            // 
            // 十六进制分析器ToolStripMenuItem
            // 
            十六进制分析器ToolStripMenuItem.Name = "十六进制分析器ToolStripMenuItem";
            十六进制分析器ToolStripMenuItem.Size = new Size(180, 22);
            十六进制分析器ToolStripMenuItem.Text = "十六进制分析器";
            // 
            // 工具ToolStripMenuItem
            // 
            工具ToolStripMenuItem.Name = "工具ToolStripMenuItem";
            工具ToolStripMenuItem.Size = new Size(44, 21);
            工具ToolStripMenuItem.Text = "工具";
            // 
            // 帮助ToolStripMenuItem
            // 
            帮助ToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { 帮助ToolStripMenuItem1, toolStripSeparator2, 关于ToolStripMenuItem });
            帮助ToolStripMenuItem.Name = "帮助ToolStripMenuItem";
            帮助ToolStripMenuItem.Size = new Size(44, 21);
            帮助ToolStripMenuItem.Text = "帮助";
            // 
            // 帮助ToolStripMenuItem1
            // 
            帮助ToolStripMenuItem1.Name = "帮助ToolStripMenuItem1";
            帮助ToolStripMenuItem1.Size = new Size(180, 22);
            帮助ToolStripMenuItem1.Text = "帮助";
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(177, 6);
            // 
            // 关于ToolStripMenuItem
            // 
            关于ToolStripMenuItem.Name = "关于ToolStripMenuItem";
            关于ToolStripMenuItem.Size = new Size(180, 22);
            关于ToolStripMenuItem.Text = "关于";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(checkedListBox);
            groupBox1.Controls.Add(groupBox5);
            groupBox1.Controls.Add(groupBox4);
            groupBox1.Controls.Add(textBox4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(textBox3);
            groupBox1.Controls.Add(label2);
            groupBox1.Location = new Point(12, 28);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(200, 410);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "筛选";
            // 
            // checkedListBox
            // 
            checkedListBox.FormattingEnabled = true;
            checkedListBox.Location = new Point(5, 255);
            checkedListBox.Name = "checkedListBox";
            checkedListBox.Size = new Size(188, 148);
            checkedListBox.TabIndex = 6;
            // 
            // groupBox5
            // 
            groupBox5.Controls.Add(toolStrip1);
            groupBox5.Location = new Point(6, 81);
            groupBox5.Name = "groupBox5";
            groupBox5.Size = new Size(188, 64);
            groupBox5.TabIndex = 5;
            groupBox5.TabStop = false;
            groupBox5.Text = "捕获控制";
            // 
            // toolStrip1
            // 
            toolStrip1.BackColor = Color.Transparent;
            toolStrip1.Dock = DockStyle.None;
            toolStrip1.GripStyle = ToolStripGripStyle.Hidden;
            toolStrip1.ImageScalingSize = new Size(32, 32);
            toolStrip1.Items.AddRange(new ToolStripItem[] { toolStripButtonStart, toolStripButtonPause, toolStripButtonStop, toolStripButtonAdd, toolStripButtonMoney });
            toolStrip1.Location = new Point(4, 18);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(183, 39);
            toolStrip1.TabIndex = 6;
            toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButtonStart
            // 
            toolStripButtonStart.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButtonStart.Image = Properties.Resources.start;
            toolStripButtonStart.ImageTransparentColor = Color.Magenta;
            toolStripButtonStart.Name = "toolStripButtonStart";
            toolStripButtonStart.Size = new Size(36, 36);
            toolStripButtonStart.Text = "开始捕获";
            // 
            // toolStripButtonPause
            // 
            toolStripButtonPause.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButtonPause.Image = Properties.Resources.pause;
            toolStripButtonPause.ImageTransparentColor = Color.Magenta;
            toolStripButtonPause.Name = "toolStripButtonPause";
            toolStripButtonPause.Size = new Size(36, 36);
            toolStripButtonPause.Text = "暂停捕获";
            // 
            // toolStripButtonStop
            // 
            toolStripButtonStop.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButtonStop.Image = Properties.Resources.stop;
            toolStripButtonStop.ImageTransparentColor = Color.Magenta;
            toolStripButtonStop.Name = "toolStripButtonStop";
            toolStripButtonStop.Size = new Size(36, 36);
            toolStripButtonStop.Text = "停止捕获";
            // 
            // toolStripButtonAdd
            // 
            toolStripButtonAdd.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButtonAdd.Image = Properties.Resources.add;
            toolStripButtonAdd.ImageTransparentColor = Color.Magenta;
            toolStripButtonAdd.Name = "toolStripButtonAdd";
            toolStripButtonAdd.Size = new Size(36, 36);
            toolStripButtonAdd.Text = "添加协议识别";
            // 
            // toolStripButtonMoney
            // 
            toolStripButtonMoney.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButtonMoney.Image = Properties.Resources.money;
            toolStripButtonMoney.ImageTransparentColor = Color.Magenta;
            toolStripButtonMoney.Name = "toolStripButtonMoney";
            toolStripButtonMoney.Size = new Size(36, 36);
            toolStripButtonMoney.Text = "使用次数";
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(conditionAdd);
            groupBox4.Controls.Add(conditionRegular);
            groupBox4.Controls.Add(conditionOther);
            groupBox4.Controls.Add(conditionServer);
            groupBox4.Controls.Add(conditionClient);
            groupBox4.Location = new Point(6, 151);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(188, 98);
            groupBox4.TabIndex = 4;
            groupBox4.TabStop = false;
            groupBox4.Text = "捕获条件";
            // 
            // conditionAdd
            // 
            conditionAdd.AutoSize = true;
            conditionAdd.ForeColor = SystemColors.ControlDarkDark;
            conditionAdd.Location = new Point(6, 42);
            conditionAdd.Name = "conditionAdd";
            conditionAdd.Size = new Size(75, 21);
            conditionAdd.TabIndex = 6;
            conditionAdd.Text = "补充条件";
            conditionAdd.UseVisualStyleBackColor = true;
            // 
            // conditionRegular
            // 
            conditionRegular.AutoSize = true;
            conditionRegular.ForeColor = SystemColors.ControlDarkDark;
            conditionRegular.Location = new Point(97, 42);
            conditionRegular.Name = "conditionRegular";
            conditionRegular.Size = new Size(87, 21);
            conditionRegular.TabIndex = 6;
            conditionRegular.Text = "正则表达式";
            conditionRegular.UseVisualStyleBackColor = true;
            // 
            // conditionOther
            // 
            conditionOther.BackColor = SystemColors.ButtonHighlight;
            conditionOther.Location = new Point(6, 69);
            conditionOther.Name = "conditionOther";
            conditionOther.Size = new Size(176, 23);
            conditionOther.TabIndex = 2;
            // 
            // conditionServer
            // 
            conditionServer.AutoSize = true;
            conditionServer.Checked = true;
            conditionServer.CheckState = CheckState.Checked;
            conditionServer.ForeColor = SystemColors.ControlDarkDark;
            conditionServer.Location = new Point(97, 19);
            conditionServer.Name = "conditionServer";
            conditionServer.Size = new Size(63, 21);
            conditionServer.TabIndex = 1;
            conditionServer.Text = "服务端";
            conditionServer.UseVisualStyleBackColor = true;
            // 
            // conditionClient
            // 
            conditionClient.AutoSize = true;
            conditionClient.Checked = true;
            conditionClient.CheckState = CheckState.Checked;
            conditionClient.ForeColor = SystemColors.ControlDarkDark;
            conditionClient.Location = new Point(6, 19);
            conditionClient.Name = "conditionClient";
            conditionClient.Size = new Size(63, 21);
            conditionClient.TabIndex = 0;
            conditionClient.Text = "客户端";
            conditionClient.UseVisualStyleBackColor = true;
            // 
            // textBox4
            // 
            textBox4.BackColor = SystemColors.ButtonHighlight;
            textBox4.Location = new Point(48, 52);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(140, 23);
            textBox4.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = SystemColors.ControlDarkDark;
            label3.Location = new Point(10, 55);
            label3.Name = "label3";
            label3.Size = new Size(32, 17);
            label3.TabIndex = 2;
            label3.Text = "地址";
            // 
            // textBox3
            // 
            textBox3.BackColor = SystemColors.ButtonHighlight;
            textBox3.Location = new Point(48, 23);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(140, 23);
            textBox3.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = SystemColors.ControlDarkDark;
            label2.Location = new Point(10, 26);
            label2.Name = "label2";
            label2.Size = new Size(32, 17);
            label2.TabIndex = 0;
            label2.Text = "端口";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(6, 49);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(477, 23);
            textBox1.TabIndex = 2;
            // 
            // button1
            // 
            button1.Location = new Point(489, 49);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 3;
            button1.Text = "发送";
            button1.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(label1);
            groupBox2.Controls.Add(radioButton2);
            groupBox2.Controls.Add(radioButton1);
            groupBox2.Controls.Add(textBox1);
            groupBox2.Controls.Add(button1);
            groupBox2.Location = new Point(218, 356);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(570, 82);
            groupBox2.TabIndex = 4;
            groupBox2.TabStop = false;
            groupBox2.Text = "调试";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Green;
            label1.BorderStyle = BorderStyle.FixedSingle;
            label1.Cursor = Cursors.Hand;
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(423, 23);
            label1.Name = "label1";
            label1.Size = new Size(58, 19);
            label1.TabIndex = 6;
            label1.Text = "数据生成";
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.ForeColor = SystemColors.ControlDarkDark;
            radioButton2.Location = new Point(77, 22);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(62, 21);
            radioButton2.TabIndex = 5;
            radioButton2.Text = "服务端";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Checked = true;
            radioButton1.ForeColor = SystemColors.ControlDarkDark;
            radioButton1.Location = new Point(9, 22);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(62, 21);
            radioButton1.TabIndex = 4;
            radioButton1.TabStop = true;
            radioButton1.Text = "客户端";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(listBoxData);
            groupBox3.Location = new Point(218, 28);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(570, 245);
            groupBox3.TabIndex = 6;
            groupBox3.TabStop = false;
            // 
            // listBoxData
            // 
            listBoxData.BackColor = SystemColors.Control;
            listBoxData.BorderStyle = BorderStyle.None;
            listBoxData.FormattingEnabled = true;
            listBoxData.ItemHeight = 17;
            listBoxData.Location = new Point(3, 13);
            listBoxData.Name = "listBoxData";
            listBoxData.Size = new Size(564, 221);
            listBoxData.TabIndex = 0;
            // 
            // textBox2
            // 
            textBox2.BackColor = SystemColors.ButtonHighlight;
            textBox2.Location = new Point(219, 279);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.ScrollBars = ScrollBars.Both;
            textBox2.Size = new Size(569, 71);
            textBox2.TabIndex = 7;
            // 
            // 打开文件ToolStripMenuItem
            // 
            打开文件ToolStripMenuItem.Name = "打开文件ToolStripMenuItem";
            打开文件ToolStripMenuItem.Size = new Size(180, 22);
            打开文件ToolStripMenuItem.Text = "打开文件";
            // 
            // 保存文件ToolStripMenuItem
            // 
            保存文件ToolStripMenuItem.Name = "保存文件ToolStripMenuItem";
            保存文件ToolStripMenuItem.Size = new Size(180, 22);
            保存文件ToolStripMenuItem.Text = "保存文件";
            // 
            // toolStripSeparator3
            // 
            toolStripSeparator3.Name = "toolStripSeparator3";
            toolStripSeparator3.Size = new Size(177, 6);
            // 
            // 导出文件ToolStripMenuItem
            // 
            导出文件ToolStripMenuItem.Name = "导出文件ToolStripMenuItem";
            导出文件ToolStripMenuItem.Size = new Size(180, 22);
            导出文件ToolStripMenuItem.Text = "导出文件";
            // 
            // toolStripSeparator4
            // 
            toolStripSeparator4.Name = "toolStripSeparator4";
            toolStripSeparator4.Size = new Size(177, 6);
            // 
            // 退出ToolStripMenuItem
            // 
            退出ToolStripMenuItem.Name = "退出ToolStripMenuItem";
            退出ToolStripMenuItem.Size = new Size(180, 22);
            退出ToolStripMenuItem.Text = "退出";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(textBox2);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(menuStrip);
            MainMenuStrip = menuStrip;
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "数据捕获&分析";
            menuStrip.ResumeLayout(false);
            menuStrip.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox5.ResumeLayout(false);
            groupBox5.PerformLayout();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip;
        private ToolStripMenuItem 文件ToolStripMenuItem;
        private ToolStripMenuItem 编辑ToolStripMenuItem;
        private GroupBox groupBox1;
        private TextBox textBox1;
        private Button button1;
        private GroupBox groupBox2;
        private ToolStripMenuItem 视图ToolStripMenuItem;
        private ToolStripMenuItem 捕获ToolStripMenuItem;
        private ToolStripMenuItem 分析ToolStripMenuItem;
        private ToolStripMenuItem 工具ToolStripMenuItem;
        private ToolStripMenuItem 帮助ToolStripMenuItem;
        private RadioButton radioButton2;
        private RadioButton radioButton1;
        private Label label1;
        private GroupBox groupBox3;
        private TextBox textBox2;
        private ToolStripMenuItem 设备ToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator1;
        private TextBox textBox4;
        private Label label3;
        private TextBox textBox3;
        private Label label2;
        private GroupBox groupBox4;
        private CheckBox conditionServer;
        private CheckBox conditionClient;
        private ToolStripMenuItem 分析器ToolStripMenuItem;
        private ToolStripMenuItem 十六进制分析器ToolStripMenuItem;
        private GroupBox groupBox5;
        private ToolStrip toolStrip1;
        private ToolStripButton toolStripButtonStart;
        private ToolStripButton toolStripButtonPause;
        private ToolStripButton toolStripButtonStop;
        private ToolStripButton toolStripButtonAdd;
        private ToolStripButton toolStripButtonMoney;
        private CheckBox conditionRegular;
        private TextBox conditionOther;
        private CheckBox conditionAdd;
        private ListBox listBoxData;
        private CheckedListBox checkedListBox;
        private ToolStripMenuItem 帮助ToolStripMenuItem1;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripMenuItem 关于ToolStripMenuItem;
        private ToolStripMenuItem 打开文件ToolStripMenuItem;
        private ToolStripMenuItem 保存文件ToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator3;
        private ToolStripMenuItem 导出文件ToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator4;
        private ToolStripMenuItem 退出ToolStripMenuItem;
    }
}