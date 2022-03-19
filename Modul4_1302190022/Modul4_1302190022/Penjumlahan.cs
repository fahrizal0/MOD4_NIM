using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul4_1302190022
{
    internal class Penjumlahan<T>
    {
        public dynamic JumlahTigaAngka(T angka1, T angka2, T angka3)
        {
            dynamic hasil = Convert.ToInt16(angka1) + Convert.ToInt16(angka2) + Convert.ToInt16(angka3);
            return hasil;
        }
    }
}
