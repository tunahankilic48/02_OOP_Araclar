using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_OOP_Uygulama_Araclar
{
    internal class Otobus : Arac, IYakitTuruveKasko, IEylemler
    {
        public YakitTuru YakitTuru { get; set; }
        public bool KaskoVarMi { get; set; }

        public override void AracOzellikleriniGoster()
        {
            Console.WriteLine($"Hız: {Hiz}\nRenk: {Renk}\nYakıt Türü: {YakitTuru}\nKasko: {(KaskoVarMi ? "Var" : "Yok")}");
        }

        public override void Durdur()
        {
            Console.WriteLine("Otobüs Duruyor");
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
