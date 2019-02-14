using System;
using System.Collections.Generic;
using System.IO;
namespace Task_3{
    class Program{
        public static List<string> ld = new List<string>(), lf = new List<string>();

        public static void Show(List<string> lf, List<string> ld){ 
            foreach (string i in ld)
                Console.WriteLine("     " + i);
            foreach (string i in lf)
                Console.WriteLine("     " + i);
        }
        
        public static List<string> Directories(string[] d){
            for (int i = 0; i < d.Length; i++){
                string k = Path.GetFileName(d[i]);
                ld.Add(k);
            }
            return ld;
        }

        public static void Directoris_Files(string[] f, string[] d){
            for (int i = 0; i < f.Length; i++) {
                string k = Path.GetFileName(f[i]);
                ld.Add(k);
            }
            Directories(d);
            Show(lf, ld);
        }
        public static void Main(string[] args){
            string DirName = @"C:\Users\win10\Desktop\pp2";
            string Dir = Path.GetFileName(DirName);
            string[] AFiles = Directory.GetFiles(DirName);
            string[] ADirs = Directory.GetDirectories(DirName);
            Console.WriteLine(Dir);
            Directoris_Files(ADirs, AFiles);           
        }
    }
}