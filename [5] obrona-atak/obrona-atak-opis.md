Napisz program, ktory symuluje walkę gracza z przeciwnikiem. Gracz rozpoczyna rozgrywkę ze 100 punktami życia (HP) oraz 60 punktami obrony.

Walka składa się z 4 rund. W każdej rundzie program powinien wykonać następujące czynności:
1. Wyświetlić aktualną liczbę punktów życia (HP) oraz dostępnych punktów obrony gracza.
2. Poprosić gracza o podanie liczby punktów obrony, które chce wykorzystać do zablokowania nadchodzącego ataku.
3. Sprawdzić, czy gracz posiada wystarczającą liczbę punktów obrony:
   - Jeśli tak, odjąć wykorzystane punkty od dostępnej puli obrony.
   - Jeśli nie, wyświetlić odpowiedni komunikat i ustawić wartość obrony w danej rundzie na 0.
4. Wylosować siłę ataku przeciwnika. Minimalna siła ataku wynosi 10, natomiast maksymalna wartość zależy od rundy:
   - I runda – 30,
   - II runda – 50,
   - III runda – 70,
   - IV runda – 90.
5. Porównać siłę ataku z wartością obrony wykorzystaną przez gracza:
   - Jeśli atak jest silniejszy od obrony, gracz traci punkty życia równe sile ataku.
   - Jeśli obrona jest równa lub większa od siły ataku, gracz całkowicie blokuje atak.
6. Po zakończeniu wszystkich czterech rund wyświetlić wynik rozgrywki:
   - Jeśli gracz ma więcej niż 0 punktów życia, wyświetlić komunikat o wygranej wraz z pozostałą liczbą HP.
   - Jeśli gracz ma 0 lub mniej punktów życia, wyświetlić komunikat o przegranej wraz z aktualną liczbą HP.
