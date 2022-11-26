using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_OOP_Uygulama_Araclar
{
    internal class Araba : Arac, IYakitTuruveKasko, IEylemler
    {
        public YakitTuru YakitTuru { get; set; }
        public bool KaskoVarMi { get; set; }

        public override void AracOzellikleriniGoster()
        {
            base.AracOzellikleriniGoster();
            Console.WriteLine($"Yakıt Türü: {YakitTuru}\nKasko: {(KaskoVarMi ? "Var" : "Yok")}");
        }

        public override void Durdur()
        {
            Console.WriteLine("Araba Duruyor");
        }

        public void Sur()
        {
            Console.WriteLine("Sürüş başladı");
        }
        public void VitesDegistir(int vites)
        {
            Console.WriteLine($"İstenilen vitese ({vites}) geçildi");
        }
        public void ParkEt()
        {
            Console.WriteLine("Park Edildi.");
        }


    }
}
