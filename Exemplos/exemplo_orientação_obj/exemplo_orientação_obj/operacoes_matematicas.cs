using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exemplo_orientação_obj
{
    class operacoes_matematicas
    {

        //atributo


        //Metodos (Ação) - Formula Matematica
        /* definição do metodo:
        todo metodo deve ter uma visibilidade (public ou private) os metodos sempre serão publicos.
        int é o tipo do metodo de acordo com a ação do metodo
        soma_doi_numeros é o nome do metodo para sua identificação quando invocado
        pelos formularios (um ou mais formularios)
        (int num1 e int num2) são tipo "variaveis" são parametros.
        obs: paramentros são informaçoes necesserais para o metodo funcionar.
        o que está no return - é o retorno do metodo exemplo demontração de uma formula matematica.*/

        public int soma_dois_numeros(int num1 , int num2)
        {
            return (num1 + num2);
        }
        public int subtracao_dois_numeros(int num1, int num2)
        {
            return (num1 - num2);
        }
        public int multiplicacao_dois_numeros(int num1, int num2)
        {
            return (num1 * num2);
        }
        public int divisao_dois_numeros(int num1, int num2)
        {
            return (num1 / num2);
        }
    }
}
