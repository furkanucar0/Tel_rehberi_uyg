
namespace Tel_rehber_uyg
{
public class Kisiler
{
public string Isim { get; set; }
public string Soyisim { get; set; }
public string Numara { get; set; }

    public Kisiler(string isim, string soyisim, string numara)
    {
        Isim = isim;
        Soyisim = soyisim;
        Numara = numara;
    }
}
}