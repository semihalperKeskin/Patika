// // SORU - 1
// //Bir konsol uygulamasında kullanıcıdan pozitif bir sayı girmesini isteyin(n). Sonrasında kullanıcıdan n adet pozitif sayı girmesini isteyin. Kullanıcının girmiş olduğu sayılardan çift olanlar console'a yazdırın.

// Console.WriteLine("Pozitif bir Sayı Giriniz: ");

// int n = int.Parse(Console.ReadLine());

// Metot metot = new();
// metot.PozitifMi(ref n);

// int sayac=1;
// int[] sayiGiris=new int[n];
// for(int i =0; i < sayiGiris.Length; i++)
// {
//     Console.WriteLine(sayac+". sayıyı girin:");
//     sayiGiris[i] = int.Parse(Console.ReadLine());
//     sayac++;
// }

// Console.WriteLine("Girdiğiniz çift sayılar: ");
// foreach(var item in sayiGiris)
// {
//     if ( item % 2 == 0)
//         Console.Write(item+" ");
// }




// class Metot
// {
//     public  int PozitifMi(ref int n)
//     {
//         while(n < 0)
//         {
//             Console.WriteLine("Pozitif bir sayı giriniz: ");
//             n = int.Parse(Console.ReadLine());
            
//         }
//         return n;
//     }
// }






// // SORU - 2 
// //Bir konsol uygulamasında kullanıcıdan pozitif iki sayı girmesini isteyin (n, m). Sonrasında kullanıcıdan n adet pozitif sayı girmesini isteyin. Kullanıcının girmiş olduğu sayılardan m'e eşit yada tam bölünenleri console'a yazdırın.


//       Console.WriteLine("İlk pozitif sayıyı giriniz: ");
//         int n = int.Parse(Console.ReadLine());
//         n.PozitifMi();

//         Console.WriteLine("İkinici sayıyı giriniz: ");
//         int m = int.Parse(Console.ReadLine());
//         m.PozitifMi();

//         Console.WriteLine(n+" "+m);
        
//         int[] nAdet = new int[n];
//         List<int> esit = new();
//         List<int> tamBolunen = new();
//         int sayac = 1;
//         Console.WriteLine(n+" kadar sayı giriniz: ");
//         for(int i = 0; i < nAdet.Length; i++)
//         {
//             Console.WriteLine(sayac+". Sayıyı giriniz: ");
//             nAdet[i] = int.Parse(Console.ReadLine());
//             while(nAdet[i] < 0)
//             {
//                 Console.WriteLine(sayac+". Sayıyı tekrar giriniz: ");
//                 nAdet[i] = int.Parse(Console.ReadLine());
//             }
//             sayac++;
//         }
//         for(int j = 0; j< nAdet.Length; j++)
//         {
//             if(nAdet[j] == m)
//             {   
//                 esit.Add(nAdet[j]);
//                 tamBolunen.Add(nAdet[j]);
//             }

//             else if (nAdet[j]%2==0)
//                 tamBolunen.Add(nAdet[j]);
//         }
//         Console.Write("Eşit olan sayılar : ");
//         foreach(var item in esit)
//         Console.Write(item+ " ");

//         Console.Write("Tam bölünen sayılar : ");
//         foreach(var item in tamBolunen)
//         Console.Write(item+ " ");
        

// public static class Metot
// {
//     public static int PozitifMi(this ref int x)
//     {
//         while(x < 0)
//         {
//             Console.WriteLine("Pozitif sayı giriniz: ");
//             x = int.Parse(Console.ReadLine());
//         }
//         return x;
//     }
// }



// // SORU - 3
// //Bir konsol uygulamasında kullanıcıdan pozitif bir sayı girmesini isteyin (n). Sonrasında kullanıcıdan n adet kelime girmesi isteyin. Kullanıcının girişini yaptığı kelimeleri sondan başa doğru console'a yazdırın.

// Metot metot = new();

// Console.WriteLine("Pozitif bir sayı giriniz : ");
// int n = int.Parse(Console.ReadLine());
// metot.PozitifMi(ref n);

// string[] kelimelik = new string[n];
// Console.WriteLine((n+1) + " Adet kelime giriniz: ");
// int sayac=1;
// for(int i = 0; i < kelimelik.Length; i++)
// {
//     Console.WriteLine(sayac+". Kelimeyi giriniz : ");
//     kelimelik[i] = Console.ReadLine();
//     sayac++;
// }
// Console.WriteLine("Girdiğiniz kelimelerin tersten sıralanışı : " );
// Array.Reverse(kelimelik);

// foreach(var item in kelimelik)
// Console.WriteLine(item);





// class Metot{

//     public int PozitifMi(ref int n)
//     {
//         while(n < 0)
//         {
//             Console.WriteLine("Girdiğiniz sayı hatalı pozitif bir sayı giriniz : ");
//             n = int.Parse(Console.ReadLine());
//         }
//         return n;
//     }
// }


// // SORU - 4
// //Bir konsol uygulamasında kullanıcıdan bir cümle yazması isteyin. Cümledeki toplam kelime ve harf sayısını console'a yazdırın.



// Console.WriteLine("Bir cümle giriniz: ");
// string cümle = Console.ReadLine();
// string[] kelimeSay = cümle.Split(' ');
// Console.WriteLine("Kelime Sayısı : "+ kelimeSay.Length);
// Console.WriteLine("Harf sayısı : "+ (cümle.Length - (kelimeSay.Length-1)));