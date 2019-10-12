using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите размер массива: ");
            int n = Convert.ToInt32(Console.ReadLine());
            double[] m = new double[n];
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"Введите {i + 1} элемент массива: ");
                m[i] = Convert.ToDouble(Console.ReadLine());
            }
            MyltMin(ref n, m);
            SumMinusPlus(ref n, m);
            SumNull(ref n, m);
            DobMaxAbsMinAbs(ref n, m);
        }

        static void MyltMin(ref int n, params double[] m)
        {
            double min = 2480866868, s = 1;
            int mini = 0;
            for (int i = 0; i < n; i++)
            {
                if (min > m[i])
                {
                    min = m[i];
                    mini = i;
                }
            }
            if (mini + 1 == m.Length)
            {
                s = 0;
            }
            else
            {
                for (int i = mini + 1; i < n; i++)
                {
                    s = s * m[i];
                }
            }
            Console.WriteLine($"Произведение всех чисел после минимального: {s}");
        }

        static void SumMinusPlus(ref int n, params double[] m)
        {
            int pv = 0, pd = -1, dd = -1;
            double s = 0;
            for (int i = 0; i < n; i++)
            {
                if (m[i] < 0)
                {
                    pv = i;
                    break;
                }
            }
            for (int i = 0; i < n; i++)
            {
                if (m[i] > 0 && pd != 0)
                {
                    dd = i;
                    break;
                }
                else if (m[i] > 0 && pd == 0)
                {
                    pd = i;
                }
            }
            if (pv < dd && pv != -1 && dd != -1)
            {
                for (int i = pv; i < dd; i++)
                {
                    s = s + m[i];
                }
                Console.WriteLine($"Сумма элементов от первого отрицательного до второго положительного: {s}");
            }
            else
            {
                Console.WriteLine("Между первым отрицательным и вторым положительным элементов массива нет элементов");
            }
        }

        static void SumNull(ref int n, params double[] m)
        {
            int firstNull = -1, lastNull = -1;
            double s = 0;
            for (int i = 0; i < n; i++)
            {
                if (m[i] == 0)
                {
                    firstNull = i;
                    break;
                }
            }
            for (int i = m.Length - 1; i >= 0; i--)
            {
                if (m[i] == 0)
                {
                    lastNull = i;
                    break;
                }
            }
            if (firstNull == -1 || lastNull == -1)
            {
                Console.WriteLine("В массиве меньше двух нулевых элементов");
            }
            else
            {
                for (int i = firstNull; i < lastNull; i++)
                {
                    s = s + m[i];
                }
                Console.WriteLine($"Сумма элементов от первого нулевого до последнего нулевого элементов: {s}");
            }
        }

        static void DobMaxAbsMinAbs(ref int n, params double[] m)
        {
            double maxAbs = -2480866868, minAbs = 2480866868, s = 1;
            int maxi = 0, mini = 0;
            for (int i = 0; i < n; i++)
            {
                if (maxAbs < Math.Abs(m[i]))
                {
                    maxAbs = Math.Abs(m[i]);
                    maxi = i;
                }
                if (minAbs > Math.Abs(m[i]))
                {
                    minAbs = Math.Abs(m[i]);
                    mini = i;
                }
            }
            if (maxi > mini)
            {
                Console.WriteLine("Между максимальным и минимальным элементом нет элементов");
            }
            else
            {
                for (int i = maxi + 1; i < mini - 1; i++)
                {
                    s = s * m[i];
                }
                Console.WriteLine($"Произвидение элементов между максимальным и минимальным элементами: {s}");
            }
        }
    }
}
