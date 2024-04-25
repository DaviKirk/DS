using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace exemploOperacaoForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btn_somar(object sender, EventArgs e)
        {
            //Declaração de variavel
           double n1, n2, n3 , soma;
            n1 = double.Parse(txt_numero1.Text);
            n2 = double.Parse(txt_numero2.Text);
            n3 = double.Parse(txt_numero3.Text);
            soma = (n1 + n2)+ n3;
            //Exibição do resultado na caixa de texto
            txt_resultado.Text = soma.ToString();
            //ToString converter o valor de variavel para texto
        }

        private void txt_numero1_click(object sender, EventArgs e)
        {

        }

        private void txt_numero2_click(object sender, EventArgs e)
        {

        }

        private void txt_resultado_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void txt_numero3_click(object sender, EventArgs e)
        {

        }

        private void btn_subtrair(object sender, EventArgs e)
        {
            //Declaração de variavel
            double n1, n2, n3, soma;
            n1 = double.Parse(txt_numero1.Text);
            n2 = double.Parse(txt_numero2.Text);
            n3 = double.Parse(txt_numero3.Text);
            soma = (n1 - n2) - n3;
            //Exibição do resultado na caixa de texto
            txt_resultado.Text = soma.ToString();
            //ToString converter o valor de variavel para texto
        }

        private void btn_multiplicar(object sender, EventArgs e)
        {
            //Declaração de variavel
            double n1, n2, n3, soma;
            n1 = double.Parse(txt_numero1.Text);
            n2 = double.Parse(txt_numero2.Text);
            n3 = double.Parse(txt_numero3.Text);
            soma = (n1 * n2) * n3;
            //Exibição do resultado na caixa de texto
            txt_resultado.Text = soma.ToString();
            //ToString converter o valor de variavel para texto
        }

        private void btn_dividir(object sender, EventArgs e)
        {
            //Declaração de variavel
            double n1, n2, n3, soma;
            n1 = double.Parse(txt_numero1.Text);
            n2 = double.Parse(txt_numero2.Text);
            n3 = double.Parse(txt_numero3.Text);
            soma = (n1 / n2) / n3;
            //Exibição do resultado na caixa de texto
            txt_resultado.Text = soma.ToString();
            //ToString converter o valor de variavel para texto
        }

        private void txt_numero1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
