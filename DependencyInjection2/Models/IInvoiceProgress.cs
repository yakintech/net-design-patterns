using System;
namespace DependencyInjection2.Models
{
    public interface IInvoiceProgress
    {
        
            void Start();

            void CalcTax();

            void Print();

            void Finish();
        
    }
}

