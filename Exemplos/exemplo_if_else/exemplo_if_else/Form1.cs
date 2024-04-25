using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace exemplo_if_else
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }


        private void rdb_manha_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rdb_noite_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rdb_tarde_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btn_escolha_Click(object sender, EventArgs e)
        {
            if (rdb_manha.Checked == true)
            {
                MessageBox.Show("você escolheu manhã");
            }
            else if (rdb_tarde.Checked == true)
            {
                MessageBox.Show("você escolheu tarde");
            }
            else if (rdb_noite.Checked == true)
            {
                MessageBox.Show("você escolheu noite");
            }
            else
            {
                MessageBox.Show("Escolha um dos periodos primeiro!");
            }
        }
    }
}
