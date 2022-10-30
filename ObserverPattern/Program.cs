using ObserverPattern.Model;

Product product = new Product();

// İlgili gözlemleyicimizi product nesnemize ekliyoruz ki değişim sonrasında notify edebilelim.
product.Attach(new CustomerObserver());

// Ürün stoğunu değiştiriyoruz.
product.ChangeStock();


Console.Read();