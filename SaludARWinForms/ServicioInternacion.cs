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
        private double precio_final;


        public ServicioInternacion(int cantidad_dias, string nombre) : base(nombre, 20000*cantidad_dias)
        {
            this.cantidad_dias = cantidad_dias;
            //Aprovechando que la clase Servicio Medico tiene un string en el constructor
            //y que Servicio internación tiene string para especialidad y no necesita como parámetro un nombre
            //usamos el parámetro de especialidad par anombre
            especialidad = nombre;
            this.Precio_final = precio_final;
        }

        public int Cantidad_dias { get => cantidad_dias; set => cantidad_dias = value; }
        public string Especialidad { get => especialidad; set => especialidad = value; }
        public double Precio_final { get => precio_final; set => precio_final = value; }

        // Necesitamos implementar el método de la clase padre
        public override double calcularPrecio(double precio)
        {
            throw new NotImplementedException();
        }


       
    }
}
