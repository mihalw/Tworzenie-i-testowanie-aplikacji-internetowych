// ZADANIE 1

using System;

public class Program
{
    public static void Main(string[] args)
    {
        int[] liczby = new int[10];
        int sumaLiczb = 0;

        Random generatorLiczb = new Random();

        for (int i = 0; i < liczby.Length; i++)
        {
            liczby[i] = generatorLiczb.Next(1, 101); // losujemy liczbę z zakresu 1-100

            Console.WriteLine("Wylosowana liczba: " + liczby[i]);

            sumaLiczb = sumaLiczb + liczby[i];
        }

        Console.WriteLine("Suma liczb wynosi " + sumaLiczb);
    }
}

// ZADANIE 2

using System;

public class Program
{
    public static void Main(string[] args)
    {
        int[] liczby = new int[10];

        Random generatorLiczb = new Random();

        // Losowanie liczb i zapisywanie ich do tablicy
        for (int i = 0; i < liczby.Length; i++)
        {
            liczby[i] = generatorLiczb.Next(1, 11);
        }

        // Wyświetlanie tablicy w normalnej kolejności
        Console.WriteLine("Liczby wylosowane:");

        for (int i = 0; i < liczby.Length; i++)
        {
            Console.WriteLine(liczby[i]);
        }

        // Wyświetlanie tablicy w odwrotnej kolejności
        Console.WriteLine("Liczby w odwrotnej kolejności:");

        for (int i = liczby.Length - 1; i >= 0; i--)
        {
            Console.WriteLine(liczby[i]);
        }
    }
}
