using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enum_Degisken_
{

    // enum'ı tanımlarken hangi tipte değer taşıyacağını söyleyebilirsiniz. Biz bu örnekte byte tipini tercih ettik
    // enum tipine değerde atayabilirsiniz. Örneğin pazartesi gününe 10 değerini verdik.

    // pazartesinden sonraki günler 11,12 şeklinde gidecektir.


    // Enum tipine string değer verilemez.


    // Perşembe gününe 10 değeri verdim Cuma 11 değerini alacaktır
    // Pazartesi 0 değerini alacaktır
    public enum Gunler:byte
    {
        Pazartesi,
        Salı,
        Çarşamba,
        Perşembe=10,
        Cuma,
        Cumartesi,
        Pazar


    }

    // Siyah'ın değeri 41 yeşil'in değeri 42 olacaktır.
    public enum Renkler : byte
    {

        Kırmızı = 10,
        Mavi=20,
        Sarı=30,
        Beyaz =40,
        Siyah,
        Yeşil

    }
}
