using System;
namespace BuilderPattern.Models2
{
    class AmirlerConcreteBuilder : PromosyonBuilder
    {
        public AmirlerConcreteBuilder()
        {
            promosyon = new Promosyon();
        }
        public override void SetCalisanProfili() => promosyon.CalisanProfili = "Amirler";
        public override void SetPromosyonNumarasi() => promosyon.PromosyonNumarasi = 100;
        public override void SetUrunAdi() => promosyon.UrunAdi = "Job";
    }
}

