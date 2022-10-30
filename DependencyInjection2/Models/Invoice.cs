using System;
namespace DependencyInjection2.Models
{
    public class Invoice
    {
        IInvoiceProgress _invoiceProgress;

        public Invoice(IInvoiceProgress invoiceProgress)
        {
            _invoiceProgress = invoiceProgress;
        }

        public void Init()
        {
            _invoiceProgress.Start();
            _invoiceProgress.CalcTax();
            _invoiceProgress.Print();
            _invoiceProgress.Finish();

          
        }
    }
}

