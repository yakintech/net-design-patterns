using StatePattern.Models;

Asistan asistan = new Asistan();

asistan.Answer();

asistan.ChangeMode(new GeceMode());

asistan.Answer();

Console.ReadKey();