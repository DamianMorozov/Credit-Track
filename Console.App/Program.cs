using System;
using LibCredit;

namespace Console.App
{
    class MainClass
    {
        #region Private fields and properties.

        //private ClassCalc _calc = ClassCalc.Instance;

        #endregion

        public static void Main()
        {
            decimal creditAamount = 487_500m;
            decimal annualInterest = 20.70m;
            decimal creditTerm = 48m;
            System.Console.WriteLine("");

            ClassCalc _calc = ClassCalc.Instance;
            _calc.Exec(creditAamount, annualInterest, creditTerm);

            System.Console.ReadKey();
        }
    }
}
