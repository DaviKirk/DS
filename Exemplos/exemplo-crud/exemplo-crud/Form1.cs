using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace exemplo_crud
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        colaborador c = new colaborador();

        private void btn_salvar_Click(object sender, EventArgs e)
        {
            try
            {
                c.setCpf(txt_cpf.Text);
                c.setNome(txt_nome.Text);
                c.setSobreNome(txt_sobrenome.Text);
                //chamar o metodo inserir
                c.inserir();
            }
            finally
            {
                MessageBox.Show("informações gravadas com sucesso");
            }

        }

        private void btn_consulta_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = c.Consultar();
        }

        private void btn_exluir_Click(object sender, EventArgs e)
        {
            try
            {
                c.setCodigo(txt_id.Text);
                c.excluir();
                dataGridView1.DataSource = c.Consultar();
            }
            finally
            {
                MessageBox.Show("informações excluídas com sucesso");
            }
        }
    }
}
