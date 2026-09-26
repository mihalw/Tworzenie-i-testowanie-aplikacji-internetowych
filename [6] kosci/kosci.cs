int[] kosci = new int[5];

// rzucamy 5 kostkami do gry
for (int i = 0; i < kosci.Length; i++)
{
    Random generatorLiczbLosowych = new Random();
    kosci[i] = generatorLiczbLosowych.Next(1, 7);
}

// wyswietlamy graczowi liczbe oczek na kazdej kostce
for (int i = 0; i < kosci.Length; i++)
{
    Console.WriteLine("Liczba oczek na kosci nr " + i + " = " + kosci[i]);
}

// dwa razy umozliwiamy graczowi rzucenie wskazanymi kostkami
for (int j = 0; j < 2; j++)
{
    // mozemy wybrac od 1 do 5 kostek zeby nimi ponownie rzucic
    int liczbaPonownieRzucanychKostek = 0;
    Console.Write("Ile kosci chcesz rzucic ponownie: "); 
    liczbaPonownieRzucanychKostek = Int32.Parse(Console.ReadLine());

    int indexRzucanejKosci = 0;
    for (int i = 0; i < liczbaPonownieRzucanychKostek; i++)
    {
        // wskazujemy numer kostki ktora ma byc ponownie rzucona
        Console.Write("Podaj nr kosci ktora rzucic ponownie: ");
        indexRzucanejKosci = Int32.Parse(Console.ReadLine());

        // losujemy nowa wartosc dla kostki ktora wybral gracz
        Random generatorLiczbLosowych = new Random();
        kosci[indexRzucanejKosci] = generatorLiczbLosowych.Next(1, 7);
    }

    // wyswietlamy graczowi ostateczny wynik
    for (int i = 0; i < kosci.Length; i++)
    {
        Console.WriteLine("Liczba oczek na kosci nr " + i + " = " + kosci[i]);
    }
    Console.WriteLine();
}
