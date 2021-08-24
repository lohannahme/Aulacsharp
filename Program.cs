using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aulascsharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Estudantes[] estud = new Estudantes[10];

            Console.Write("How many rooms will be rented: ");
            int rentedRooms = int.Parse(Console.ReadLine());

            for (int i = 1; i <= rentedRooms; i++)
            {
                Console.WriteLine($"Rent #{i}:");
                Console.Write("Name: ");
                string nome = Console.ReadLine();
                Console.Write("Email: ");
                string email = Console.ReadLine();
                Console.Write("Room: ");
                int quarto = int.Parse(Console.ReadLine());

                estud[quarto] = new Estudantes { Nome = nome, Email = email };
            }

            Console.WriteLine("Busy rooms: ");

            for (int y = 0; y < 10; y++)
            {
                if (estud[y] != null)
                {
                    Console.WriteLine($"{y}: {estud[y]}");
                }

            }

            Console.ReadLine();
        }
    }
}
