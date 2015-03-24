using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Accumulation
{
    class Program
    {
        // Determine how much money is in an account after 1, 2, 5 & 10 years if $35.00 is deposited daily

        static void Main(string[] args)
        {

            var accountBalance = 0.00M;
            var deposit = 35.00M;

            // Start at Jan 1 2015
            DateTime startDate = new DateTime(2015, 1, 1);
            DateTime currentDate = startDate.AddDays(-1);

            // define the end of year dates
            DateTime endDate1 = new DateTime(2015,12,31);
            DateTime endDate2 = new DateTime(2016, 12,31);
            DateTime endDate3 = new DateTime(2017, 12, 31);
            DateTime endDate4 = new DateTime(2019, 12, 31);
            DateTime endDate5 = new DateTime(2024, 12, 31);

            // var totalDays = (endDate5 - currentDate).TotalDays;
            //for (DateTime i = startDate; i <  endDate1;  i.AddDays(1))
            //{
            //    accountBalance += deposit;
            //}
            //Console.WriteLine("Account Balance after 1 Year: " + accountBalance);

            while (currentDate < endDate1 )
            {
                accountBalance += deposit;
                currentDate = currentDate.AddDays(1);                
            }

            Console.WriteLine("Account Balance at " + currentDate.ToShortDateString() + ": " + String.Format("{0:C}", accountBalance));

            while (currentDate < endDate2)
            {
                accountBalance += deposit;
                currentDate = currentDate.AddDays(1);
            }

            Console.WriteLine("Account Balance at " + currentDate.ToShortDateString() + ": " + String.Format("{0:C}", accountBalance));

            while (currentDate < endDate3)
            {
                accountBalance += deposit;
                currentDate = currentDate.AddDays(1);
            }

            Console.WriteLine("Account Balance at " + currentDate.ToShortDateString() + ": " + String.Format("{0:C}", accountBalance));

            while (currentDate < endDate4)
            {
                accountBalance += deposit;
                currentDate = currentDate.AddDays(1);
            }

            Console.WriteLine("Account Balance at " + currentDate.ToShortDateString() + ": " + String.Format("{0:C}", accountBalance));

            while (currentDate < endDate5)
            {
                accountBalance += deposit;
                currentDate = currentDate.AddDays(1);
            }

            Console.WriteLine("Account Balance at " + currentDate.ToShortDateString() + ": " + String.Format("{0:C}", accountBalance));



            // do simple calc

            // one year is 365 days

            //accountBalance += deposit * 365;
            //Console.WriteLine("Account Balance after 1 Year: " + accountBalance);

            //accountBalance += deposit * 365;
            //Console.WriteLine("Account Balance after 2 Years: " + accountBalance);

            //accountBalance += deposit * 365 * 3;
            //Console.WriteLine("Account Balance after 5 Years: " + accountBalance);

            //accountBalance += deposit * 365 * 5;
            //Console.WriteLine("Account Balance after 10 Years: " + accountBalance);

            Console.ReadLine();
        }
    }
}
