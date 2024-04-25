using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace exemplo_polimorfismo
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
        //instanciamento do objeto incompleto
        empregado objeto = null;
        private void btn_verificar_Click(object sender, EventArgs e)
        {
            if (rd_assalariado.Checked)
            {
                objeto = new assalariado();
                double t;
                t = 0;
                lbl_data_vencimento.Text = objeto.vencimento(t).ToString();
            }
            else if (rd_comissionado.Checked)
            {
                objeto = new comissionado();
                double t;
                t = 0;
                lbl_data_vencimento.Text = objeto.vencimento(t).ToString();
            }
            else if (rd_horista.Checked)
            {
                objeto = new horista();
                double t;
                t = 0;
                lbl_data_vencimento.Text = objeto.vencimento(t).ToString();
            }
            objeto.setNome(txt_nome.Text);
            lbl_nome.Text = objeto.getNome();
            objeto.setCpf(txt_cpf.Text);
            lbl_cpf.Text = objeto.getCpf();
            objeto.setSobrenome(txt_sobrenome.Text);
            lbl_sobrenome.Text = objeto.getSobrenome();

        }

    }
}
