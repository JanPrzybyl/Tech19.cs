using System;

class Program
{
    static void Main()
    {
        int[] T = new int[20];
        Random random = new Random();
        for (int i = 0; i < T.Length; i++)
        {
            T[i] = random.Next(1, 101);
        }
        
        Console.WriteLine(string.Join(" ", T));
        QuickSortLomuto(T, 0, T.Length - 1);
        Console.WriteLine(string.Join(" ", T));
    }

    static void QuickSortLomuto(int[] T, int lewy, int prawy)
    {
        if (lewy < prawy)
        {
            int pivot = T[prawy];
            int i = lewy;
            for (int k = lewy; k < prawy; k++)
            {
                if (T[k] <= pivot)
                {
                    int temp = T[i];
                    T[i] = T[k];
                    T[k] = temp;
                    i++;
                }
            }

            int temp2 = T[i];
            T[i] = T[prawy];
            T[prawy] = temp2;

            if (lewy < i - 1)
            {
                QuickSortLomuto(T, lewy, i - 1);
            }
            if (prawy > i + 1)
            {
                QuickSortLomuto(T, i + 1, prawy);
            }
        }
    }
}
