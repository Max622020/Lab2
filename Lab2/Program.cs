using System;
using System.IO;
namespace Lab2
{
    class Program
    {
        static void Main(string[] args)
        {

            string s;
            double x, y;
            StreamWriter f = new StreamWriter("Res.txt");
            StreamReader f1 = new StreamReader("Lab2.txt");
            f.WriteLine("Таблица значений \n");
            f.WriteLine("+________________________________________+\n");
            f.WriteLine("+          Аргумент             +                Функция           +\n");
        metka: s = f1.ReadLine();
            if (s == null) goto metka1;
            x = Convert.ToDouble(s);
            y = (2 * Math.PI) / (x * x) - Math.PI;
            
            f.WriteLine("+          х = {0:F3}             +       y = {1:e3}               +\n", x, y);
            goto metka;
        metka1:
            f.WriteLine("+________________________________________+\n");
            f.WriteLine(" Составил Харченко Максим {0} \n", s);
            f.Close();
            f1.Close();

            // 1 ex
            double A =0.086;
            int I = -19;
            double C = 4.025;
            bool L = false;
            string surname = "Xarchenko";
            Console.WriteLine("A = {0,5} \n", A);
            Console.WriteLine("I = {0,1} \n",I);
            Console.WriteLine("C = {0,2} \n",C);
            Console.WriteLine("L = {0,5} \n", L);
            Console.WriteLine("Surname = {0,9} \n", surname);

        }
    }
}
