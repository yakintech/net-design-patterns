using System;
namespace BuilderPattern.Models
{
    public abstract class IPhoneBuilder
    {

        protected Phone phone;
        public Phone Phone
        {
            get { return phone; }
        }

        public abstract void SetPrice();
       public abstract void SetBrand();
       public abstract void SetId();
        public abstract void SetName();


    }
}

