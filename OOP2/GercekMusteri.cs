using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP2
{
    internal class GercekMusteri : Musteri   //Bu "GercekMusteri bir Musteridir" demek. 
    {
        public string TcNo { get; set; }   //Eğer sayısal bir işlem yapmayacaksan sayısal veri tepiyle tutmanın bir anlamı yok.
        public string Adi { get; set; }
        public string Soyadi { get; set; }

    }
}
