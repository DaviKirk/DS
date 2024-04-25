using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Supermercado_comprar_estoque
{
    class controle_de_estoque
    {
        public int quantidadeProdutoEstoque(int quantMaxima, int quantEmEstoque)
        {
            return (quantEmEstoque - quantMaxima);
        }
    }
}
