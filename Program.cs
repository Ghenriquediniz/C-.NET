using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Variáveis
            string nomeAluno, serieAluno, turmaAluno;
            string pergunta = "s";
            float nota1, nota2, nota3, nota4, media;
            while (pergunta == "s")
            {
                Console.Write("Informe o nome do aluno: "); //Console.Write informa o texto
                nomeAluno = Console.ReadLine(); //Permite digitar no console
                Console.Write("Informe a série do aluno: ");
                serieAluno = Console.ReadLine();
                Console.Write("Inforeme a turma do aluno: ");
                turmaAluno = Console.ReadLine();

                Console.Write("Informe a nota1: ");
                nota1 = Convert.ToSingle(Console.ReadLine()); //Convert.ToSingle converte em texto
                Console.Write("Informe a nota2: ");
                nota2 = Convert.ToSingle(Console.ReadLine());
                Console.Write("Informe a nota3: ");
                nota3 = Convert.ToSingle(Console.ReadLine());
                Console.Write("Informe a nota4: ");
                nota4 = Convert.ToSingle(Console.ReadLine());

                media = (nota1 + nota2 + nota3 + nota4) / 4;

                Console.WriteLine("A média do aluno {0} da série {1}, da turma {2} é de {3}.", nomeAluno, serieAluno, turmaAluno, media);

                if (media >= 5)
                {
                    Console.WriteLine("Aluno {0} APROVADO.", nomeAluno);
                }
                else if (media >= 3 && media < 5)
                {
                    Console.WriteLine("Aluno {0} RECUPERAÇÃO.", nomeAluno);
                }
                else
                {
                    Console.WriteLine("Aluno {0} REPROVADO.", nomeAluno);
                }

                Console.Write("Deseja calcular outra média? (s/n): ");
                pergunta = Console.ReadLine().ToLower();

            }

            

            Console.WriteLine("Programa finalizado.");

            

            Console.ReadKey(); //Para parar da ação//
        }
    }
}
