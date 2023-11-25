using System.Collections.Generic;
using System.Windows.Forms;

namespace SaludARWinForms
{
    internal class Administrador
    {
        public List<ServicioMedico> Servicios;
        public List<Medicamento> Medicamentos;

        // Singleton es un patrón de diseño creacional que nos permite asegurarnos de que una clase
        // tenga una única instancia, a la vez que proporciona un punto de acceso global a dicha instancia.
        // En este caso, como no queremos trabajar con una BD, instanciamos el patrón singleton en el administrador
        // para que cada vez que agreguemos un servicio o un medicamento, se agregue a la misma lista y luego podamos
        // acceder a todos los servicios


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

        public void addServicio(ServicioMedico servicio)
        {
            Servicios.Add(servicio);

        }

        public void addMedicamento(Medicamento medicamento)
        {
            Medicamentos.Add(medicamento);
        }
  
    }
}
