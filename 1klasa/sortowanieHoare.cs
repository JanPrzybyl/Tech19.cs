using System;

class Program
{
    static void Main()
    {
        int[] T = new int[10];
        Random random = new Random();
        for (int i = 0; i < T.Length; i++)
        {
            T[i] = random.Next(1, 101);
        }
        
        Console.WriteLine(string.Join(" ", T));
        QuickSortHoare(T, 0, T.Length - 1);
        Console.WriteLine(string.Join(" ", T));
    }

    static void QuickSortHoare(int[] T, int lewy, int prawy)
    {
        int i = lewy;
        int j = prawy;
        int pivot = T[(lewy + prawy) / 2];

        while (i <= j)
        {
            while (T[i] < pivot)
            {
                i++;
            }
            while (T[j] > pivot)
            {
                j--;
            }
            if (i <= j)
            {
                int temp = T[i];
                T[i] = T[j];
                T[j] = temp;
                i++;
                j--;
            }
        }

        if (lewy < j)
        {
            QuickSortHoare(T, lewy, j);
        }
        if (prawy > i)
        {
            QuickSortHoare(T, i, prawy);
        }
    }
}
