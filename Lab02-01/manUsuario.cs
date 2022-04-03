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
    public partial class manUsuario : Form
    {
        
        public manUsuario()
        {
            InitializeComponent();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string DNI = txtDNI.Text;
            string nombre = txtNombre.Text;
            string apellido = txtApellido.Text;
            string telefono = txtTelefono.Text;
            string email = txtEmail.Text;
            string direccion = txtDireccion.Text;
            string fechaNac = txtFechaNac.Text;


            dgvUsuarios.Rows.Add(DNI, nombre, apellido, telefono, email, direccion, fechaNac);
        }

        private void dgvUsuarios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
