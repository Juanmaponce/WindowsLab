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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void btnValidar_Click(object sender, EventArgs e)
        {
            int edad = Convert.ToInt32(txtEdad.Text);

            string msjeValidacion = ValidarEdad(edad);

            MessageBox.Show(msjeValidacion);

        }

        public string ValidarEdad(int num)
        {
            if (num <= 0)
            {
                return "ERROR";
            }
            else if (num < 18)
            {
                return "Usted es menor de edad" ;
            }
            else if (num >= 18 && num < 60)
            {
                return "Usted es mayor de edad";
            }
            else if (num >= 60)
            {
                return "Usted es adulto mayor";
            }
            else
            {
                return "edad invalida";
            }
        }
    }
}
