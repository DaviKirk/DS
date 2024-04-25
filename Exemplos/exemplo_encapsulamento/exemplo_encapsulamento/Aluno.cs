using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exemplo_encapsulamento
{
    class Aluno
    {
        //criar atributo
        private string nome;
        //a cada atributo, necessario criar 2 metodos (get e set)

        //metodo sem retorno possui a palavra "void" não return
        //o nome do metodo deve ser "set" + o nome do atributo com a primeira palavra em capslock
        //os valores digitados pelo usuario são guardados no pareamento
        //(string nome) e rapassa ao atributo
        public void setNome(string nome)
        {
            this.nome = nome;
        }
        //2° metodo
        //metodo com retorno, o tipo do metodo deve ser o do mesmo tipo do atributo que esta ligado
        //o nome do metodo devera ser get+ o nome do atributo com a 1° letra em capslock (getNome)
        //metodo get serve para mostrar valores ao usuario armazenado dentro do metodo set.
        public string getNome()
        {
            return this.nome;
        }
        
    }
}
