using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioIf
{
    class Program
    {
        static void Main(string[] args)
        { 
            Console.WriteLine("digite o nome do Aluno");
            string aluno = Console.ReadLine();
            Console.WriteLine("Digite a nota 1");
            double nota1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Digite a nota  2");
            double nota2 = Convert.ToDouble(Console.ReadLine());
            double mediaAluno = (nota1 + nota2) / 2;
            if
                (mediaAluno > 10)
            {
                Console.WriteLine($"Valor incorreto");
            }
            else if (mediaAluno >= 0 && mediaAluno < 1)
            {
                Console.WriteLine($"O {aluno} você está reprovado");
            }
            else if (mediaAluno >= 1 && mediaAluno < 5)
            {
                Console.WriteLine($"O {aluno} você está reprovado");
            }
            else if (mediaAluno >= 5 && mediaAluno < 8)
            {
                Console.WriteLine($"O {aluno} passou raspando!");
            }
            else if ((mediaAluno >= 8 && mediaAluno < 9) || (mediaAluno >= 9 || mediaAluno < 10))
            {
                Console.WriteLine($"O {aluno} você mandou bem");
            }
            else  
            {
                Console.WriteLine($"O {aluno} está de parabéns, vc é muito inteligente!");
            }

            Console.Read();
            
        }


    }
}

