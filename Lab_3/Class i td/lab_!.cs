using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_3
{
    public class Lab_1
    {
        public double osnovanie_a;
        public double argument_b;
        public int ocruglenie;
        public double log;
        public double znak;
     
        public Lab_1()
        {
            Console.WriteLine("Введите логорифм");

            Console.Write("Введите основание a: ");
            osnovanie_a = double.Parse(Console.ReadLine());
           

            Console.Write("Введите аргумент b: ");
            argument_b = double.Parse(Console.ReadLine());

            Console.Write("До каких n знаков округлить: ");
            ocruglenie = int.Parse(Console.ReadLine());


            log = Math.Log(argument_b, osnovanie_a);
            znak = Math.Round(log, ocruglenie);
           
        }
    }
}
