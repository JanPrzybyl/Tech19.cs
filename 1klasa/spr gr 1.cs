using System.Collections;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Threading.Channels;

internal class Program
{
    static bool CzyPier(int n)
    {
        for (int i = 2; i < n; i++)
        {
            if (n % i == 0)
                return false;
        }
        return true;
    }
    private static void Main(string[] args)
    {
        //zad 1
        int n = int.Parse(Console.ReadLine());
        ArrayList A = new ArrayList();

        for (int i = 1; i < n; i++)
        {
            if (n % i == 0)
            {
                A.Add(i);
            }
        }
        foreach (int i in A)
        {
            Console.WriteLine(i);
        }

        //zad 2
        int[] T = new int[20];
        Random r = new Random();
        for (int i = 0; i < T.Length; i++)
        {
            T[i] = r.Next(100, 1000);
            Console.Write(T[i] + " ");
            if (!CzyPier(T[i]) && T[i] % 2 != 0 && T[i] % 3 != 0 && T[i] % 5 != 0 && T[i] % 7 != 0)
            {
                Console.Write(T[i] + " ");
            }
            else
            {
                i--;
            }
        }

        //zad 3
        ArrayList A = new ArrayList();
        int suma = 0;
        int[] T = new int[40];
        Random r = new Random();

        for (int i = 0; i < T.Length; i++)
        {
            T[i] = r.Next(10, 100);
            Console.Write(T[i] + " ");
            bool flaga = false;
            for (int j = 0; j < i; j++)
            {
                if (T[i] == T[j])
                {
                    flaga = true;
                    break;
                }
            }
            if (flaga)
            {
                suma += T[i] + T[i];
                A.Add(T[i]);
            }
        }
        foreach (int i in A)
        {
            Console.Write(i + " ");
        }
        Console.WriteLine(suma);
    }

}
