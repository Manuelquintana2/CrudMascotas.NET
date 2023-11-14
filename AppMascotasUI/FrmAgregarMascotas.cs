using Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppMascotasUI
{
    public partial class FrmAgregarMascotas : Form
    {
        public Perro perro;
        public Gato gato;
        public Loro loro;
        public FrmAgregarMascotas()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Dependiendo el Radio Button que checkees, te habre el form correspondiente
        /// El dato obtenido, se le asigna al atributo correspondiente
        /// Se crean instancias nulas para que el codigo no rompa
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            this.perro = new Perro();
            this.gato = new Gato();
            this.loro = new Loro();
            if (rButtonPerro.Checked)
            {
                FrmAgregarPerro frm = new FrmAgregarPerro();
                frm.ShowDialog();
                if (frm.DialogResult == DialogResult.OK)
                {
                    this.perro = frm.perro;
                    this.DialogResult = DialogResult.OK;
                }
            }
            else
            {
                if (rButtonGato.Checked)
                {
                    FrmAgregarGato frm = new FrmAgregarGato();
                    frm.ShowDialog();
                    if(frm.DialogResult == DialogResult.OK)
                    {
                        this.gato = frm.gato;
                        this.DialogResult = DialogResult.OK;
                    }
                }
                else
                {
                    if (rButtonLoro.Checked)
                    {
                        FrmAgregarLoro frm = new FrmAgregarLoro();
                        frm.ShowDialog();
                        if(frm.DialogResult == DialogResult.OK)
                        {
                            this.loro = frm.loro;
                            this.DialogResult = DialogResult.OK;
                        }
                    }
                }
            }
        }
        private void gBoxMascotas_Enter(object sender, EventArgs e)
        {

        }
    }
}
