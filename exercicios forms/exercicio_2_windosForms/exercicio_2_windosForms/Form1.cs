using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace exercicio_2_windosForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void click_anos(object sender, EventArgs e)
        {

        }

        private void converter_Click(object sender, EventArgs e)
        {
            double anos, dias;
            anos = double.Parse(txt_anos.Text);
            dias = anos * 365;
            text_resultado.Text = dias.ToString();

        }

        private void text_dias(object sender, EventArgs e)
        {

        }

        private void txt_anos_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
