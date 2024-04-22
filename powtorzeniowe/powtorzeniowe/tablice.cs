using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace powtorzeniowe
{
   public class Tablice
    {
        //tworzymy publiczne funkcje w skrypcie Tablice
        public void Wyswietl(int[] tab)
        {
            for (int i = 0; i < tab.Length; i++)
            {
                Console.Write(tab[i]+ ", ");
            }
        }
        public int[] Tworzenie_tablicy()

        {
            //pobieramy dlugosc tablicy od uzytkownika
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
