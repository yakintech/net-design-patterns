using System;
using System.Reflection;

namespace BuilderPattern.Models
{
    public class Phone
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Brand { get; set; }

        public decimal Price { get; set; }

        public override string ToString()
        {
            return $"{Brand} markalı, ücreti {Price}  olarak üretilmiştir.";
        }
    }
}

