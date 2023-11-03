namespace SoundRecorder
{
    partial class Form1
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
            components = new System.ComponentModel.Container();
            statusStrip1 = new StatusStrip();
            toolStripStatusLabel1 = new ToolStripStatusLabel();
            menuStrip1 = new MenuStrip();
            settingToolStripMenuItem = new ToolStripMenuItem();
            splitContainer1 = new SplitContainer();
            button_StopRecord = new Button();
            button_StartRecord = new Button();
            groupBox1 = new GroupBox();
            radioButton_SaveAsFile = new RadioButton();
            radioButton_SaveAsChipBoard = new RadioButton();
            saveFileDialog1 = new SaveFileDialog();
            timer1 = new System.Windows.Forms.Timer(components);
            statusStrip1.SuspendLayout();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // statusStrip1
            // 
            statusStrip1.Items.AddRange(new ToolStripItem[] { toolStripStatusLabel1 });
            statusStrip1.Location = new Point(0, 183);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(605, 22);
            statusStrip1.TabIndex = 0;
            // 
            // toolStripStatusLabel1
            // 
            toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            toolStripStatusLabel1.Size = new Size(32, 17);
            toolStripStatusLabel1.Text = "空闲";
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { settingToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(605, 25);
            menuStrip1.TabIndex = 3;
            menuStrip1.Text = "menuStrip1";
            // 
            // settingToolStripMenuItem
            // 
            settingToolStripMenuItem.Name = "settingToolStripMenuItem";
            settingToolStripMenuItem.Size = new Size(44, 21);
            settingToolStripMenuItem.Text = "设置";
            settingToolStripMenuItem.Click += settingToolStripMenuItem_Click;
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(0, 25);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(button_StopRecord);
            splitContainer1.Panel1.Controls.Add(button_StartRecord);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(groupBox1);
            splitContainer1.Size = new Size(605, 158);
            splitContainer1.SplitterDistance = 447;
            splitContainer1.TabIndex = 4;
            // 
            // button_StopRecord
            // 
            button_StopRecord.Location = new Point(224, 62);
            button_StopRecord.Name = "button_StopRecord";
            button_StopRecord.Size = new Size(75, 23);
            button_StopRecord.TabIndex = 1;
            button_StopRecord.Text = "停止录制";
            button_StopRecord.UseVisualStyleBackColor = true;
            button_StopRecord.Click += button_StopRecord_Click;
            // 
            // button_StartRecord
            // 
            button_StartRecord.Location = new Point(78, 62);
            button_StartRecord.Name = "button_StartRecord";
            button_StartRecord.Size = new Size(75, 23);
            button_StartRecord.TabIndex = 0;
            button_StartRecord.Text = "开始录制";
            button_StartRecord.UseVisualStyleBackColor = true;
            button_StartRecord.Click += button_StartRecord_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(radioButton_SaveAsFile);
            groupBox1.Controls.Add(radioButton_SaveAsChipBoard);
            groupBox1.Dock = DockStyle.Fill;
            groupBox1.Location = new Point(0, 0);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(154, 158);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "保存到";
            // 
            // radioButton_SaveAsFile
            // 
            radioButton_SaveAsFile.AutoSize = true;
            radioButton_SaveAsFile.Location = new Point(37, 64);
            radioButton_SaveAsFile.Name = "radioButton_SaveAsFile";
            radioButton_SaveAsFile.Size = new Size(50, 21);
            radioButton_SaveAsFile.TabIndex = 2;
            radioButton_SaveAsFile.TabStop = true;
            radioButton_SaveAsFile.Text = "文件";
            radioButton_SaveAsFile.UseVisualStyleBackColor = true;
            radioButton_SaveAsFile.CheckedChanged += radioButton2_CheckedChanged;
            // 
            // radioButton_SaveAsChipBoard
            // 
            radioButton_SaveAsChipBoard.AutoSize = true;
            radioButton_SaveAsChipBoard.Location = new Point(37, 37);
            radioButton_SaveAsChipBoard.Name = "radioButton_SaveAsChipBoard";
            radioButton_SaveAsChipBoard.Size = new Size(62, 21);
            radioButton_SaveAsChipBoard.TabIndex = 1;
            radioButton_SaveAsChipBoard.TabStop = true;
            radioButton_SaveAsChipBoard.Text = "剪贴板";
            radioButton_SaveAsChipBoard.UseVisualStyleBackColor = true;
            radioButton_SaveAsChipBoard.MouseClick += radioButton_SaveAsChipBoard_MouseClick;
            // 
            // timer1
            // 
            timer1.Interval = 1000;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(605, 205);
            Controls.Add(splitContainer1);
            Controls.Add(statusStrip1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "录音机";
            Load += Form1_Load;
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private StatusStrip statusStrip1;
        private ToolStripStatusLabel toolStripStatusLabel1;
        private MenuStrip menuStrip1;
        private SplitContainer splitContainer1;
        private Button button_StopRecord;
        private Button button_StartRecord;
        private GroupBox groupBox1;
        private RadioButton radioButton_SaveAsFile;
        private RadioButton radioButton_SaveAsChipBoard;
        private SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Timer timer1;
        private ToolStripMenuItem settingToolStripMenuItem;
    }
}