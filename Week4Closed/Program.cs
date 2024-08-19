using Week4Closed;

while(true)
{
tercih: Console.WriteLine("Telefon üretmek için 1 Bilgisayar üretmek için 2 sayısını giriniz.");
    int tercih = Convert.ToInt32(Console.ReadLine());

    if (tercih == 1)
    {
        Phone telefon = new Phone();
        Console.WriteLine("Telefon Seri Numarası ? ");
        telefon.SeriNumarasi = Console.ReadLine();

        Console.WriteLine("Telefon Adı ? ");
        telefon.Ad = Console.ReadLine();

        Console.WriteLine("Telefon açıklaması ? ");
        telefon.Aciklama = Console.ReadLine();

        Console.WriteLine("Telefon işletim sistemi ? ");
        telefon.IsletimSistemi = Console.ReadLine();

        Console.WriteLine("Telefonun Tr Lisansı var mı?");
        telefon.TrLisansVarmi = Convert.ToBoolean(Console.ReadLine());

        Console.WriteLine("<----------- Özellikler ------------>");
        Console.WriteLine("Bilgisayar nesneniz aşağıdaki özelikkler ile oluşturulacak.");
        telefon.BilgileriYazdir();
    }
    else if (tercih == 2)
    {
        Computer bilgisayar = new Computer();
        Console.WriteLine("Bilgisayarı Seri Numarası ? ");
        bilgisayar.SeriNumarasi = Console.ReadLine();

        Console.WriteLine("Bilgisayar Adı ? ");
        bilgisayar.Ad = Console.ReadLine();

        Console.WriteLine("Bilgisayarı açıklaması ? ");
        bilgisayar.Aciklama = Console.ReadLine();

        Console.WriteLine("Bilgisayarı işletim sistemi ? ");
        bilgisayar.IsletimSistemi = Console.ReadLine();

        Console.WriteLine("Bilgisayarı usb giriş sayısı ? ");
        bilgisayar.UsbGirisSayisi = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Bilgisayarın bluetooth özelliği var mı ? ");
        bilgisayar.BluettohVarMi = Convert.ToBoolean(Console.ReadLine());

        Console.WriteLine("<----------- Özellikler ------------>");
        Console.WriteLine("Bilgisayar nesneniz aşağıdaki özelikkler ile oluşturulacak.");
        bilgisayar.BilgileriYazdir();
    }
    else
    {
        Console.WriteLine("Yanlış bir sayı giriniz.");
        goto tercih;
    }

tercih2: Console.WriteLine("Yeni bir ürün girmek istiyor musun? (evet/hayır)");

    string yeni = Console.ReadLine();
    if (yeni == "hayır")
    {
        Console.WriteLine("İyi Günler Gardaş");
        break;
    }
    else if (yeni == "evet")
        continue;
    else
        goto tercih2;
}

