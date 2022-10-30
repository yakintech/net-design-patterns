using System;
namespace ObserverPattern.Model
{
    /// <summary>
    /// Observer - Soyut sınıfımız.
    /// Soyutlamamızın nedeni ise birden fazla sınıf tarafındanda takip edilmesini sağlamak.
    /// </summary>
    public abstract class Observer
    {
        // Herhangi bir değişimde gözlemleyiciler tarafından yapılması istenilen aksiyonlar.
        public abstract void Update();
    }
}

