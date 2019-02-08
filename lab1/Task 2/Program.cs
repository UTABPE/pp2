using System;
namespace ConsoleApp1{
    class Class{
        protected string name;
        protected string id;
        protected string year;
        public Class(string name, string id, string year){
            this.name = name;
            this.id = id;
            this.year = year;
        }
        public void PrintInfo(){
            Console.WriteLine(name + " " + id + " " + year);
        }
    }
    class Program{
        static void Main(string[] args){
            Class s = new Class("Aba", "123", "1");
            s.PrintInfo();
        }
    }
}
