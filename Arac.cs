using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_OOP_Uygulama_Araclar
{

    internal abstract class Arac
    {
        public double Hiz { get; set; }
        public string Renk { get; set; }

        public virtual void AracOzellikleriniGoster()
        {
            Console.WriteLine($"Hız: {Hiz}\nRenk: {Renk}");
        }
        public abstract void Durdur();

    }
}
