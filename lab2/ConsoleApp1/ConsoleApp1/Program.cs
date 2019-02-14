using System.IO;
namespace System{
    class Program{
        public static bool Prime(int n){ //определение прайма
            if (n == 1) return false;
            for (int i = 2; i <= Math.Sqrt(n); i++){
                if (n % i == 0) return false;
            }
            return true;
        }
        static void Main(string[] args){
            FileStream F = new FileStream(@"C:\Users\win10\Desktop\pp2\lab2\2\Text.txt", FileMode.Open, FileAccess.Read); //откртие
            FileStream F2 = new FileStream(@"C:\Users\win10\Desktop\pp2\lab2\2\ans.txt", FileMode.Create, FileAccess.Write);
            StreamReader S = new StreamReader(F);
            StreamWriter SW = new StreamWriter(F2);
            string org = new string(S.ReadLine()) ;
            S.Close(); // закрытие
            F.Close();
            string[] res = org.Split(); // разделение стринга на части
            int z;
            string res1="";
            for (int i=0; i<res.Length; i++){ // цикл для записи всех праймов в 1 стринг
                z = int.Parse(res[i]);
                if (Prime(z) == true){
                    res1 += z + " ";
                }
            }
            SW.Write(res1); // запись
            SW.Close();//закрытие
            F2.Close();
        }
    }
}
