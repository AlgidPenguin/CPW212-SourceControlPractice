using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SourceControlPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            getSubtotal();
        }

        public static Decimal getSubtotal()
        {
            Console.WriteLine("Please enter a subtotal: ");
            string input = Console.ReadLine();
            return Convert.ToDecimal(input);
        }
    }
}
