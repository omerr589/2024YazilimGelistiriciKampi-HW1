using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Workaround
{
    internal class Vatandas
    {
        //string ad ;
        //string soyad;

        //int dogumYili = 1998;
        //string tcNo = "12345678910";

        public string Ad { get; set; }
        public string Soyad { get; set; }
        public int DogumYili { get; set; }
        public string TcNo { get; set; }

        public Vatandas(string ad, string soyad, int dogumYili, string tcNo)
        {
            Ad = ad;
            Soyad = soyad;
            DogumYili = dogumYili;
            TcNo = tcNo;
        }

        public Vatandas() { }

        public void BilgileriGetir()
        {
            Console.WriteLine(
                "Adı: " + Ad + "\n" +
                "Soyadı : " + Soyad + "\n" +
                "Doğum Yılı : " + DogumYili + "\n" +
                "TcNo: " + TcNo + "\n"
            );
        }
    }
}
