using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumNumbers
{
    public class Program
    {
        public static double Total(double A)
        {
            double volume = A ;

            double Sum = 0;
        //  double Var = 0;
            double Total = 0;

            do
            {
                // Sum = Sum + (Convert.ToDouble(Console.ReadLine()));
                Total = Sum++ / Sum;
                // Var = Var + 1;
                Console.WriteLine("Enter test score: " + Sum);
                Sum++;
                if (Sum > 10) ;
                    break;
            
            }
            while (true);
        
            /*
             do
            {
                Sum = Sum + (Convert.ToDouble(Console.ReadLine()));
                Total = Sum / volume;
                Var = Var + 1;
            }
            while (Var < volume);
            */
            
            if (Total < 59.99)
            {
                Console.Write("The average grade is F or a ");
            }
            else if (Total > 59.99 && Total < 69.99)
            {
                Console.Write("The average grade is D or a ");
            }
            else if (Total > 69.99 && Total < 79.99)
            {
                Console.Write("The average grade is C or a ") ;
            }
            else if (Total > 79.99 && Total < 89.99)
            {
                Console.Write("The average grade is B or a ") ;
            }
            else if (Total > 89.99)
            {
                Console.Write("The average grade is A or a ");
            }
           
            return Math.Round(Total, 2);
            }

        static void Main(string[] args)

        {
            Console.Write("Answer for each test must range between 0 and 100." +
                "\nEnter how many tests are being graded: ");
            double A = double.Parse(Console.ReadLine());

            Console.Write(Total(A));
            Console.ReadLine();

        }
    }
}
