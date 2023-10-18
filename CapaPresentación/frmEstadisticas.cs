using CapaConsultorio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace CapaPresentación
{
    public partial class frmEstadisticas : Form
    {
        private CS_estadistica estadisticaService;
        public frmEstadisticas()
        {
            InitializeComponent();
            estadisticaService = new CS_estadistica();
            //iconButton1.Click += MostrarEstadisticas();
            //chart1.Series.Add(new Series("Series1"));
            //chart1.Series["Series1"].ChartType = SeriesChartType.Bar;
            chart1.ChartAreas[0].AxisX.Title = "Intervalos de Fechas";
            chart1.ChartAreas[0].AxisY.Title = "Recuento";
            chart1.ChartAreas[0].AxisX.LabelStyle.Format = "yyyy-MM-dd";
           // chart1.ChartAreas[0].AxisY.LabelStyle.Format = "0";



        }



        private void frmEstadisticas_Load(object sender, EventArgs e)
        {

        }

        public void mostrarEstadisticas()
        {


        }

        private void iconButton1_Click(object sender, EventArgs e)
        {

                DateTime fechaInicio = dateTimePicker1.Value;
                DateTime fechaFin = dateTimePicker2.Value;

                // Llama al servicio para obtener los datos
                DataTable dataTable = estadisticaService.GetTurnosEnIntervalo(fechaInicio, fechaFin);

                // Limpia los datos existentes en la serie
                chart1.Series["Series1"].Points.Clear();

                // Configura el formato del eje Y para mostrar números enteros
                chart1.ChartAreas[0].AxisY.LabelStyle.Format = "0";

                // Configura el eje X para mostrar fechas individuales

                chart1.ChartAreas[0].AxisX.Interval = 1;
                chart1.ChartAreas[0].AxisX.IntervalType = DateTimeIntervalType.Days;
                chart1.ChartAreas[0].AxisX.LabelStyle.Format = "yyyy-MM-dd";
                chart1.ChartAreas[0].AxisX.Minimum = fechaInicio.ToOADate();  // Establece la fecha de inicio como mínimo
                chart1.ChartAreas[0].AxisX.Maximum = fechaFin.ToOADate();  // Establece la fecha de fin como máximo


            // Procesa los datos y agrega números de turnos para cada fecha
            foreach (DataRow row in dataTable.Rows)
                {
                    DateTime fecha = (DateTime)row["Fecha"];
                    int cantidad = Convert.ToInt32(row["Cantidad"]);

                    // Agrega cada fecha individualmente al eje X
                    chart1.Series["Series1"].Points.AddXY(fecha.ToOADate(), cantidad);
                }
            }

     }
}

        