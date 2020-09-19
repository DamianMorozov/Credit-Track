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
            decimal creditAmount, decimal annualInterest, decimal creditTerm, bool useFirstSummary)
        {
            var result = new List<ClassRecord>();
            decimal i = annualInterest / 100 / 12;
            decimal amountCredit = 0;
            decimal remaining = creditAmount - amountCredit;
            decimal amountPay = 0;
            decimal amountPercent = 0;
            
            // Items.
            for (var number = 1; number <= creditTerm; number++)
            {
                var j = (decimal)Math.Pow((double)(1 + i), (double)creditTerm);
                var pay = creditAmount * (i + i/(j - 1));
                amountPay += pay;
                var percent = remaining * i;
                amountPercent += percent;
                var credit = pay - percent;
                amountCredit += credit;
                remaining = creditAmount - amountCredit;
                result.Add(new ClassRecord(number, pay, percent, credit, remaining));
            }

            // Summary.
            if (useFirstSummary)
                return new List<ClassRecord>()
                    { new ClassRecord(null, amountPay, amountPercent, amountCredit, null) }.
                    Union(result).ToList();

            result.Add(new ClassRecord(null, amountPay, amountPercent, amountCredit, null));
            return result;
        }
    }

    public class ClassRecord
    {
        public int? Number { get; }
        public decimal Pay { get; }
        public decimal Percent { get; }
        public decimal Credit { get; }
        public decimal? Remaining { get; }

        public ClassRecord(int? number, decimal pay, decimal percent, decimal credit, decimal? remaining)
        {
            Number = number;
            Pay = pay;
            Percent = percent;
            Credit = credit;
            Remaining = remaining;
        }
    }
}
