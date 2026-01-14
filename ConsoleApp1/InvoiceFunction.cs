using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class InvoiceFunction
    {
        public InvoiceValidationResult ValidateInvoices(List<decimal>InvoiceAmounts)

        {
            //CASE 1: Checking InvoiceAmount NUll
            if (InvoiceAmounts == null)
                throw new ArgumentNullException(nameof(InvoiceAmounts));

            // Getting total count
            InvoiceValidationResult result = new InvoiceValidationResult
            {
                TotalCount = InvoiceAmounts.Count
            };
            //CASE 2: IF No invoice will return empty list
            if(!InvoiceAmounts.Any())
            {
                return result;
            }
            //
            HashSet<decimal> DuplicateAmount = InvoiceAmounts.GroupBy(x => x) //Group by invoice amount
                                              .Where(g => g.Count() > 1) // filtered groups having duplicates
                                              .Select(g => g.Key) // extract duplicates
                                              .ToHashSet();  //use hashset for 0(1)  lookup

            foreach (decimal amount in InvoiceAmounts)
            {
                if (amount > 0 && amount < 1_000_000 && !DuplicateAmount.Contains(amount))
                {
                    result.ValidInvoices.Add(amount);
                }
                {
                    result.InValidInvoices.Add(amount);
                }
            }
            //foreach (decimal output in result.ValidInvoices)
            //{
            //    Console.WriteLine(output);

            //}
            Console.WriteLine("Valid Invoices");
            Console.WriteLine(string.Join(" ", result.ValidInvoices));
            return result;
        }
    }
}
