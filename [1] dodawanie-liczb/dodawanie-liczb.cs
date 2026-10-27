using System;

public class HelloWorld {
    public static void Main(string[] args) {
        Console.WriteLine("Podaj liczbe: ");
        int a = Int32.Parse(Console.ReadLine());
        Console.WriteLine("Podaj liczbe: ");
        int b = Int32.Parse(Console.ReadLine());
        int suma = a + b;
        Console.WriteLine("Suma wynosi: " + suma);
    }
}
