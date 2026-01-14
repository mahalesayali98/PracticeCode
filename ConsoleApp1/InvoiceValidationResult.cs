using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class InvoiceValidationResult
    {
        public List<decimal> ValidInvoices { get; set; }
        public List<decimal> InValidInvoices { get; set; }

        public int TotalCount { get; set; }

        public InvoiceValidationResult()
        {
            ValidInvoices = new List<decimal>();
            InValidInvoices = new List<decimal>();
        }

    }
}
