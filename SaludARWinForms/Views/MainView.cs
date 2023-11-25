using Microsoft.Win32;
using SaludARWinForms.Views;
using System.Drawing.Drawing2D;

namespace SaludARWinForms
{
    public partial class MainView : Form
    {
        public MainView()
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

        private void btnAdd_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form formAddService = new ServiceAdd();
            formAddService.ShowDialog();
            formAddService = null;
            this.Show();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDetail_Click(object sender, EventArgs e)
        {

            this.Hide();
            Form formGrid = new ModalServices();
            formGrid.ShowDialog();
            formGrid = null;
            this.Show();
        }
    }
}