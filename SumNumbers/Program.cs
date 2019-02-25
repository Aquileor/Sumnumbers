using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumNumbers
{
    public class Program
    {
        public static double sum(double V1, double V2, double V3, double V4, double V5, double V6, double V7, double V8, double V9, double V10)
        {
            double sum = (V1 + V2 + V3 + V4 + V5 + V6 + V7 + V8 + V9 + V10)/10;
            //return sum;
            return Math.Round(sum, 2);



        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter 10 values that range between 0 to 100. ");
            double V1 = double.Parse(Console.ReadLine());
            double V2 = double.Parse(Console.ReadLine());
            double V3 = double.Parse(Console.ReadLine());
            double V4 = double.Parse(Console.ReadLine());
            double V5 = double.Parse(Console.ReadLine());
            double V6 = double.Parse(Console.ReadLine());
            double V7 = double.Parse(Console.ReadLine());
            double V8 = double.Parse(Console.ReadLine());
            double V9 = double.Parse(Console.ReadLine());
            double V10 = double.Parse(Console.ReadLine());


            Console.Write("Sum of 10 values that range between 0 to 100 equals ");
            Console.Write(sum(V1, V2, V3, V4, V5, V6, V7, V8, V9, V10));
            //Console.Write("\nThe avergae grade is");
            //Console.Write();
            Console.ReadLine();

            
        }
    }
}
