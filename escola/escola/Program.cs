using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace escola
{
    class Program
    {
        static void Main(string[] args)
        {

            string opcao = "1";
            while (opcao == "1")
            {
                List<dynamic> Lista = new List<dynamic>();
                Console.WriteLine("Digite o nome do aluno");
                string Nome;
                Lista.Add(new {Nome = Console.ReadLine()});
                Console.WriteLine("digite a matricula do aluno");
                int Matricula = Convert.ToInt32(Console.ReadLine());
                Lista.Add(Matricula);
                Console.WriteLine("Digite a nota 1");
                double nota1 = Convert.ToDouble(Console.ReadLine());
                Lista.Add(nota1);
                Console.WriteLine("Digite a nota 2");
                double nota2 = Convert.ToDouble(Console.ReadLine());
                Lista.Add(nota2);
                Console.WriteLine("Digite a nota 3");
                double nota3 = Convert.ToDouble(Console.ReadLine());
                Lista.Add(nota3);
                Console.WriteLine("Digite a nota 4");
                double nota4 = Convert.ToDouble(Console.ReadLine());
                Lista.Add(nota4);
                double mediaAluno = (nota1 + nota2 + nota3 + nota4) / 4;
                Lista.Add(mediaAluno);
                string resultado;
                if (mediaAluno >= 7)
                {
                    resultado = "Aprovado";
                }
                else
                {
                    resultado = "Reprovado";
                }
                Lista.Add(resultado);
                Console.WriteLine("Deseja inserir outro nome? 1-SIM | 2-NÃO");
                opcao = Console.ReadLine();
                Console.WriteLine("-------- Lista de Alunos -------");
                Lista.ForEach(i => Console.WriteLine(i));
                Console.ReadKey();
            }
        }
    }
}
