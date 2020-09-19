using System;
using System.Collections.Generic;
using LibCredit;

namespace Console.App
{
    internal static class MainClass
    {
        public static void Main()
        {
            var creditAmount = ReadDecimal("Credit amount, currency: ");
            var annualInterest = ReadDecimal("Annual interest, percents: ");
            var creditTerm = ReadDecimal("Credit term, months: ");

            PrintCaption();

            ClassCalc _calc = ClassCalc.Instance;
            var records = _calc.Exec(creditAmount, annualInterest, creditTerm, true);

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

        private static void PrintCaption()
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
                    System.Console.WriteLine(
                        $"|        | {$"{item.Pay:0.}",9}  | {$"{item.Percent:0.}",9}  | {$"{item.Credit:0.}",9}  |            |");
                    System.Console.WriteLine("+--------+------------+------------+------------+------------+");
                }
                else
                {
                    System.Console.WriteLine(
                        $"|{item.Number,6}  | {$"{item.Pay:0.}",9}  | {$"{item.Percent:0.}",9}  | {$"{item.Credit:0.}",9}  | {$"{item.Remaining:0.}",9}  |");
                }
            }
            System.Console.WriteLine("+--------+------------+------------+------------+------------+");
        }
    }
}
