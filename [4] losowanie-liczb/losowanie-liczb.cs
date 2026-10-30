using System;

public class LosowanieLiczb {
    public static void Main(string[] args) {
        int[] liczby = new int[6];
        Random generatorLiczb = new Random();
        for (int i = 0; i < liczby.Length; i++) // liczby.Length zwraca liczbę elementów tablicy, czyli 6
        {
            liczby[i] = generatorLiczb.Next(1, 50); // Losowanie liczb od 1 do 49
        }

        for (int i = 0; i < liczby.Length; i++) 
        {
            Console.WriteLine("Wylosowana liczba: " + liczby[i]);
        }
    }
}
