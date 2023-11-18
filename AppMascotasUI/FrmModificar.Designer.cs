namespace AppMascotasUI
{
    partial class FrmModificar
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
            label1 = new Label();
            txtNombre = new TextBox();
            label2 = new Label();
            numEdad = new NumericUpDown();
            label3 = new Label();
            numPeso = new NumericUpDown();
            label4 = new Label();
            numPatas = new NumericUpDown();
            btnModificar = new Button();
            btnCancelar = new Button();
            lblId = new Label();
            numId = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)numEdad).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numPeso).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numPatas).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numId).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(346, 9);
            label1.Name = "label1";
            label1.Size = new Size(89, 28);
            label1.TabIndex = 0;
            label1.Text = "Nombre";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(266, 40);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(242, 27);
            txtNombre.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(358, 70);
            label2.Name = "label2";
            label2.Size = new Size(58, 28);
            label2.TabIndex = 3;
            label2.Text = "Edad";
            // 
            // numEdad
            // 
            numEdad.Location = new Point(266, 101);
            numEdad.Name = "numEdad";
            numEdad.Size = new Size(242, 27);
            numEdad.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(358, 131);
            label3.Name = "label3";
            label3.Size = new Size(55, 28);
            label3.TabIndex = 5;
            label3.Text = "Peso";
            // 
            // numPeso
            // 
            numPeso.Location = new Point(266, 162);
            numPeso.Name = "numPeso";
            numPeso.Size = new Size(242, 27);
            numPeso.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(312, 192);
            label4.Name = "label4";
            label4.Size = new Size(145, 28);
            label4.TabIndex = 7;
            label4.Text = "Total de patas";
            // 
            // numPatas
            // 
            numPatas.Location = new Point(266, 223);
            numPatas.Name = "numPatas";
            numPatas.Size = new Size(242, 27);
            numPatas.TabIndex = 8;
            // 
            // btnModificar
            // 
            btnModificar.Location = new Point(266, 383);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(96, 55);
            btnModificar.TabIndex = 14;
            btnModificar.Text = "Modificar";
            btnModificar.UseVisualStyleBackColor = true;
            btnModificar.Click += btnModificar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(412, 383);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(96, 55);
            btnCancelar.TabIndex = 15;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // lblId
            // 
            lblId.AutoSize = true;
            lblId.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblId.Location = new Point(592, 70);
            lblId.Name = "lblId";
            lblId.Size = new Size(144, 28);
            lblId.TabIndex = 17;
            lblId.Text = "Id a modificar";
            // 
            // numId
            // 
            numId.Location = new Point(546, 101);
            numId.Name = "numId";
            numId.Size = new Size(242, 27);
            numId.TabIndex = 18;
            // 
            // FrmModificar
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(numId);
            Controls.Add(lblId);
            Controls.Add(btnCancelar);
            Controls.Add(btnModificar);
            Controls.Add(numPatas);
            Controls.Add(label4);
            Controls.Add(numPeso);
            Controls.Add(label3);
            Controls.Add(numEdad);
            Controls.Add(label2);
            Controls.Add(txtNombre);
            Controls.Add(label1);
            Name = "FrmModificar";
            Text = "FrmModificar";
            Load += FrmModificar_Load;
            ((System.ComponentModel.ISupportInitialize)numEdad).EndInit();
            ((System.ComponentModel.ISupportInitialize)numPeso).EndInit();
            ((System.ComponentModel.ISupportInitialize)numPatas).EndInit();
            ((System.ComponentModel.ISupportInitialize)numId).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        protected TextBox txtNombre;
        protected NumericUpDown numEdad;
        protected NumericUpDown numPeso;
        protected NumericUpDown numPatas;
        protected Button btnModificar;
        protected Button btnCancelar;
        private Label lblId;
        protected NumericUpDown numId;
    }
}