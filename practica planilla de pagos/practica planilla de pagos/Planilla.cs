using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practica_planilla_de_pagos
{
    public class Planilla
    {
        public string NombreEmpleado { get; set; }
        public string Cargo { get; set; }
        public int Sueldo { get; set; }       
        public int Comision { get; set; }
        public double Afp { get { return Sueldo * 0.12; } set { } }
        public double SeguroSocial { get { return Sueldo * 0.05; } set { } }
        public int AñosTrabajados { get { return DateTime.Now.Year - FechaIngreso.Year; } set { } }
        public DateTime FechaIngreso { get; set; }
        public double Gratificacion { get; set; }
        public double TotalNeto { get; set; }
        public double Cooperativa { get; set; }
        public DateTime FechaConsulta { get; set; }       
    }
}
