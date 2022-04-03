using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab02_01
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            if (txtUsuario.TextLength > 6)
            {

                    PrincipalMDI principal = new PrincipalMDI();
                principal.Show();
                this.Hide();

                }
                else msgError("Tu usuario es el número de tu DNI");

            }
        private void msgError(string msg)
        {
            lblErrorUsuario.Text = "    " + msg;
            lblErrorUsuario.Visible = true;
        }


        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtUsuario_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
