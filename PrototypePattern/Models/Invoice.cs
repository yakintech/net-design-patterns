using System;
namespace PrototypePattern.Models
{
    public class Invoice : ICloneable
    {
        public string Name { get; set; }

        public string Surname { get; set; }

        public string Address { get; set; }

        public decimal Balance { get; set; }

        public object Clone()
        {
            return this.MemberwiseClone();
        }
    }

}

