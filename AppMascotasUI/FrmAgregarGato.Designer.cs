namespace AppMascotasUI
{
    partial class FrmAgregarGato
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
            label5 = new Label();
            numReaccion = new NumericUpDown();
            label6 = new Label();
            numSalto = new NumericUpDown();
            gBoxRaza = new GroupBox();
            rBtnBambino = new RadioButton();
            rBtnBritanico = new RadioButton();
            rBtnPersa = new RadioButton();
            rBtnSiames = new RadioButton();
            btnAgregar = new Button();
            btnCancelar = new Button();
            ((System.ComponentModel.ISupportInitialize)numEdad).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numPeso).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numPatas).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numReaccion).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numSalto).BeginInit();
            gBoxRaza.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(336, 9);
            label1.Name = "label1";
            label1.Size = new Size(89, 28);
            label1.TabIndex = 1;
            label1.Text = "Nombre";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(261, 40);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(242, 27);
            txtNombre.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(345, 70);
            label2.Name = "label2";
            label2.Size = new Size(58, 28);
            label2.TabIndex = 3;
            label2.Text = "Edad";
            // 
            // numEdad
            // 
            numEdad.Location = new Point(261, 101);
            numEdad.Name = "numEdad";
            numEdad.Size = new Size(242, 27);
            numEdad.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(345, 131);
            label3.Name = "label3";
            label3.Size = new Size(55, 28);
            label3.TabIndex = 5;
            label3.Text = "Peso";
            // 
            // numPeso
            // 
            numPeso.Location = new Point(261, 162);
            numPeso.Name = "numPeso";
            numPeso.Size = new Size(242, 27);
            numPeso.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(305, 192);
            label4.Name = "label4";
            label4.Size = new Size(145, 28);
            label4.TabIndex = 7;
            label4.Text = "Total de patas";
            // 
            // numPatas
            // 
            numPatas.Location = new Point(261, 223);
            numPatas.Maximum = new decimal(new int[] { 5, 0, 0, 0 });
            numPatas.Name = "numPatas";
            numPatas.Size = new Size(242, 27);
            numPatas.TabIndex = 8;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(261, 253);
            label5.Name = "label5";
            label5.Size = new Size(303, 28);
            label5.TabIndex = 9;
            label5.Text = "Tiempo de reaccion(Segundos)";
            // 
            // numReaccion
            // 
            numReaccion.Location = new Point(261, 284);
            numReaccion.Maximum = new decimal(new int[] { 5, 0, 0, 0 });
            numReaccion.Name = "numReaccion";
            numReaccion.Size = new Size(242, 27);
            numReaccion.TabIndex = 10;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(305, 314);
            label6.Name = "label6";
            label6.Size = new Size(160, 28);
            label6.TabIndex = 11;
            label6.Text = "Metros de salto";
            // 
            // numSalto
            // 
            numSalto.Location = new Point(261, 345);
            numSalto.Maximum = new decimal(new int[] { 5, 0, 0, 0 });
            numSalto.Name = "numSalto";
            numSalto.Size = new Size(242, 27);
            numSalto.TabIndex = 12;
            // 
            // gBoxRaza
            // 
            gBoxRaza.Controls.Add(rBtnBambino);
            gBoxRaza.Controls.Add(rBtnBritanico);
            gBoxRaza.Controls.Add(rBtnPersa);
            gBoxRaza.Controls.Add(rBtnSiames);
            gBoxRaza.Location = new Point(5, 52);
            gBoxRaza.Name = "gBoxRaza";
            gBoxRaza.Size = new Size(250, 320);
            gBoxRaza.TabIndex = 13;
            gBoxRaza.TabStop = false;
            gBoxRaza.Text = "Raza";
            // 
            // rBtnBambino
            // 
            rBtnBambino.AutoSize = true;
            rBtnBambino.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            rBtnBambino.Location = new Point(7, 235);
            rBtnBambino.Name = "rBtnBambino";
            rBtnBambino.Size = new Size(93, 24);
            rBtnBambino.TabIndex = 3;
            rBtnBambino.TabStop = true;
            rBtnBambino.Text = "Bambino";
            rBtnBambino.UseVisualStyleBackColor = true;
            // 
            // rBtnBritanico
            // 
            rBtnBritanico.AutoSize = true;
            rBtnBritanico.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            rBtnBritanico.Location = new Point(7, 174);
            rBtnBritanico.Name = "rBtnBritanico";
            rBtnBritanico.Size = new Size(93, 24);
            rBtnBritanico.TabIndex = 2;
            rBtnBritanico.TabStop = true;
            rBtnBritanico.Text = "Britanico";
            rBtnBritanico.UseVisualStyleBackColor = true;
            // 
            // rBtnPersa
            // 
            rBtnPersa.AutoSize = true;
            rBtnPersa.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            rBtnPersa.Location = new Point(7, 113);
            rBtnPersa.Name = "rBtnPersa";
            rBtnPersa.Size = new Size(68, 24);
            rBtnPersa.TabIndex = 1;
            rBtnPersa.TabStop = true;
            rBtnPersa.Text = "Persa";
            rBtnPersa.UseVisualStyleBackColor = true;
            // 
            // rBtnSiames
            // 
            rBtnSiames.AutoSize = true;
            rBtnSiames.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            rBtnSiames.Location = new Point(7, 52);
            rBtnSiames.Name = "rBtnSiames";
            rBtnSiames.Size = new Size(79, 24);
            rBtnSiames.TabIndex = 0;
            rBtnSiames.TabStop = true;
            rBtnSiames.Text = "Siames";
            rBtnSiames.UseVisualStyleBackColor = true;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(261, 383);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(96, 55);
            btnAgregar.TabIndex = 14;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(407, 383);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(96, 55);
            btnCancelar.TabIndex = 15;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // FrmAgregarGato
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnCancelar);
            Controls.Add(btnAgregar);
            Controls.Add(gBoxRaza);
            Controls.Add(numSalto);
            Controls.Add(label6);
            Controls.Add(numReaccion);
            Controls.Add(label5);
            Controls.Add(numPatas);
            Controls.Add(label4);
            Controls.Add(numPeso);
            Controls.Add(label3);
            Controls.Add(numEdad);
            Controls.Add(label2);
            Controls.Add(txtNombre);
            Controls.Add(label1);
            Name = "FrmAgregarGato";
            Text = "FrmAgregarGato";
            ((System.ComponentModel.ISupportInitialize)numEdad).EndInit();
            ((System.ComponentModel.ISupportInitialize)numPeso).EndInit();
            ((System.ComponentModel.ISupportInitialize)numPatas).EndInit();
            ((System.ComponentModel.ISupportInitialize)numReaccion).EndInit();
            ((System.ComponentModel.ISupportInitialize)numSalto).EndInit();
            gBoxRaza.ResumeLayout(false);
            gBoxRaza.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtNombre;
        private Label label2;
        private NumericUpDown numEdad;
        private Label label3;
        private NumericUpDown numPeso;
        private Label label4;
        private NumericUpDown numPatas;
        private Label label5;
        private NumericUpDown numReaccion;
        private Label label6;
        private NumericUpDown numSalto;
        private GroupBox gBoxRaza;
        private RadioButton rBtnSiames;
        private RadioButton rBtnBambino;
        private RadioButton rBtnBritanico;
        private RadioButton rBtnPersa;
        private Button btnAgregar;
        private Button btnCancelar;
    }
}