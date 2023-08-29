using System.Globalization;

namespace practica_planilla_de_pagos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            CalcularAñosServicio();
        }

        private void btnprocesar_Click(object sender, EventArgs e)
        {
            var cargo = cbxempleado.Text;

            switch (cargo)
            {
                case "Coordinador":
                    var nuevaPlantilla = new Planilla()
                    {
                        NombreEmpleado = txtempleado.Text,
                        FechaIngreso = dtpfechaingreso.Value,
                        Sueldo = 2000,
                        Comision = 250,
                        Cargo = "Coordinador",
                        FechaConsulta = DateTime.Now,
                        Gratificacion = ObtenerGratificacion(2000)
                    };

                    nuevaPlantilla.TotalNeto = CalcularTotalNeto(nuevaPlantilla);

                    lblsueldobasico.Text = nuevaPlantilla.Sueldo.ToString();
                    lblgratificacion.Text = nuevaPlantilla.Gratificacion.ToString();
                    lblcomision.Text = nuevaPlantilla.Comision.ToString();
                    lblafp.Text = nuevaPlantilla.Afp.ToString();
                    lblsegurosocial.Text = nuevaPlantilla.SeguroSocial.ToString();
                    lbltotalingresos.Text = (nuevaPlantilla.Sueldo + nuevaPlantilla.Comision).ToString();
                    lbltotaldescuentos.Text = (nuevaPlantilla.Afp + nuevaPlantilla.Cooperativa).ToString();
                    lbltotalaportaciones.Text = nuevaPlantilla.SeguroSocial.ToString();
                    lbltotalneto.Text = nuevaPlantilla.TotalNeto.ToString();


                    var n = dgvEmpleados.Rows.Add();
                    dgvEmpleados.Rows[n].Cells[0].Value = nuevaPlantilla.NombreEmpleado;
                    dgvEmpleados.Rows[n].Cells[1].Value = nuevaPlantilla.Cargo;
                    dgvEmpleados.Rows[n].Cells[2].Value = nuevaPlantilla.AñosTrabajados;
                    dgvEmpleados.Rows[n].Cells[3].Value = nuevaPlantilla.TotalNeto;

                    break;
                case "Jefe":
                    lblsueldobasico.Text = "4000";
                    nuevaPlantilla = new Planilla()
                    {
                        NombreEmpleado = txtempleado.Text,
                        FechaIngreso = dtpfechaingreso.Value,
                        Sueldo = 2000,
                        Comision = 250,
                        Cargo = "Coordinador",
                        FechaConsulta = DateTime.Now,
                        Gratificacion = ObtenerGratificacion(2000)
                    };

                    nuevaPlantilla.TotalNeto = CalcularTotalNeto(nuevaPlantilla);

                    lblsueldobasico.Text = nuevaPlantilla.Sueldo.ToString();
                    lblgratificacion.Text = nuevaPlantilla.Gratificacion.ToString();
                    lblcomision.Text = nuevaPlantilla.Comision.ToString();
                    lblafp.Text = nuevaPlantilla.Afp.ToString();
                    lblsegurosocial.Text = nuevaPlantilla.SeguroSocial.ToString();
                    lbltotalingresos.Text = (nuevaPlantilla.Sueldo + nuevaPlantilla.Comision).ToString();
                    lbltotaldescuentos.Text = (nuevaPlantilla.Afp + nuevaPlantilla.Cooperativa).ToString();
                    lbltotalaportaciones.Text = nuevaPlantilla.SeguroSocial.ToString();
                    lbltotalneto.Text = nuevaPlantilla.TotalNeto.ToString();


                    n = dgvEmpleados.Rows.Add();
                    dgvEmpleados.Rows[n].Cells[0].Value = nuevaPlantilla.NombreEmpleado;
                    dgvEmpleados.Rows[n].Cells[1].Value = nuevaPlantilla.Cargo;
                    dgvEmpleados.Rows[n].Cells[2].Value = nuevaPlantilla.AñosTrabajados;
                    dgvEmpleados.Rows[n].Cells[3].Value = nuevaPlantilla.TotalNeto;
                    break;
                case "Capacitador":
                    lblsueldobasico.Text = "2500";
                    nuevaPlantilla = new Planilla()
                    {
                        NombreEmpleado = txtempleado.Text,
                        FechaIngreso = dtpfechaingreso.Value,
                        Sueldo = 2500,
                        Comision = 250,
                        Cargo = "Capacitador",
                        FechaConsulta = DateTime.Now,
                        Gratificacion = ObtenerGratificacion(2000)
                    };

                    nuevaPlantilla.TotalNeto = CalcularTotalNeto(nuevaPlantilla);

                    lblsueldobasico.Text = nuevaPlantilla.Sueldo.ToString();
                    lblgratificacion.Text = nuevaPlantilla.Gratificacion.ToString();
                    lblcomision.Text = nuevaPlantilla.Comision.ToString();
                    lblafp.Text = nuevaPlantilla.Afp.ToString();
                    lblsegurosocial.Text = nuevaPlantilla.SeguroSocial.ToString();
                    lbltotalingresos.Text = (nuevaPlantilla.Sueldo + nuevaPlantilla.Comision).ToString();
                    lbltotaldescuentos.Text = (nuevaPlantilla.Afp + nuevaPlantilla.Cooperativa).ToString();
                    lbltotalaportaciones.Text = nuevaPlantilla.SeguroSocial.ToString();
                    lbltotalneto.Text = nuevaPlantilla.TotalNeto.ToString();


                    n = dgvEmpleados.Rows.Add();
                    dgvEmpleados.Rows[n].Cells[0].Value = nuevaPlantilla.NombreEmpleado;
                    dgvEmpleados.Rows[n].Cells[1].Value = nuevaPlantilla.Cargo;
                    dgvEmpleados.Rows[n].Cells[2].Value = nuevaPlantilla.AñosTrabajados;
                    dgvEmpleados.Rows[n].Cells[3].Value = nuevaPlantilla.TotalNeto;
                    break;
                case "Asistente":
                    lblsueldobasico.Text = "1200";
                    nuevaPlantilla = new Planilla()
                    {
                        NombreEmpleado = txtempleado.Text,
                        FechaIngreso = dtpfechaingreso.Value,
                        Sueldo = 2000,
                        Comision = 250,
                        Cargo = "Asistente",
                        FechaConsulta = DateTime.Now,
                        Gratificacion = ObtenerGratificacion(2500)
                    };

                    nuevaPlantilla.TotalNeto = CalcularTotalNeto(nuevaPlantilla);

                    lblsueldobasico.Text = nuevaPlantilla.Sueldo.ToString();
                    lblgratificacion.Text = nuevaPlantilla.Gratificacion.ToString();
                    lblcomision.Text = nuevaPlantilla.Comision.ToString();
                    lblafp.Text = nuevaPlantilla.Afp.ToString();
                    lblsegurosocial.Text = nuevaPlantilla.SeguroSocial.ToString();
                    lbltotalingresos.Text = (nuevaPlantilla.Sueldo + nuevaPlantilla.Comision).ToString();
                    lbltotaldescuentos.Text = (nuevaPlantilla.Afp + nuevaPlantilla.Cooperativa).ToString();
                    lbltotalaportaciones.Text = nuevaPlantilla.SeguroSocial.ToString();
                    lbltotalneto.Text = nuevaPlantilla.TotalNeto.ToString();


                    n = dgvEmpleados.Rows.Add();
                    dgvEmpleados.Rows[n].Cells[0].Value = nuevaPlantilla.NombreEmpleado;
                    dgvEmpleados.Rows[n].Cells[1].Value = nuevaPlantilla.Cargo;
                    dgvEmpleados.Rows[n].Cells[2].Value = nuevaPlantilla.AñosTrabajados;
                    dgvEmpleados.Rows[n].Cells[3].Value = nuevaPlantilla.TotalNeto;
                    break;
                default:
                    MessageBox.Show("Seleccionar item!!");
                    break;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {


            lblfechaactual.Text = DateTime.Now.ToShortDateString();
            txtmesconsultado.Text = DateTime.Now.ToString("MMMM", CultureInfo.CreateSpecificCulture("es-BO")).ToUpper();
        }

        private void dtpfechaingreso_ValueChanged(object sender, EventArgs e)
        {
            CalcularAñosServicio();
        }

        public double CalcularTotalNeto(Planilla plantilla)
        {
            var TotalNeto = plantilla.Sueldo + plantilla.Gratificacion + plantilla.Comision - plantilla.Afp - plantilla.SeguroSocial;
            return TotalNeto;
        }
        public int ObtenerGratificacion(int sueldo)
        {

            if (DateTime.Now.Month == 4)
                return 400;
            if (DateTime.Now.Month == 7)
                return 450;
            if (DateTime.Now.Month == 12)
                return sueldo * 2;
            else
                return 0;

        }

        private void CalcularAñosServicio()
        {
            var añosTrabajados = DateTime.Now.Year - dtpfechaingreso.Value.Year;
            txtañosdeservicio.Text = añosTrabajados.ToString();
        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btncancelar_Click(object sender, EventArgs e)
        {
            lblsueldobasico.Text = "";
            lblgratificacion.Text = "";
            lblcomision.Text = "";
            lblafp.Text = "";
            lblcooperativa.Text = "";
            lblsegurosocial.Text = "";
            lbltotalingresos.Text = "";
            lbltotaldescuentos.Text = "";
            lbltotalaportaciones.Text = "";
        }
    }
}