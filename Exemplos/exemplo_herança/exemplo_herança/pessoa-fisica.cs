using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exemplo_herança
{
    // ":" é o sinal que possibilita a herança 
    class pessoa_fisica : pessoa
    {
        private string rg;

        public void setRG(string rg)
        {
            this.rg = rg;
        }
        public string getRg()
        {
            return this.rg;
        }
    }
}
