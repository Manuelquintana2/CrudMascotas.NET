namespace AppMascotasUI
{
    partial class MascotaFav
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
            imagenMascota = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)imagenMascota).BeginInit();
            SuspendLayout();
            // 
            // imagenMascota
            // 
            imagenMascota.Location = new Point(12, 32);
            imagenMascota.Name = "imagenMascota";
            imagenMascota.Size = new Size(301, 377);
            imagenMascota.TabIndex = 0;
            imagenMascota.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 17F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(364, 32);
            label1.Name = "label1";
            label1.Size = new Size(100, 40);
            label1.TabIndex = 1;
            label1.Text = "label1";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 17F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(364, 98);
            label2.Name = "label2";
            label2.Size = new Size(100, 40);
            label2.TabIndex = 2;
            label2.Text = "label2";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 17F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(364, 161);
            label4.Name = "label4";
            label4.Size = new Size(100, 40);
            label4.TabIndex = 4;
            label4.Text = "label4";
            // 
            // MascotaFav
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(imagenMascota);
            Name = "MascotaFav";
            Text = "MascotaFav";
            Load += MascotaFav_Load;
            ((System.ComponentModel.ISupportInitialize)imagenMascota).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox imagenMascota;
        private Label label1;
        private Label label2;
        private Label label4;
    }
}