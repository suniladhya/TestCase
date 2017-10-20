using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorConsoleApp
{
    public static class Addition
    {
        public static void Add(int v1, int v2)
        {
            try
            {
                Console.WriteLine($"Sum of two Nos are: {v1 + v2}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Message: {ex.Message}");
                Console.WriteLine($"Source: {ex.Source}");

            }
        }

        public static Object Add_Two_Nos(int v1, int v2)
        {
            try
            {
                return v1 + v2;
            }
            catch (Exception ex)
            {
                return ex;

            }
        }
    }
}
