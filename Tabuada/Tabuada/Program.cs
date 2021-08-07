using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tabuada
{
    class Program
    {
        static void Main(string[] args)
        {
            int sair = 0;
            do
            {
                int formula, contador, numero;
                Console.WriteLine("Digite qual número deseja a tabuada");
                numero = Convert.ToInt32(Console.ReadLine());
                for (contador = 1; contador <= 10; contador++)
                {
                    formula = numero * contador;
                    Console.WriteLine(numero + " X " + contador + " = " + formula);
                }
                Console.WriteLine("digite 1 para continuar ou 0 para sair");
                sair = Convert.ToInt32(Console.ReadLine());
                if(sair == 0)
                {
                    break;
                }
            }
            while (true);
        }
        
    }
}
