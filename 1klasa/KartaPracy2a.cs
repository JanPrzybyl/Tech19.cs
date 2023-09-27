//Zad 1

int a, b;
a = int.Parse(Console.ReadLine());
b = int.Parse(Console.ReadLine());
if ((a + b) % 2 == 0)
{
    Console.WriteLine("Tak, parzysta");
}
else
{
    Console.WriteLine("Nie, nieparzysta");
}

//Zad 2

int a, b;
a = int.Parse(Console.ReadLine());
b = int.Parse(Console.ReadLine());
if ((a + b) / 2 > Math.Sqrt(a * b))
{
    Console.WriteLine("Tak, srednia arytmetyczna jest wieksza od sredniej geometrycznej");
}
else
{
    Console.WriteLine("Nie, srednia arytmetyczna nie jest wieksza od sredniej geometrycznej");
}

//Zad 3

int a, b, c;
a = int.Parse(Console.ReadLine());
b = int.Parse(Console.ReadLine());
c = int.Parse(Console.ReadLine());
if (a == b || a == c || b == c)
{
    Console.WriteLine("Tak, przynajmniej dwie liczby sa rowne");
    if (a == b && a == c && b == c)
    {
        Console.WriteLine("Wszystkie liczbe sa rowne");
    }
    else if (a == b)
    {
        Console.WriteLine("jest to liczba1 i liczba2");
    }
    else if (a == c)
    {
        Console.WriteLine("jest to liczba1 i liczba3");
    }
    else if (b == c)
    {
        Console.WriteLine("jest to liczba2 i liczba3");
    }
}
else
{
    Console.WriteLine("Nie, nie ma rownych");
}

//Zad 4

int a, b, c, d;
a = int.Parse(Console.ReadLine());
b = int.Parse(Console.ReadLine());
c = int.Parse(Console.ReadLine());
d = int.Parse(Console.ReadLine());
if (a < b && a < c && a < d)
{
    Console.WriteLine("Najmniejsza liczba to a");
}
else if (b < a && b < c && b < d)
{
    Console.WriteLine("Najmniejsza liczba to b");
}
else if (c < a && c < b && c < d)
{
    Console.WriteLine("Najmniejsza liczba to c");
}
else if (d < a && d < b && d < c)
{
    Console.WriteLine("Najmniejsza liczba to d");
}

//Zad 5

int a, b, c;
a = int.Parse(Console.ReadLine());
b = int.Parse(Console.ReadLine());
c = int.Parse(Console.ReadLine());
if (a + b > c && b + c > a && a + c > b)
{
    Console.WriteLine("TAK, liczby spelniaja nierownosc trojkata");
}
else
{
    Console.WriteLine("NIE, liczby nie spelnia nierownosci trojkata");
}

//Zad 6

int a, b, c;
a = int.Parse(Console.ReadLine());
b = int.Parse(Console.ReadLine());
c = int.Parse(Console.ReadLine());
if (a + b > c && b + c > a && a + c > b)
{
    Console.WriteLine("TAK, trojkat powstanie");
    if (Math.Pow(a, 2) + Math.Pow(b, 2) == Math.Pow(c, 2) || Math.Pow(b, 2) + Math.Pow(c, 2) == Math.Pow(a, 2) || Math.Pow(a, 2) + Math.Pow(c, 2) == Math.Pow(b, 2))
    {
        Console.WriteLine("prostokatny");
    }
    else if (Math.Pow(a, 2) + Math.Pow(b, 2) > Math.Pow(c, 2) || Math.Pow(b, 2) + Math.Pow(c, 2) > Math.Pow(a, 2) || Math.Pow(a, 2) + Math.Pow(c, 2) > Math.Pow(b, 2))
    {
        Console.WriteLine("ostrokatny");
    }
    else if (Math.Pow(a, 2) + Math.Pow(b, 2) < Math.Pow(c, 2) || Math.Pow(b, 2) + Math.Pow(c, 2) < Math.Pow(a, 2) || Math.Pow(a, 2) + Math.Pow(c, 2) < Math.Pow(b, 2))
    {
        Console.WriteLine("rozwartokatny");
    }
}
else
{
    Console.WriteLine("NIE, trojkat nie powstanie");
}
