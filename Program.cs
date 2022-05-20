using System;
using CalculoMedia.Classes;

namespace CalculoMedia
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\n Cálculo de Médias");
            Console.Write(" Digite o nome da matéria: ");
            string nomeMateria = Console.ReadLine();

            Console.Write(" Digite a nota da Avaliação Diversificada (0.0 - 7,0): ");
            double notaDiver = Double.Parse(Console.ReadLine());

            Console.Write(" Digite a nota da Avaliação Obrigatória (0.0 - 9,0): ");
            double notaObrig = Double.Parse(Console.ReadLine());

            Console.Write(" Digite a nota da Avaliação Atitudinal (0.0 - 2,0): ");
            double notaAtitu = Double.Parse(Console.ReadLine());

            Calculo c = new Calculo(nomeMateria, notaDiver, notaObrig, notaAtitu);
        }
    }
}