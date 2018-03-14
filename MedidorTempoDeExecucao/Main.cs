using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
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
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                var item = new ListViewItem(openFileDialog.FileName);
                if (!listView.Items.Contains(item))
                {
                    listView.Items.Add(item);
                }
            }
        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            List<Media> resultados = new List<Media>();

            foreach (ListViewItem p in listView.Items)
            {
                ProcessStartInfo startInfo = new ProcessStartInfo();
                startInfo.CreateNoWindow = false;
                startInfo.UseShellExecute = false;
                startInfo.FileName = p.Text;
                startInfo.WindowStyle = ProcessWindowStyle.Hidden;

                // roda 10 vezes para acostumar o processador e normalizar o tempo de execução
                for (int i = 0; i < 10; i++)
                {
                    Process exeProcess = Process.Start(startInfo);
                    exeProcess.WaitForExit();
                }

                TimeSpan ts = new TimeSpan();
                Stopwatch stopWatch = new Stopwatch();
                for (int i = 0; i < numQtd.Value; i++)
                {
                    stopWatch.Start();

                    Process exeProcess = Process.Start(startInfo);
                    exeProcess.WaitForExit();

                    stopWatch.Stop();
                    ts += stopWatch.Elapsed;
                    stopWatch.Reset();
                }

                ts = TimeSpan.FromTicks(ts.Ticks / (int)numQtd.Value);
                resultados.Add(new Media(startInfo.FileName.Split('\\').Last(), ts.TotalMilliseconds));
            }

            Resultado r = new Resultado(resultados);
            r.Show();
        }
    }
}
