using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace atividade3
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1, n2, n3, soma;
            double notaFinal;
            Console.Write("qual sua nota na primeira prova:");
            n1 = int.Parse(Console.ReadLine());
            Console.Write("qual sua nota na segunda prova:");
            n2 = int.Parse(Console.ReadLine());
            Console.Write("qual sua nota na terceira prova:");
            n3 = int.Parse(Console.ReadLine());
            soma = (n1*2) + (n2*3) + (n3*5);
            notaFinal = soma / 10;
            Console.Write("sua media é: " + notaFinal);
            Console.ReadKey();

        }
    }
}
