using System.Collections.Generic;
using System.Windows.Forms;

namespace SaludARWinForms
{
    internal class Administrador
    {
        private List<ServicioMedico> Servicios;
        public List<Medicamento> Medicamentos;

        // Singleton instance
        private static Administrador instance;

        private Administrador()
        {
            this.Servicios = new List<ServicioMedico>();
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

        public void addServicio()
        {
            // Implement adding a new service
        }

        public void addMedicamento(Medicamento medicamento)
        {
            Medicamentos.Add(medicamento);
        }

        public void showAll()
        {
            foreach (var medicamento in Medicamentos)
            {
                MessageBox.Show($"Nombre: {medicamento.Nombre}, Porcentaje Ganancia: {medicamento.Porcentaje_ganancia}, Precio Lista: {medicamento.Precio_lista}");
                // Display more fields if necessary
            }
        }

        // Other methods like montoTotalFacturado, cantServiciosSimples, etc.

        // You can add more functionalities to your class as required
    }
}
