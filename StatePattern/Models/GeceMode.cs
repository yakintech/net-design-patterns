using System;
namespace StatePattern.Models
{
    class GeceMode : IMode
    {
        public void Answer()
        {
            System.Console.WriteLine("Şu an görüşmeye kapalı");
        }
    }
}

