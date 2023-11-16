namespace AppMascotasUI
{
    partial class FrmModificarPerro
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
            lblVelocidad = new Label();
            numVelocidad = new NumericUpDown();
            label5 = new Label();
            numComer = new NumericUpDown();
            gBoxRaza = new GroupBox();
            rBtnDooberman = new RadioButton();
            rBtnRotweiller = new RadioButton();
            rBtnPitbull = new RadioButton();
            rBtnGalgo = new RadioButton();
            ((System.ComponentModel.ISupportInitialize)numEdad).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numPeso).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numPatas).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numVelocidad).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numComer).BeginInit();
            gBoxRaza.SuspendLayout();
            SuspendLayout();
            // 
            // btnModificar
            // 
            btnModificar.Click += btnModificar_Click_1;
            // 
            // btnCancelar
            // 
            btnCancelar.Click += btnCancelar_Click;
            // 
            // lblVelocidad
            // 
            lblVelocidad.AutoSize = true;
            lblVelocidad.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblVelocidad.Location = new Point(349, 253);
            lblVelocidad.Name = "lblVelocidad";
            lblVelocidad.Size = new Size(67, 28);
            lblVelocidad.TabIndex = 16;
            lblVelocidad.Text = "Km/H";
            // 
            // numVelocidad
            // 
            numVelocidad.Location = new Point(266, 284);
            numVelocidad.Name = "numVelocidad";
            numVelocidad.Size = new Size(242, 27);
            numVelocidad.TabIndex = 17;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(223, 314);
            label5.Name = "label5";
            label5.Size = new Size(328, 28);
            label5.TabIndex = 18;
            label5.Text = " Tiempo para comer (en minutos)";
            // 
            // numComer
            // 
            numComer.Location = new Point(266, 345);
            numComer.Name = "numComer";
            numComer.Size = new Size(242, 27);
            numComer.TabIndex = 19;
            // 
            // gBoxRaza
            // 
            gBoxRaza.Controls.Add(rBtnDooberman);
            gBoxRaza.Controls.Add(rBtnRotweiller);
            gBoxRaza.Controls.Add(rBtnPitbull);
            gBoxRaza.Controls.Add(rBtnGalgo);
            gBoxRaza.Location = new Point(32, 40);
            gBoxRaza.Name = "gBoxRaza";
            gBoxRaza.Size = new Size(173, 307);
            gBoxRaza.TabIndex = 20;
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
            // FrmModificarPerro
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(gBoxRaza);
            Controls.Add(numComer);
            Controls.Add(label5);
            Controls.Add(numVelocidad);
            Controls.Add(lblVelocidad);
            Name = "FrmModificarPerro";
            Text = "FrmModificarPerro";
            Load += FrmModificarPerro_Load;
            Controls.SetChildIndex(txtNombre, 0);
            Controls.SetChildIndex(numEdad, 0);
            Controls.SetChildIndex(numPeso, 0);
            Controls.SetChildIndex(numPatas, 0);
            Controls.SetChildIndex(btnModificar, 0);
            Controls.SetChildIndex(btnCancelar, 0);
            Controls.SetChildIndex(lblVelocidad, 0);
            Controls.SetChildIndex(numVelocidad, 0);
            Controls.SetChildIndex(label5, 0);
            Controls.SetChildIndex(numComer, 0);
            Controls.SetChildIndex(gBoxRaza, 0);
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

        private Label lblVelocidad;
        private NumericUpDown numVelocidad;
        private Label label5;
        private NumericUpDown numComer;
        private GroupBox gBoxRaza;
        private RadioButton rBtnDooberman;
        private RadioButton rBtnRotweiller;
        private RadioButton rBtnPitbull;
        private RadioButton rBtnGalgo;
    }
}