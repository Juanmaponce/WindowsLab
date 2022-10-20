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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnArea_Click(object sender, EventArgs e)
        {
            decimal alto = Convert.ToDecimal(txtAlto.Text);
            decimal ancho = Convert.ToDecimal(txtAncho.Text);
            decimal areaRectanguo = CalcularArea(alto, ancho);

            MessageBox.Show(areaRectanguo.ToString());
            
        }
        #region mis metodos

        public decimal CalcularArea(decimal numero1, decimal numero2)
        {
            decimal area;
            area = numero1 * numero2;
            return area;
        }
        #endregion
    }
}
