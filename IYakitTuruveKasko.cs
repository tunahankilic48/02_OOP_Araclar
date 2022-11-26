using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_OOP_Uygulama_Araclar
{
    internal interface IYakitTuruveKasko
    {
        public YakitTuru YakitTuru { get; set; }
        public bool KaskoVarMi { get; set; }

    }
}
