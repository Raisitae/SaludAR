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
        private string nombre;
        private int cantidad_dias;
        private int nivel_complejidad;
        private double precio_final;
        private double precio;

        public ServicioLaboratorio(int cantidad_dias, int nivel_complejidad, string nombre) : base (nombre, cantidad_dias*10000)
        {
            this.nombre = nombre;
            this.cantidad_dias = cantidad_dias;
            this.nivel_complejidad = nivel_complejidad;
            precio = calcularPrecio(nivel_complejidad);
            precio_final = calcularPrecioFinal(precio);
        }
        public int Cantidad_dias { get => cantidad_dias; set => cantidad_dias = value; }
        public int Nivel_complejidad { get => nivel_complejidad; set => nivel_complejidad = value; }
        public double Precio_final { get => precio_final; set => precio_final = value; }

        // Necesitamos sobreescribir el método para después poder sobrecargarlo
        public override double calcularPrecio(double precio)
        {
            throw new NotImplementedException();
        }

        public double calcularPrecio(int nivel_complejidad)
        {
            if (nivel_complejidad > 3) {
                precio += precio * cantidad_dias * 1.25;
            }
            
            return precio;
        }
        
        
       
    }
}
