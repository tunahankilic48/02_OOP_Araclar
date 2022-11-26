using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_OOP_Uygulama_Araclar
{
    internal class Gemi : Arac, IYakitTuruveKasko
    {
        // gemi => dumeneGec Limanabagla, Bakımagit, yakıtturu
        public YakitTuru YakitTuru { get; set; }
        public bool KaskoVarMi { get; set; }

        public override void AracOzellikleriniGoster()
        {
            Console.WriteLine($"Hız: {Hiz}\nRenk: {Renk}\nYakıt Türü: {YakitTuru}\nKasko: {(KaskoVarMi ? "Var" : "Yok")}");
        }

        public override void Durdur()
        {
            Console.WriteLine("Gemi Duruyor");
        }
        public void DumeneGec()
        {
            Console.WriteLine("Dümene Geçildi.");
        }
        public void LimanaBagla()
        {
            Console.WriteLine("Gemi Limana Bağlandı");
        }
        public void BakimaGit()
        {
            Console.WriteLine("Gemi Bakıma Götürüldü");
        }

    }
}
