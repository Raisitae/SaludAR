using SaludARWinForms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace SaludARWinForms
{
    internal class Administrador
    {
        private List<ServicioMedico> Servicios;
        public List<Medicamento> Medicamentos;

        // Singleton instance
        private static Administrador instance;

        public Administrador()
        {
            this.Servicios  = new List<ServicioMedico>();
            this.Medicamentos = new List<Medicamento>();
        }

        public static Administrador GetInstance()
        {
            if (instance == null)
            {
                instance = new Administrador();
            }
            return instance;
        }

        public void addServicio() { 
            
        }
            //new servicio switch de acuredo al tipo de servicio
            //pushear a la lista de servicios

        public void addMedicamento(Medicamento medicamento) {

            Medicamentos.Add(medicamento);
        }
        //new medicamento
        //pushear a la lista de medicamentos


        public void showAll()
        {
           
            foreach (var elemento in Medicamentos)
            {
                MessageBox.Show($"Nombre: {elemento.Nombre}, Porcentaje Ganancia: {elemento.Porcentaje_ganancia} , Precio Lista: {elemento.Precio_lista}");
                // Imprime más campos si es necesario
            }

          
        }

        //return servicios y medicamentos


        public void montoTotalFacturado() { }
        public void cantServiciosSimples() { }

    }
}

