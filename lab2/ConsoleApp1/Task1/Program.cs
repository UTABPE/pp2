using System;
using System.IO;
namespace ConsoleApp1{
    class Program{
        public static bool Pal(string s){ // Определения полиндрома
            for (int i = 0, j = s.Length - 1; i < j; i++, j--)
                if (s[i] != s[j]) return false;
            return true;
        }
        static void Main(string[] args){
            FileStream f = new FileStream(@"C:\Users\win10\Desktop\pp2\lab2\2\Task1.txt", FileMode.Open, FileAccess.Read); // открытие
            StreamReader sr = new StreamReader(f);
            string s = new string(sr.ReadToEnd()); // Запись возможного полиндрома
            sr.Close(); // закрытие
            f.Close();
            if (Pal(s)) Console.WriteLine("Yes"); //да
            else Console.WriteLine("No"); // нет
        }
    }
}
