using Emlakci;
using EmlakciLib;
using System.Security.Cryptography;

namespace Emlakci
{
    internal class Program
    {
        static void Main(string[] args)
        {

            KiralikEv ke = new KiralikEv(500, 600, 3, "Kiralik Ev", 100, 80);
            KiralikEv ke1 = new KiralikEv(800, 900, 2, "Kiralik Ev", 120, 90);
            KiralikEv ke2 = new KiralikEv(10000, 10000, 4, "Kiralik Ev", 200, 100);


            var se = new SatilikEv(400, 3, "Satılık Ev", 110, 60);
            var se1 = new SatilikEv(700, 2, "Satılık Ev", 120, 70);
            var se2 = new SatilikEv(900, 4, "Satılık Ev", 140, 80);

            Ev[] evler = { ke, ke1, ke2, se, se1, se2 };

            for (int i = 0; i < evler.Length; i++)
            {
                //if (evler[i] is SatilikEv)
                //{
                //    SatilikEv sev = (SatilikEv)evler[i];
                //    Console.WriteLine(sev.EvBilgileri());
                //}
                //else
                //{
                //    KiralikEv kev = (KiralikEv)evler[i];
                //    Console.WriteLine(kev.EvBilgileri());
                //}
                Console.WriteLine(evler[i].EvinBilgileri());
                Console.WriteLine(evler[i].Bilgiler());
                Console.WriteLine("------------------");
            }







            //Ev evim = new Ev();
            //evim.alan = 100;
            //evim.semt = "Gazi";
            //evim.katno = 2;
            //evim.odasayisi = 3;


            //string bilgi = evim.EvinBilgileri();
            //Console.WriteLine(bilgi);


            //var evim2 = new Ev {alan= 150, katno= 2, odasayisi= 3, semt= "Çayyolu"};


            //Console.WriteLine(evim2.EvinBilgileri());

            //var evim3 = new Ev(3,2,100);
            //Console.WriteLine(evim3.EvinBilgileri());

            //Console.WriteLine($"Belleteki ev sayısı: {Ev.sayac} ");

            //var evim = new Ev();


            //evim.Semt = "Çayyolu";
            //Console.WriteLine($" Evin konumu :" + " " + evim.Semt);

            //evim.Alan = 100;
            //Console.WriteLine($"Evin Alanı :" + " " + evim.Alan);

            //evim.SetOdaSayisi(3);
            //Console.WriteLine($"Evin Oda Sayısı :" + " " + evim.Odasayisi);






            //Ev evim = new Ev();
            //Console.Write("Oda sayısını giriniz :" + " " + evim.Odasayisi);
            //evim.Odasayisi = int.Parse(Console.ReadLine());
            //Console.Write("Kat no :" + " " + evim.Odasayisi);
            //evim.Katno1 = int.Parse(Console.ReadLine());
            //Console.Write("Alan :" + " " + evim.Katno1);
            //evim.Alan1 = int.Parse(Console.ReadLine());


            //try
            //{
            //    Console.Write("Semt :" + " ");
            //    evim.SetSemt(Console.ReadLine());
            //}
            //catch (FormatException ex)
            //{
            //    Console.WriteLine($"Hatalı giriş yaptınız.");
            //    Console.WriteLine($"Hata mesajı: {ex.Message}");
            //}

            //Console.WriteLine(evim.Buyukluk);

            //Console.WriteLine(evim.EvinBilgileri());
            //Console.ReadLine();
            //int sayi = 5;//set
            //Console.WriteLine(sayi);//get
            //



        }
    }
}



//Ev evim = new Ev(); 
//Ev classından nesne türetildi
//evim: Referans. Nesnelerin bellekteki adresini tutarlar.
//Ev : Class. Classlar aynı zamanda bir veri tipidir.
//new: Bellekte nesne oluşturmaya yarayan anahtar sözcük.
//Nesne: new anahtar sözcüğü ile HEAP bölgesinde oluşturulurlar.

//Erişim Belirleyiciler (Access Modifiers)
//private : Sadece tanımlandığı sınıf içerisinde erişilebilir.
//public : Class içinde tanımlanan üyeye her yerden erişim imkanı sağlar

//DRY (Don't Repeat Yourself): Kendini tekrar etme. Kod tekrarını önlemek için kullanılan bir prensiptir.

//Kapsüllemek (Encapsulation) İlkesi: Class içerisinde yapılan işlerin, class dışında gizlenmesidir. Örn: odasayisi field'ına değer atama işlemi yapmak için öncelikle fied private yapıldı, ardından SetOdaSayisi(int odasayisi) metodu yazıldı. Bu metod içinde gelen değerin mutlak değeri alınarak odasayisi fieldına aktarıldı ve bu işlemden bu metodu kullananların bilgisi olmadı.  