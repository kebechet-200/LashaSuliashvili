using System;
using System.Collections.Generic;
using System.Text;

namespace Practice_1
{
    static class MATH
    {
        public static double Pow(int a, int n, out string result)
        {
            int number = 1;
            if (!(n >= 0))
            {
                result = Statusses.PowMustBeaPositiveOrZero.ToString();
                return 0;
            }
            else
            {
                result = Statusses.Success.ToString();
                if (n == 0) return 1;
                for (int i = 0; i < n; i++)
                {
                    number *= a;
                }
            }
            return number;
        }

        public static int Min(int a, int b, out string result)
        {
            if (a==b)
            {
                result = Statusses.NumberNotBeEqual.ToString();
                return 0;
            }
            else
            {
                result = Statusses.Success.ToString();
                if (a > b) return b;
                else return a;
            }
        }

        public static int Max(int a, int b, out string result)
        {
            if (a == b)
            {
                result = Statusses.NumberNotBeEqual.ToString();
                return 0;
            }
            else
            {
                result = Statusses.Success.ToString();
                if (a > b) return a;
                else return b;
            }
        }

    }
}
