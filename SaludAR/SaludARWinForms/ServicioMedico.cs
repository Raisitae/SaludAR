using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaludARWinForms
{
    internal abstract class ServicioMedico
    {
       private string? nombre;
       private double precio;

        public ServicioMedico(string? nombre, double precio)
        {
            this.nombre = nombre;
            this.precio = precio;
        }

        public string? Nombre { get => nombre; set => nombre = value; }
        public double Precio { get => precio; set => precio = value; }

        public abstract double calcularPrecio(double precio);

        public double calcularPrecioFinal(double precio) {

            double iva = 0.21;
            double ivaDePrecio = ((precio*iva)/2);
            precio = precio + ivaDePrecio;
            return precio;
        }
    }
}
