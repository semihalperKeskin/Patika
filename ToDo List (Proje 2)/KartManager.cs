using System;
using System.Collections;
using System.Collections.Generic;

namespace ToDo_List__Proje_2_
{
    public class KartManager
    {
        List<TakımUyeler> takımUyeleri = new()
        {
            new TakımUyeler(1,"Ahmet"),
            new TakımUyeler(2,"Ali"),
            new TakımUyeler(3,"Veli"),
            new TakımUyeler(4,"Can")
        };
            List<KartIcerik> kartlar = new List<KartIcerik>(){
            new KartIcerik("Test", "Başarı testi", 1, KartIcerik.KartTür.TODO, KartIcerik.Büyüklük.XS),
            new KartIcerik("Araba","Spor Arabalar",2,KartIcerik.KartTür.INPROGRESS,KartIcerik.Büyüklük.L),
            new KartIcerik("Spor","Fitness",4,KartIcerik.KartTür.DONE,KartIcerik.Büyüklük.M)
        };
        public async void Listele()
        {
            List<KartIcerik> todos = kartlar.FindAll(KartIcerik => KartIcerik.kartTür == KartIcerik.KartTür.TODO);
            List<KartIcerik> inprogressList = kartlar.FindAll(KartIcerik => KartIcerik.kartTür == KartIcerik.KartTür.INPROGRESS);
            var doneList = this.kartlar.FindAll(kartlar => kartlar.kartTür == KartIcerik.KartTür.DONE);

            Console.WriteLine("TODO Line");
            Console.WriteLine("************************");
            for(int i=0; i< todos.Count;i++ )
            {Console.WriteLine(todos[i]);}

            Console.WriteLine("IN PROGRESS Line");
            Console.WriteLine("************************");
            for(int i=0; i< inprogressList.Count;i++ )
            {Console.WriteLine(inprogressList[i]);}
            
            Console.WriteLine("IN PROGRESS Line");
            Console.WriteLine("************************");
            for(int i=0; i< doneList.Count;i++ )
            {Console.WriteLine(doneList[i]);}
            

        }
        public async void KartEkle()
        {
            Console.Write("Başlık Giriniz                                  :");
            string baslikEkle = Console.ReadLine();
            Console.WriteLine();

            Console.WriteLine("İçerik Giriniz                                  :");
            string icerikEkle = Console.ReadLine();
            Console.WriteLine();

            Console.WriteLine("Büyüklük Seçiniz -> XS(1),S(2),M(3),L(4),XL(5)  :");
            int büyüklükEkle = int.Parse(Console.ReadLine());
            Console.WriteLine();
            var büyüklükEkleTür = KartIcerik.Büyüklük.XS;
            if(büyüklükEkle == 1)
                büyüklükEkleTür = KartIcerik.Büyüklük.XS;
            if(büyüklükEkle == 2)
                büyüklükEkleTür = KartIcerik.Büyüklük.S;
            if(büyüklükEkle == 3)
                büyüklükEkleTür = KartIcerik.Büyüklük.M;
            if(büyüklükEkle == 4)
                büyüklükEkleTür = KartIcerik.Büyüklük.L;
            if(büyüklükEkle == 5)
                büyüklükEkleTür = KartIcerik.Büyüklük.XL;

            Console.WriteLine(" Kişi Seçiniz                                    :");
            int kisiEkle = int.Parse(Console.ReadLine());

            int check =0;
            for(int i = 0; i<takımUyeleri.Count;i++)
            {
                if(kisiEkle == takımUyeleri[i].id)
                {
                    check++;
                }
            }
            if(check == 1)
            {
                Console.WriteLine("Kart başarı ile eklendi");
                kartlar.Add(new KartIcerik(baslikEkle, icerikEkle, büyüklükEkleTür,kisiEkle));
            }
            else if(check == 0)
            {
                Console.WriteLine("Geçersiz Kişi işlemden çıkılıyor..");
            }
        }
        public async void KartSil()
        {
            Console.WriteLine(" Öncelikle silmek istediğiniz kartı seçmeniz gerekiyor.");
            Console.WriteLine("Lütfen kart başlığını giriniz: ");
            string silinecekBaslik = Console.ReadLine();
            int check = 0;
            for(int i = 0; i < kartlar.Count; i++)
            {
                if(silinecekBaslik == kartlar[i].Baslik)
                {
                    kartlar.RemoveAt(i);
                    check = 1;
                }
            }
            if(check == 1)
                Console.WriteLine("Silme işlemi başarılı.");
            else if (check == 0)
            {
                Console.WriteLine("Aradığınız krtiterlere uygun kart board'da bulunamadı. Lütfen bir seçim yapınız.");
                Console.WriteLine("* Silmeyi sonlandırmak için : (1)");
                Console.WriteLine(" * Yeniden denemek için : (2)");
                int tekrarSecim = Convert.ToInt32(Console.ReadLine());
                if(tekrarSecim == 1)
                    Console.WriteLine("Silme işlemi sonlandırıldı..");
                else if(tekrarSecim == 2)
                {
                    Console.WriteLine(" Öncelikle silmek istediğiniz kartı seçmeniz gerekiyor.");
                 string silinecekBaslik1 = Console.ReadLine();
                check = 0;
                for(int i = 0; i < kartlar.Count; i++)
                 {
                    if(silinecekBaslik == kartlar[i].Baslik)
                     {
                         kartlar.RemoveAt(i);
                         check = 1;
                     }
                 }
                if(check == 1)
                     Console.WriteLine("Silme işlemi başarılı.");
     
                }
            }
        }
        public async void KartTasi()
        {
            Console.WriteLine(" Öncelikle taşımak istediğiniz kartı seçmeniz gerekiyor.");
            Console.WriteLine("Lütfen kart başlığını giriniz: ");
            string tasınacakBaslik = Console.ReadLine();
            int check = 0;
            for(int i = 0; i < kartlar.Count; i++)
            {
                if(tasınacakBaslik == kartlar[i].Baslik)
                {
                    Console.WriteLine("Bulunan Kart Bilgileri:");
                    Console.WriteLine("**************************************");
                    Console.WriteLine("Başlık      :"+ kartlar[i].Baslik);
                    Console.WriteLine("İçerik      :"+ kartlar[i].Icerik);
                    Console.WriteLine("Atanan Kişi :"+ kartlar[i].AtananKisi);
                    Console.WriteLine("Büyüklük    :"+ kartlar[i].büyüklük);
                    Console.WriteLine("Line        :"+ kartlar[i].kartTür);
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine("Lütfen taşımak istediğiniz Line'ı seçiniz:");
                    Console.WriteLine("(1) TODO");
                    Console.WriteLine("(2) IN PROGRESS");
                    Console.WriteLine("(3) DONE");
                    int secimTasima = Convert.ToInt32(Console.ReadLine());
                    if(secimTasima == 1)
                    {
                    kartlar[i].kartTür = (KartIcerik.KartTür)secimTasima;
                    Console.WriteLine("İşlem Başarılı.");
                    }
                    if(secimTasima == 2)
                    {
                        kartlar[i].kartTür = (KartIcerik.KartTür)secimTasima;
                        Console.WriteLine("İşlem Başarılı.");
                    }
                    if(secimTasima == 3)
                    {
                        kartlar[i].kartTür = (KartIcerik.KartTür)secimTasima;
                        Console.WriteLine("İşlem Başarılı.");
                    }
                    check = 1;
                }
            }
            if(check == 0)
            {
                Console.WriteLine("Hatalı bir seçim yaptınız! İşlem sonlandırılıyor..");
            }
            for(int i = 0; i<kartlar.Count;i++)
            {
                    Console.WriteLine("Bulunan Kart Bilgileri:");
                    Console.WriteLine("**************************************");
                    Console.WriteLine("Başlık      :"+ kartlar[i].Baslik);
                    Console.WriteLine("İçerik      :"+ kartlar[i].Icerik);
                    Console.WriteLine("Atanan Kişi :"+ kartlar[i].AtananKisi);
                    Console.WriteLine("Büyüklük    :"+ kartlar[i].büyüklük);
                    Console.WriteLine("Line        :"+ kartlar[i].kartTür);
            }
        }
    }
}