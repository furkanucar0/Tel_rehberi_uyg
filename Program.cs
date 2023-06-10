namespace Tel_rehber_uyg;

public class program
{
    public static void Main(string[] args)
    {
        Eylemler allactions = new Eylemler();

        Boolean status = true;
        while (status)
        {
            Console.WriteLine("Telefon Rehberine Hoşgelidiniz\n\n\n" +
                "1-Telefon numarasi kaydet\n" +
                "2-Telefon numarasi sil\n" +
                "3-Telefon numarasi güncelle\n" +
                "4-A-Z Sirali şekilde kayitli numaralari göster\n" +
                "5-Z-A Sirali şekilde kayitli numaralari göster\n" +
                "6-Rehberde arama\n" +
                "0-Çikiş");
            int giris = int.Parse(Console.ReadLine() ?? "");

            switch(giris)
            {
                case 1:
                    allactions.Ekle();
                    break;

                case 2:
                    allactions.Sil();
                    break;

                case 3:
                    allactions.Guncelle();
                    break;

                case 4:
                    allactions.AzSirala();
                    break;
                    
                case 5:
                    allactions.ZaSirala();
                    break;

                case 6:
                    allactions.Arama();
                    break;
                case 0:
                    status = false;
                    break;
            }

            Console.ReadKey();

        }
    }
}