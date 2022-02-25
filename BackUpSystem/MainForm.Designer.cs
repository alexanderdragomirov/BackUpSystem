namespace BackUpSystem
{
    partial class BackUpSystem
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
            this.file_watch = new System.IO.FileSystemWatcher();
            this.PathFolderTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Start_Button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.file_watch)).BeginInit();
            this.SuspendLayout();
            // 
            // file_watch
            // 
            this.file_watch.EnableRaisingEvents = true;
            this.file_watch.IncludeSubdirectories = true;
            this.file_watch.Path = "C:\\Users\\Alexandr\\Desktop\\FileFolder";
            this.file_watch.SynchronizingObject = this;
            this.file_watch.Changed += new System.IO.FileSystemEventHandler(this.File_watch_Changed);
            this.file_watch.Created += new System.IO.FileSystemEventHandler(this.File_watch_Created);
            this.file_watch.Deleted += new System.IO.FileSystemEventHandler(this.File_watch_Deleted);
            this.file_watch.Renamed += new System.IO.RenamedEventHandler(this.File_watch_Renamed);
            // 
            // PathFolderTextBox
            // 
            this.PathFolderTextBox.Location = new System.Drawing.Point(127, 50);
            this.PathFolderTextBox.Name = "PathFolderTextBox";
            this.PathFolderTextBox.Size = new System.Drawing.Size(470, 27);
            this.PathFolderTextBox.TabIndex = 0;
            this.PathFolderTextBox.TextChanged += new System.EventHandler(this.PathFolder_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Путь к папке\r\n";
            // 
            // Start_Button
            // 
            this.Start_Button.BackColor = System.Drawing.SystemColors.ControlLight;
            this.Start_Button.Location = new System.Drawing.Point(266, 114);
            this.Start_Button.Name = "Start_Button";
            this.Start_Button.Size = new System.Drawing.Size(151, 49);
            this.Start_Button.TabIndex = 2;
            this.Start_Button.Text = "Start";
            this.Start_Button.UseVisualStyleBackColor = false;
            this.Start_Button.Click += new System.EventHandler(this.Start_Button_Click);
            // 
            // BackUpSystem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuBar;
            this.ClientSize = new System.Drawing.Size(667, 175);
            this.Controls.Add(this.Start_Button);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PathFolderTextBox);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Name = "BackUpSystem";
            this.Text = "BackUpSystem";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.file_watch)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private FileSystemWatcher file_watch;
        private TextBox PathFolderTextBox;
        private Button Start_Button;
        private Label label1;
    }
}