using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace exemplo_orientação_obj
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int n1;
        int n2;
        //variavel global
        private void btn_somar_Click(object sender, EventArgs e)
        {
            //operações matematicas é o nome da classe 
            //op é o nome do objeto (apelido) se a classe tem um nome ela não pode ser chamada por e sim pelo apelido
            //new operacoes_matematicas é a criação do construtor da classe.

            //o codigo a baixo ultilizado para ligar a classe com o formulario (instanciar objeto)
            operacoes_matematicas op = new operacoes_matematicas();
            int n1 = int.Parse(txt_num1.Text);
            int n2 = int.Parse(txt_num2.Text);
            txt_resu.Text = "" + op.soma_dois_numeros(n1,n2);
        }
        private void btn_subtracao_Click(object sender, EventArgs e)
        {
            operacoes_matematicas op = new operacoes_matematicas();
            int n1 = int.Parse(txt_num1.Text);
            int n2 = int.Parse(txt_num2.Text);
            txt_resu.Text = "" + op.subtracao_dois_numeros(n1, n2);
        }

        private void btn_multi_Click(object sender, EventArgs e)
        {
            operacoes_matematicas op = new operacoes_matematicas();
            int n1 = int.Parse(txt_num1.Text);
            int n2 = int.Parse(txt_num2.Text);
            txt_resu.Text = "" + op.multiplicacao_dois_numeros(n1, n2);
        }

        private void btn_divisao_Click(object sender, EventArgs e)
        {
            operacoes_matematicas op = new operacoes_matematicas();
            int n1 = int.Parse(txt_num1.Text);
            int n2 = int.Parse(txt_num2.Text);
            txt_resu.Text = "" + op.divisao_dois_numeros(n1, n2);
        }
    }
}