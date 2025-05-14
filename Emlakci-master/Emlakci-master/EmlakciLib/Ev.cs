using System;
using System.Security.Cryptography.X509Certificates;

namespace EmlakciLib
{


    public abstract class Ev
    {
        public string EvinBilgileri()
        {
            return $"Oda Sayısı:{this.Odasayisi}\nKat no :{this.Katno}\nAlan:{this.Alan}\nSemt:{this.Semt}\nEv Büyüklüğü:{this.Buyukluk}\n";
        }
        public abstract string Bilgiler();
        private string semt;
        public string Semt { get; set; }
        private int odasayisi;
        public int Odasayisi { get; set; }
        private int katno;
        public int Katno { get; set; }
        public string Buyukluk { get; private set; }
        private double alan;
        public double Alan { get; set; }
    }
}   
        
    

//Constructor-yapıcı metodlar
//Görevi: Bir class içindeki nesne türetilirken çalışır ve class içindeki fieldlara varsayılarak değer atamak için kullanılır.
//Her classta mutlaka vardır. Varsayılan olarak parametre almazlar. Bu constructorlara default constructor da denir.
//İsimleri classa dı ile aynıdır. Farklı isimle tanımlamazlar
//Geri dönüş tipleri yoktur
//Classlardan nesne türetildiğinde çalışan ilk metoddur
//ctor code snippeti ile default constructor oluşturuabilir.

//Bir class içinde static olarak tanımlanan üyelere, class ismi ile erişilir ve bu üyeler prohram çalıştığı sürece bellekte tutulurlar. Nesnelerden bağımsız, class'a ait yapılardır.
  //public void SetAlan(double alan) => this.Alan = Math.Abs(alan);


    //public string GetSemt() =>  this.Semt;


    //public void SetSemt(string semt) => this.Semt = char.ToUpper(semt[0]) + semt.Substring(1).ToLower();





    //public virtual string EvinBilgileri()
    //{
    //    return $"Oda Sayısı:{this.Odasayisi}\nKat no :{this.Katno}\nAlan:{this.Alan}\nSemt:{this. Semt}\nEv Büyüklüğü:{this.Buyukluk}\n";
    //}
    //public class Ev
    //{
    //    public Ev(int odasayisi, int katno, double alan, string semt = "Kızılay")//Constructor
    //    {
    //        this.Odasayisi = odasayisi;
    //        this.Katno = katno;
    //        this.Semt = semt;
    //        this.Alan = (int)alan; // Explicit cast from double to int
    //    }



    //    //public Ev(int odasayisi, int katno, double alan)
    //    //{
    //    //    this.odasayisi = odasayisi;
    //    //    this.katno = katno;
    //    //    this.semt = "Kızılay";
    //    //    this.alan = alan;
    //    //}
    //    public static int sayac = 0;
    //    public Ev()
    //    {
    //        sayac++;
    //    }

    //    private int odasayisi;//field
    //    private int katno; 
    //    private string semt;//Buraya atanan değerler büyük harf olmalı
    //    //private string büyüklük;


    //    //Alan
    //    //50-75 küçük ev
    //    //75-120 orta ev
    //    //120+ büyük ev














    //    //Lambda Expression : Get ve Set bloklarında tek satırlık işlem yapılacaksa kullanılır.

    //    public string Semt { get => semt; set => semt = value.ToUpper(); }
    //    public int Katno { get; set; } //Auto Property : Get ve Set bloklarında işlem yapılamaycağı zaman kullanılır.

    //    //Full Property : Get ve Set bloklarında işlem yapılacaksa kullanılır.
    //    private int myVar;

    //    public int MyProperty
    //    {
    //        get 
    //        { 
    //            //Burda başka işlemler yapılabilir
    //            return myVar; 
    //        }
    //        set 
    //        {
    //            //Burda başka işlemler yapılabilir
    //            myVar = value;
    //        }
    //    }

    //    public int Odasayisi { get => odasayisi; set => odasayisi = value; }
    //    public int Katno1 { get => katno; set => katno = value; }
    //    public int Alan1 { get; set; }
    //    public string Buyukluk { get; private set ; }
    //    public void SetOdaSayisi(int odasayisi) => this.Odasayisi = Math.Abs(odasayisi);


    //private int alan;

    //public int Alan
    //{
    //    get
    //    {
    //        return Alan1;
    //    }

    //    set
    //    {
    //        Alan1 = value;
    //        if (Alan1 >= 50 && Alan1 < 75)
    //        {
    //            this.Buyukluk = "Küçük Ev";
    //        }
    //        if (Alan1 >= 75 && Alan1 < 120)
    //        {
    //            this.Buyukluk = "Orta Ev";
    //        }
    //        else if (Alan1 >= 120)
    //        {
    //            this.Buyukluk = "Büyük Ev";
    //        }
    //        else 
    //        { 
    //            this.Buyukluk = "Hatalı giriş yaptınız.";
    //        }
    //    }
    //}