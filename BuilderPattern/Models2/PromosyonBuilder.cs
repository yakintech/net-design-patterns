using System;
namespace BuilderPattern.Models2
{
    abstract class PromosyonBuilder
    {
        protected Promosyon promosyon;
        public Promosyon Promosyon
        {
            get
            {
                return promosyon;
            }
        }
        public abstract void SetUrunAdi();
        public abstract void SetPromosyonNumarasi();
        public abstract void SetCalisanProfili();
    }
}

