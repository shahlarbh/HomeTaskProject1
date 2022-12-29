namespace HomeTaskProject1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Task1.
            Console.Write("Ededi daxil edin:");
            int number = int.Parse(Console.ReadLine());
            int countDigit = (int)Math.Log10(number) + 1;
            int r, i, sum = 0;
            i = countDigit % 2 == 0 ? 0 : 1;

            while (number != 0)
            {
                r = number % 10;
                number /= 10;

                if (i % 2 == 0)
                {
                    sum += r * r;
                }

                i++;
            }

            Console.WriteLine(sum);
            #endregion

            #region Task2.
            Console.Write("Ededi daxil edin:");
            int number = int.Parse(Console.ReadLine());
            int countDigitLog = (int)Math.Log10(number) + 1;
            int r, sum = 0;

            while (number != 0)
            {
                r = number % 10;
                number /= 10;
                sum += r * countDigitLog;
                countDigitLog--;
            }

            Console.WriteLine(sum);
            #endregion

            #region Task3.
            Console.Write("Ededi daxil edin:");
            int number = int.Parse(Console.ReadLine());
            int countDigitLog = (int)Math.Log10(number) + 1;

            if (countDigitLog == 5)
            {
                int x = (400000 + number) * 10 + 2;
                Console.WriteLine(x);
            }

            else
            {
                Console.WriteLine("Eded 5 reqemli deyil");
            }
            #endregion

            #region Task4.
            Console.Write("Ededi daxil edin:");
            int number = int.Parse(Console.ReadLine());
            int r1, r2, tmp;
            bool isDifferenceDigit = true;

            while (number != 0)
            {
                r1 = number % 10;
                number /= 10;
                tmp = number;

                while (tmp != 0)
                {
                    r2 = tmp % 10;
                    tmp /= 10;

                    if (r1 == r2)
                    {
                        Console.WriteLine("Eded muxtelif reqemli deyil");
                        isDifferenceDigit = false;
                        break;
                    }
                }

                if (!isDifferenceDigit)
                {
                    break;
                }
            }

            if (isDifferenceDigit)
            {
                Console.WriteLine("Eded muxtelif reqemlidir");
            }
            #endregion

            #region Task5.
            Console.Write("Ededi daxil edin:");
            int x = int.Parse(Console.ReadLine());
            Console.Write("Ededi daxil edin:");
            int y = int.Parse(Console.ReadLine());
            int count = 0;

            for (int i = Math.Min(x, y); i <= Math.Max(x, y); i++)
            {
                if (Math.Sqrt(i) == (int)Math.Sqrt(i))
                {
                    Console.WriteLine(i);
                    count++;
                }
            }
            Console.WriteLine($"Count:{count}");
            #endregion

        }
    }
}