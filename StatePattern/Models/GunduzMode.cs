using System;
namespace StatePattern.Models
{
    class GunduzMode : IMode
    {
        public void Answer()
        {
            System.Console.WriteLine("Şu an görüşmeye açık");
        }
    }
}

