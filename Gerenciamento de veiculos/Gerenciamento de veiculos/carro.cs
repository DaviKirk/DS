using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gerenciamento_de_veiculos
{
    class carro : veiculo
    {
        private string arCondicionado;
        private string ABS;
        private string TCS;
        private string tetoSolar;

        public void setArCondicionado(string arCondicionado)
        {
            this.arCondicionado = arCondicionado;
        }

        public string getArCondicionado()
        {
            return this.arCondicionado;
        }

        public void setABS(string ABS)
        {
            this.ABS = ABS;
        }

        public string getABS()
        {
            return this.ABS;
        }

        public void setTCS(string TCS)
        {
            this.TCS = TCS;
        }

        public string getTCS()
        {
            return this.TCS;
        }

        public void settetoSolar(string tetoSolar)
        {
            this.tetoSolar = tetoSolar;
        }

        public string getTetoSolar()
        {
            return this.tetoSolar;
        }
    }
}
