using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaludARWinForms
{
    internal class ServicioInternacion : ServicioMedico
    {

        private int cantidad_dias;
        private string? especialidad;

        public ServicioInternacion(int cantidad_dias, string especialidad,double precio) :base(especialidad,precio)
        {
            this.cantidad_dias = cantidad_dias;
            this.especialidad = especialidad;
        }

        public int Cantidad_dias { get => cantidad_dias; set => cantidad_dias = value; }
        public string Especialidad { get => especialidad; set => especialidad = value; }


        public override double calcularPrecio(double precio)
        {
            throw new NotImplementedException();
        }

        public double calcularPrecio(int cantidad_dias)
        {
            double precio = 0;
            precio = cantidad_dias * 20000;
            calcularPrecioFinal(precio);
            return precio;
        }
    }
}
