using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraFSG {
    class Program {
        static void Main(string[] args)
        {
            double nota1, NotaFinal1 = 0, NotaFinal2 = 0, NotaFinal3 = 0;
            double porcentagem1, nota3, porcentagem3;
            Console.WriteLine("Desenvolvido por: Tiago H de Castilhos, Eng. da Computação");
            Console.WriteLine("Separador decimal: Vírgula\n");
            
            //Nota 1
            Console.Write("Número de notas na Nota 1: ");
            int qteNota1 = int.Parse(Console.ReadLine());

            for(int i = 0; i < qteNota1; i++)
            {
                Console.Write("Nota " + (i + 1) + ": ");
                nota1 = double.Parse(Console.ReadLine());
                if (qteNota1 == 1)
                {
                    porcentagem1 = 100;
                }
                else
                {
                    Console.Write("Porcentagem dela na nota 1: ");
                    porcentagem1 = double.Parse(Console.ReadLine());
                }

                Nota1 nota = new Nota1(nota1, porcentagem1);
                
                NotaFinal1 += nota.CalcularNota(nota1, porcentagem1);

                
            }
            NotaFinal1 = NotaFinal1 * 0.2;
            Console.WriteLine();
            //Nota 2
            Console.Write("Nota na APS: ");
            double Nota2 = double.Parse(Console.ReadLine());
            Nota2 NotaAPS = new Nota2(Nota2);
            NotaFinal2 = NotaAPS.CalculoAPS(Nota2);
            Console.WriteLine();

            //Nota 3
            Console.Write("Número de notas na Nota 3: ");
            int qteNota3 = int.Parse(Console.ReadLine());

            for (int i = 0; i < qteNota3; i++)
            {
                Console.Write("Nota " + (i + 1) + ": ");
                nota3 = double.Parse(Console.ReadLine());
                if (qteNota3 == 1)
                {
                    porcentagem3 = 100;
                }
                else
                {
                    Console.Write("Porcentagem dela na nota 3: ");
                    porcentagem3 = double.Parse(Console.ReadLine());
                }

                Nota1 nota = new Nota1(nota3, porcentagem3);

                NotaFinal3 += nota.CalcularNota(nota3, porcentagem3);


            }
            NotaFinal3 = NotaFinal3 * 0.6;

            double NotaFinal = Nota1.SomaDeNotas(NotaFinal1, NotaFinal2, NotaFinal3);
            Console.WriteLine();

            if (NotaFinal >= 7)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine(NotaFinal.ToString("F2") + " = Aprovado");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(NotaFinal.ToString("F2") + " = Reprovado");
            }
            Console.ReadLine();
        }
    }
}
