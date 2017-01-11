using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lotto
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Monta rivia haluat pelata? ");
            int RivienMaara = int.Parse(Console.ReadLine());
            int[] Numerot = new int[7];
            Random randomi = new Random();



            for (int j = 1; j <= RivienMaara; j++)
            {
                Console.WriteLine("Rivi numero " + j);
                for (int i = 0; i < 7; i++)
                {

                    int ArvottuNumero = randomi.Next(1, 40);
                    if (Numerot.Contains(ArvottuNumero))
                    {
                        i--;
                    }
                    else
                    {
                        Numerot[i] = ArvottuNumero;
                    }
                }

                for (int i = 0; i < 7; i++)
                {
                    Console.WriteLine(Numerot[i]);
                }
            }
        }
    }
}