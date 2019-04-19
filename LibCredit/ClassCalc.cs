﻿using System;
using System.Collections.Generic;

namespace LibCredit
{
    public class ClassCalc
    {
        private static readonly Lazy<ClassCalc> _instance = new Lazy<ClassCalc>(() => new ClassCalc());

        public static ClassCalc Instance { get { return _instance.Value; } }

        private ClassCalc()
        {
        }

        public List<(int, decimal, decimal, decimal, decimal)> Exec(
            decimal creditAamount, decimal annualInterest, decimal creditTerm)
        {
            var result = new List<(int, decimal, decimal, decimal, decimal)>();
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
                result.Add((number, pay, percent, credit, remaining));
            }
            result.Add((-1, amountPay, amountPercent, amountCredit, -1));
            return result;
        }
    }
}