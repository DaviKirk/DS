using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*Biblioteca*/

namespace exemploRevisão
{
    /*classe padrão do c# é a classe program
    Classe necessaria para execução do projeto
    um classe é composta por 3 coisas.
    primeira: nome
    segunda: atributos
    terceira: metodos
    */
    class Program
    {
        /*metodo - ação
        um metodo possui nome para ser chamado
        um método possui argumentos (string[] args)
        oque é um argumento?
        informação necessaria para execução do método*/
        static void Main(string[] args)
        {
            double n1, n2, soma;
            Console.WriteLine("qual o primeiro numero:");
            n1 = double.Parse(Console.ReadLine());
            Console.WriteLine("qual o segundo numero:");
            n2 = double.Parse(Console.ReadLine());

            soma = n1 + n2;

            Console.WriteLine("o resultado da sua soma é:" + soma);

            Console.ReadKey();
        }
    }
}
