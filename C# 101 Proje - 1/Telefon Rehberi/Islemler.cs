using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Telefon_Rehberi
{
    internal class Islemler
    {
        public void NewPerson()
        {
            String ad;
            string soyad;
            string phonNo;
            Console.Write("Lütfen isim giriniz              : ");
            ad = Console.ReadLine();
            Console.WriteLine();

            Console.Write("Lütfen soyisim giriniz           : ");
            soyad = Console.ReadLine();
            Console.WriteLine();

            Console.Write("Lütfen Telefon numarası giriniz  : ");
            phonNo = Console.ReadLine();
            Console.WriteLine();

            TelList.TelListe.Add(new Rehber(ad, soyad, phonNo));
        }
        public void DeletePerson()
        {
            Console.WriteLine("Lütfen numarasını silmek istediğiniz kişinin adını ya da soyadını giriniz:");
            string person = Console.ReadLine();
            int check = 0;

            foreach (var item in TelList.TelListe)
            {
                if (item.ad.ToLower() == person.ToLower() || item.soyad.ToLower() == person.ToLower())
                {
                    Console.WriteLine("{0} isimli kişi rehberden silinmek üzere, onaylıyor musunuz ?(y/n)", item.ad);
                    char yesOrNo = char.Parse(Console.ReadLine());
                    if (yesOrNo == 'y')
                    {
                        TelList.TelListe.RemoveAt(TelList.TelListe.IndexOf(item));
                        Console.WriteLine("Silme Onayı Başarılı, Çıkılıyor...");
                        check++;
                        break;

                    }
                    else
                    {
                        check++;
                        Console.WriteLine("Silme Onayı Başarısız, Çıkılıyor...");
                        break;
                    }
                }
            }
            if (check == 0)
            {
                Console.WriteLine("Aradığınız krtiterlere uygun veri rehberde bulunamadı. Lütfen bir seçim yapınız.");
                Console.WriteLine("* Silmeyi sonlandırmak için : (1)");
                Console.WriteLine("* Yeniden denemek için      : (2)");
                int secim = int.Parse(Console.ReadLine());
                if (secim == 2)
                {
                    while (secim == 2)
                    {
                        Console.WriteLine("Lütfen numarasını silmek istediğiniz kişinin adını ya da soyadını giriniz:");
                        person = Console.ReadLine();
                        foreach (var item in TelList.TelListe)
                        {
                            if (item.ad.ToLower() == person.ToLower() || item.soyad.ToLower() == person.ToLower())
                            {
                                Console.WriteLine("{0} isimli kişi rehberden silinmek üzere, onaylıyor musunuz ?(y/n)", item.ad);
                                char j = char.Parse(Console.ReadLine());
                                if (j == 'y')
                                {
                                    TelList.TelListe.RemoveAt(TelList.TelListe.IndexOf(item));
                                    Console.WriteLine("Silme Onayı Başarılı, Çıkılıyor...");
                                    check++;
                                    secim = 3;
                                    break;

                                }
                                else
                                {
                                    check++;
                                    Console.WriteLine("Silme Onayı Başarısız, Çıkılıyor...");
                                    break;
                                }
                            }
                        }
                    }
                }
            }
        }

        public void Update()
        {
            int find = 0;
            Console.WriteLine("Lütfen numarasını güncellemek istediğiniz kişinin adını ya da soyadını giriniz:");
            string person = Console.ReadLine();
            for (int i = 0; i < TelList.TelListe.Count; i++)
            {
                if(person.ToLower() == TelList.TelListe[i].ad.ToLower() || person.ToLower() == TelList.TelListe[i].soyad.ToLower())
                {
                    Console.WriteLine("Güncellemek istediğiniz kişi : {0} {1}",TelList.TelListe[i].ad, TelList.TelListe[i].soyad);
                    Console.WriteLine("Lütfen güncellemek istediğiniz yeni telefon numarasını giriniz : ");
                    string newTelNo = Console.ReadLine();
                    newTelNo = TelList.TelListe[i].telNo;
                    Console.WriteLine("Telefon Numarası Güncellemesi Başarılı, Çıkılıyor...");
                    find++;
                    break;
                }
            }
            if(find == 0)
                Console.WriteLine("Telefon Numarası Güncellemesi Başarısız, Çıkılıyor...");
        }
        public void Listeleme()
        {
            Console.WriteLine("Telefon Rehberi");
            Console.WriteLine("**********************************************");
            foreach(var item in TelList.TelListe)
            {
                Console.WriteLine("İsim : "+ item.ad);
                Console.WriteLine("Soyisim : "+item.soyad);
                Console.WriteLine("Telefon Numarası : " + item.telNo);
            }
        }
        public void FindPerson()
        {
            int find = 0;
            Console.WriteLine("Arama yapmak istediğiniz tipi seçiniz.");
            Console.WriteLine(" **********************************************");
            Console.WriteLine("İsim veya soyisime göre arama yapmak için: (1)");
            Console.WriteLine("Telefon numarasına göre arama yapmak için: (2)");
            char chose = char.Parse(Console.ReadLine());
            if (chose == '1')
            {
                Console.WriteLine("Lütfen aramak istediğiniz kişinin ismini veya soyisimini giriniz : ");
                string kisi = Console.ReadLine();
                for (int i = 0; i < TelList.TelListe.Count; i++)
                {
                    if (kisi.ToLower() == TelList.TelListe[i].ad.ToLower() || kisi.ToLower() == TelList.TelListe[i].soyad.ToLower())
                    {
                        Console.WriteLine(" Arama Sonuçlarınız:");
                        Console.WriteLine("**********************************************");
                        Console.WriteLine("isim : " + TelList.TelListe[i].ad);
                        Console.WriteLine("Soyisim : " + TelList.TelListe[i].soyad);
                        Console.WriteLine("Telefon Numarası : " + TelList.TelListe[i].telNo);
                        find++;
                    }
                }

            }
            else if (chose == '2')
            {
                Console.WriteLine("Lütfen aramak istediğiniz kişinin telefon numarasını giriniz : ");
                string kisi = Console.ReadLine();
                for (int i = 0; i < TelList.TelListe.Count; i++)
                {
                    if (kisi.ToLower() == TelList.TelListe[i].telNo.ToLower())
                    {
                        Console.WriteLine(" Arama Sonuçlarınız:");
                        Console.WriteLine("**********************************************");
                        Console.WriteLine("isim : " + TelList.TelListe[i].ad);
                        Console.WriteLine("Soyisim : " + TelList.TelListe[i].soyad);
                        Console.WriteLine("Telefon Numarası : " + TelList.TelListe[i].telNo);
                        find++;
                    }
                }

            }
            if (find == 0)
                Console.WriteLine("Arama sonucu bulunamadı.");

        }
        public void StartScreen()
        {
            Console.WriteLine("Lütfen yapmak istediğiniz işlemi seçiniz :)");
            Console.WriteLine("*******************************************");
            Console.WriteLine("(1) Yeni Numara Kaydetmek");
            Console.WriteLine("(2) Varolan Numarayı Silmek");
            Console.WriteLine("(3) Varolan Numarayı Güncelleme");
            Console.WriteLine("(4) Rehberi Listelemek");
            Console.WriteLine("(5) Rehberde Arama Yapmak﻿");
        }
    }
        public class TelList
        {
            public static List<Rehber> TelListe = new List<Rehber>();
        }
}
