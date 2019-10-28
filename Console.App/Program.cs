using System;
using System.Collections.Generic;
using LibCredit;

namespace Console.App
{
    class MainClass
    {
        public static void Main()
        {
            decimal creditAamount = 100_000m;
            decimal annualInterest = 10.00m;
            decimal creditTerm = 12m;

            creditAamount = ReadDecimal("Credit amount, currency: ");
            annualInterest = ReadDecimal("Annual interest, percents: ");
            creditTerm = ReadDecimal("Credit term, months: ");

            PrintCaption(creditAamount, annualInterest, creditTerm);

            ClassCalc _calc = ClassCalc.Instance;
            var records = _calc.Exec(creditAamount, annualInterest, creditTerm, true);

            PrintBody(records);

            System.Console.ReadKey();
        }

        private static decimal ReadDecimal(string message)
        {
            decimal value = 0;
            bool check = false;
            while (!check)
            {
                try
                {
                    System.Console.Write(message);
                    value = Convert.ToDecimal(System.Console.ReadLine());
                    if (value > 0)
                        check = true;
                    else
                        System.Console.Write("Value must be more than 0!");
                }
                catch
                {
                    //
                }
            }
            return value;
        }

        private static void PrintCaption(decimal creditAamount, decimal annualInterest, decimal creditTerm)
        {
            System.Console.WriteLine("+--------+------------+------------+------------+------------+");
            System.Console.WriteLine("| Number |       Pay  |   Percent  |    Credit  |  Remaining |");
            System.Console.WriteLine("+--------+------------+------------+------------+------------+");

        }

        private static void PrintBody(List<ClassRecord> records)
        {
            foreach (var item in records)
            {
                if (item.Number == -1)
                {
                    System.Console.WriteLine(string.Format("|        | {0,9}  | {1,9}  | {2,9}  |            |",
                        string.Format("{0:0.}", item.Pay),
                        string.Format("{0:0.}", item.Percent),
                        string.Format("{0:0.}", item.Credit)));
                    System.Console.WriteLine("+--------+------------+------------+------------+------------+");
                }
                else
                {
                    System.Console.WriteLine(string.Format("|{0,6}  | {1,9}  | {2,9}  | {3,9}  | {4,9}  |",
                        item.Number,
                        string.Format("{0:0.}", item.Pay),
                        string.Format("{0:0.}", item.Percent),
                        string.Format("{0:0.}", item.Credit),
                        string.Format("{0:0.}", item.Remaining)));
                }
            }
            System.Console.WriteLine("+--------+------------+------------+------------+------------+");
        }
    }
}
