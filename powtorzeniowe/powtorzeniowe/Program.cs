using powtorzeniowe;

class PlikGłówny
{

    static void Main(string[] args)
    {
        //zmienna ktora jest odwolaniem do innego skryptu
        tablice tablice = new tablice();

        int[] tab = tablice.Tworzenie_tablicy();

        for (int i = 0; i < tab.Length; i++)
        {
            Console.WriteLine(tab[i]);
        }
        


    }
}