using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_3
{
    public class Program_2_1_3
    {
        public int use = 1; //используется для проверок

        public Program_2_1_3()
        {
            Console.WriteLine("Ввод данных первой фигуры: ");
            double[] oneX = new double[4];  //массив для оси x
            double[] oneY = new double[4];  //массив для оси y
            for (int i = 0; i < 4; i++)  //будет повторять 4 раза
            {
                oneX[i] = double.Parse(Console.ReadLine()); //ввод значений для осей
                oneY[i] = double.Parse(Console.ReadLine()); //ввод значений для осей
            }

            Console.WriteLine("Ввод данных второй фигуры: ");
            double[] twoX = new double[4];  //массив для оси x
            double[] twoY = new double[4];  //массив для оси y
            for (int i = 0; i < 4; i++)  //будет повторять 4 раза
            {
                twoX[i] = double.Parse(Console.ReadLine()); //ввод значений для осей
                twoY[i] = double.Parse(Console.ReadLine()); //ввод значений для осей
            }

            void Figura(double[] str, double[] st)
            {
                double[] one = new double[4];
                for (int i = 0; i < 4; i++)
                {
                    if (use == 4)
                    {
                        use = 0;
                    }
                    one[i] = Math.Sqrt(Math.Pow(str[use] - str[i], 2) + Math.Pow(st[use] - st[i], 2)); //возводит в квадрат и потом в степень
                    use++;
                }
                if (one[0] == 0 || one[1] == 0 || one[2] == 0 || one[3] == 0)
                {
                    Console.WriteLine("Не верная фигура");
                }
                else if (one[0] == one[2] || one[1] == one[3])
                {
                    Console.WriteLine("Фигура построена");
                }
                else
                {
                    Console.WriteLine("Не верная фигура");
                }

            }
            Figura(oneX, oneY);
            Figura(twoX, twoY);

            for (int i = 0; i < 4; i++)
            {
                if (use == 4) use = 0;
                for (int j = 0; j < 4; j++)
                {
                    if (oneX[j] >= twoX[i] && oneX[i] <= twoX[use] && oneY[j] >= twoY[i] && oneY[i] <= twoY[use])  // проверяет наложение
                    {
                        Console.WriteLine("Наложение!!!");
                    }
                }

            }
        }

    }
}
