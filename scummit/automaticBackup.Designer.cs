namespace scummit
{
    partial class automaticBackup
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
            this.file = new System.Windows.Forms.OpenFileDialog();
            this.folder = new System.Windows.Forms.FolderBrowserDialog();
            this.fileName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.chooseFile = new System.Windows.Forms.Button();
            this.chooseFolder = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.backupFolder = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.interval = new System.Windows.Forms.NumericUpDown();
            this.start = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.filesToKeep = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.backups = new System.Windows.Forms.ListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.restore = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.lastBackup = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.interval)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.filesToKeep)).BeginInit();
            this.SuspendLayout();
            // 
            // file
            // 
            this.file.FileName = "openFileDialog1";
            // 
            // fileName
            // 
            this.fileName.Location = new System.Drawing.Point(73, 9);
            this.fileName.Name = "fileName";
            this.fileName.Size = new System.Drawing.Size(367, 20);
            this.fileName.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Source";
            // 
            // chooseFile
            // 
            this.chooseFile.Location = new System.Drawing.Point(446, 7);
            this.chooseFile.Name = "chooseFile";
            this.chooseFile.Size = new System.Drawing.Size(75, 23);
            this.chooseFile.TabIndex = 2;
            this.chooseFile.Text = "Choose...";
            this.chooseFile.UseVisualStyleBackColor = true;
            this.chooseFile.Click += new System.EventHandler(this.chooseFile_Click);
            // 
            // chooseFolder
            // 
            this.chooseFolder.Location = new System.Drawing.Point(446, 33);
            this.chooseFolder.Name = "chooseFolder";
            this.chooseFolder.Size = new System.Drawing.Size(75, 23);
            this.chooseFolder.TabIndex = 5;
            this.chooseFolder.Text = "Choose...";
            this.chooseFolder.UseVisualStyleBackColor = true;
            this.chooseFolder.Click += new System.EventHandler(this.chooseFolder_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Destination";
            // 
            // backupFolder
            // 
            this.backupFolder.Location = new System.Drawing.Point(73, 35);
            this.backupFolder.Name = "backupFolder";
            this.backupFolder.Size = new System.Drawing.Size(367, 20);
            this.backupFolder.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Interval (m)";
            // 
            // interval
            // 
            this.interval.Location = new System.Drawing.Point(73, 65);
            this.interval.Name = "interval";
            this.interval.Size = new System.Drawing.Size(120, 20);
            this.interval.TabIndex = 8;
            this.interval.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // start
            // 
            this.start.Location = new System.Drawing.Point(446, 62);
            this.start.Name = "start";
            this.start.Size = new System.Drawing.Size(75, 23);
            this.start.TabIndex = 9;
            this.start.Text = "Start";
            this.start.UseVisualStyleBackColor = true;
            this.start.Click += new System.EventHandler(this.start_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // filesToKeep
            // 
            this.filesToKeep.Location = new System.Drawing.Point(237, 65);
            this.filesToKeep.Name = "filesToKeep";
            this.filesToKeep.Size = new System.Drawing.Size(120, 20);
            this.filesToKeep.TabIndex = 10;
            this.filesToKeep.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(199, 67);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Keep";
            // 
            // backups
            // 
            this.backups.FormattingEnabled = true;
            this.backups.Location = new System.Drawing.Point(73, 91);
            this.backups.Name = "backups";
            this.backups.Size = new System.Drawing.Size(367, 160);
            this.backups.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 91);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(28, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Files";
            // 
            // restore
            // 
            this.restore.Location = new System.Drawing.Point(446, 91);
            this.restore.Name = "restore";
            this.restore.Size = new System.Drawing.Size(75, 23);
            this.restore.TabIndex = 14;
            this.restore.Text = "Restore";
            this.restore.UseVisualStyleBackColor = true;
            this.restore.Click += new System.EventHandler(this.restore_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(174, 259);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "Last backup:";
            // 
            // lastBackup
            // 
            this.lastBackup.Location = new System.Drawing.Point(249, 256);
            this.lastBackup.Name = "lastBackup";
            this.lastBackup.Size = new System.Drawing.Size(191, 20);
            this.lastBackup.TabIndex = 16;
            // 
            // automaticBackup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(529, 283);
            this.Controls.Add(this.lastBackup);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.restore);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.backups);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.filesToKeep);
            this.Controls.Add(this.start);
            this.Controls.Add(this.interval);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.chooseFolder);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.backupFolder);
            this.Controls.Add(this.chooseFile);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.fileName);
            this.Name = "automaticBackup";
            this.Text = "Automatic backup";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.interval)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.filesToKeep)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog file;
        private System.Windows.Forms.FolderBrowserDialog folder;
        private System.Windows.Forms.TextBox fileName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button chooseFile;
        private System.Windows.Forms.Button chooseFolder;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox backupFolder;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown interval;
        private System.Windows.Forms.Button start;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.NumericUpDown filesToKeep;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox backups;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button restore;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox lastBackup;
    }
}

