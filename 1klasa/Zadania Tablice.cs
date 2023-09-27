/*
Wygeneruj tablicę n losowych liczb:
Random r = new Random()
r.Next(pocz, kon)

n = 10 w przedziale [1,20]

1. Znajdź największą liczbę w tablicy
2. Znajdź najmniejszą liczbę w tablicy
3. Podaj ile razy występuje najwieksza liczba w tablicy
4. Podaj ile razy występuje najmniejsza liczba w tablicy
5. Podaj rozpiętość tablicy (różnica max - min)
6. Podaj sumę liczb w tablicy
7. Podaj średnią wartość liczb w tablicy
8. Których liczb jest więcej w tablicy: parzystych czy nieparzystych?
9. Ile w tablicy jest liczb pierwszych?
10. Podaj v-ce max i v-ce min liczb tablicy
*/

int n = 10;
int pocz = 1;
int kon = 20;

int[] T = new int[n];
Random r = new Random();
for (int i = 0; i < n; i++) T[i] = r.Next(pocz, kon);

for (int i = 0; i < n; i++)
{
    Console.Write(T[i]+ " ");
}

//zad 1
int maks = T[0];
for (int i = 1; i < n; i++)
{
    if (T[i] > maks) 
    {
        maks = T[i];
    }
}
Console.Write(maks);
//zad 2
int min = 20;
for (int i = 0; i < n; i++)
{
    if (T[i] < min)
    {
        min = T[i];
    }
}
Console.Write(min);

//zad 5
int maks = T[0];
int min = T[0];
for (int i = 0; i < n; i++)
{
    if (T[i] > maks)
    {
        maks = T[i];
    }
}
for (int j = 0; j < n; j++)
{
    if (T[j] < min)
    {
        min = T[j];
    }
}
Console.WriteLine();
Console.Write(maks - min);

//zad 6
int suma = 0;
for (int i = 0; i < T.Length; i++)
{
    suma += T[i];

}
Console.WriteLine();
Console.Write(suma);

//zad 7
int srednia = 0;
int suma = 0;
int ilosc = 10;
for (int i =0; i < T.Length; i++)
{
    suma += T[i];
    srednia = suma / ilosc;
}
Console.WriteLine();
Console.Write(srednia);

//zad 8
int ilosc_nieparz = 0;
int ilosc_parz = 0;
for (int i = 0; i < n; i++)
{
    if (T[i] % 2 == 0)
    {
        ilosc_parz = ilosc_parz + 1;
    }
    else
    {
        ilosc_nieparz = ilosc_nieparz + 1;
    }
}
if (ilosc_parz > ilosc_nieparz)
    Console.WriteLine("Liczb parzystych jest wiecej");
else
    Console.WriteLine("Liczb nieparzystych jest wiecej");

Console.WriteLine();
Console.WriteLine();

Console.WriteLine(ilosc_parz);
Console.WriteLine(ilosc_nieparz);
//zad 9
int pierwsza = 1;
for (int i = 0; i < n; i++)
{
    if (pierwsza / 1 == 0 && pierwsza / i ==0)
}
