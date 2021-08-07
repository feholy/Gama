using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotnetFramework
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Qual é a nota do aluno 1 ?");
            double Aluno1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("A nota do aluno 1 é " + Aluno1);
            Console.WriteLine("Qual é a nota do aluno 2 ?");
            double Aluno2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("A nota do aluno 2 é " + Aluno2);
            double Resultado = Aluno1 / Aluno2;
            Console.WriteLine("A divisão das notas dos dois alunos é " + Resultado);
            Console.Read();
        }
    }
}
