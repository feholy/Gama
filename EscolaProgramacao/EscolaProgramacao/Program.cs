using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EscolaProgramacao
{
    class Program
    {
        static void Main(string[] args)
        {
            string Nome, Matricula, Status;
            double Nota1, Nota2, Nota3, Nota4, MediaAluno;
            Console.WriteLine("Quantos alunos você deseja cadastrar ?");
            int Quantidade = Convert.ToInt32(Console.ReadLine());
            List<dynamic> Lista = new List<dynamic>();

            for (int i = 0; i < Quantidade; i++) 
            {
                int indice = i + 1;
                Console.WriteLine("Digite o nome do aluno");
                Nome = Console.ReadLine();
                Console.WriteLine("digite a matricula do aluno");
                Matricula = (Console.ReadLine());
                Console.WriteLine("Digite a nota 1: ");
                Nota1 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Digite a nota 2: ");
                Nota2 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Digite a nota 3: ");
                Nota3 = Convert.ToDouble(Console.ReadLine()); ;
                Console.WriteLine("Digite a nota 4: ")    ;
                Nota4 = Convert.ToDouble(Console.ReadLine());
                MediaAluno = (Nota1 + Nota2 + Nota3 + Nota4) / 4;

                Status =+ MediaAluno >= 7 ? "aprovado." : "reprovado.";

                Lista.Add(new
                {
                    Aluno = Nome,
                    Mat = Matricula,
                    N1 = Nota1,
                    N2 = Nota2,
                    N3 = Nota3,
                    N4 = Nota4,
                    Media = MediaAluno,
                    Sts = Status
                });
                Console.Clear();
            }

            Console.WriteLine("Segue a lista de  Alunos");
            foreach (var lista in Lista)
            {
                Console.WriteLine("----------------------------------------");
                Console.WriteLine("Nome: " + lista.Aluno);
                Console.WriteLine("Matrícula: " + lista.Mat);
                Console.Write("Notas: " + lista.N1 + ",");
                Console.Write(lista.N2 + ",");
                Console.Write(lista.N3 + ",");
                Console.Write(lista.N4);
                Console.WriteLine();
                Console.WriteLine("Média: " + lista.Media);
                Console.WriteLine("Status: " + lista.Sts);
                Console.WriteLine("----------------------------------------");

            }

            Console.ReadKey();
        }
    }
}
