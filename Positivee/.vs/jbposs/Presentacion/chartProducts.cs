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
    public partial class chartProducts : Form
    {
        public chartProducts()
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

                // Obtener los 10 productos más vendidos dentro del rango de fechas
                var productosMasVendidos = dbContext.detalleVenta
                    .Where(d => d.venta.fecha >= fechaDesde && d.venta.fecha <= fechaHasta)
                    .GroupBy(d => d.producto)
                    .Select(g => new
                    {
                        Producto = g.Key,
                        TotalVentas = g.Sum(d => d.cantidad)
                    })
                    .OrderByDescending(x => x.TotalVentas)
                    .Take(10)
                    .ToList();

                chart1.Series.Clear();
                chart1.Titles.Clear();

                // Crear la serie del gráfico (en este caso, un pie chart)
                Series series = new Series();
                series.ChartType = SeriesChartType.Pie;
                 
                // Agregar los datos al gráfico
                foreach (var producto in productosMasVendidos)
                {
                    DataPoint dataPoint = new DataPoint();
                    dataPoint.SetValueY(producto.TotalVentas);
                    dataPoint.Label = $"{producto.Producto.titulo}: {producto.TotalVentas}"; // Agregar la cantidad al label
                    series.Points.Add(dataPoint);
                }

                // Agregar la serie al gráfico
                chart1.Series.Add(series);

                // Agregar un título al gráfico
                Title title = new Title("Productos más vendidos", Docking.Top, new Font("Arial", 14, FontStyle.Bold), Color.Black);
                chart1.Titles.Add(title);
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
