using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FUNCIONA_PELOAMORDEEUS
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

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
    }
}
