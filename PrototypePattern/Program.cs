
using PrototypePattern.Models;

Invoice invoice = new Invoice();
invoice.Name = "Çağatay";
invoice.Surname = "Yıldız";
invoice.Address = "Cihangir";
invoice.Balance = 22;



Invoice invoice2 = (Invoice)invoice.Clone();
invoice2.Balance = 55;


Console.Write("*");
