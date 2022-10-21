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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void btnNombreCompleto_Click(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text;
            string apellido = txtApellido.Text;

            string nombreCompleto = Concatenar(nombre, apellido);
            MessageBox.Show(nombreCompleto);
        }
        private void btnCompleto_Click(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text;
            string apellido = txtApellido.Text;
            int fechaNacimieto = dateTimePicker1.Value.Year;
            string nombreCompleto = Concatenar(nombre, apellido, fechaNacimieto);
            MessageBox.Show(nombreCompleto);
        }

        #region Metodos

        public string Concatenar(string name, string lastname)
        {
            return name + ", " + lastname;
        }

        public string Concatenar(string name, string lastname, int birthday)
        {
            int fechaActual = DateTime.Today.Year;
            int edad = fechaActual - birthday;
            return "name" +", "+ lastname +" tiene "+ edad +" años";
        }

        #endregion

    }
}
