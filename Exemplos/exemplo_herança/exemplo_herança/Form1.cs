﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace exemplo_herança
{
    public partial class Form1 : Form
    {

        funcionario f = new funcionario();
        private void btn_armazenar_Click(object sender, EventArgs e)
        {
            //captura das informações
            f.setNome(txt_nome.Text);
            f.setRG(txt_RG.Text);
            f.setCartao(txt_cartao.Text);

            //Mostrasr as informações

            lbl_nome.Text = f.getNome();
            lbl_RG.Text = f.getRg();
            lbl_cartao.Text = f.getCartao();

        }

        private void lbl_nome_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void lbl_RG_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void txt_cartao_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_RG_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_nome_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lbl_cartao_Click(object sender, EventArgs e)
        {

        }
    }
}
