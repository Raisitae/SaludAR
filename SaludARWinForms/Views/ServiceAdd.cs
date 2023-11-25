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
    public partial class ServiceAdd : Form
    {
        public ServiceAdd()
        {
            InitializeComponent();
            this.DoubleBuffered = true;
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

        private void btnMedicamento_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form formMedicamentoService = new MedicamentoService();
            formMedicamentoService.ShowDialog();
            formMedicamentoService = null;
            this.Show();
        }

        private void btnLaboratorio_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form formLabService = new LabService();
            formLabService.ShowDialog();
            formLabService = null;
            this.Show();

        }

        private void btnInternacion_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form formAdmittion = new AdmittionService();
            formAdmittion.ShowDialog();
            formAdmittion = null;
            this.Show();

        }

        private void flecha_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
