// (Przykladowa rejestracja do strony)

using System;
using System.IO;

const string PATH = @"database.txt";

void Rejestracja() {
    
    Console.Write("Wpisz login: ");
    string login = Console.ReadLine();
    Console.Write("Wpisz haslo: ");
    string password = Console.ReadLine();

    using(StreaWriter sw = File.CreateText(PATH)) {
        sw.WriteLine(login);
        sw.WriteLine(password);
    }

}
void Logowanie() {

    string db_login, db_password;

    Console.Write("Login: ");
    string login = Console.ReadLine();
    Console.Write("Haslo: ");
    string password = Console.ReadLine();

    using(StreamReader sr = File.OpenText(PATH)) {
        
        int n = 1;
        string line;
        while((line = sr.ReadLine()) != null) {
            if(n==1)
                db_login = line;
            else if(n==2)
                db_password = line; 
            n++;
        }

        if(login == db_login && password == db_password)
            Console.WriteLine("Zalogowano pomyslnie");
        else
            Console.WriteLine("Niepoprawne dane");

        Console.ReadKey();
    }
}

bool isOn = true;

while(isOn) {
    Console.Clear();

    Console.WriteLine("------------------");
    Console.WriteLine("       Witaj      ");
    Console.WriteLine("------------------");
    Console.WriteLine("1. Logowanie      ");
    Console.WriteLine("2. Rejestracja    ");
    Console.WriteLine("3. Wyjscie        ");
    Console.WriteLine("------------------");
    Console.Write("Wybor: ");
    char choice = Console.ReadLine();
    
    switch(choice) {
        case '1':
            Logowanie();
            break;
        case '2':
            Rejestracja();
            break;
        case '3':
            isOn = false;
            break;
    }
}

using System;
using System.IO;
// 1.1 Napisz funkcje która zwraca sume cyfr podaniej liczby
int SumaCyfr(int a)
{
    int jed = a % 10;
    int dzie = (a % 100) / 10;
    int set = a / 100;
    int sum = jed + dzie + set;
    return sum;
}
Console.WriteLine(SumaCyfr(358));

// 1.2 Napisz funkcje, która zwraca odwrócony do wprowadzonego napis
string ReverseString(string napis)
{
    char[] chars = napis.ToCharArray();
    Array.Reverse(chars);
    return new string(chars);
}
string input = "ala ma kota";
string reversed = ReverseString(input);
System.Console.WriteLine(reversed);

// 3.2 Zapisz do pliku 10 losowych liczb dwucyfrowych. Odczytaj ten plik i wypisz największą z liczb
string path = "liczby.txt";
StreamWriter sw = new StreamWriter(path);
Random r = new Random();
for (int i = 0; i < 10; i++)
{
    int liczba = r.Next(10, 100);
    sw.WriteLine(liczba);
}
sw.Close();

string [] arr = File.ReadAllLines(path);
int max = int.MinValue;

foreach (string str in arr)
{
    int liczba = int.Parse(str);
    if (liczba > max)
    {
        max = liczba;
    }
}
System.Console.WriteLine("max liczba: " + max);

// 3.3  Zapisz do pliku 100 losowych liczb trzycyfrowych. Odczytaj ten plik i wypisz wszystkie liczby-palindromy, np 242 itp.
string path = "liczby1.txt";
StreamWriter sw = new StreamWriter(path);
Random r = new Random();
for (int i = 0; i < 100; i++)
{
    int x = r.Next(100,1000);
    sw.WriteLine(x);
    int jed = x % 10;
    int set = x / 100;
    if (jed == set)
    {
        System.Console.WriteLine(x);
    }
}
sw.Close();
