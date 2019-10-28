using System;
using System.Collections.Generic;
using System.Linq;

namespace LibCredit
{
    public class ClassCalc
    {
        #region Design pattern "Singleton".

        private static readonly Lazy<ClassCalc> _instance = new Lazy<ClassCalc>(() => new ClassCalc());

        public static ClassCalc Instance => _instance.Value;

        private ClassCalc()
        {
            //
        }

        #endregion

        public List<ClassRecord> Exec(
            decimal creditAamount, decimal annualInterest, decimal creditTerm, bool useFirstSummary)
        {
            var result = new List<ClassRecord>();
            decimal i = annualInterest / 100 / 12;
            decimal amountCredit = 0;
            decimal remaining = creditAamount - amountCredit;
            decimal amountPay = 0;
            decimal amountPercent = 0;
            
            // Items.
            for (int number = 1; number <= creditTerm; number++)
            {
                var j = (decimal)Math.Pow((double)(1 + i), (double)creditTerm);
                var pay = creditAamount * (i + i/(j - 1));
                amountPay += pay;
                var percent = remaining * i;
                amountPercent += percent;
                var credit = pay - percent;
                amountCredit += credit;
                remaining = creditAamount - amountCredit;
                result.Add(new ClassRecord(number, pay, percent, credit, remaining));
            }

            // Summary.
            if (useFirstSummary)
                return new List<ClassRecord>()
                    { new ClassRecord(-1, amountPay, amountPercent, amountCredit, -1) }.
                    Union(result).ToList();

            result.Add((new ClassRecord(-1, amountPay, amountPercent, amountCredit, -1)));
            return result;
        }
    }

    public class ClassRecord
    {
        public int Number { get; set; }
        public decimal Pay { get; set; }
        public decimal Percent { get; set; }
        public decimal Credit { get; set; }
        public decimal Remaining { get; set; }

        public ClassRecord(int number, decimal pay, decimal percent, decimal credit, decimal remaining)
        {
            Number = number;
            Pay = pay;
            Percent = percent;
            Credit = credit;
            Remaining = remaining;
        }
    }
}
