using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_3
{  
    public class lab_1_4
    {
        public string vvod;
        public string[] per;
        public string per2;
        public string per3;

        public lab_1_4()
        {
            Console.WriteLine("Введите уравнение");
            vvod = Console.ReadLine();
            vvod = vvod.Replace("-", ".-");         // заменяет знак с минуса на точку с минумос
            vvod = vvod.Replace("+", ".+");         // заменяет плюс на плюс с точкой
            per = vvod.Split('.', '=');    // разделяет на разные строки 
            Console.WriteLine("___________________________");
            for (int i = 0; i < per.Length; i++)
            {
                if (per[i].EndsWith("x"))  // находит число с x
                { per[i] = per[i].Replace("x", ""); Console.Write(per[i]); Console.WriteLine(" Множитель"); } // убирает x и делает пустоту
            }
            for (int i = 0; i < per.Length; i++)  // смотрит до конца строки
            {
                if (per[i].EndsWith("|")) // смотрит совпадает ли этот символ
                {
                    per[i] = per[i].Replace("+|", "");  //убрал часть модуля перед число и сделал пустоту
                    per2 = per[i];               // чмсло
                    per2 = per2.Replace("-", "|-");     // убирает минус перед число и после остаток модуля и минус
                    per3 = per2;                 // число
                    Console.Write(per2);
                    per3 = per3.Replace("-", "");   // убирает минус и меняет на пустоту
                    Console.WriteLine("Модуль числа " + per3);  // число без модуля и минуса
                }
            }
        }
    }

}

