﻿using powtorzeniowe;

class PlikGłówny
{

    static void Main(string[] args)
    {
        //zmienna ktora jest odwolaniem do innego skryptu
        Tablice tablica = new Tablice();

        //wywolujemy fynkcje tworzaca tablice
        int[] tab = tablica.Tworzenie_tablicy();

        //wywolujemy metode wyswietlajaca tablice
    tablica.Wyswietl(tab);
        //wywolujemy metiode wyswietlajaca tavlciue
        tablica.SortujBabelkowo(tab);

        tablica.Wyswietl(tab);

    }
}