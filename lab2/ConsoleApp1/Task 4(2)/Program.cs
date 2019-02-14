using System;
using System.IO;
namespace Task3{
    class Program{
        static void Print_info(FileSystemInfo file, int nmspc){ // принмает путь и 
            string s = new string(' ', nmspc);
            s = s + file.Name;
            Console.WriteLine(s);
            if ( file.GetType() ==  typeof(DirectoryInfo)){
                var v = (file as DirectoryInfo).GetFileSystemInfos();
                foreach (var n in v){
                    Print_info(n, nmspc + 3);
                }
            }

        }
        static void Main(string[] args){
            DirectoryInfo directory = new DirectoryInfo(@"C:\Users\win10\Desktop"); // путь
            Print_info(directory, 1);
        }
    }
}