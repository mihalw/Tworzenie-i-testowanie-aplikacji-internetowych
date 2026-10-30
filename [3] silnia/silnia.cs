using System;

public class Silnia {
    public static void Main(string[] args) {
        Console.Write("Podaj liczbe: ");
        int liczba = Convert.ToInt32(Console.ReadLine());

        int wynik = 1;
        for (int i = 1; i <= liczba; i++)
         {
            wynik = wynik * i;
        }
        Console.WriteLine("Silnia wynosi " + wynik);
    }
}
