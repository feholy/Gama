using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vendedora_de_lentilha
{
    class Program
    {
        static void Main(string[] args)
        {
            double Valorlentilha = 1.50;
            Console.WriteLine("Qual é a quantidade de lentilha que deseja (Obs: digitar quantidade em Kg) ?\n");
            double Peso = Convert.ToDouble(Console.ReadLine());
            //Console.WriteLine(Peso = Peso * 1000);
            double ValorTotal = Peso * Valorlentilha;
            Console.WriteLine("O valor a  ser pago por " + Peso + "  de lentilha é: " + ValorTotal+ "kg");
            Console.ReadKey();

        }
    }
}
