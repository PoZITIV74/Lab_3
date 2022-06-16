using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_3
{
    internal class Lab_2
    {
        public double PI;
        public double vvod;
        public int ocruglenie;
        public double ocruglenie_n;
        public double ocruglenie_n_2;
        public int main;
        public double gr_rad;
        public double rad_gr;

        public Lab_2()
        {
            PI = Math.PI;       

            Console.WriteLine("Меню: ");
            Console.WriteLine("1. Из градусов в радианы");
            Console.WriteLine("2. Из радиан в градусы");
            main = int.Parse(Console.ReadLine());

            Console.Write("Введите значение");
            vvod = double.Parse(Console.ReadLine());
            Console.WriteLine();

            Console.Write("Округление до n: ");
            ocruglenie = int.Parse(Console.ReadLine());
            Console.WriteLine();

            gr_rad = vvod * PI / 180;
            rad_gr = vvod * 180 / PI;

            ocruglenie_n = Math.Round(gr_rad, ocruglenie);
            ocruglenie_n_2 = Math.Round(rad_gr, ocruglenie);
        }

    }
}
