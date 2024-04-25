using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Supermercado_comprar_estoque
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int quantidadeEstoque, QuantidadeMaximaEstoque;
        string nomeProduto;

        private void btn_mostrarInfo_Click(object sender, EventArgs e)
        {
            controle_de_estoque op = new controle_de_estoque();
            lbl_nome.Text = "Nome do produto: " + nomeProduto;
            lbl_quantEstoque.Text = "Quantidade em estoque: " + quantidadeEstoque;
            lbl_quantComprar.Text = "Quantidade Comprar: " + op.quantidadeProdutoEstoque(quantidadeEstoque, QuantidadeMaximaEstoque);
        }

        private void btn_enviarInfo_Click(object sender, EventArgs e)
        {
            quantidadeEstoque = int.Parse(txt_quantEstoque.Text);
            QuantidadeMaximaEstoque = int.Parse(txt_quantMaxEstoque.Text);
            nomeProduto = txt_nomeProduto.Text;
        
        }
    }
}
