namespace AppMascotasUI
{
    partial class FrmAgregarLoro
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
            numTiempoVuelo = new NumericUpDown();
            label6 = new Label();
            numAltura = new NumericUpDown();
            btnAgregar = new Button();
            btnCancelar = new Button();
            gBoxTipo = new GroupBox();
            rBtnEclecto = new RadioButton();
            rBtnAmazonico = new RadioButton();
            rBtnGuacamayo = new RadioButton();
            rBtnAfricano = new RadioButton();
            txtFrase = new TextBox();
            label7 = new Label();
            ((System.ComponentModel.ISupportInitialize)numEdad).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numPeso).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numPatas).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numTiempoVuelo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numAltura).BeginInit();
            gBoxTipo.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(330, 9);
            label1.Name = "label1";
            label1.Size = new Size(89, 28);
            label1.TabIndex = 1;
            label1.Text = "Nombre";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(255, 40);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(242, 27);
            txtNombre.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(341, 70);
            label2.Name = "label2";
            label2.Size = new Size(58, 28);
            label2.TabIndex = 3;
            label2.Text = "Edad";
            // 
            // numEdad
            // 
            numEdad.Location = new Point(255, 101);
            numEdad.Maximum = new decimal(new int[] { 30, 0, 0, 0 });
            numEdad.Name = "numEdad";
            numEdad.Size = new Size(242, 27);
            numEdad.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(344, 131);
            label3.Name = "label3";
            label3.Size = new Size(55, 28);
            label3.TabIndex = 5;
            label3.Text = "Peso";
            // 
            // numPeso
            // 
            numPeso.Location = new Point(255, 162);
            numPeso.Name = "numPeso";
            numPeso.Size = new Size(242, 27);
            numPeso.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(299, 192);
            label4.Name = "label4";
            label4.Size = new Size(145, 28);
            label4.TabIndex = 7;
            label4.Text = "Total de patas";
            // 
            // numPatas
            // 
            numPatas.Location = new Point(255, 223);
            numPatas.Maximum = new decimal(new int[] { 5, 0, 0, 0 });
            numPatas.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numPatas.Name = "numPatas";
            numPatas.Size = new Size(242, 27);
            numPatas.TabIndex = 8;
            numPatas.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(244, 253);
            label5.Name = "label5";
            label5.Size = new Size(267, 28);
            label5.TabIndex = 9;
            label5.Text = "Tiempo de vuelo(Semanas)";
            // 
            // numTiempoVuelo
            // 
            numTiempoVuelo.Location = new Point(255, 284);
            numTiempoVuelo.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numTiempoVuelo.Name = "numTiempoVuelo";
            numTiempoVuelo.Size = new Size(242, 27);
            numTiempoVuelo.TabIndex = 10;
            numTiempoVuelo.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(244, 314);
            label6.Name = "label6";
            label6.Size = new Size(267, 28);
            label6.TabIndex = 11;
            label6.Text = "Altura de vuelo(En metros)";
            // 
            // numAltura
            // 
            numAltura.Location = new Point(255, 345);
            numAltura.Maximum = new decimal(new int[] { 300, 0, 0, 0 });
            numAltura.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numAltura.Name = "numAltura";
            numAltura.Size = new Size(242, 27);
            numAltura.TabIndex = 12;
            numAltura.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(255, 383);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(96, 55);
            btnAgregar.TabIndex = 14;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(401, 383);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(96, 55);
            btnCancelar.TabIndex = 15;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // gBoxTipo
            // 
            gBoxTipo.Controls.Add(rBtnEclecto);
            gBoxTipo.Controls.Add(rBtnAmazonico);
            gBoxTipo.Controls.Add(rBtnGuacamayo);
            gBoxTipo.Controls.Add(rBtnAfricano);
            gBoxTipo.Location = new Point(12, 40);
            gBoxTipo.Name = "gBoxTipo";
            gBoxTipo.Size = new Size(173, 307);
            gBoxTipo.TabIndex = 16;
            gBoxTipo.TabStop = false;
            gBoxTipo.Text = "Tipo";
            // 
            // rBtnEclecto
            // 
            rBtnEclecto.AutoSize = true;
            rBtnEclecto.Location = new Point(6, 247);
            rBtnEclecto.Name = "rBtnEclecto";
            rBtnEclecto.Size = new Size(78, 24);
            rBtnEclecto.TabIndex = 3;
            rBtnEclecto.TabStop = true;
            rBtnEclecto.Text = "Eclecto";
            rBtnEclecto.UseVisualStyleBackColor = true;
            // 
            // rBtnAmazonico
            // 
            rBtnAmazonico.AutoSize = true;
            rBtnAmazonico.Location = new Point(6, 186);
            rBtnAmazonico.Name = "rBtnAmazonico";
            rBtnAmazonico.Size = new Size(105, 24);
            rBtnAmazonico.TabIndex = 2;
            rBtnAmazonico.TabStop = true;
            rBtnAmazonico.Text = "Amazonico";
            rBtnAmazonico.UseVisualStyleBackColor = true;
            // 
            // rBtnGuacamayo
            // 
            rBtnGuacamayo.AutoSize = true;
            rBtnGuacamayo.Location = new Point(6, 120);
            rBtnGuacamayo.Name = "rBtnGuacamayo";
            rBtnGuacamayo.Size = new Size(108, 24);
            rBtnGuacamayo.TabIndex = 1;
            rBtnGuacamayo.TabStop = true;
            rBtnGuacamayo.Text = "Guacamayo";
            rBtnGuacamayo.UseVisualStyleBackColor = true;
            // 
            // rBtnAfricano
            // 
            rBtnAfricano.AutoSize = true;
            rBtnAfricano.Location = new Point(6, 64);
            rBtnAfricano.Name = "rBtnAfricano";
            rBtnAfricano.Size = new Size(86, 24);
            rBtnAfricano.TabIndex = 0;
            rBtnAfricano.TabStop = true;
            rBtnAfricano.Text = "Africano";
            rBtnAfricano.UseVisualStyleBackColor = true;
            // 
            // txtFrase
            // 
            txtFrase.Location = new Point(525, 40);
            txtFrase.Name = "txtFrase";
            txtFrase.Size = new Size(242, 27);
            txtFrase.TabIndex = 17;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(567, 9);
            label7.Name = "label7";
            label7.Size = new Size(148, 28);
            label7.TabIndex = 18;
            label7.Text = "Frase a repetir";
            // 
            // FrmAgregarLoro
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label7);
            Controls.Add(txtFrase);
            Controls.Add(gBoxTipo);
            Controls.Add(btnCancelar);
            Controls.Add(btnAgregar);
            Controls.Add(numAltura);
            Controls.Add(label6);
            Controls.Add(numTiempoVuelo);
            Controls.Add(label5);
            Controls.Add(numPatas);
            Controls.Add(label4);
            Controls.Add(numPeso);
            Controls.Add(label3);
            Controls.Add(numEdad);
            Controls.Add(label2);
            Controls.Add(txtNombre);
            Controls.Add(label1);
            Name = "FrmAgregarLoro";
            Text = "FrmAgregarLoro";
            ((System.ComponentModel.ISupportInitialize)numEdad).EndInit();
            ((System.ComponentModel.ISupportInitialize)numPeso).EndInit();
            ((System.ComponentModel.ISupportInitialize)numPatas).EndInit();
            ((System.ComponentModel.ISupportInitialize)numTiempoVuelo).EndInit();
            ((System.ComponentModel.ISupportInitialize)numAltura).EndInit();
            gBoxTipo.ResumeLayout(false);
            gBoxTipo.PerformLayout();
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
        private NumericUpDown numTiempoVuelo;
        private Label label6;
        private NumericUpDown numAltura;
        private Button btnAgregar;
        private Button btnCancelar;
        private GroupBox gBoxTipo;
        private RadioButton rBtnEclecto;
        private RadioButton rBtnAmazonico;
        private RadioButton rBtnGuacamayo;
        private RadioButton rBtnAfricano;
        private TextBox txtFrase;
        private Label label7;
    }
}