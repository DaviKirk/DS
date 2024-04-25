using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Media_Final_Orientado_Obj
{
    class calculo_notas
    {
        public double calculoNotas(double nota1, double nota2, double nota3, double nota4)
        {
            return ((nota1 + nota2 + nota3 + nota4) / 4);
        }
    }
}
