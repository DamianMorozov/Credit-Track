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
            var records = _calc.Exec(creditAamount, annualInterest, creditTerm);

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

        private static void PrintBody(List<(int, decimal, decimal, decimal, decimal)> records)
        {
            System.Console.WriteLine(string.Format("|        | {0,9}  | {1,9}  | {2,9}  |            |",
                string.Format("{0:0.}", records[records.Count - 1].Item2),
                string.Format("{0:0.}", records[records.Count - 1].Item3),
                string.Format("{0:0.}", records[records.Count - 1].Item4)));
            System.Console.WriteLine("+--------+------------+------------+------------+------------+");
            foreach (var item in records)
            {
                if (item.Item1 > 0 && item.Item5 > 0)
                {
                    System.Console.WriteLine(string.Format("|{0,6}  | {1,9}  | {2,9}  | {3,9}  | {4,9}  |",
                        item.Item1,
                        string.Format("{0:0.}", item.Item2),
                        string.Format("{0:0.}", item.Item3),
                        string.Format("{0:0.}", item.Item4),
                        string.Format("{0:0.}", item.Item5)));
                }
            }
            System.Console.WriteLine("+--------+------------+------------+------------+------------+");
        }
    }
}
