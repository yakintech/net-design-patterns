using System;
namespace BuilderPattern.Models2
{
    class PromosyonGonder
    {
        public void Gonder(PromosyonBuilder builder)
        {
            builder.SetCalisanProfili();
            builder.SetPromosyonNumarasi();
            builder.SetUrunAdi();
        }
    }
}

