using System;

namespace Quarterly_Sales
{
    internal class Program
    {
        public static string[] quarter = { "", "", "", "" };
        public static double[] doublequarter = { 0, 0, 0, 0 };
        static void Title()
        {
            Console.WriteLine("The Quarterly Sales program\n");
        }
        static void Main(string[] args)
        {
            String Success = "";
            Title();
            do
            {
                try
                {
                    Success = "true";
                    Array.Clear(quarter, 0, quarter.Length);
                    Array.Clear(doublequarter, 0, doublequarter.Length);
                    DataEntry();
                    double Total = TotalCalculation();
                    AverageCalculation(Total);
                    LowestCalculation();
                    HighestCalculation();
                }
                catch (Exception)
                {
                    Console.WriteLine("Please enter a valid number");
                    Console.WriteLine();
                    Success = "false";
                }
            } while (Success == "false");
        }   
        static void DataEntry()
        {
            for(int i = 0; i < quarter.Length; i++)
            {
                if(quarter[i] != "")
                {
                    Console.Write("Enter sales for Q" + (i + 1) + ": ");
                    quarter[i] = Console.ReadLine();
                }
            }
            for (int i = 0; i < quarter.Length; i++)
            {
                if (quarter[i] != "")
                {
                    doublequarter[i] = Convert.ToDouble(quarter[i]);
                }
            }
            Console.WriteLine();
        }
        static double TotalCalculation()
        {
            double Total = 0;
            for (int i = 0; i < doublequarter.Length; i++)
            {
                Total += doublequarter[i];
            }
            Console.WriteLine("Total:                        " + Math.Round(Total,2));
            return Total;
        }
        static void AverageCalculation(double Total)
        {
            double Average = Total / doublequarter.Length;
            Console.WriteLine("Average Quarter:              " + Math.Round(Average,2));
        }
        static void LowestCalculation()
        {
            int i;
            double min = doublequarter[0];
            for (i = 0; i < doublequarter.Length; i++)
                if (doublequarter[i] < min)
                    min = doublequarter[i];
            Console.WriteLine("Lowest Quarter:               " + Math.Round(min,2));
        }
        static void HighestCalculation()
        {
            int i;
            double max = doublequarter[0];
            for (i = 0; i < doublequarter.Length; i++)
                if (doublequarter[i] > max)
                    max = doublequarter[i];
            Console.WriteLine("Highest Quarter:              " + Math.Round(max,2));
        }
    }
}