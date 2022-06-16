using System;
using static System.Math;
using System.Collections.Generic;


namespace Lab_3
{ 
    class Program
    {

        static void Main(string[] args)
        {
           
            while (true)
            {
                Main main = new Main();
                if(main.vvod_puncta == 1 || main.vvod_puncta == 2 || main.vvod_puncta == 3 || main.vvod_puncta == 4)
                {
                    if (main.vvod_puncta == 1)
                    {
                        Lab_1 lab_1_1 = new Lab_1();

                        Console.WriteLine();
                        Console.WriteLine("Натуральный логорифм: " + lab_1_1.log);
                        Console.WriteLine("Округленный до n: " + lab_1_1.znak);
                        Console.ReadLine();
                        Console.Clear();

                    }
                    else if (main.vvod_puncta == 2)
                    {
                        Lab_2 lab_2_1 = new Lab_2();                                       
                      
                            if (lab_2_1.main == 1)
                            {
                                Console.WriteLine("Градусы: " + lab_2_1.vvod);
                                Console.WriteLine("Округление до n знака: " + lab_2_1.ocruglenie_n);
                                Console.ReadLine();
                                Console.Clear();
                            }
                            else if (lab_2_1.main == 2)
                            {
                                Console.WriteLine("Радианы: " + lab_2_1.vvod);
                                Console.WriteLine("Округление до n знака: " + lab_2_1.ocruglenie_n_2);
                                Console.ReadLine();
                                Console.Clear();
                            }
                            else
                            {
                                Console.WriteLine("Не верно введено значение");
                            }                                                                                 
                    }
                    else if (main.vvod_puncta == 3)
                    {
                        Program_2_1_3 lab_3_1 = new Program_2_1_3();

                        Console.ReadLine();
                        Console.Clear();
                    }
                    else if (main.vvod_puncta == 4)
                    {
                        lab_1_4 lab_1_4 = new lab_1_4();

                        Console.ReadLine();
                        Console.Clear();
                    }
                    else
                    {
                        Console.WriteLine("Не верно выбран номер задания!");
                    }
                }
            }
        }
    }
}
