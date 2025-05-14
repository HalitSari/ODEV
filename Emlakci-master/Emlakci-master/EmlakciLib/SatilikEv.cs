using System;
using System.Collections.Generic;
using System.Text;

namespace EmlakciLib
{
    public class SatilikEv : Ev
    {
        public SatilikEv()
        {

        }

        public SatilikEv(int odasayisi, int katno, double alan, string semt)
        {
            Odasayisi = odasayisi;
            Katno = katno;
            Alan = alan;
            Semt = semt;
        }

        public SatilikEv(double satisfiyat, int odasayisi, string semt, int katno, double alan) : this(odasayisi, katno, alan, semt)
        {
            Satisfiyat = satisfiyat;
        }

        public double Satisfiyat { get; set; }

        //public new string EvBilgileri()
        //{
        //    return $"{base.EvBilgileri()}\nSatış Fiyat:{this.Satisfiyat}";
        //}

        public override string Bilgiler()
        {
            return ($"\nSatış Fiyat:{this.Satisfiyat}");
        }
    }
}
//Name Hiding: Türeyen classlarda, base classtaki üye(ler)in ismiyle aynı isimli bir üye tanımlanırsa, artık türeyen class referansıyla base classtaki üyeye erişilemez. 