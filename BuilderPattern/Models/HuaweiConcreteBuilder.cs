using System;
using System.Numerics;

namespace BuilderPattern.Models
{
    public class HuaweiConcreteBuilder : IPhoneBuilder
    {
        public HuaweiConcreteBuilder()
        {
            phone = new Phone();
        }

        public override void SetBrand()
        {
            phone.Brand = "Huawei";
        }

        public override void SetId()
        {
            phone.Id = 2;
        }

        public override void SetName()
        {
            phone.Name = "Huawei B1";
        }

        public override void SetPrice()
        {
            phone.Price = 3300;
        }
    }
}

