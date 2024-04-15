using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace powtorzeniowe
{
   public class tablice
    {
        public void Wyswietl()
        {
            Console.WriteLine("to jest plik z tablicami");
        }
        public int[] Tworzenie_tablicy()

        {
            Console.WriteLine("ile znakow ma miec tablica?");
            int dl = int.Parse(Console.ReadLine());

            int[] ints = new int[dl];

            for (int i = 0; i < dl; i++)
            {
                Console.WriteLine("podaj kolejny element tablicy");
                ints[i] = int.Parse(Console.ReadLine());
            }
            return ints;
        }
                

        }
}
