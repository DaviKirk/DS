using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace exercicio_4_e_5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_calcular_Click(object sender, EventArgs e)
        {
            // Variables to store grades and result
            int num1, num2, num3, num4, resultado;

            // Parsing input from text boxes to integers
            num1 = int.Parse(txt_primeiranota.Text);
            num2 = int.Parse(txt_segundanota.Text);
            num3 = int.Parse(txt_terceiranota.Text);
            num4 = int.Parse(txt_quartanota.Text);

            // Calculating average
            resultado = num1 + num2 + num3 + num4;
            resultado = resultado / 4;

            // Assigning grade based on the average
            if (resultado <= 5)
            {
                txt_resultado.Text = "I"; // Insufficient
                txt_resultado.ForeColor = Color.Red;
            }
            else if (resultado <= 7)
            {
                txt_resultado.Text = "R"; // Regular
                txt_resultado.ForeColor = Color.Orange;
            }
            else if (resultado <= 9)
            {
                txt_resultado.Text = "B"; // Good
                txt_resultado.ForeColor = Color.Blue;
            }
            else if (resultado <= 10)
            {
                txt_resultado.Text = "MB"; // Very Good
                txt_resultado.ForeColor = Color.Blue;
            }
        }
    }
}
