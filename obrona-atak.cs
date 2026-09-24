int hp = 100;
int punktyObrony = 60;
int[] maksymalnyZakresAtakow = { 30, 50, 70, 90 };
int minimalnyZakresAtaku = 10;

int pojedynczaObrona = 0;
int pojedynczyAtak = 0;
for (int i = 0; i < maksymalnyZakresAtakow.Length; i++)
{
    Console.WriteLine("HP = " + hp + ", punkty obrony = " + punktyObrony);

    // mowimy za ile sie bronimy
    Console.Write("Podaj wartosc obrony: ");
    pojedynczaObrona = Int32.Parse(Console.ReadLine());
    if (pojedynczaObrona <= punktyObrony)
    {
        punktyObrony = punktyObrony - pojedynczaObrona;
    }
    else
    {
        Console.WriteLine("Nie masz tylu punktow obrony. Ustawiam obrone na 0.");
        pojedynczaObrona = 0;
    }

    // losujemy wartosc ataku
    Random random = new Random();
    pojedynczyAtak = random.Next(minimalnyZakresAtaku, maksymalnyZakresAtakow[i] + 1);
    Console.WriteLine("Atak wynosi: " + pojedynczyAtak);

    if (pojedynczyAtak > pojedynczaObrona)
    {
        hp = hp - pojedynczyAtak;
        Console.WriteLine("Zostales ranny, tracisz " + pojedynczyAtak);
    }
    else
    {
        Console.WriteLine("Atak zostal wybroniony!");
    }

    Console.WriteLine();
}

if (hp > 0)
{
    Console.WriteLine("Gratulacje, wygrales! HP = " + hp);
}
else
{
    Console.WriteLine("Przegrales! HP = " + hp);
}
