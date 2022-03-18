using System;
using System.Collections;
using System.Collections.Generic;

namespace ToDo_List__Proje_2_
{

    public class KartIcerik
    {
        public KartTür kartTür;
        public string Baslik;
        public string Icerik;
        public int AtananKisi;
        public Büyüklük büyüklük;

        public KartIcerik(string baslik, string ıcerik,int atananKisi, KartTür kartTür, Büyüklük büyüklük)
        {
            this.kartTür = kartTür;
            Baslik = baslik;
            Icerik = ıcerik;
            AtananKisi = atananKisi;
            this.büyüklük = büyüklük;
        }
        public KartIcerik(string baslik, string ıcerik, Büyüklük büyüklük, int atananKisi)
        {
            Baslik = baslik;
            Icerik = ıcerik;
            AtananKisi = atananKisi;
            this.büyüklük = büyüklük;
        }


        public enum Büyüklük
        {
            XS=1,
            S,
            M,
            L,
            XL
        }
        public enum KartTür
        {
            TODO =1,
            INPROGRESS,
            DONE
        }
        
    }
}