using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week4Closed
{
    internal class Phone : BaseMakine
    {
        public bool TrLisansVarmi { get; set; }
        public Phone() 
        { 
            UretimTarihi=DateTime.Now;
        }

        public override void BilgileriYazdir()
        {
            base.BilgileriYazdir();
            Console.WriteLine($"Tr Lisans: {TrLisansVarmi}");
        }

        public override void UrunAdiGetir()
        {
            Console.WriteLine("Telefon adı: "+Ad);
        }
    }
}
