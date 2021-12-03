using System;
using System.Collections.Generic;
using System.Text;

namespace Practice
{
    public static class InnerExceptions
    {
        public static void GetLastInnerException(Exception ex)
        {
            while(ex.InnerException != null)
            {
                ex = ex.InnerException;
            }
            Console.WriteLine(ex.ToString());
        }
        public static void GetAllInnerExMessage(Exception ex)
        {
            while (ex.InnerException != null)
            {
                Console.WriteLine(ex.ToString());
                ex = ex.InnerException;
            }
            Console.WriteLine(ex.ToString());
        }
    }
}
