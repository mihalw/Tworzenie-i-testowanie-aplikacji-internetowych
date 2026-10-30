using System;

public class Pelnoletnosc {
    public static void Main(string[] args) {
        Console.Write("Podaj wiek: ");
        int wiek = Int32.Parse(Console.ReadLine());
        if (wiek >= 18) {
            Console.WriteLine("Jestes pelnoletni");
        } else {
            Console.WriteLine("Jestes niepelnoletni");
        }
    }
}
