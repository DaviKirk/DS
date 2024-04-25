using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Media_Final_Orientado_Obj
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        double num1, num2, num3, num4;

        private void btn_somaMedia_Click(object sender, EventArgs e)
        {
            calculo_notas op = new calculo_notas();
            num1 = double.Parse(txt_nota1.Text);
            num2 = double.Parse(txt_nota2.Text);
            num3 = double.Parse(txt_nota3.Text);
            num4 = double.Parse(txt_nota4.Text);

            lbl_resu.Text = "" + op.calculoNotas(num1, num2, num3, num4);
        }
    }
}
