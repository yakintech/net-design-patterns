using System;
namespace BuilderPattern.Models
{
    public class CreatePhone
    {
        public void Create(IPhoneBuilder phone)
        {
            phone.SetId();
            phone.SetName();
            phone.SetPrice();
            phone.SetBrand();
        }
    }
}

