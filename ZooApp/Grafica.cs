using LiveCharts;
using LiveCharts.Wpf;
using System;
using System.Data;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using SeriesCollection = LiveCharts.SeriesCollection;

namespace ZooApp
{
    public partial class Grafica : Form
    {
        ControlAnimals controls = new ControlAnimals();
        //controls.getRatingHabitat(); Pasale DESC si queres que sea descendiente como string
        //controls.getRatingEspecie(); Pasale ASC si queres que sea ascendente como string

        public Grafica()
        {
            InitializeComponent();
            
        }

        Func<ChartPoint, string> label = chartpoint => string.Format("{0} ({1:P})", chartpoint.Y, chartpoint.Participation);

        private void Grafica_Load(object sender, EventArgs e)
        {
            DataSet datos_h = controls.getRatingHabitat();
            DataTable seriesHabitats = datos_h.Tables[0];

            DataSet datos_e = controls.getRatingEspecie();
            DataTable seriesESpecies = datos_e.Tables[0];

            pieCharH.LegendLocation = LegendLocation.Bottom;
            pieChartE.LegendLocation = LegendLocation.Bottom;

            SeriesCollection series_h = new SeriesCollection();
            SeriesCollection series_e = new SeriesCollection();



            foreach (DataRow fila in seriesHabitats.Rows)
            {
                series_h.Add(new PieSeries() { Title = fila["Habitat"].ToString(),
                    Values = new ChartValues<int> { Convert.ToInt32(fila["Cantidad"].ToString()) },
                    DataLabels = true, LabelPoint = label });


             }

            foreach (DataRow fila in seriesESpecies.Rows)
            {
                series_e.Add(new PieSeries()
                {
                    Title = fila["Especie"].ToString(),
                    Values = new ChartValues<int> { Convert.ToInt32(fila["Cantidad"].ToString()) },
                    DataLabels = true,
                    LabelPoint = label
                });


            }

            pieCharH.Series = series_h;
            pieChartE.Series = series_e;

        }
    }
}
