using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVD_A
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            ffmpegCheck.Checked = File.Exists(@"ffmpeg.exe");
            mkisofsChk.Checked = File.Exists(@"mkisofs.exe");
            dvdaChk.Checked = File.Exists(@"dvda-author.exe");

            bool passedDependCheck = (File.Exists(@"dvda-author.exe")) & (File.Exists(@"dvda-author.exe")) & (File.Exists(@"mkisofs.exe"));
            {
                if (!passedDependCheck) {
                    MessageBox.Show("You are missing one or more dependencies. This application will not function without them. Please download the latest release from https://github.com/Rubik7711/dvda-utility", "Error! Missing Dependencies", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }

            System.Windows.Forms.ToolTip btnToolTip = new System.Windows.Forms.ToolTip();
            btnToolTip.SetToolTip(this.button1, "Choose the folder where your audio files are stored.");
            btnToolTip.SetToolTip(this.OutputSelector, "Encoded fils will be saved to this location. This will overwrite existing files with the same name.");

        }

        private void button1_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog source = new FolderBrowserDialog();
            if (DialogResult.OK == source.ShowDialog())
            {
                string path = source.SelectedPath;
                System.Console.WriteLine(path);
                SourcePath.Text = path;
                SourcePath.Enabled = true;
                SourcePath.BackColor = Color.White;

            }
        }

        private void SourcePath_TextChanged(object sender, EventArgs e)
        {

        }

        private void OutputSelector_Click(object sender, EventArgs e)
        {
            if (!SourcePath.Enabled)
            {
                System.Windows.Forms.ToolTip btnToolTip = new System.Windows.Forms.ToolTip();
                btnToolTip.SetToolTip(this.OutputSelector, "Select a source folder first");
            }
            else
            {
                FolderBrowserDialog output = new FolderBrowserDialog();
                if (DialogResult.OK == output.ShowDialog())
                {
                    string outpath = output.SelectedPath;
                    System.Console.WriteLine(outpath);
                    OutputPath.Text = outpath;
                    OutputPath.Enabled = true;
                    OutputPath.BackColor = Color.White;

                }
            }
        }

        private void EncodeButt_Click(object sender, EventArgs e)
        {
            if ( (SourcePath.Enabled) & (OutputPath.Enabled) )
            {
                progressBar.Maximum = 100;
                progressBar.Value = 0;

                int count = Directory.GetFiles(SourcePath.Text, "*.*").Length;
                int iteration = 0;

                if (Directory.Exists(SourcePath.Text)) {
                    //ErrorLbl.Text = "Encoding files using Meridian Lossless Packing (MLP) compression. This could take a while!";
                    foreach (var file in Directory.GetFiles(SourcePath.Text, "*.*")) { 
                        Process process = new Process();
                        process.StartInfo.FileName = "ffmpeg";
                        process.StartInfo.Arguments = "-y -i \u0022" + file + "\u0022 -c:a mlp -strict -2 \u0022" + OutputPath.Text + "\\" + Path.GetFileNameWithoutExtension(file) + ".mlp\u0022";
                        process.StartInfo.UseShellExecute = false;
                        process.StartInfo.CreateNoWindow = true;
                        process.Start();
                        iteration++;
                        progressBar.Value += 100 / count;
                        ErrorLbl.Text = "(" + iteration + " / " + count + ") Encoding " + Path.GetFileNameWithoutExtension(file);
                        process.WaitForExit();
                        System.Console.WriteLine(process.StartInfo.Arguments);
                        if (iteration >= count)
                        {
                            progressBar.Value = 50;
                            ErrorLbl.Text = "Formatting files for DVD-A playback. Please wait!";

                            Process DVDA = new Process();
                            DVDA.StartInfo.FileName = "dvda-author.exe";
                            DVDA.StartInfo.Arguments = "-g \u0022" + OutputPath.Text + "\\*.mlp" + "\u0022 -P0 -W -d -o \u0022" + OutputPath.Text + "\\output\u0022";
                            System.Console.WriteLine(DVDA.StartInfo.Arguments);
                            DVDA.StartInfo.UseShellExecute = false;
                            DVDA.StartInfo.CreateNoWindow = true;
                            DVDA.Start();
                            DVDA.WaitForExit();

                            progressBar.Value = 80;
                            ErrorLbl.Text = "Creating ISO file. Almost done!";

                            Process ISO = new Process();
                            ISO.StartInfo.FileName = "mkisofs.exe";
                            ISO.StartInfo.Arguments = "-dvd-audio -o \u0022" + OutputPath.Text + "\\dvd.iso\u0022 " + "\u0022" + OutputPath.Text + "\\output\u0022";

                            System.Console.WriteLine(ISO.StartInfo.Arguments);
                            ISO.StartInfo.UseShellExecute = true;
                            ISO.StartInfo.CreateNoWindow = true;
                            ISO.Start();
                            ISO.WaitForExit();

                            progressBar.Value = 0;
                            ErrorLbl.Text = "Your .ISO was successfully created and saved to " + "\u0022" + OutputPath.Text + "\u0022. Mount it with Windows and burn as \u0022Mastered Disk\u0022.";

                            ProcessStartInfo MountISO = new ProcessStartInfo();
                            MountISO.FileName = "EXPLORER.EXE";
                            MountISO.Arguments = OutputPath.Text;
                            Process.Start(MountISO);


                        }
                    }
                }
            }
            else
            {
                if (!SourcePath.Enabled) {
                    ErrorLbl.Text = "You did not select a source folder!";
                }
                else if (!OutputPath.Enabled)
                {
                    ErrorLbl.Text = "You did not select an output folder!";
                }

            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void ffmpegCheck_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

    }
}
