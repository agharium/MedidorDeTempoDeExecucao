using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MedidorTempoDeExecucao
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void btnOpenFile_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                txtFilePath.Text = openFileDialog.FileName;
            }
        }

        private void btnOneHundredTimes_Click(object sender, EventArgs e)
        {
            ProcessStartInfo startInfo = new ProcessStartInfo();
            startInfo.CreateNoWindow = false;
            startInfo.UseShellExecute = false;
            startInfo.FileName = txtFilePath.Text;
            startInfo.WindowStyle = ProcessWindowStyle.Hidden;

            TimeSpan ts = new TimeSpan();
            Stopwatch stopWatch = new Stopwatch();
            for (int i = 0; i < 100; i++)
            {
                stopWatch.Start();

                Process exeProcess = Process.Start(startInfo);
                exeProcess.WaitForExit();

                stopWatch.Stop();
                ts += stopWatch.Elapsed;
                stopWatch.Reset();
            }

            ts = TimeSpan.FromTicks(ts.Ticks / 100);

            string elapsedTime = String.Format("{0:00}:{1:00}:{2:00}.{3:00}", ts.Hours, ts.Minutes, ts.Seconds, ts.Milliseconds);
            MessageBox.Show(elapsedTime);
        }
    }
}
