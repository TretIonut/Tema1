using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tema1
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int rng = rnd.Next(0, 101);
            string nrS_read;
            int counter = 1;

            Console.WriteLine("Guess the number between 0 and 100:");
            nrS_read = Console.ReadLine();
            int nr_read = int.Parse(nrS_read);

            do
            {
                if (nr_read < rng)
                {
                    Console.WriteLine("The number inserted is too small. Please try again:");
                }
                else if (nr_read > rng)
                {
                    Console.WriteLine("The number inserted is too big. Please try again:");
                }
                else
                {
                    break;
                }
                nrS_read = Console.ReadLine();
                nr_read = int.Parse(nrS_read);
                counter++;
            } while (rng != nr_read);

            Console.WriteLine("Congratulations! You have guessed the number in {0} tries.", counter);

        }
    }
}
