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
            double subtotal = getSubtotal();
            double tax = calculateTax(subtotal);
            double grandTotal = getGrandTotal(subtotal, tax);
            printResults(subtotal, tax, grandTotal);
            Console.ReadKey();
        }

        public static double getSubtotal()
        {
            Console.WriteLine("Please enter a subtotal: ");
            string input = Console.ReadLine();
            return Convert.ToDouble(input);
        }

        public static double calculateTax(double subtotal)
        {
            double taxRate = .095;
            double tax = subtotal * taxRate;

            return tax;
        }

        public static double getGrandTotal(double subtotal, double tax)
        {
            return subtotal + tax;
        }

        public static void printResults(double sub, double tax, double grand)
        {
            Console.WriteLine("Subtotal: " + sub.ToString("C"));
            Console.WriteLine("Tax(9.5%): " + tax.ToString("C"));
            Console.WriteLine("Grand Total: " + grand.ToString("C"));
        }
    }
}
