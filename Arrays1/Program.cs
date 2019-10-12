using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите длину массива: ");
            int n = Convert.ToInt32(Console.ReadLine());
            double[] m = new double[n];
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"Введите {i + 1} элемент массива: ");
                m[i] = Convert.ToDouble(Console.ReadLine());
            }
            Sum(ref n, m);
            Max(ref n, m);
            MaxAbs(ref n, m);
            SumNumbers(ref n, m);
            Int(ref n, m);
        }

        static void Sum(ref int n, params double[] m)
        {
            double s = 0;
            for (int i = 0; i < n; i++)
            {
                if (m[i] < 0)
                {
                    s = s + m[i];
                }
            }
            Console.WriteLine($"Сумма отрицательных элементов массива: {s}");
        }

        static void Max(ref int n, params double[] m)
        {
            double max = -2480866868, nm = 0;
            for (int i = 0; i < n; i++)
            {
                if (m[i] > max)
                {
                    max = m[i];
                    nm = i + 1;
                }
            }
            Console.WriteLine($"Максимальный элемент массива: {max}");
            MaxNumber(ref nm);
        }

        static void MaxNumber(ref double nm)
        {
            Console.WriteLine($"Номер максимального элемента массива: {nm}");
        }

        static void MaxAbs(ref int n, params double[] m)
        {
            double maxa = -2480866868;
            double q = 0;
            for (int i = 0; i < n; i++)
            {
                if (Math.Abs(m[i]) > maxa)
                {
                    maxa = Math.Abs(m[i]);
                    q = m[i];
                }
            }
            Console.WriteLine($"Максимальный за модулем элемент массива: {q}");
        }

        static void SumNumbers(ref int n, params double[] m)
        {
            int p = 0;
            for(int i = 0; i < n; i++)
            {
                if(m[i] > 0)
                {
                    p = p + i + 1;
                }
            }
            Console.WriteLine($"Сумма номеров положительных элементов массива: {p}");
        }

        static void Int(ref int n, params double[] m)
        {
            int q = 0, s = 0;
            for(int i = 0; i < n; i++)
            {
                q = (int)m[i];
                if(m[i] - q == 0)
                {
                    s++;
                }
            }
            Console.WriteLine($"Количество целых чисел в массиве: {s}");
        }
    }
}
