using System;
using System.CodeDom;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Linq.Expressions;
using System.Net;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace Абрамян_Задачи
{
    internal class Program
    {

        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.InputEncoding = Encoding.UTF8;
            Console.Title = "Абрамян Задачи";
            

            // Console.BufferHeight = Console.WindowHeight;
            // Console.Write("X: ");
            // double x = double.Parse(Console.ReadLine());
            // Console.Write("N: ");
            // int n = int.Parse(Console.ReadLine());
            //
            // double s = 0;
            // double d = 0;
            // double R = -1;
            // for (double i = 0; i <= n; i++)
            // {
            //     double No = 2 * i + 1;
            //     double N = 1;
            //     double X = 1;
            //
            //     // Code of Factarial`s Cycle
            //     for (double j = 1; j <= No; j++)
            //     {
            //         X *= x;
            //         N *= j;
            //     }
            //     R *= -1;
            //     s += (R * X) / N;
            //     d += Math.Pow(-1, i) * Math.Pow(x, 2 * i + 1) / N;// Этот код работает ЧЕТКО!!!
            // }
            // Console.WriteLine($"Результат 1 равен: {s}");
            // Console.WriteLine($"Результат 2 равен: {d}");
            // Console.WriteLine($"Проверочный результат: {Math.Sin(x)}");
// Запускаем таймер
        Stopwatch stopwatch = Stopwatch.StartNew();

            // --- Твой код здесь ---
                    
            // string S = Console.ReadLine();
            // int N = S.Length;
            // int count = 0;
            //
            // for (int i = N - 1; i > 0; i--)
            // {
            //     
            //     if (S[i].ToString() == " ")
            //     {
            //         break;
            //     }
            //     count++;
            // }
            //
            // if (S[N - 1].ToString() == ".")
            // {
            //     Console.WriteLine(count - 1);
            // }
            // else
            // {
            //     Console.WriteLine(count);
            // }

            for (int i = 0; i < 1000000; i++)
            {
                Console.WriteLine(i);
            }

            // Останавливаем таймер
            stopwatch.Stop();

            // Показываем время выполнения
            Console.WriteLine("Время выполнения программы: " + stopwatch.Elapsed.TotalSeconds + " секунд");
        }
    }
}