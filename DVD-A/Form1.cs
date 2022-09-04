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
            ffmpegErLbl.Visible = !File.Exists(@"ffmpeg.exe");

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
                            progressBar.Value = 0;
                            ErrorLbl.Text = "Encoding is complete. You may now close this program.";
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

        private void ffmpegErLbl_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://www.gyan.dev/ffmpeg/builds/ffmpeg-git-full.7z");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
