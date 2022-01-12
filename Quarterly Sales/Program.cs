using System;

namespace Quarterly_Sales
{
    internal class Program
    {
        //no point in setting array values if you are clearing it at the beginning of main()
        //public static string[] quarter = { "", "", "", "" };
        //public static double[] doublequarter = { 0, 0, 0, 0 };

        //Used Global array version
        //public static double[] doublequarter = new double[4];
        static void Title()
        {
            Console.WriteLine("The Quarterly Sales program\n");
        }

        public static void Main(string[] args)
        {
            double[] doublequarter = new double[4];
            String Success = "";
            Title();
            do
            {
                try
                {
                    Success = "true";
                    //Array.Clear(quarter, 0, quarter.Length);
                    Array.Clear(doublequarter, 0, doublequarter.Length);
                    //An alternative to clear the array is:
                    //doublequarter = new double[4];

                    //Your way with a global Array
                    //DataEntry();
                    //double Total = TotalCalculation();
                    //AverageCalculation(Total);
                    //LowestCalculation();
                    //HighestCalculation();

                    //Alternative with a local array
                    doublequarter = DataEntry(doublequarter);
                    double Total = TotalCalculation(doublequarter);
                    AverageCalculation(Total, doublequarter.Length);
                    LowestCalculation(doublequarter);
                    HighestCalculation(doublequarter);
                }
                catch (Exception)
                {
                    Console.WriteLine("Please enter a valid number");
                    Console.WriteLine();
                    Success = "false";
                }
            } while (Success == "false");
        }
        static double[] DataEntry(double[] doublequarter)
        {

            for (int i = 0; i < doublequarter.Length; i++)
            {
                Console.Write("Enter sales for Q" + (i + 1) + ": ");
                string temp = Console.ReadLine();
                doublequarter[i] = Convert.ToDouble(temp); //add to doubleQuarter here instead of looping a second time
            }
            //only need one array so quarter[] is not needed
            //can add to doubleQuarter in the same for loop above to minimize looping
            //for (int i = 0; i < quarter.Length; i++)
            //{
            //    if (quarter[i] != "")
            //    {
            //        doublequarter[i] = Convert.ToDouble(quarter[i]);
            //    }
            //}
            Console.WriteLine();
            return doublequarter;
        }
        static double TotalCalculation(double[] doublequarter)
        {
            double Total = 0;
            for (int i = 0; i < doublequarter.Length; i++)
            {
                Total += doublequarter[i];
            }
            Console.WriteLine("Total:\t\t\t" + Math.Round(Total,2));
            return Total;
        }
        //static double TotalCalculation()
        //{
        //    double Total = 0;
        //    for (int i = 0; i < doublequarter.Length; i++)
        //    {
        //        Total += doublequarter[i];
        //    }
        //    Console.WriteLine("Total:                        " + Math.Round(Total, 2));
        //    return Total;
        //}

        static void AverageCalculation(double Total, int numberOfQuarters)
        {
            double Average = Total / numberOfQuarters;
            Console.WriteLine("Average Quarter:\t" + Math.Round(Average,2));
        }
        //static void AverageCalculation(double Total)
        //{
        //    double Average = Total / doublequarter.Length;
        //    Console.WriteLine("Average Quarter:              " + Math.Round(Average, 2));
        //}

        static void LowestCalculation(double[] doublequarter)
        {
            int i;
            double min = doublequarter[0];
            for (i = 0; i < doublequarter.Length; i++)
                if (doublequarter[i] < min)
                    min = doublequarter[i];
            Console.WriteLine("Lowest Quarter:\t\t" + Math.Round(min,2));
        }

        //static void LowestCalculation()
        //{
        //    int i;
        //    double min = doublequarter[0];
        //    for (i = 0; i < doublequarter.Length; i++)
        //        if (doublequarter[i] < min)
        //            min = doublequarter[i];
        //    Console.WriteLine("Lowest Quarter:               " + Math.Round(min, 2));
        //}

        static void HighestCalculation(double[] doublequarter)
        {
            int i;
            double max = doublequarter[0];
            for (i = 0; i < doublequarter.Length; i++)
                if (doublequarter[i] > max)
                    max = doublequarter[i];
            Console.WriteLine("Highest Quarter:\t" + Math.Round(max,2));
        }

        //static void HighestCalculation()
        //{
        //    int i;
        //    double max = doublequarter[0];
        //    for (i = 0; i < doublequarter.Length; i++)
        //        if (doublequarter[i] > max)
        //            max = doublequarter[i];
        //    Console.WriteLine("Highest Quarter:              " + Math.Round(max, 2));
        //}
    }
}