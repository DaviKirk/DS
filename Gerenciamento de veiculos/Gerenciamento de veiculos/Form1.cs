using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gerenciamento_de_veiculos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        carro c = new carro();
        private void button1_Click(object sender, EventArgs e)
        {
            c.setModelo(txt_modelo.Text);
            c.setMarca(txt_marca.Text);
            c.setCor(txt_cor.Text);
            c.setNumeroDePortas(txt_numeroDePorta.Text);
            c.setNumeroDeRodas(txt_numeroDeRodas.Text);
            c.setAnoDeFabricacao(txt_anoDefabricacao.Text);


        }
    }
}
