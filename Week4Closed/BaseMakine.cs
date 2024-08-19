using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week4Closed
{
    internal abstract class BaseMakine
    {
        public DateTime UretimTarihi {  get; set; }
        public string SeriNumarasi { get; set; }
        public string Ad { get; set; }
        public string Aciklama { get; set; }
        public string IsletimSistemi { get; set; }
    
        public virtual void BilgileriYazdir()
        {
            Console.WriteLine($"Üretim Tarihi: {UretimTarihi}");
            Console.WriteLine($"Seri Numarası: {SeriNumarasi}");
            Console.WriteLine($"Ad: {Ad}");
            Console.WriteLine($"Açıklama: {Aciklama}");
            Console.WriteLine($"İşletim Sistemi: {IsletimSistemi}");
        }

        public abstract void UrunAdiGetir();
    }
}
