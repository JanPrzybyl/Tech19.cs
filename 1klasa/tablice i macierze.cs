using System;

class Program
{
    static bool CzyZlozona(int n)
    {
        for (int i = 2; i < n; i++)
        {
            if (n % i == 0)
            {
                return false;
            }
        }
        return true;
    }
    static void Main(string[] args)
    {
        Console.WriteLine("Zadanie 1");
        Random r = new Random();
        int suma = 0;
        int ilosc = 0;
        int liczby = 0;
        int[] T = new int[30];
        for (int i = 0; i < T.Length; i++)
        {
            T[i] = r.Next(100,1000);
            System.Console.Write(T[i] + " ");
        }
        for (int i = 0; i < T.Length; i++)
        {
            int liczba = T[i];
            for (int j = 0; j < T.Length; j++)
            {
                if (liczba == T[j])
                {
                    ilosc++;
                    suma += liczba;
                }
            }
        }
        System.Console.WriteLine();
        System.Console.WriteLine($"Suma to: {suma} Ilosc to: {ilosc}");

        Console.WriteLine("Zadanie 2");
        Random r = new Random();
        int liczba = 0;
        int x = 0;
        int[] T = new int[20];
        while (x < T.Length)
        {
            liczba = r.Next(10,100);
            if (CzyZlozona(liczba) == true)
            {
                T[x] = liczba;
                x++;
            }
        }
        for (int i = 0; i < T.Length; i++)
        {
            Console.Write(T[i] + " ");
        }

        // Suma ramki bez rogów
        Console.WriteLine("Zadanie 3");
        Random r = new Random();
        int n = int.Parse(Console.ReadLine());
        int[,] M = new int[n,n];
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                M[i,j] = r.Next(10,100);
            }
        }
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                Console.Write(M[i,j] + " ");
            }
            System.Console.WriteLine();
        }
        int suma1 = 0;
        int suma2 = 0;
        int suma3 = 0;
        int suma4 = 0;
        int BigSuma = 0;
        int ilosc = 0;
        for (int i = 0; i < n; i++)
        {
            suma1 += M[i, 0];
            ilosc++;

            suma2 += M[0, i];
            ilosc++;

            suma3 += M[i, n - 1];
            ilosc++;

            suma4 += M[n - 1, i];
            ilosc++;

            BigSuma = suma1 + suma2 + suma3 + suma4;
        }
        System.Console.WriteLine($"Suma to: {BigSuma} Ilosc to: {ilosc}");

        // Suma przekątnych (diagonale)
        System.Console.WriteLine("Zadanie 4");
        Random r = new Random();
        int n = 5;
        int[,] M = new int[n,n];
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                M[i,j] = r.Next(100,1000);
            }
        }
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                System.Console.Write(M[i,j] + " ");
            }
            System.Console.WriteLine();
        }
        int suma = 0;
        for (int i = 0; i < n; i++)
        {
            suma += M[i, i];
            suma += M[i, n - 1 - i];
        }
        System.Console.WriteLine($"Suma to: {suma}");

        //Suma przekątnych krzyzowych (w ksztalcie krzyza) - not work
        Random rand = new Random();
        int suma = 0;
        int n = int.Parse(Console.ReadLine());
        int[,] macierz = new int[n, n];
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                if (i == n / 2 - 1 || j ==  n / 2 - 1)
                {
                    macierz[i, j] = rand.Next(10, 100);
                }
                else
                {
                    macierz[i, j] = 0;
                }
                if (i == j || i == n - 1 - j)
                {
                    Console.Write(macierz[i, j] + " ");
                }
                else
                {
                    Console.Write("  ");
                }
            }
            Console.WriteLine();
        }

        for (int i = 0; i < n; i++)
        {
                suma += macierz[i, i];
                suma += macierz[i, n - 1 - i];
        }
        Console.WriteLine("Suma dwucyfrowych przekątnych krzyża: " + suma);
    }
}
