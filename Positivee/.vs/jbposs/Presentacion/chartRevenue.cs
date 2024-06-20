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
    public partial class chartRevenue : Form
    {
        public chartRevenue()
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
                 
                // Obtener la recaudación de las ventas por día
                var recaudacionPorDia = dbContext.detalleVenta
                    .Where(d => d.venta.fecha >= fechaDesde && d.venta.fecha <= fechaHasta)
                    .GroupBy(d => DbFunctions.TruncateTime(d.venta.fecha))
                    .Select(g => new
                    {
                        Dia = g.Key,
                        Recaudacion = g.Sum(d => d.venta.total_venta) // Ajusta esto según la propiedad que representa el monto en tu modelo
                    })
                    .OrderBy(x => x.Dia)
                    .ToList();


                chart1.Series.Clear();
                chart1.Titles.Clear();

                // Crear la serie del gráfico (en este caso, un histograma)
                Series series = new Series();
                series.ChartType = SeriesChartType.Column;
                series.Name = "Recaudación de Ventas"; // Nombre de la serie
                series.Color = Color.DarkGreen;

                // Agregar los datos al gráfico
                foreach (var recaudacionDia in recaudacionPorDia)
                {
                    DataPoint dataPoint = new DataPoint();
                    dataPoint.SetValueY(recaudacionDia.Recaudacion);
                    dataPoint.Label = $"${recaudacionDia.Recaudacion}";
                    dataPoint.AxisLabel = recaudacionDia.Dia.ToString(); // Etiqueta del eje X formateada automáticamente
                    series.Points.Add(dataPoint);
                }

                // Agregar la serie al gráfico
                chart1.Series.Add(series);

                // Agregar un título al gráfico
                Title title = new Title($"Recaudación de Ventas por día ({fechaDesde.ToShortDateString()} - {fechaHasta.ToShortDateString()})", Docking.Top, new Font("Arial", 14, FontStyle.Bold), Color.Black);
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
