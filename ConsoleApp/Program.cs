using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var AdditionResult = Addition.Add_Two_Nos(12, 13);
            if (Convert.ToInt32(AdditionResult)  < 0)
            {
                Exception ex = (Exception)AdditionResult;
                Console.WriteLine($"Message: {ex.Message}");
                Console.WriteLine($"Source: {ex.Source}");
            }
            else
            {
                Console.WriteLine($"Sum of two Nos are: {AdditionResult}");
            }

            Console.ReadKey();
        }


    }
}
