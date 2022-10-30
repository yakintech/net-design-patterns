using System;
namespace ObserverPattern.Model
{
    /// <summary>
    /// ConcreteObserver - Gerçek takip eden nesnemiz.
    /// </summary>
    class CustomerObserver : Observer
    {
        public override void Update()
        {
            Console.WriteLine("Takip ettiğim ürünün stoğu değişti.");
            Console.ReadLine();
        }
    }
}

