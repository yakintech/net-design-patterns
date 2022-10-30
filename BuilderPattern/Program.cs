
using BuilderPattern.Models;

IPhoneBuilder phone = new SamsungConcreteBuilder();
CreatePhone createPhone = new CreatePhone();
createPhone.Create(phone);

Console.WriteLine(phone.Phone.ToString());



phone = new HuaweiConcreteBuilder();
createPhone.Create(phone);
Console.WriteLine(phone.Phone.ToString());

Console.Read();