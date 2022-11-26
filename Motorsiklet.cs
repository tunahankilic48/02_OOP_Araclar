using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_OOP_Uygulama_Araclar
{
    internal class Motorsiklet : Arac, IEylemler
    {
        public MotorsikletTipi MotorsikletTipi { get; set; }
        public bool KaskoVarMi { get; set; }

        public override void AracOzellikleriniGoster()
        {
            Console.WriteLine($"Hız: {Hiz}\nRenk: {Renk}\nMotor Tipi: {MotorsikletTipi}\nKasko: {(KaskoVarMi ? "Var" : "Yok")}");
        }
        public void ServiseGit()
        {
            Console.WriteLine("Servise gidiliyor.");
        }

        public override void Durdur()
        {
            Console.WriteLine("Motorsiklet Duruyor");
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
