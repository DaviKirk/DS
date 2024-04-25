using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace atividade2
{
    class Program
    {
        static void Main(string[] args)
        {
            int votosNulos, votosBrancos, votosValidos, soma;
            double part1, part2, part3;
            Console.WriteLine("quantidade de votos nulos:");
            votosNulos = int.Parse(Console.ReadLine());
            Console.WriteLine("quantidade de votos em branco:");
            votosBrancos = int.Parse(Console.ReadLine());
            Console.WriteLine("quantidade de votos validos:");
            votosValidos = int.Parse(Console.ReadLine());

            soma = votosValidos + votosNulos + votosBrancos;

            part1 = (votosValidos * 100)/soma;
            part2 = (votosNulos *100)/soma;
            part3 = (votosBrancos *100)/soma;

            Console.WriteLine(" o total de votos foi: "+soma+ "\n a porcentagem de votos nulos foi: "+
                part2+ "% \n a porcentagem de votos brancos foi: " + 
                part3 + "% \n a porcentagem de votos validos foi: " + part1+ "%");

            Console.ReadKey();
        }
    }
}
