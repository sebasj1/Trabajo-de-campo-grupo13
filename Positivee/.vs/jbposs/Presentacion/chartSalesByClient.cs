using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace jbposs.Presentacion
{
    public partial class chartSalesByClient : Form
    {
        public chartSalesByClient()
        {
            InitializeComponent();
        }

        private void chartSales_Load(object sender, EventArgs e)
        {
            updateChart();
        
        }

        private void updateChart()
        {

            using (jbposEntities dbContext = new jbposEntities())
            {
                // Obtener la fecha desde y hasta los DateTimePickers
                DateTime fechaDesde = dtpDesde.Value;
                DateTime fechaHasta = dtpHasta.Value;

                // Obtener los clientes que más compraron dentro del rango de fechas
                var clientesMasCompraron = dbContext.venta
                    .Where(v => v.fecha >= fechaDesde && v.fecha <= fechaHasta)
                    .GroupBy(v => v.id_cliente)
                    .Select(g => new
                    {
                        ClienteId = g.Key,
                        TotalCompras = g.Sum(v => v.total_venta),
                        NombreApellido = g.FirstOrDefault().cliente.nombre + " " + g.FirstOrDefault().cliente.apellido 
                    })
                    .OrderByDescending(x => x.TotalCompras)
                    .Take(10) 
                    .ToList();

                chart1.Series.Clear();
                chart1.Titles.Clear();

                // Crear la serie del gráfico (en este caso, un pie chart)
                Series series = new Series();
                series.ChartType = SeriesChartType.Pie;
                series.Name = "Monto gastado por cliente";  

                // Agregar los datos al gráfico
                foreach (var cliente in clientesMasCompraron)
                {
                    DataPoint dataPoint = new DataPoint();
                    dataPoint.SetValueY(cliente.TotalCompras);
                    dataPoint.Label = $"{cliente.NombreApellido}: ${cliente.TotalCompras}"; 
                    series.Points.Add(dataPoint);
                }

                // Agregar la serie al gráfico
                chart1.Series.Add(series);

                // Agregar un título al gráfico
                Title title = new Title($"Monto gastado por cliente ({fechaDesde.ToShortDateString()} - {fechaHasta.ToShortDateString()})", Docking.Top, new Font("Arial", 14, FontStyle.Bold), Color.Black);
                chart1.Titles.Add(title);

                // Mostrar el gráfico en el control Chart
                chart1.Invalidate();
            }
        }
        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void dtpDesde_ValueChanged(object sender, EventArgs e)
        {
            updateChart();
        }

        private void dtpHasta_ValueChanged(object sender, EventArgs e)
        {
            updateChart();
        }
    }
}
