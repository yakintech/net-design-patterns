using System;
namespace StatePattern.Models
{
    class AwayMode : IMode
    {
        public void Answer()
        {
            System.Console.WriteLine("Sizin için geri döndüm nasıl yardımcı?");
        }
    }
}

