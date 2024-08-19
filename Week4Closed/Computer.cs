using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week4Closed
{
    internal class Computer : BaseMakine
    {
        public int _usbGirisSayisi;

        public int UsbGirisSayisi
        {
            get { return _usbGirisSayisi; }
            set
            {
                if (value == 2 || value == 4)
                {
                    _usbGirisSayisi = value;
                }
                else
                    _usbGirisSayisi = -1;
            }
        }

        public bool BluettohVarMi { get; set; }

        public Computer()
        {
            UretimTarihi = DateTime.Now;
        }

        public override void BilgileriYazdir()
        {
            base.BilgileriYazdir();
            Console.WriteLine($"Usb giriş soket sayısı: {UsbGirisSayisi}");
            Console.WriteLine($"Bluetooth özelliği: {BluettohVarMi}");
        }

        public override void UrunAdiGetir()
        {
            Console.WriteLine("Bilgisayar adı: "+ Ad);
        }
    }
}
