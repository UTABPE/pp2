using System;
using System.IO;
namespace Task_4{
    class Program{
        static void Main(string[] args){
            string Path1 = @"C:\Users\win10\Desktop\probka";
            string subPath = @"C:\Users\win10\Desktop\lab";
            DirectoryInfo DR = new DirectoryInfo(Path1);
            DR.CreateSubdirectory(subPath);
            DR.Delete(Path1);
        }
    }
}
