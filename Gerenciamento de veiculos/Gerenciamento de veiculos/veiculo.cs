using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gerenciamento_de_veiculos
{
    class veiculo
    {
        private string numeroDeRodas;
        private string cor;
        private string modelo;
        private string anoDeFabricacao;
        private string numeroDePortas;
        private string marca;
        
        public void setNumeroDeRodas(string numeroDeRodas)
        {
            this.numeroDeRodas = numeroDeRodas;
        }

        public string getNumeroDeRodas()
        {
            return this.numeroDeRodas;
        }

        public void setCor(string cor)
        {
            this.cor = cor;
        }

        public string getCor()
        {
            return this.cor;
        }

        public void setModelo(string modelo)
        {
            this.modelo = modelo;
        }

        public void getModelo(string modelo)
        {
            this.modelo = modelo;
        }


        public void setAnoDeFabricacao(string anoDeFabricacao)
        {
            this.anoDeFabricacao = anoDeFabricacao;
        }

        public void getAnoDeFabricacao(string anoDeFabricacao)
        {
            this.anoDeFabricacao = anoDeFabricacao;
        }

        public void setNumeroDePortas(string numeroDePortas)
        {
            this.numeroDePortas = numeroDePortas;
        }

        public void getNumeroDePortas(string numeroDePortas)
        {
            this.numeroDePortas = numeroDePortas;
        }


        public void setMarca(string marca)
        {
            this.marca = marca;
        }

        public void getMarca(string marca)
        {
            this.marca = marca;
        }



    }
}
