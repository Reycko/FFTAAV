using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FFTAAV
{
    public partial class FFTAAV : Form
    {
        public FFTAAV()
        {
            InitializeComponent();
        }

        private async void GenButton_Click(object sender, EventArgs e)
        {
            // Gonna be some messy code, but this does enough for a 0.1 > 0.2 GUI upgrade.

            string resolution;
            string FFmpegLoc_;
            string FileOutput;
            string FileInput;
            string cmdLine;
            string cmdLineF;
            
            


            resolution = res1.Text + "x" + res2.Text;
            FFmpegLoc_ = "\"" + ffmpegLoc.Text + "\"";
            FileOutput = "\"" + output.Text + ".mp4" + "\"";
            FileInput = "\"" + input.Text + "\"";

            cmdLine = FFmpegLoc_ + " -f rawvideo -pixel_format rgb32 -video_size 32x32 -framerate 10.766666 -i " + FileInput + " -f u8 -ar 44100 -ac 1 -i " + FileInput + " -sws_flags neighbor -s " + resolution + " " + FileOutput; 

            cmdLineF = "@echo off && cls && " + cmdLine;
            

            System.Console.WriteLine("Should execute");
            
 //         System.Diagnostics.Process.Start("cmd.exe", "/c " + cmdLineF);
            MessageBox.Show($"{FileInput} is getting converted (you can close this message box)");
            /*          var proc = Process.Start("cmd.exe");
                      proc.StartInfo.Arguments = cmdLineF;
                      proc.WaitForExit();
            */
            var psi = new ProcessStartInfo("cmd", "/c " + cmdLineF);
            psi.UseShellExecute = false;
            psi.CreateNoWindow = true;
            psi.RedirectStandardOutput = true;
            Process.Start(psi);
   

            
        }
    }
}
