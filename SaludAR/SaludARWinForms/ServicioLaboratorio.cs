using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaludARWinForms
{
    internal class ServicioLaboratorio : ServicioMedico
    {

        private int cantidad_dias;
        private int nivel_complejidad;

        public ServicioLaboratorio(int cantidad_dias, int nivel_complejidad, string? nombre, double precio) : base (nombre, precio)
        {
            this.cantidad_dias = cantidad_dias;
            this.nivel_complejidad = nivel_complejidad;
        }

        public int Cantidad_dias { get => cantidad_dias; set => cantidad_dias = value; }
        public int Nivel_complejidad { get => nivel_complejidad; set => nivel_complejidad = value; }

        public override double calcularPrecio(double precio)
        {
            throw new NotImplementedException();
        }

        public double calcularPrecio( int cantidad_dias, int nivel_complejidad)
        {
            double precio = 0;
            if ((nivel_complejidad < 0 ) & (nivel_complejidad > 3)) {
                precio += 10000 * cantidad_dias;
            } else if (nivel_complejidad >3)
            {
                precio += 10000 * cantidad_dias * 1.25;
            }
            calcularPrecioFinal(precio);
            return precio;
        }

       
    }
}
