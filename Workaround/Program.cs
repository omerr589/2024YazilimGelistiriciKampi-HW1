using System;
using Workaround;
using Business.Concrete;
using Entities.Concrete;

public class Program
{
    private static void Main(string[] args)
    {
        Vatandas vatandas1 = new Vatandas();
        Vatandas vatandas2 = new Vatandas("Ömer Faruk", "Yılmaz", 1998, "12345678910");

        vatandas1.Ad = "İsim1";
        vatandas1.Soyad = "soyisim1";
        vatandas1.DogumYili = 1999;
        vatandas1.TcNo = "12345678910";

        vatandas1.BilgileriGetir();
        vatandas2.BilgileriGetir();

        // Diziler

        string[] ogrenciler = new string[3];

        ogrenciler[0] = "Ömer";
        ogrenciler[0] = "Faruk";
        ogrenciler[0] = "Yılmaz";

        foreach (string s in ogrenciler)
        {
            Console.WriteLine(s);
        }

        string[] sehirler1 = new[] { "Ankara", "İstanbul", "İzmir" };
        string[] sehirler2 = new[] { "Bursa", "Antalya", "Amasya" };

        sehirler2 = sehirler1;
        sehirler1[0] = "Adana";

        Console.WriteLine(sehirler2[0]);


        List<string> yeniSehirler1 = new List<string> { "İstanbul_", "Ankara_", "Sivas_" };
        yeniSehirler1.Add("Adana_");

        /* Array'a yeni Eleman Ekleme */
        string[] Temp = new string[sehirler1.Length + 1];
        sehirler1.CopyTo(Temp, 0);
        Temp[sehirler1.Length] = "YeniEklenen";
        sehirler1 = Temp;

        Console.WriteLine("/ÖDEV1/");


        foreach (string s in sehirler1)
        {
            Console.WriteLine(s);
        }

        Person person1 = new Person();

        person1.FirstName = "Ömer Faruk";
        person1.LastName = "Yılmaz";
        person1.DateOfBirthYear = 1998;
        person1.NationalIdentity = 12345678910;


        PttManager pttManager = new PttManager(new PersonManager());

        pttManager.GiveMask(person1);


        Console.ReadLine();
    }
}