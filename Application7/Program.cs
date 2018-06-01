using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application7
{
    public class calculatesum
    {
        public int mainfuncation()
        {
            int result = 0;

            for (int i = 2; i < 355000; i++)
            {
                int sumOfPowers = 0; int number = i;
                while (number > 0)
                {
                    int d = number % 10;
                    number /= 10;

                    int temp = d;
                    for (int j = 1; j < 5; j++)
                    {
                        temp *= d;
                    }
                    sumOfPowers += temp;
                }

                if (sumOfPowers == i)
                {
                    result += i;
                }
            }
            return result;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            calculatesum mf = new calculatesum();
            mf.mainfuncation();
            Console.ReadKey();
        }
    }
}
