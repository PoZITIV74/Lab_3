using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_3
{
    public class Main
    {
        public double vvod_puncta;

        public Main()
        {
            Console.WriteLine("1. Задание: Логорифм");
            Console.WriteLine("2. Задание: Перевод из градусов в радианы и обратно");
            Console.WriteLine("3. Задание: Построение параллелограмма");
            Console.WriteLine("4. Задание: Работа с уравнением");     
            vvod_puncta = double.Parse(Console.ReadLine());
        }
    }
}
