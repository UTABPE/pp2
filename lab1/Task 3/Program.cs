using System;
namespace ConsoleApp1{
    class Program{
        static void Main(string[] args){
            int n = int.Parse(Console.ReadLine()); // размер
            string[] s = Console.ReadLine().Split(); // считывание 
            Console.Clear();
            for (int i = 0; i < s.Length; i++){
                Console.Write(s[i] + " " + s[i] + " "); // гениальное решение 
            }
        }
    }
}
