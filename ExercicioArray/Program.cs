using System;

namespace ExercicioArray
{
    class Program
    {
        static void Main(string[] args)
        {
            Hospede[] hospedes = new Hospede[10];

            Console.Write("Quantos quartos serão alugados? ");

            int quartos = int.Parse(Console.ReadLine());

            for (int i = 1; i <= quartos; i++)
            {
                Console.WriteLine($"Aluguel #{i}:" );

                Console.Write("Nome: ");
                string nome = Console.ReadLine();

                Console.Write("Email: ");
                string email = Console.ReadLine();

                Console.Write("Quarto: ");
                int quarto = int.Parse(Console.ReadLine());

                hospedes[quarto] = new Hospede(nome, email);
            }

            Console.WriteLine();
            Console.WriteLine("Quartos ocupados:");
            for (int i = 0; i < hospedes.Length; i++)
            {
                if (hospedes[i] != null)
                {
                    Console.WriteLine(i + ": " + hospedes[i]);
                }
            }
        }
    }
}
