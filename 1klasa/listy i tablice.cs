using System;
using System.Collections;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Threading.Channels;

class Program
{
    static void Main(string[] args)
    {
        // zad 1 dzielniki liczby wpisane do listy
        ArrayList A = new ArrayList();
        int n = int.Parse(Console.ReadLine());

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

        // zad 2 Lista 20 liczb podzielnych przez 50
        ArrayList B = new ArrayList();
        Random r = new Random();
        while (B.Count < 20)
        {
            int x = r.Next(2,100) * 50;
            if (x >= 100 && x <= 1000)
            {
                B.Add(x);
            }
        }
        foreach (int i in B)
        {
            System.Console.Write(i + " ");
        }

        //zad 4 Macierz 25x25
        int[,] M = new int[25,25];
        Random r = new Random();

        for (int i = 0; i < 25; i++)
        {
            for (int j = 0; j < 25; j++)
            {
                M[i,j] = r.Next(100,1000);
                Console.Write(M[i,j] + "\t");
            }
        }

        //zad 5 Macierz //1 1 1
                        //2 2 2
                        //3 3 3
        int[,] M = new int[3,3];
        for (int i = 0 ; i < 3; i++)
        {
            for (int j = 0 ; j < 3; j++)
            {
                M[i,j] = i + 1;
                Console.Write(M[i,j] + "\t");
            }
            Console.WriteLine();
        }

        //zad 6 Macierz //1 2 3
                        //4 5 6
                        //7 8 9
        int[,] M = new int[3,3];
        int ile = 1;
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                M[i, j] = ile;
                Console.Write(M[i, j] + "\t");
                ile++;
            }
            Console.WriteLine();
        }
    }
}
