namespace Tel_rehber_uyg
{
    public class Eylemler
    {
        private List<Kisiler> kisiler = new List<Kisiler>();

        public Eylemler()
        {
            kisiler.Add(new Kisiler("furkan", "ucar", "0555 555 55 55"));
            kisiler.Add(new Kisiler("kaan", "ucar", "0555 555 55 56"));
            kisiler.Add(new Kisiler("mehmet", "ucar", "0555 555 55 57"));
            kisiler.Add(new Kisiler("nisa", "ucar", "0555 555 55 58"));
            kisiler.Add(new Kisiler("bunyamin", "ucar", "0555 555 55 59"));
        }

        public void Ekle()
        {
            Console.Write("Lutfen Eklenecek Kisinin Adini Giriniz: ");
            string isim = Console.ReadLine() ?? "";
            Console.Write("Lutfen Eklenecek Kisinin Soyadini Giriniz: ");
            string soyisim = Console.ReadLine() ?? "";
            Console.Write("Lutfen Eklenecek Kisinin Numarasini Giriniz: ");
            string numara = Console.ReadLine() ?? "";

            Kisiler newKisi = new Kisiler(isim, soyisim, numara);
            kisiler.Add(newKisi);
            Console.WriteLine(isim + " adli kisi rehbere kaydedildi.");
        }

        public void Sil()
        {
            Console.WriteLine("Lutfen Silmek Istediginiz Kisinin Adini Veya Soyadini Giriniz:");
            string isimveyasoyisimSil = Console.ReadLine() ??"";    
            isimveyasoyisimSil = isimveyasoyisimSil.ToLower();

            bool kisiSilindi = false;
            for (int i = 0; i < kisiler.Count; i++)
            {
                if (kisiler[i].Isim.Equals(isimveyasoyisimSil) || kisiler[i].Soyisim.Equals(isimveyasoyisimSil))
                {
                    Console.WriteLine(kisiler[i].Isim + " adli kisi listeden silinecektir. Onayliyorsaniz (1), Onaylamiyorsaniz (2)");
                    int deger = int.Parse(Console.ReadLine() ?? "");

                    if (deger == 1)
                    {
                        Console.WriteLine(kisiler[i].Isim + " adli kisi rehberden silindi.");
                        kisiler.RemoveAt(i);
                        kisiSilindi = true;
                        break;
                    }
                    else
                    {
                        break;
                    }
                }
            }

            if (!kisiSilindi)
            {
                Console.WriteLine("Aranan kisi rehberde kayitli degildir. Tekrar denemek icin (1). Silme isleminden cikmak icin (2)`ye basiniz.");
                int deger = int.Parse(Console.ReadLine() ?? "");
                if (deger == 1)
                {
                    Sil();
                }
            }
        }

        public void Guncelle()
        {
            Console.WriteLine("Lutfen Kisinin Adini veya Soyadini Giriniz:");
            string isimveyasoyisimGuncelle = Console.ReadLine() ?? "";

            bool kisiGuncellendi = false;
            for (int i = 0; i < kisiler.Count; i++)
            {
                if (kisiler[i].Isim.Equals(isimveyasoyisimGuncelle) || kisiler[i].Soyisim.Equals(isimveyasoyisimGuncelle))
                {
                    Console.WriteLine("(1) Adi Guncelle\n(2) Soyadi Guncelle\n(3) Numarayi Guncelle\n(0) Guncellemekten Vazgec");
                    int deger = int.Parse(Console.ReadLine() ?? "");

                    switch (deger)
                    {
                        case 1:
                            Console.WriteLine("Lutfen Yeni Adi Giriniz:");
                            string yeniIsim = Console.ReadLine() ?? "";
                            kisiler[i].Isim = yeniIsim;
                            Console.WriteLine(kisiler[i].Isim + " olarak guncellendi.");
                            kisiGuncellendi = true;
                            break;
                        case 2:
                            Console.WriteLine("Lutfen Yeni Soyismi Giriniz:");
                            string yeniSoyisim = Console.ReadLine() ?? "";
                            kisiler[i].Soyisim = yeniSoyisim;
                            Console.WriteLine(kisiler[i].Soyisim + " olarak guncellendi.");
                            kisiGuncellendi = true;
                            break;
                        case 3:
                            Console.WriteLine("Lutfen Yeni Numara Giriniz:");
                            string yeniNumara = Console.ReadLine() ?? "";
                            kisiler[i].Numara = yeniNumara;
                            Console.WriteLine(kisiler[i].Numara + " olarak guncellendi.");
                            kisiGuncellendi = true;
                            break;
                        default:
                            break;
                    }

                    break;
                }
            }

            if (!kisiGuncellendi)
            {
                Console.WriteLine("Aranan kisi rehberde kayitli degildir. Tekrar denemek icin (1). Guncelleme isleminden cikmak icin (2)`ye basiniz.");
                int deger = int.Parse(Console.ReadLine() ?? "");
                if (deger == 1)
                {
                    Guncelle();
                }
            }
        }

        public void AzSirala()
        {
            var siralakisi = kisiler.OrderBy(value => value.Isim);
            foreach (var kisi in siralakisi)
            {
                Console.WriteLine("---------------------");
                Console.WriteLine("Kisi Adi         : " + kisi.Isim);
                Console.WriteLine("Kisinin Soyadi   : " + kisi.Soyisim);
                Console.WriteLine("Kisinin Numarasi : " + kisi.Numara);
            }
        }

        public void ZaSirala()
        {
            var siralakisi = kisiler.OrderByDescending(value => value.Isim);
            foreach (var kisi in siralakisi)
            {
                Console.WriteLine("---------------------");
                Console.WriteLine("Kisi Adi         : " + kisi.Isim);
                Console.WriteLine("Kisinin Soyadi   : " + kisi.Soyisim);
                Console.WriteLine("Kisinin Numarasi : " + kisi.Numara);
            }
        }

        public void Arama()
        {
            Console.WriteLine("Lutfen Aramak Istediginiz Kisinin Adini Giriniz:");
            string ara = Console.ReadLine()?.ToLower() ?? "";

            bool kisiBulundu = false;
            foreach (var kisi in kisiler)
            {
                if (kisi.Isim.Equals(ara))
                {
                    Console.WriteLine("--------------------------");
                    Console.WriteLine("Kisinin Adi          : " + kisi.Isim);
                    Console.WriteLine("Kisinin Soyadi       : " + kisi.Soyisim);
                    Console.WriteLine("Kisinin Numarasi     : " + kisi.Numara);
                    kisiBulundu = true;
                }
            }

            if (!kisiBulundu)
            {
                Console.WriteLine("Aranan kisi rehberde kayitli degildir.");
            }
        }
    }
}
