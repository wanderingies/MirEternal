namespace PacketEditor
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
            _checkedListBox = new CheckedListBox();
            propertyGrid = new PropertyGrid();
            _addProtocol = new Button();
            _saveProtocol = new Button();
            _exportProtocol = new Button();
            _deleteProtocol = new Button();
            statusStrip1 = new StatusStrip();
            toolStripStatusLabel1 = new ToolStripStatusLabel();
            _inputProtocol = new Button();
            statusStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // _checkedListBox
            // 
            _checkedListBox.FormattingEnabled = true;
            _checkedListBox.Location = new Point(12, 12);
            _checkedListBox.Name = "_checkedListBox";
            _checkedListBox.Size = new Size(240, 400);
            _checkedListBox.TabIndex = 0;
            // 
            // propertyGrid
            // 
            propertyGrid.Location = new Point(258, 12);
            propertyGrid.Name = "propertyGrid";
            propertyGrid.Size = new Size(530, 400);
            propertyGrid.TabIndex = 1;
            // 
            // _addProtocol
            // 
            _addProtocol.Location = new Point(389, 9);
            _addProtocol.Name = "_addProtocol";
            _addProtocol.Size = new Size(75, 23);
            _addProtocol.TabIndex = 2;
            _addProtocol.Text = "添加";
            _addProtocol.UseVisualStyleBackColor = true;
            // 
            // _saveProtocol
            // 
            _saveProtocol.Location = new Point(470, 9);
            _saveProtocol.Name = "_saveProtocol";
            _saveProtocol.Size = new Size(75, 23);
            _saveProtocol.TabIndex = 3;
            _saveProtocol.Text = "保存";
            _saveProtocol.UseVisualStyleBackColor = true;
            // 
            // _exportProtocol
            // 
            _exportProtocol.Location = new Point(632, 9);
            _exportProtocol.Name = "_exportProtocol";
            _exportProtocol.Size = new Size(75, 23);
            _exportProtocol.TabIndex = 4;
            _exportProtocol.Text = "导出";
            _exportProtocol.UseVisualStyleBackColor = true;
            // 
            // _deleteProtocol
            // 
            _deleteProtocol.Location = new Point(713, 9);
            _deleteProtocol.Name = "_deleteProtocol";
            _deleteProtocol.Size = new Size(75, 23);
            _deleteProtocol.TabIndex = 5;
            _deleteProtocol.Text = "导出列表";
            _deleteProtocol.UseVisualStyleBackColor = true;
            // 
            // statusStrip1
            // 
            statusStrip1.Items.AddRange(new ToolStripItem[] { toolStripStatusLabel1 });
            statusStrip1.Location = new Point(0, 428);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(800, 22);
            statusStrip1.TabIndex = 6;
            statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            toolStripStatusLabel1.Size = new Size(32, 17);
            toolStripStatusLabel1.Text = "统计";
            // 
            // _inputProtocol
            // 
            _inputProtocol.Location = new Point(551, 9);
            _inputProtocol.Name = "_inputProtocol";
            _inputProtocol.Size = new Size(75, 23);
            _inputProtocol.TabIndex = 7;
            _inputProtocol.Text = "导入";
            _inputProtocol.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(_inputProtocol);
            Controls.Add(statusStrip1);
            Controls.Add(_deleteProtocol);
            Controls.Add(_exportProtocol);
            Controls.Add(_saveProtocol);
            Controls.Add(_addProtocol);
            Controls.Add(propertyGrid);
            Controls.Add(_checkedListBox);
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "协议编辑器";
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private CheckedListBox _checkedListBox;
        private PropertyGrid propertyGrid;
        private Button _addProtocol;
        private Button _saveProtocol;
        private Button _exportProtocol;
        private Button _deleteProtocol;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel toolStripStatusLabel1;
        private Button _inputProtocol;
    }
}