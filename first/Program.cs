using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace first
{
    class Program
    {
        static void  equation(double a, double b, double c){
            double  sol1, sol2, delta;
            if (a == 0)
            {
                if (b == 0)
                {
                    if (c == 0)
                        Console.WriteLine("Infinté de solution !!!");
                    else
                        Console.WriteLine("Pas de solution !!!");
                }
                else
                {
                    sol1 = sol2 = -c / b;
                    Console.WriteLine("Une solution : " + sol1);
                }
            }
            else
            {
                delta = b * b - 4 * a * c;
                if (delta == 0)
                {
                    sol1 = sol2 = -b / 2 * a;
                    Console.WriteLine("Solution double : " + sol1);
                }
                else
                {
                    if (delta > 0)
                    {
                        sol1 = (-b - Math.Sqrt(delta)) / 2 * a;
                        sol2 = (-b + Math.Sqrt(delta)) / 2 * a;
                        Console.WriteLine("Deux solution, sol1 = " + sol1 + "et sol2 = " + sol2);
                    }
                    else
                    {
                        Console.WriteLine("Pas de Solution dans R ");
                    }
                }
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        static bool isArmstrong(int value) {
            int[] cube = numbers(value);
            if (cube != null) 
                if(value == ((cube[0]*cube [0]*cube[0]) + (cube[1]*cube [1]*cube[1])+ (cube[2]*cube[2]*cube[2])))
                    return true;
                else 
                    return false;
            else
                return false;
        }


        static int[] numbers(int value) {
            int[] result = new int[3]; 
            if ((value >= 100) && (value <= 999))
            {
                result[0] = value / 100;
                result[1] = ((value/10)%10);
                result[2] = value%10;
                return result;
            }else{
                return null;
            }
        }

        static bool isprime(int value) {
            int div = 0;
            for (int i = 1; i < value; i++) {
                if (value % i == 0)
                    div++;
            }
            if (div == 1)
                return true;
            else
                return false;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            for (int i = 100; i <= 500; i++)
                if (isArmstrong(i))
                    Console.WriteLine(i);
            for (int i = 1; i <= 100; i++) {
                if (isprime(i))
                    Console.WriteLine(i);
            }
            Console.ReadKey();
         }
    }
}
