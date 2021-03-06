﻿using System;
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
                foreach (var file in openFileDialog.FileNames)
                {
                    var item = new ListViewItem(file);
                    if (!listView.Items.Contains(item))
                    {
                        listView.Items.Add(item);
                    }
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

                // roda 5 vezes para acostumar o processador e normalizar o tempo de execução
                for (int i = 0; i < 5; i++)
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
                resultados.Add(new Media(startInfo.FileName.Split('\\').Last(), ts.TotalSeconds));
            }

            Resultado r = new Resultado(resultados);
            r.Show();
        }
    }
}
