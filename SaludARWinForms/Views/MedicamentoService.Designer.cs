namespace SaludARWinForms.Views
{
    partial class MedicamentoService
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MedicamentoService));
            lblNombreMedicamento = new Label();
            lblGanancia = new Label();
            lblPrecio = new Label();
            txtNombreMedicamento = new TextBox();
            txtGanancia = new TextBox();
            txtPrecio = new TextBox();
            btnAgregarMedicamento = new Button();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // lblNombreMedicamento
            // 
            lblNombreMedicamento.AutoSize = true;
            lblNombreMedicamento.BackColor = Color.Transparent;
            lblNombreMedicamento.Font = new Font("Arial", 15F, FontStyle.Regular, GraphicsUnit.Point);
            lblNombreMedicamento.Location = new Point(84, 75);
            lblNombreMedicamento.Name = "lblNombreMedicamento";
            lblNombreMedicamento.Size = new Size(203, 23);
            lblNombreMedicamento.TabIndex = 0;
            lblNombreMedicamento.Text = "Nombre Medicamento";
            // 
            // lblGanancia
            // 
            lblGanancia.AutoSize = true;
            lblGanancia.BackColor = Color.Transparent;
            lblGanancia.Font = new Font("Arial", 15F, FontStyle.Regular, GraphicsUnit.Point);
            lblGanancia.Location = new Point(84, 146);
            lblGanancia.Name = "lblGanancia";
            lblGanancia.Size = new Size(193, 23);
            lblGanancia.TabIndex = 1;
            lblGanancia.Text = "Porcentaje Ganancia";
            // 
            // lblPrecio
            // 
            lblPrecio.AutoSize = true;
            lblPrecio.BackColor = Color.Transparent;
            lblPrecio.Font = new Font("Arial", 15F, FontStyle.Regular, GraphicsUnit.Point);
            lblPrecio.Location = new Point(84, 220);
            lblPrecio.Name = "lblPrecio";
            lblPrecio.Size = new Size(66, 23);
            lblPrecio.TabIndex = 2;
            lblPrecio.Text = "Precio";
            // 
            // txtNombreMedicamento
            // 
            txtNombreMedicamento.Font = new Font("Arial", 15F, FontStyle.Regular, GraphicsUnit.Point);
            txtNombreMedicamento.Location = new Point(84, 99);
            txtNombreMedicamento.Name = "txtNombreMedicamento";
            txtNombreMedicamento.Size = new Size(361, 30);
            txtNombreMedicamento.TabIndex = 3;
            // 
            // txtGanancia
            // 
            txtGanancia.Font = new Font("Arial", 15F, FontStyle.Regular, GraphicsUnit.Point);
            txtGanancia.Location = new Point(84, 170);
            txtGanancia.Name = "txtGanancia";
            txtGanancia.Size = new Size(361, 30);
            txtGanancia.TabIndex = 4;
            // 
            // txtPrecio
            // 
            txtPrecio.Font = new Font("Arial", 15F, FontStyle.Regular, GraphicsUnit.Point);
            txtPrecio.Location = new Point(84, 244);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.Size = new Size(361, 30);
            txtPrecio.TabIndex = 5;
            // 
            // btnAgregarMedicamento
            // 
            btnAgregarMedicamento.Font = new Font("Arial", 15F, FontStyle.Regular, GraphicsUnit.Point);
            btnAgregarMedicamento.Location = new Point(84, 319);
            btnAgregarMedicamento.Name = "btnAgregarMedicamento";
            btnAgregarMedicamento.Size = new Size(179, 50);
            btnAgregarMedicamento.TabIndex = 6;
            btnAgregarMedicamento.Text = "Agregar";
            btnAgregarMedicamento.UseVisualStyleBackColor = true;
            btnAgregarMedicamento.Click += btnAgregarMedicamento_Click;
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
            pictureBox1.TabIndex = 9;
            pictureBox1.TabStop = false;
            pictureBox1.Click += flecha_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(519, 64);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(235, 229);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 10;
            pictureBox2.TabStop = false;
            // 
            // MedicamentoService
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(834, 411);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(btnAgregarMedicamento);
            Controls.Add(txtPrecio);
            Controls.Add(txtGanancia);
            Controls.Add(txtNombreMedicamento);
            Controls.Add(lblPrecio);
            Controls.Add(lblGanancia);
            Controls.Add(lblNombreMedicamento);
            Name = "MedicamentoService";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MedicamentoService";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNombreMedicamento;
        private Label lblGanancia;
        private Label lblPrecio;
        private TextBox txtNombreMedicamento;
        private TextBox txtGanancia;
        private TextBox txtPrecio;
        private Button btnAgregarMedicamento;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
    }
}