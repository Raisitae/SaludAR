using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SaludARWinForms.Views
{
    public partial class ModalServices : Form
    {
        public ModalServices()
        {
            InitializeComponent();
            Administrador admin = Administrador.GetInstance();

            this.DoubleBuffered = true;



            DataTable dt = new DataTable();
            dt.Columns.Add("Nombre");
            dt.Columns.Add("Tipo de servicio");
            dt.Columns.Add("Precio");
            double precioTotal = 0;

            foreach (Medicamento med in admin.Medicamentos)
            {
                dt.Rows.Add(med.Nombre, "Medicamento", med.Precio_Final);
                precioTotal += med.Precio_Final;
            }

            foreach (ServicioMedico serv in admin.Servicios)
            {
                if (serv is ServicioInternacion)
                {
                    dt.Rows.Add(serv.Nombre, "Internación", serv.Precio_Final);
                    precioTotal += serv.Precio_Final;
                }
                else if (serv is ServicioLaboratorio)
                {
                    dt.Rows.Add(serv.Nombre, "Laboratorio", serv.Precio_Final);
                    precioTotal += serv.Precio_Final;
                }

            }

            dataGridView1.DataSource = dt;
            lblTotal.Text = "Total a pagar: " + precioTotal.ToString();

        }



        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            Invalidate(); // Activa repaint cuando se activa resize
        }
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);


            Color lavenderColor = Color.FromArgb(176, 156, 215);
            Color lightPinkColor = Color.FromArgb(242, 136, 182);

            using (LinearGradientBrush brush = new LinearGradientBrush(
                this.ClientRectangle,
                lavenderColor,
                lightPinkColor,
                LinearGradientMode.Horizontal))
            {
                e.Graphics.FillRectangle(brush, this.ClientRectangle);
            }
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Administrador admin = Administrador.GetInstance();


        }

        private void flecha_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
