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
                Console.Write(tab[i] + ", ");
            }
            Console.WriteLine();
        }
        public int[] Tworzenie_tablicy()

        {
            //pobieramy dlugosc tablicy od uzytkownika
            Console.WriteLine("ile znakow ma miec tablica?");
            int dl = int.Parse(Console.ReadLine());

            //tworzymy pusta tablice o podanej dlugosci
            int[] ints = new int[dl];

            //dodajemy kolejno elementy do tablicy
            for (int i = 0; i < dl; i++)
            {
                Console.WriteLine("podaj kolejny element tablicy");
                ints[i] = int.Parse(Console.ReadLine());
            }
            return ints;
        }


    
    public void SortujBabelkowo(int[] tab)
    {
            for (int i = 0; i < tab.Length; i++)
            {
                for (int j = 1; j < tab.Length - i; j++)
                {
                    if (tab[j - 1] > tab[j])
                    {
                        int temp = tab[j - 1];
                        tab[j - 1] = tab[j];
                        tab[j] = temp;
                    }
                }
            }
                }
        public bool Przeszukaj(int[] tab)
        {
            Console.WriteLine("jakiej liczby szukasz w tablicy? ");
            int szukana = int.Parse(Console.ReadLine());

            for (int i = 0; i < tab.Length; i++)
            {
                if (tab[i] == szukana)
                {
                    return true;
                }
            }
            return false;
            

            
        }
            }
        }
    

        
    
        

            

            
        

    

