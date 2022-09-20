using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ_MASS
{
//    class Program
//    {
//        static void Main()
//        {
//            string[] ot0do9 = { "Ноль ", "Один ", "Два ", "Три ", "Четыре ", "Пять ", "Шесть ", "Семь ", "Восемь ", "Девять ", "Ноль ", "Одна ", "Две " };
//            string[] ot10do19 = { "Ноль ", "Одиннадцать ", "Двенадцать ", "Тринадцать ", "Четырнадцать ", "Пятнадцать ", "Шестнадцать ", "Семнадцать ", "Восемнадцать ", "Девятнадцать " };
//            string[] ot20do90 = { "Ноль ", "Десять ", "Двадцать ", "Тридцать ", "Сорок ", "Пятьдесят ", "Шестьдесят ", "Семьдесят ", "Восемьдесят ", "Девяносто " };
//            string[] ot100do900 = { "Ноль ", "Сто ", "Двести ", "Триста ", "Четыреста ", "Пятьсот ", "Шестьсот ", "Семьсот ", "Восемьсот ", "Девятьсот " };
//            string[] tichachiMillion = { "Миллион ", "Тысяча ", "Тысячи ", "Тысяч " };

//            Console.WriteLine("Введите число от 0 до 1 000 000:");

//            try
//            {
//                int number = int.Parse(Console.ReadLine());
//                if (number < 0 || number > 1000000)
//                {
//                    Console.WriteLine("Число не из диапазона!");
//                    Main();
//                }

//                if (number == 0)
//                {
//                    Console.WriteLine(ot0do9[0]);
//                }
//                else if ((number / 1000000) > 0)
//                {
//                    Console.WriteLine(ot0do9[1] + ' ' + tichachiMillion[0]);
//                }
//                else
//                {
//                    int temp = number / 1000; //работаем с тысячами
//                    if (temp / 100 > 0)
//                    {
//                        Console.Write(ot100do900[temp / 100] + ' ');
//                    }
//                    if (temp % 100 > 4 && temp % 100 < 10)
//                    {
//                        Console.Write(ot0do9[temp % 100] + ' ' + tichachiMillion[3]);
//                    }
//                    else if (temp % 100 == 1)
//                    {
//                        Console.Write(ot0do9[temp % 100 + 10] + ' ' + tichachiMillion[1]);
//                    }
//                    else if (temp % 100 == 2)
//                    {
//                        Console.Write(ot0do9[temp % 100 + 10] + ' ' + tichachiMillion[2]);
//                    }
//                    else if (temp % 100 > 2 && temp % 100 < 5)
//                    {
//                        Console.Write(ot0do9[temp % 100] + ' ' + tichachiMillion[2]);
//                    }
//                    else if (temp % 100 > 10 && temp % 100 < 20)
//                    {
//                        Console.Write(ot10do19[(temp % 100) % 10] + ' ' + tichachiMillion[3]);
//                    }
//                    else
//                    {
//                        if ((temp % 100) / 10 > 0)
//                        {
//                            Console.Write(ot20do90[(temp % 100) / 10] + ' ');
//                        }

//                        if (((temp % 100) % 10) > 0)
//                        {
//                            Console.Write(ot0do9[(temp % 100) % 10] + ' ' + tichachiMillion[3]);
//                        }
//                        else if (temp > 0)
//                        {
//                            Console.Write(tichachiMillion[3]);
//                        }
//                    }
//                    if (temp > 0)
//                    {
//                        Console.Write(' ');
//                    }
//                    temp = number % 1000;//работаем до 1000

//                    if (temp / 100 > 0)
//                    {
//                        Console.Write(ot100do900[temp / 100]);
//                    }
//                    if (temp % 100 > 0 && temp % 100 < 10)
//                    {
//                        Console.Write(ot0do9[temp % 100]);
//                    }
//                    else if (temp % 100 > 10 && temp % 100 < 20)
//                    {
//                        Console.Write(ot10do19[(temp % 100) % 10]);
//                    }
//                    else
//                    {
//                        if ((temp % 100) / 10 > 0)
//                        {
//                            Console.Write(' ' + ot20do90[(temp % 100) / 10] + ' ');
//                        }
//                        if (((temp % 100) % 10) > 0)
//                        {
//                            Console.Write(ot0do9[(temp % 100) % 10]);
//                        }
//                    }
//                }

//                Console.WriteLine();
//            }
//            catch (FormatException)
//            {
//                Console.WriteLine("Это не число!");
//                Main();
//            }
//            catch (OverflowException)
//            {
//                Console.WriteLine("Число не из диапазона!");
//                Main();
//            }
//            System.Threading.Thread.Sleep(10000);
//        }
//    }
    class Program
    {
        static void Main()
        {
            int height;
            int width;

            int num = 1;
            Console.Write("Введите высоту: ");
            height = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите ширину: ");
            width = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            int[,] ar = new int[height, width];

            for (int i = 0; i < height; i++)
            {
                if (i % 2 == 0)
                {
                    for (int j = 0; j < width; j++)
                    {
                        ar[i, j] = num;
                        num++;
                    }
                }
                else
                {
                    for (int j = width - 1; j >= 0; j--)
                    {
                        ar[i, j] = num;
                        num++;
                    }
                }
                
            }

            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j < width; j++)
                {
                    Console.Write(ar[i, j] + "\t");
                }
                Console.WriteLine();
            }
            System.Threading.Thread.Sleep(10000);
        }
    }
}

