using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_OOP_Uygulama_Araclar
{
    internal interface IEylemler
    {
        //Eylemler => (Sur, VitesDEgistir(int vites), parkEt => Araba, Otobus, Motorsiklet

        void Sur();
        public void VitesDegistir(int vites);
        public void ParkEt();
    }
}
