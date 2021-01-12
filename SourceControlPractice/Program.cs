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
            Double subtotal = getSubtotal();
            Double tax = calculateTax(subtotal);
            Double grandTotal = getGrandTotal(subtotal, tax);

        }

        public static Double getSubtotal()
        {
            Console.WriteLine("Please enter a subtotal: ");
            string input = Console.ReadLine();
            return Convert.ToDouble(input);
        }

        public static Double calculateTax(Double subtotal)
        {
            Double taxRate = .095;
            Double tax = subtotal * taxRate;

            return tax;
        }

        public static Double getGrandTotal(Double subtotal, Double tax)
        {
            return subtotal + tax;
        }
    }
}
