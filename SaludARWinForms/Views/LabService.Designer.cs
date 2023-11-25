namespace SaludARWinForms.Views
{
    partial class LabService
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LabService));
            pictureBox2 = new PictureBox();
            btnAgregarLab = new Button();
            txtComplejidad = new TextBox();
            txtCantDias = new TextBox();
            txtNombre = new TextBox();
            lblComplejidad = new Label();
            lblCantDias = new Label();
            lblNombreEstudio = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox2
            // 
            pictureBox2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.Image = Properties.Resources.result;
            pictureBox2.Location = new Point(516, 64);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(235, 229);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 18;
            pictureBox2.TabStop = false;
            // 
            // btnAgregarLab
            // 
            btnAgregarLab.Font = new Font("Arial", 15F, FontStyle.Regular, GraphicsUnit.Point);
            btnAgregarLab.Location = new Point(81, 319);
            btnAgregarLab.Name = "btnAgregarLab";
            btnAgregarLab.Size = new Size(179, 50);
            btnAgregarLab.TabIndex = 17;
            btnAgregarLab.Text = "Agregar";
            btnAgregarLab.UseVisualStyleBackColor = true;
            btnAgregarLab.Click += agregar_Click;
            // 
            // txtComplejidad
            // 
            txtComplejidad.Font = new Font("Arial", 15F, FontStyle.Regular, GraphicsUnit.Point);
            txtComplejidad.Location = new Point(81, 244);
            txtComplejidad.Name = "txtComplejidad";
            txtComplejidad.Size = new Size(361, 30);
            txtComplejidad.TabIndex = 16;
            // 
            // txtCantDias
            // 
            txtCantDias.Font = new Font("Arial", 15F, FontStyle.Regular, GraphicsUnit.Point);
            txtCantDias.Location = new Point(81, 170);
            txtCantDias.Name = "txtCantDias";
            txtCantDias.Size = new Size(361, 30);
            txtCantDias.TabIndex = 15;
            // 
            // txtNombre
            // 
            txtNombre.Font = new Font("Arial", 15F, FontStyle.Regular, GraphicsUnit.Point);
            txtNombre.Location = new Point(81, 99);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(361, 30);
            txtNombre.TabIndex = 14;
            // 
            // lblComplejidad
            // 
            lblComplejidad.AutoSize = true;
            lblComplejidad.BackColor = Color.Transparent;
            lblComplejidad.Font = new Font("Arial", 15F, FontStyle.Regular, GraphicsUnit.Point);
            lblComplejidad.Location = new Point(81, 218);
            lblComplejidad.Name = "lblComplejidad";
            lblComplejidad.Size = new Size(290, 23);
            lblComplejidad.TabIndex = 13;
            lblComplejidad.Text = "Nivel de complejidad (del 1 al 5)";
            // 
            // lblCantDias
            // 
            lblCantDias.AutoSize = true;
            lblCantDias.BackColor = Color.Transparent;
            lblCantDias.Font = new Font("Arial", 15F, FontStyle.Regular, GraphicsUnit.Point);
            lblCantDias.Location = new Point(81, 146);
            lblCantDias.Name = "lblCantDias";
            lblCantDias.Size = new Size(318, 23);
            lblCantDias.TabIndex = 12;
            lblCantDias.Text = "Cantidad de días desde la muestra";
            // 
            // lblNombreEstudio
            // 
            lblNombreEstudio.AutoSize = true;
            lblNombreEstudio.BackColor = Color.Transparent;
            lblNombreEstudio.Font = new Font("Arial", 15F, FontStyle.Regular, GraphicsUnit.Point);
            lblNombreEstudio.Location = new Point(84, 75);
            lblNombreEstudio.Name = "lblNombreEstudio";
            lblNombreEstudio.Size = new Size(148, 23);
            lblNombreEstudio.TabIndex = 11;
            lblNombreEstudio.Text = "Nombre estudio";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Cursor = Cursors.Hand;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(10, 9);
            pictureBox1.Margin = new Padding(4, 3, 4, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(66, 49);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 19;
            pictureBox1.TabStop = false;
            pictureBox1.Click += flecha_Click;
            // 
            // LabService
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(834, 411);
            Controls.Add(pictureBox1);
            Controls.Add(pictureBox2);
            Controls.Add(btnAgregarLab);
            Controls.Add(txtComplejidad);
            Controls.Add(txtCantDias);
            Controls.Add(txtNombre);
            Controls.Add(lblComplejidad);
            Controls.Add(lblCantDias);
            Controls.Add(lblNombreEstudio);
            Margin = new Padding(3, 2, 3, 2);
            Name = "LabService";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "LabService";
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox2;
        private Button btnAgregarLab;
        private TextBox txtComplejidad;
        private TextBox txtCantDias;
        private TextBox txtNombre;
        private Label lblComplejidad;
        private Label lblCantDias;
        private Label lblNombreEstudio;
        private PictureBox pictureBox1;
    }
}