namespace AppMascotasUI
{
    partial class FrmAgregarPerro
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
            lblVelocidad = new Label();
            numVelocidad = new NumericUpDown();
            label5 = new Label();
            numComer = new NumericUpDown();
            gBoxRaza = new GroupBox();
            rBtnDooberman = new RadioButton();
            rBtnRotweiller = new RadioButton();
            rBtnPitbull = new RadioButton();
            rBtnGalgo = new RadioButton();
            btnAgregar = new Button();
            btnCancelar = new Button();
            ((System.ComponentModel.ISupportInitialize)numEdad).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numPeso).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numPatas).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numVelocidad).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numComer).BeginInit();
            gBoxRaza.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(282, 9);
            label1.Name = "label1";
            label1.Size = new Size(89, 28);
            label1.TabIndex = 0;
            label1.Text = "Nombre";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(200, 40);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(242, 27);
            txtNombre.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(292, 70);
            label2.Name = "label2";
            label2.Size = new Size(58, 28);
            label2.TabIndex = 2;
            label2.Text = "Edad";
            // 
            // numEdad
            // 
            numEdad.Location = new Point(200, 101);
            numEdad.Maximum = new decimal(new int[] { 30, 0, 0, 0 });
            numEdad.Name = "numEdad";
            numEdad.Size = new Size(242, 27);
            numEdad.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(292, 131);
            label3.Name = "label3";
            label3.Size = new Size(55, 28);
            label3.TabIndex = 4;
            label3.Text = "Peso";
            // 
            // numPeso
            // 
            numPeso.Location = new Point(200, 157);
            numPeso.Name = "numPeso";
            numPeso.Size = new Size(242, 27);
            numPeso.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(247, 192);
            label4.Name = "label4";
            label4.Size = new Size(145, 28);
            label4.TabIndex = 6;
            label4.Text = "Total de patas";
            // 
            // numPatas
            // 
            numPatas.Location = new Point(200, 223);
            numPatas.Maximum = new decimal(new int[] { 5, 0, 0, 0 });
            numPatas.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numPatas.Name = "numPatas";
            numPatas.Size = new Size(242, 27);
            numPatas.TabIndex = 7;
            numPatas.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // lblVelocidad
            // 
            lblVelocidad.AutoSize = true;
            lblVelocidad.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblVelocidad.Location = new Point(282, 253);
            lblVelocidad.Name = "lblVelocidad";
            lblVelocidad.Size = new Size(67, 28);
            lblVelocidad.TabIndex = 8;
            lblVelocidad.Text = "Km/H";
            // 
            // numVelocidad
            // 
            numVelocidad.Location = new Point(200, 284);
            numVelocidad.Name = "numVelocidad";
            numVelocidad.Size = new Size(242, 27);
            numVelocidad.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(200, 314);
            label5.Name = "label5";
            label5.Size = new Size(328, 28);
            label5.TabIndex = 10;
            label5.Text = " Tiempo para comer (en minutos)";
            // 
            // numComer
            // 
            numComer.Location = new Point(200, 345);
            numComer.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numComer.Name = "numComer";
            numComer.Size = new Size(242, 27);
            numComer.TabIndex = 11;
            numComer.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // gBoxRaza
            // 
            gBoxRaza.Controls.Add(rBtnDooberman);
            gBoxRaza.Controls.Add(rBtnRotweiller);
            gBoxRaza.Controls.Add(rBtnPitbull);
            gBoxRaza.Controls.Add(rBtnGalgo);
            gBoxRaza.Location = new Point(21, 40);
            gBoxRaza.Name = "gBoxRaza";
            gBoxRaza.Size = new Size(173, 307);
            gBoxRaza.TabIndex = 12;
            gBoxRaza.TabStop = false;
            gBoxRaza.Text = "Raza";
            // 
            // rBtnDooberman
            // 
            rBtnDooberman.AutoSize = true;
            rBtnDooberman.Location = new Point(6, 247);
            rBtnDooberman.Name = "rBtnDooberman";
            rBtnDooberman.Size = new Size(110, 24);
            rBtnDooberman.TabIndex = 3;
            rBtnDooberman.TabStop = true;
            rBtnDooberman.Text = "Dooberman";
            rBtnDooberman.UseVisualStyleBackColor = true;
            // 
            // rBtnRotweiller
            // 
            rBtnRotweiller.AutoSize = true;
            rBtnRotweiller.Location = new Point(6, 186);
            rBtnRotweiller.Name = "rBtnRotweiller";
            rBtnRotweiller.Size = new Size(97, 24);
            rBtnRotweiller.TabIndex = 2;
            rBtnRotweiller.TabStop = true;
            rBtnRotweiller.Text = "Rotweiller";
            rBtnRotweiller.UseVisualStyleBackColor = true;
            // 
            // rBtnPitbull
            // 
            rBtnPitbull.AutoSize = true;
            rBtnPitbull.Location = new Point(6, 120);
            rBtnPitbull.Name = "rBtnPitbull";
            rBtnPitbull.Size = new Size(72, 24);
            rBtnPitbull.TabIndex = 1;
            rBtnPitbull.TabStop = true;
            rBtnPitbull.Text = "Pitbull";
            rBtnPitbull.UseVisualStyleBackColor = true;
            // 
            // rBtnGalgo
            // 
            rBtnGalgo.AutoSize = true;
            rBtnGalgo.Location = new Point(6, 64);
            rBtnGalgo.Name = "rBtnGalgo";
            rBtnGalgo.Size = new Size(70, 24);
            rBtnGalgo.TabIndex = 0;
            rBtnGalgo.TabStop = true;
            rBtnGalgo.Text = "Galgo";
            rBtnGalgo.UseVisualStyleBackColor = true;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(200, 383);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(96, 55);
            btnAgregar.TabIndex = 13;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(346, 383);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(96, 55);
            btnCancelar.TabIndex = 14;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // FrmAgregarPerro
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(652, 450);
            Controls.Add(btnCancelar);
            Controls.Add(btnAgregar);
            Controls.Add(gBoxRaza);
            Controls.Add(numComer);
            Controls.Add(label5);
            Controls.Add(numVelocidad);
            Controls.Add(lblVelocidad);
            Controls.Add(numPatas);
            Controls.Add(label4);
            Controls.Add(numPeso);
            Controls.Add(label3);
            Controls.Add(numEdad);
            Controls.Add(label2);
            Controls.Add(txtNombre);
            Controls.Add(label1);
            Name = "FrmAgregarPerro";
            Text = "FrmAgregarPerro";
            ((System.ComponentModel.ISupportInitialize)numEdad).EndInit();
            ((System.ComponentModel.ISupportInitialize)numPeso).EndInit();
            ((System.ComponentModel.ISupportInitialize)numPatas).EndInit();
            ((System.ComponentModel.ISupportInitialize)numVelocidad).EndInit();
            ((System.ComponentModel.ISupportInitialize)numComer).EndInit();
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
        private Label lblVelocidad;
        private NumericUpDown numVelocidad;
        private Label label5;
        private NumericUpDown numComer;
        private GroupBox gBoxRaza;
        private RadioButton rBtnDooberman;
        private RadioButton rBtnRotweiller;
        private RadioButton rBtnPitbull;
        private RadioButton rBtnGalgo;
        private Button btnAgregar;
        private Button btnCancelar;
    }
}