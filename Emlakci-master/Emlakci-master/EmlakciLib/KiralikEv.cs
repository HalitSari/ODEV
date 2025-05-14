using System;
using System.Collections.Generic;
using System.Text;

namespace EmlakciLib
{
    public class KiralikEv : Ev
    {
        public KiralikEv()
        {

        }

        public KiralikEv(int odasayisi, int katno, double alan, string semt)
        {
            Odasayisi = odasayisi;
            Katno = katno;
            Alan = alan;
            Semt = semt;
        }

        public KiralikEv(double kira, double depozito, int odasayisi, string semt, int katno, double alan) : this(odasayisi, katno, alan, semt)
        {
            this.Kira = kira;
            this.Depozito = depozito;
        }

        public double Kira { get; set; }
        public double Depozito { get; set; }

        //public new string EvBilgileri()
        //{
        //    return $"{base.EvBilgileri()}\nKira:{this.Kira}\nDepozito:{this.Depozito}";
        //}

        public override string Bilgiler()
        {
            return $"Kira:{this.Kira}\nDepozito:{this.Depozito}";

        }
    }
}
//internal: Yalnızca aynı namespace içindeki classlar tarafından erişilebilir.
//virtual: Override edilmesi gereken üyeler, virtual anahtar kelimesi ile tanımlanır.
//Polymorphisim(Çok biçimlilik): base classta virtual olarak tanımlanan üyeler, türeyen classlarda override edilerek farklı biçimlerde kullanılabilir.

//Constructor-Yapıcı Metod-Kurucu Metod
//Görevi: Bir classtan nesne türetilirken çalışır ve class içindeki fieldlara varsayılan değer atamalarını yapar.
//Her classta mutlaka vardır. Varsayılan olarak parametre almazlar. bu constructorlara default constructor da denir.
//İsimleri class adı ile aynıdır. Farklı isimle tanımlamazlar.
//Geri dönüş tipleri yoktur.
//Classlardan nesne türetildilğinde çalışan ilk metoddur.
//ctor code snippeti ile default constructor oluşturulabilir. ctor+tab

//Bir class içinde static olarak tanımlanan üyelere, class ismi ile erişilir ve bu üyeler program çalıştığı sürece bellekte tutulurlar. Nesnelerden bağımsız, class'a ait yapılar.

//Kapsülleme (Encapsulation) İlkesi: Class içerisinde yapılan işlerin, class dışından gizlenmesidir. Örn: odasayisi field'ına değer atama işlemi yapmak için öncelikle field private yapıldı, sonrasında bu fielda erişebilen public SetOdaSayisi(int odasayisi) metodu yazıldı. Bu metod içinde gelen değerin mutlak değeri alınarak odasayisi fieldına aktarıldı ve bu işlemden bu metodu kullananların bilgisi olmadı.
