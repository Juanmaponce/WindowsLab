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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void btnMultiplicar_Click(object sender, EventArgs e)
        {
            int numero = Convert.ToInt32(txtNumero.Text);
            string valores =Multiplicar(numero);
            MessageBox.Show(valores);

        }

        #region mis metodos

        public string Multiplicar(int num)
        {
            int[] mults = new int[12];
            for (int i = 1; i <= 12; i++)
            {
                int mult = num * i;
                mults[i-1] = mult;
                
            }
            string result = String.Join(" , ", mults);
            return result;

        }

        #endregion
    }
}
