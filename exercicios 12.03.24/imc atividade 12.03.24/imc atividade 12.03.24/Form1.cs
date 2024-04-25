using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace imc_atividade_12._03._24
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_IMCcalc_Click(object sender, EventArgs e)
        {
            double imc, altura = 0, peso;
            altura = double.Parse(txt_box1.Text);
            peso = double.Parse(txt_box2.Text);

            imc = peso / (altura * altura);

            lbl_resultado.Text = imc.ToString();

            if(imc <= 16)
            {
                lbl_resultado.Text = "Baixo peso Grau III";
            }
            else if (imc <= 16.99)
            {
                lbl_resultado.Text = "Baixo peso Grau II";
            }
            else if (imc <= 18.49)
            {
                lbl_resultado.Text = "Baixo peso Grau I";
            }
            else if (imc <= 24.99)
            {
                lbl_resultado.Text = " Peso saudável";
            }
            else if (imc <= 29.99)
            {
                lbl_resultado.Text = " Sobrepeso ";
            }
            else if (imc <= 34.99)
            {
                lbl_resultado.Text = " Obesidade Grau I  ";
            }
            else if (imc <= 39.99)
            {
                lbl_resultado.Text = " Obesidade Grau II  ";
            }
            else if (imc >= 40)
            {
                lbl_resultado.Text = " Obesidade Grau III  ";
            }

        }

        private void lbl_resultado_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
