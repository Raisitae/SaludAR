using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaludARWinForms
{
    internal class Administrador
    {
        private List<ServicioMedico> Servicios;
        private List<Medicamento> Medicamento;

        public Administrador(List<ServicioMedico> servicios, List<Medicamento> medicamento)
        {
            Servicios = servicios;
            Medicamento = medicamento;
        }

        public void addServicio() { }
            //new servicio switch de acuredo al tipo de servicio
            //pushear a la lista de servicios

        public void addMedicamento() { }
        //new medicamento
        //pushear a la lista de medicamentos

        public void showAll() { }
        //return servicios y medicamentos


        public void montoTotalFacturado() { }
        public void cantServiciosSimples() { }

    }
}
