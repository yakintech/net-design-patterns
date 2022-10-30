
using BuilderPattern.Models;
using BuilderPattern.Models2;

IPhoneBuilder phone = new SamsungConcreteBuilder();


CreatePhone createPhone = new CreatePhone();
createPhone.Create(phone);

Console.WriteLine(phone.Phone.ToString());



phone = new HuaweiConcreteBuilder();
createPhone.Create(phone);
Console.WriteLine(phone.Phone.ToString());

Console.Read();


//PromosyonBuilder promosyon = new AmirlerConcreteBuilder();
//PromosyonGonder gonder = new PromosyonGonder();
//gonder.Gonder(promosyon);
//promosyon.Promosyon.ToString();

//promosyon = new KadinlarConcreteBuilder();
//gonder.Gonder(promosyon);
//promosyon.Promosyon.ToString();

//Console.Read();