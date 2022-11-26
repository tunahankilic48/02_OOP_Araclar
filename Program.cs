/*
Araba, Gemi, Motorsiklet, Otobüs classalarım var.

Hız, renk, AracOzellikleriniGoster, Durdur ortak özellikleri var.

YakitTuru ve kasko => Araba, Otobüs, Gemi

Eylemler => (Sur, VitesDEgistir(int vites), parkEt => Araba, Otobus, Motorsiklet

Araba; ARacOzellikleriniGoster çalıştığında hem base bilgileri gelecek hemde arabanın yakıt türü arabanın kaskosu bilgileri gelecek zorunlu methodlar Consolewriteline ve ilgili bilgilerle doldurulacak

gemi => dumeneGec Limanabagla, Bakımagit, yakıtturu

motorsiklet => Motortipi kasko servisegit parket sur vitesdegistir.

*/

using _02_OOP_Uygulama_Araclar;

Araba araba1 = new Araba();
araba1.Renk = "Metalic Mavi";
//araba1.YakitTuru = (YakitTuru)1;
araba1.YakitTuru = YakitTuru.Benzin;
araba1.Hiz = 150;
araba1.KaskoVarMi = true;

Gemi gemi1 = new Gemi()
{
    Renk = "Beyaz",
    YakitTuru = (YakitTuru)2,
    Hiz = 60,
    KaskoVarMi = false
};

Motorsiklet motorsiklet1 = new Motorsiklet();
motorsiklet1.Renk = "Kırmızı";
motorsiklet1.MotorsikletTipi = (MotorsikletTipi)4;
motorsiklet1.Hiz = 240;
motorsiklet1.KaskoVarMi = true;

Otobus otobus1 = new Otobus();
otobus1.Renk = "Siyah";
otobus1.YakitTuru = (YakitTuru)2;
otobus1.Hiz = 120;
otobus1.KaskoVarMi = false;

