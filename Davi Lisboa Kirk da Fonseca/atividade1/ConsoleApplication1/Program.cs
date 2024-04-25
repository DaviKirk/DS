using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            int anos, dias;
            Console.WriteLine("quantos anos você tem:");
            anos = int.Parse(Console.ReadLine());

            dias = anos * 365;

            Console.WriteLine("sua idade em dias é " + dias);

            Console.ReadKey();
        }
    }
}
