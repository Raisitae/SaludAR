namespace SaludARWinForms.Views
{
    partial class AdmittionService
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdmittionService));
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            btnAgregarInternacion = new Button();
            txtCantDias = new TextBox();
            txtEspecialidad = new TextBox();
            lblInternacion = new Label();
            lblEspecialidad = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Cursor = Cursors.Hand;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(11, 12);
            pictureBox1.Margin = new Padding(5, 4, 5, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(75, 65);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 28;
            pictureBox1.TabStop = false;
            pictureBox1.Click += flecha_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.Image = Properties.Resources.nurse;
            pictureBox2.Location = new Point(590, 85);
            pictureBox2.Margin = new Padding(3, 4, 3, 4);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(269, 305);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 27;
            pictureBox2.TabStop = false;
            // 
            // btnAgregarInternacion
            // 
            btnAgregarInternacion.Font = new Font("Arial", 15F, FontStyle.Regular, GraphicsUnit.Point);
            btnAgregarInternacion.Location = new Point(93, 425);
            btnAgregarInternacion.Margin = new Padding(3, 4, 3, 4);
            btnAgregarInternacion.Name = "btnAgregarInternacion";
            btnAgregarInternacion.Size = new Size(205, 67);
            btnAgregarInternacion.TabIndex = 26;
            btnAgregarInternacion.Text = "Agregar";
            btnAgregarInternacion.UseVisualStyleBackColor = true;
            btnAgregarInternacion.Click += btnAgregarInternacion_Click_1;
            // 
            // txtCantDias
            // 
            txtCantDias.Font = new Font("Arial", 15F, FontStyle.Regular, GraphicsUnit.Point);
            txtCantDias.Location = new Point(93, 280);
            txtCantDias.Margin = new Padding(3, 4, 3, 4);
            txtCantDias.Name = "txtCantDias";
            txtCantDias.Size = new Size(412, 36);
            txtCantDias.TabIndex = 24;
            // 
            // txtEspecialidad
            // 
            txtEspecialidad.Font = new Font("Arial", 15F, FontStyle.Regular, GraphicsUnit.Point);
            txtEspecialidad.Location = new Point(93, 185);
            txtEspecialidad.Margin = new Padding(3, 4, 3, 4);
            txtEspecialidad.Name = "txtEspecialidad";
            txtEspecialidad.Size = new Size(412, 36);
            txtEspecialidad.TabIndex = 23;
            // 
            // lblInternacion
            // 
            lblInternacion.AutoSize = true;
            lblInternacion.BackColor = Color.Transparent;
            lblInternacion.Font = new Font("Arial", 15F, FontStyle.Regular, GraphicsUnit.Point);
            lblInternacion.Location = new Point(93, 248);
            lblInternacion.Name = "lblInternacion";
            lblInternacion.Size = new Size(369, 28);
            lblInternacion.TabIndex = 21;
            lblInternacion.Text = "Cantidad de días de internación";
            // 
            // lblEspecialidad
            // 
            lblEspecialidad.AutoSize = true;
            lblEspecialidad.BackColor = Color.Transparent;
            lblEspecialidad.Font = new Font("Arial", 15F, FontStyle.Regular, GraphicsUnit.Point);
            lblEspecialidad.Location = new Point(96, 153);
            lblEspecialidad.Name = "lblEspecialidad";
            lblEspecialidad.Size = new Size(157, 28);
            lblEspecialidad.TabIndex = 20;
            lblEspecialidad.Text = "Especialidad";
            // 
            // AdmittionService
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(953, 548);
            Controls.Add(pictureBox1);
            Controls.Add(pictureBox2);
            Controls.Add(btnAgregarInternacion);
            Controls.Add(txtCantDias);
            Controls.Add(txtEspecialidad);
            Controls.Add(lblInternacion);
            Controls.Add(lblEspecialidad);
            Name = "AdmittionService";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AdmitionService";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Button btnAgregarInternacion;
        private TextBox txtCantDias;
        private TextBox txtEspecialidad;
        private Label lblInternacion;
        private Label lblGanancia;
        private Label lblEspecialidad;
    }
}