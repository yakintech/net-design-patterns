using SingletonPattern;

DBHelper helper1 = DBHelper.CreateDbHelper("con 1");
helper1.StateMessage = "deneme";

DBHelper helper2 = DBHelper.CreateDbHelper("con 2");

Console.WriteLine(helper2.StateMessage);
Console.ReadKey();