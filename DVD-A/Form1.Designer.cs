
namespace DVD_A
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.button1 = new System.Windows.Forms.Button();
            this.SourcePath = new System.Windows.Forms.TextBox();
            this.OutputSelector = new System.Windows.Forms.Button();
            this.OutputPath = new System.Windows.Forms.TextBox();
            this.EncodeButt = new System.Windows.Forms.Button();
            this.ErrorLbl = new System.Windows.Forms.Label();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.ffmpegCheck = new System.Windows.Forms.CheckBox();
            this.DependLbl = new System.Windows.Forms.Label();
            this.HeadLbl = new System.Windows.Forms.Label();
            this.mkisofsChk = new System.Windows.Forms.CheckBox();
            this.dvdaChk = new System.Windows.Forms.CheckBox();
            this.CleanupBox = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 63);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(120, 28);
            this.button1.TabIndex = 1;
            this.button1.Text = "Source";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // SourcePath
            // 
            this.SourcePath.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.SourcePath.Enabled = false;
            this.SourcePath.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.SourcePath.Location = new System.Drawing.Point(137, 67);
            this.SourcePath.Name = "SourcePath";
            this.SourcePath.ReadOnly = true;
            this.SourcePath.Size = new System.Drawing.Size(237, 20);
            this.SourcePath.TabIndex = 2;
            this.SourcePath.Text = "C:\\Users\\RC\\Music\\Library";
            // 
            // OutputSelector
            // 
            this.OutputSelector.Location = new System.Drawing.Point(12, 97);
            this.OutputSelector.Name = "OutputSelector";
            this.OutputSelector.Size = new System.Drawing.Size(120, 28);
            this.OutputSelector.TabIndex = 3;
            this.OutputSelector.Text = "Output";
            this.OutputSelector.UseVisualStyleBackColor = true;
            this.OutputSelector.Click += new System.EventHandler(this.OutputSelector_Click);
            // 
            // OutputPath
            // 
            this.OutputPath.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.OutputPath.Enabled = false;
            this.OutputPath.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.OutputPath.Location = new System.Drawing.Point(137, 102);
            this.OutputPath.Name = "OutputPath";
            this.OutputPath.ReadOnly = true;
            this.OutputPath.Size = new System.Drawing.Size(237, 20);
            this.OutputPath.TabIndex = 4;
            this.OutputPath.Text = "C:\\Users\\RC\\Music\\Multichannel\\Tracks";
            // 
            // EncodeButt
            // 
            this.EncodeButt.Location = new System.Drawing.Point(12, 139);
            this.EncodeButt.Name = "EncodeButt";
            this.EncodeButt.Size = new System.Drawing.Size(120, 34);
            this.EncodeButt.TabIndex = 5;
            this.EncodeButt.Text = "Encode";
            this.EncodeButt.UseVisualStyleBackColor = true;
            this.EncodeButt.Click += new System.EventHandler(this.EncodeButt_Click);
            // 
            // ErrorLbl
            // 
            this.ErrorLbl.AutoSize = true;
            this.ErrorLbl.BackColor = System.Drawing.SystemColors.Menu;
            this.ErrorLbl.Location = new System.Drawing.Point(135, 139);
            this.ErrorLbl.MaximumSize = new System.Drawing.Size(250, 40);
            this.ErrorLbl.Name = "ErrorLbl";
            this.ErrorLbl.Size = new System.Drawing.Size(0, 13);
            this.ErrorLbl.TabIndex = 6;
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(12, 188);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(362, 23);
            this.progressBar.TabIndex = 7;
            // 
            // ffmpegCheck
            // 
            this.ffmpegCheck.AutoCheck = false;
            this.ffmpegCheck.AutoSize = true;
            this.ffmpegCheck.Location = new System.Drawing.Point(12, 243);
            this.ffmpegCheck.Name = "ffmpegCheck";
            this.ffmpegCheck.Size = new System.Drawing.Size(58, 17);
            this.ffmpegCheck.TabIndex = 8;
            this.ffmpegCheck.Text = "ffmpeg";
            this.ffmpegCheck.UseVisualStyleBackColor = true;
            // 
            // DependLbl
            // 
            this.DependLbl.AutoSize = true;
            this.DependLbl.Location = new System.Drawing.Point(13, 224);
            this.DependLbl.Name = "DependLbl";
            this.DependLbl.Size = new System.Drawing.Size(79, 13);
            this.DependLbl.TabIndex = 9;
            this.DependLbl.Text = "Dependencies:";
            // 
            // HeadLbl
            // 
            this.HeadLbl.AutoSize = true;
            this.HeadLbl.Location = new System.Drawing.Point(13, 9);
            this.HeadLbl.MaximumSize = new System.Drawing.Size(365, 200);
            this.HeadLbl.Name = "HeadLbl";
            this.HeadLbl.Size = new System.Drawing.Size(347, 39);
            this.HeadLbl.TabIndex = 11;
            this.HeadLbl.Text = "Your media should be stored as individual tracks in the source directory. The out" +
    "put directory should be an empty folder. (Optional) Cleanup will remove the titl" +
    "e set after creating the disk.";
            // 
            // mkisofsChk
            // 
            this.mkisofsChk.AutoCheck = false;
            this.mkisofsChk.AutoSize = true;
            this.mkisofsChk.Location = new System.Drawing.Point(67, 243);
            this.mkisofsChk.Name = "mkisofsChk";
            this.mkisofsChk.Size = new System.Drawing.Size(61, 17);
            this.mkisofsChk.TabIndex = 12;
            this.mkisofsChk.Text = "mkisofs";
            this.mkisofsChk.UseVisualStyleBackColor = true;
            // 
            // dvdaChk
            // 
            this.dvdaChk.AutoCheck = false;
            this.dvdaChk.AutoSize = true;
            this.dvdaChk.Location = new System.Drawing.Point(125, 243);
            this.dvdaChk.Name = "dvdaChk";
            this.dvdaChk.Size = new System.Drawing.Size(83, 17);
            this.dvdaChk.TabIndex = 14;
            this.dvdaChk.Text = "dvda-author";
            this.dvdaChk.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.dvdaChk.UseVisualStyleBackColor = true;
            // 
            // CleanupBox
            // 
            this.CleanupBox.AutoSize = true;
            this.CleanupBox.Location = new System.Drawing.Point(309, 243);
            this.CleanupBox.Name = "CleanupBox";
            this.CleanupBox.Size = new System.Drawing.Size(65, 17);
            this.CleanupBox.TabIndex = 15;
            this.CleanupBox.Text = "Cleanup";
            this.CleanupBox.UseVisualStyleBackColor = true;
            this.CleanupBox.CheckedChanged += new System.EventHandler(this.CleanupBox_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 272);
            this.Controls.Add(this.CleanupBox);
            this.Controls.Add(this.dvdaChk);
            this.Controls.Add(this.mkisofsChk);
            this.Controls.Add(this.HeadLbl);
            this.Controls.Add(this.DependLbl);
            this.Controls.Add(this.ffmpegCheck);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.ErrorLbl);
            this.Controls.Add(this.EncodeButt);
            this.Controls.Add(this.OutputPath);
            this.Controls.Add(this.OutputSelector);
            this.Controls.Add(this.SourcePath);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "DVD-A Utility";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox SourcePath;
        private System.Windows.Forms.Button OutputSelector;
        private System.Windows.Forms.TextBox OutputPath;
        private System.Windows.Forms.Button EncodeButt;
        private System.Windows.Forms.Label ErrorLbl;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.CheckBox ffmpegCheck;
        private System.Windows.Forms.Label DependLbl;
        private System.Windows.Forms.Label HeadLbl;
        private System.Windows.Forms.CheckBox mkisofsChk;
        private System.Windows.Forms.CheckBox dvdaChk;
        private System.Windows.Forms.CheckBox CleanupBox;
    }
}

