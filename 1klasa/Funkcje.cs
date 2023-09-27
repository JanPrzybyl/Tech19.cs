// funkcje sa nam znane z mat i z inf: f(x) WriteLine()

/*
typ_zwracany nazwa(parametr)
{
    instrukcje
}
*/

/*void przywitaj()
{
    Console.WriteLine("Witam sensei");
}
przywitaj();
przywitaj();*/

// napisz funkcje, która oblicza sumę przekazanych przez parametr 3 liczb

void suma1(int a, int b, int c);
{
    Console.WriteLine(a + b + c);
}
suma1(4, 7, 9);

int suma2(int x, int y, int z)
{
    return x + y;
}
Console.WriteLine(suma2(4,7,9));

// naisz funkcje dajaca rabat(cena, rabat) na towar

double DajRabat(double cena, int rabat)
{
    return cena * (1 - rabat / 100);
}
Console.WriteLine(DajRabat(100d, 25));
