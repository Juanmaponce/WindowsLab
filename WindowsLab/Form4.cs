using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace WindowsLab
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void btnCirculo_Click(object sender, EventArgs e)
        {
            string form = txtForma.Text;
            MessageBox.Show(CalcularArea(form).ToString());
        }

        public double CalcularArea(string forma)
        {
            double area;
            if (forma.ToUpper() == "CIRCULO")
            {
            double diametro = Convert.ToDouble(Interaction.InputBox("Ingresar diametro"));
            area = 0.25*diametro*3.14;
            }
            else if (forma.ToUpper() == "RECTANGULO")
            {
                double altura = Convert.ToDouble(Interaction.InputBox("Ingresar altura"));
                double ancho = Convert.ToDouble(Interaction.InputBox("Ingresar base"));
                area = altura * ancho;
            }
            else if (forma.ToUpper() == "TRAPECIO")
            {
                double altura = Convert.ToDouble(Interaction.InputBox("Ingresar altura"));
                double ancho1 = Convert.ToDouble(Interaction.InputBox("Ingresar base mayor"));
                double ancho2 = Convert.ToDouble(Interaction.InputBox("Ingresar base menor"));
                area = (altura * (ancho1+ancho2))/2;
            }
            else
            {
                area = 0;
            }
            return area;
        }

    }
}
