namespace Utility
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
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            groupBox3 = new GroupBox();
            oubutton2 = new Button();
            textBox6 = new TextBox();
            textBox5 = new TextBox();
            m_button3 = new Button();
            inbutton2 = new Button();
            groupBox2 = new GroupBox();
            oubutton1 = new Button();
            textBox4 = new TextBox();
            inbutton1 = new Button();
            textBox3 = new TextBox();
            m_button2 = new Button();
            groupBox1 = new GroupBox();
            outextBox = new TextBox();
            m_button1 = new Button();
            intextBox = new TextBox();
            tabPage2 = new TabPage();
            tabPage3 = new TabPage();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(0, 0);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(800, 450);
            tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(groupBox3);
            tabPage1.Controls.Add(groupBox2);
            tabPage1.Controls.Add(groupBox1);
            tabPage1.Location = new Point(4, 26);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(792, 420);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "加解密";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(oubutton2);
            groupBox3.Controls.Add(textBox6);
            groupBox3.Controls.Add(textBox5);
            groupBox3.Controls.Add(m_button3);
            groupBox3.Controls.Add(inbutton2);
            groupBox3.Location = new Point(8, 165);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(776, 62);
            groupBox3.TabIndex = 2;
            groupBox3.TabStop = false;
            groupBox3.Text = "批量";
            // 
            // oubutton2
            // 
            oubutton2.Location = new Point(587, 22);
            oubutton2.Name = "oubutton2";
            oubutton2.Size = new Size(75, 23);
            oubutton2.TabIndex = 9;
            oubutton2.Text = "输出";
            oubutton2.UseVisualStyleBackColor = true;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(14, 22);
            textBox6.Name = "textBox6";
            textBox6.ReadOnly = true;
            textBox6.Size = new Size(240, 23);
            textBox6.TabIndex = 6;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(341, 22);
            textBox5.Name = "textBox5";
            textBox5.ReadOnly = true;
            textBox5.Size = new Size(240, 23);
            textBox5.TabIndex = 8;
            // 
            // m_button3
            // 
            m_button3.Location = new Point(687, 22);
            m_button3.Name = "m_button3";
            m_button3.Size = new Size(75, 23);
            m_button3.TabIndex = 5;
            m_button3.Text = "加解密";
            m_button3.UseVisualStyleBackColor = true;
            // 
            // inbutton2
            // 
            inbutton2.Location = new Point(260, 22);
            inbutton2.Name = "inbutton2";
            inbutton2.Size = new Size(75, 23);
            inbutton2.TabIndex = 7;
            inbutton2.Text = "输入";
            inbutton2.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(oubutton1);
            groupBox2.Controls.Add(textBox4);
            groupBox2.Controls.Add(inbutton1);
            groupBox2.Controls.Add(textBox3);
            groupBox2.Controls.Add(m_button2);
            groupBox2.Location = new Point(8, 100);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(776, 59);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "文件";
            // 
            // oubutton1
            // 
            oubutton1.Location = new Point(587, 22);
            oubutton1.Name = "oubutton1";
            oubutton1.Size = new Size(75, 23);
            oubutton1.TabIndex = 4;
            oubutton1.Text = "输出";
            oubutton1.UseVisualStyleBackColor = true;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(341, 22);
            textBox4.Name = "textBox4";
            textBox4.ReadOnly = true;
            textBox4.Size = new Size(240, 23);
            textBox4.TabIndex = 3;
            // 
            // inbutton1
            // 
            inbutton1.Location = new Point(260, 22);
            inbutton1.Name = "inbutton1";
            inbutton1.Size = new Size(75, 23);
            inbutton1.TabIndex = 2;
            inbutton1.Text = "输入";
            inbutton1.UseVisualStyleBackColor = true;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(14, 22);
            textBox3.Name = "textBox3";
            textBox3.ReadOnly = true;
            textBox3.Size = new Size(240, 23);
            textBox3.TabIndex = 1;
            // 
            // m_button2
            // 
            m_button2.Location = new Point(687, 22);
            m_button2.Name = "m_button2";
            m_button2.Size = new Size(75, 23);
            m_button2.TabIndex = 0;
            m_button2.Text = "加解密";
            m_button2.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(outextBox);
            groupBox1.Controls.Add(m_button1);
            groupBox1.Controls.Add(intextBox);
            groupBox1.Location = new Point(8, 6);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(776, 88);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "字串";
            // 
            // outextBox
            // 
            outextBox.Location = new Point(14, 51);
            outextBox.Name = "outextBox";
            outextBox.ReadOnly = true;
            outextBox.Size = new Size(748, 23);
            outextBox.TabIndex = 2;
            // 
            // m_button1
            // 
            m_button1.Location = new Point(687, 22);
            m_button1.Name = "m_button1";
            m_button1.Size = new Size(75, 23);
            m_button1.TabIndex = 1;
            m_button1.Text = "加解密";
            m_button1.UseVisualStyleBackColor = true;
            // 
            // intextBox
            // 
            intextBox.Location = new Point(14, 22);
            intextBox.Name = "intextBox";
            intextBox.Size = new Size(667, 23);
            intextBox.TabIndex = 0;
            // 
            // tabPage2
            // 
            tabPage2.Location = new Point(4, 26);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(792, 420);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "坐标";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            tabPage3.Location = new Point(4, 26);
            tabPage3.Name = "tabPage3";
            tabPage3.Size = new Size(792, 420);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "时间";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tabControl1);
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "通用工具";
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private GroupBox groupBox1;
        private Button m_button1;
        private TextBox intextBox;
        private TextBox outextBox;
        private GroupBox groupBox2;
        private Button oubutton1;
        private TextBox textBox4;
        private Button inbutton1;
        private TextBox textBox3;
        private Button m_button2;
        private GroupBox groupBox3;
        private Button oubutton2;
        private TextBox textBox6;
        private TextBox textBox5;
        private Button m_button3;
        private Button inbutton2;
        private TabPage tabPage3;
    }
}