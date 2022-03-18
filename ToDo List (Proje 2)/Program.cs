using System;
using System.Collections;
using System.Collections.Generic;

namespace ToDo_List__Proje_2_
{
    class Program
    {
        static void Main(string[] args)
        {
            KartManager cartManager = new();

            Console.WriteLine("Lütfen yapmak istediğiniz işlemi seçiniz :)\n" +
                "*******************************************\n" +
                "(1) Board Listelemek\n" +
                "(2) Board'a Kart Eklemek\n" +
                "(3) Board'dan Kart Silmek\n" +
                "(4) Kart Taşımak");

            int choice = int.Parse(Console.ReadLine());

            if(choice == 1)
                    cartManager.Listele();
            if(choice == 2)
                    cartManager.KartEkle();
            if(choice == 3)
                    cartManager.KartSil();
            if(choice == 4)
                    cartManager.KartTasi();
            else
            {
                Console.WriteLine("Hatalı giriş yaptınız!");
            }
        }

    }
}
