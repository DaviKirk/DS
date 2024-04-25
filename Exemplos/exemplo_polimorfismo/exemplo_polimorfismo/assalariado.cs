using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exemplo_polimorfismo
{
    class assalariado : empregado
    {
        private double salario;

        public void setSalario(double salario)
        {
            this.salario = salario;
        }
        public double getSalario()
        {
            return this.salario;
        }

        //o metodo vencimento da classe assalariado e gerdado da classe empregado que tambem possui um metodo de nome vencimento.
        //sendo assim necessario adicionar a palavra overrride(sobrepor) na frente da visibilidade
        public override double vencimento(double valor)
        {
            valor = 1000;
            return valor;
        }
    }
}
