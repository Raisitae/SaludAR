using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaludARWinForms
{
    internal class Medicamento
    {
        private string? nombre;
        private double porcentaje_ganancia;
        private double precio_lista;
        private double precio_final;

        public Medicamento(string? nombre, double porcentaje_ganancia, double precio_lista)
        {
            this.nombre = nombre;
            this.porcentaje_ganancia = porcentaje_ganancia;
            this.precio_lista = precio_lista;
        }

        public string? Nombre { get => nombre; set => nombre = value; }
        public double Porcentaje_ganancia { get => porcentaje_ganancia; set => porcentaje_ganancia = value; }
        public double Precio_lista { get => precio_lista; set => precio_lista = value; }

        public double calcular_precio(double porcentaje_ganancia, double precio_lista)
        {
            double porcentaje = (porcentaje_ganancia / 100) + 1;
            precio_final = precio_lista * porcentaje;
            return precio_final;
        }

        public override string ToString()
        {
            return nombre + " " + precio_final + " " + porcentaje_ganancia;
        }

    }

}
