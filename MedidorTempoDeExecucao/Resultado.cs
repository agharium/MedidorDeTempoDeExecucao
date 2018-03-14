using System.Collections.Generic;
using System.Windows.Forms;

namespace MedidorTempoDeExecucao
{
    public partial class Resultado : Form
    {
        public Resultado(List<Media> medias)
        {
            InitializeComponent();

            int count = 0;
            foreach(var m in medias)
            {
                
                chart.ChartAreas[0].AxisY.LabelStyle.Format = "0.00";
                chart.Series["Média (milésimos)"].Points.AddXY(m.nome, m.tempo);
                chart.Series["Média (milésimos)"].Points[count].Label = m.tempo.ToString();
                count++;
            }
            chart.Titles.Add("Gráfico de desempenho");
        }
    }
}
