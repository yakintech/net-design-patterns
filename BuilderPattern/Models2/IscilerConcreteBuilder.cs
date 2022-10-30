using System;
namespace BuilderPattern.Models2
{
    class IscilerConcreteBuilder : PromosyonBuilder
    {
        public IscilerConcreteBuilder()
        {
            promosyon = new Promosyon();
        }
        public override void SetCalisanProfili() => promosyon.CalisanProfili = "İşçiler";
        public override void SetPromosyonNumarasi() => promosyon.PromosyonNumarasi = 270;
        public override void SetUrunAdi() => promosyon.UrunAdi = "Ceket";
    }
}

