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
    public partial class chartSales : Form
    {
        public chartSales()
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

                // Obtener el total de productos vendidos por día
                var productosPorDia = dbContext.detalleVenta
                    .Where(d => d.venta.fecha >= fechaDesde && d.venta.fecha <= fechaHasta)
                   
                    .GroupBy(d => DbFunctions.TruncateTime(d.venta.fecha))
                    .Select(g => new
                    {
                        Dia = g.Key,
                        TotalVentas = g.Sum(d => d.cantidad)
                    })
                    .OrderBy(x => x.Dia)
                    .ToList();

                chart1.Series.Clear();
                chart1.Titles.Clear();

                // Crear la serie del gráfico (en este caso, un histograma)
                Series series = new Series();
                
                series.ChartType = SeriesChartType.Column;
                series.Name = "Cantidad de productos vendidos";
                // Agregar los datos al gráfico
                foreach (var ventaPorDia in productosPorDia)
                {
                    DataPoint dataPoint = new DataPoint();
                    dataPoint.SetValueY(ventaPorDia.TotalVentas);
                    dataPoint.Label = $"{ventaPorDia.TotalVentas}";
                    dataPoint.AxisLabel = ventaPorDia.Dia.ToString(); // Etiqueta del eje X
                    series.Points.Add(dataPoint);
                }

                // Agregar la serie al gráfico
                chart1.Series.Add(series);

                // Agregar un título al gráfico
                Title title = new Title($"Total de productos vendidos por día ({fechaDesde.ToShortDateString()} - {fechaHasta.ToShortDateString()})", Docking.Top, new Font("Arial", 14, FontStyle.Bold), Color.Black);
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
