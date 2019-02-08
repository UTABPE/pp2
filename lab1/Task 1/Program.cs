using System;
using System.Collections.Generic;
namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            int z, cnt = 0, k = 0;
            int n = int.Parse(Console.ReadLine()); // Размер массива
            string[] s = Console.ReadLine().Split(); // Элементы массива
            List<int> ans = new List<int>(); // Будущий список простых элеметов
            for (int i = 0; i < s.Length; i++)
            { // Нахождение простых числе
                z = int.Parse(s[i]);
                for (int j = 2; j <= z; j++)
                {
                    if (z % j == 0) cnt++;
                }
                if (cnt == 1) { ans.Insert(k, z); k++; }
                cnt = 0;
            }
            Console.WriteLine(k); // Колличество простых чисел
            for (int i = 0; i < k; i++)
            {
                Console.Write(ans[i] + " "); // Простые числа   
            }
        }
    }
}
