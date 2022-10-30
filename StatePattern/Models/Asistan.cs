using System;
namespace StatePattern.Models
{
    public class Asistan
    {
        IMode amode;

        public Asistan()
        {
            this.amode = new GunduzMode();
        }

        public void ChangeMode(IMode mode)
        {
            this.amode = mode;
        }

        public void Answer()
        {
            this.amode.Answer();
        }
    }
}

