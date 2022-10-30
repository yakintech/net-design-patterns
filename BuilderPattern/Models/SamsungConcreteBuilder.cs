using System;
namespace BuilderPattern.Models
{
    public class SamsungConcreteBuilder : IPhoneBuilder
    {

        public SamsungConcreteBuilder()
        {
            phone = new Phone();
        }

        public override void SetBrand()
        {
            phone.Brand = "Samsung";
        }

        public override void SetId()
        {
            phone.Id = 1;
        }

        public override void SetName()
        {
            phone.Name = "S3";
        }

        public override void SetPrice()
        {
            phone.Price = 2200;
        }
    }
}

