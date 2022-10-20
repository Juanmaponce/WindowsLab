using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsLab
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void btnValidar_Click(object sender, EventArgs e)
        {
            string name = txtNombre.Text;
            string rol = txtRol.Text;
            string sex = txtSexo.Text;
            if (ValidarSexo(sex) && ValidarSexo(rol))
            {
                MessageBox.Show("Nombre: " + name + "\n" + "Rol:" + rol + "\n" + "Sexo" + sex);
            }
            else
            {
                MessageBox.Show("Sexo o Rol invalido");
            }
            
        }

        public bool ValidarRol(string rol)
        {
            bool valid;
            if(rol.ToLower() != "administrador" && rol.ToLower() != "estandar" && rol.ToLower() != "invitados")
            {
                valid = false;
            }
            else
            {
                valid=true;
            }
            return valid;
        }
        public bool ValidarSexo(string sexo)
        {
            bool valid;
            if (sexo.ToLower() != "masculino" && sexo.ToLower() != "femenino")
            {
                valid = false;
            }
            else
            {
                valid = true;
            }
            return valid;
        }
    }
}
