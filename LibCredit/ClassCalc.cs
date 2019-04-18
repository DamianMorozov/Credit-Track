using System;
namespace LibCredit
{
    public class ClassCalc
    {
        private static readonly Lazy<ClassCalc> _instance = new Lazy<ClassCalc>(() => new ClassCalc());

        public static ClassCalc Instance { get { return _instance.Value; } }

        private ClassCalc()
        {
        }

        public void Exec(decimal creditAamount, decimal annualInterest, decimal creditTerm)
        {
            System.Console.WriteLine("Credit amount: " + creditAamount.ToString());
            System.Console.WriteLine("Annual interest: " + annualInterest.ToString());
            System.Console.WriteLine("Credit term: " + creditTerm.ToString());

            System.Console.WriteLine("+--------+------------+------------+------------+------------+");
            System.Console.WriteLine("| Number |       Pay  |   Percent  |    Credit  |  Remaining |");
            System.Console.WriteLine("+--------+------------+------------+------------+------------+");

            decimal i = annualInterest / 100 / 12;
            decimal j = 0;
            decimal pay = 0;
            decimal percent = 0;
            decimal credit = 0;
            decimal amountCredit = 0;
            decimal remaining = creditAamount - amountCredit;
            decimal amountPay = 0;
            decimal amountPercent = 0;
            for (int number = 1; number <= creditTerm; number++)
            {
                j = (decimal)Math.Pow((double)(1 + i), (double)creditTerm);

                pay = creditAamount * (i + (i / (j - 1)));
                amountPay += pay;

                percent = remaining * i;
                amountPercent += percent;

                credit = pay - percent;
                amountCredit += credit;

                remaining = creditAamount - amountCredit;

                System.Console.WriteLine(string.Format("|{0,6}  | {1,9}  | {2,9}  | {3,9}  | {4,9}  |",
                    number, 
                    string.Format("{0:0.}", pay),
                    string.Format("{0:0.}", percent),
                    string.Format("{0:0.}", credit),
                    string.Format("{0:0.}", remaining)));
            }
            System.Console.WriteLine("+--------+------------+------------+------------+------------+");
            System.Console.WriteLine(string.Format("|        | {0,9}  | {1,9}  | {2,9}  |            |",

                string.Format("{0:0.}", amountPay),
                string.Format("{0:0.}", amountPercent),
                string.Format("{0:0.}", amountCredit)));
            System.Console.WriteLine("+--------+------------+------------+------------+------------+");
        }
    }
}
