
//Klavyeden girilen 20 adet pozitif sayının asal ve asal olmayan olarak 2 ayrı listeye atın. (ArrayList sınıfını kullanara yazınız.)
// Negatif ve numeric olmayan girişleri engelleyin.
// Her bir dizinin elemanlarını büyükten küçüğe olacak şekilde ekrana yazdırın.
// Her iki dizinin eleman sayısını ve ortalamasını ekrana yazdırın.

using System.Collections.Generic;
using System.Collections;

int n = 5;
ArrayList liste = new ArrayList();
ArrayList asal = new ArrayList();
ArrayList noAsal = new ArrayList();
int sayiGiris=0;

for(int i = 0; i < n ; i++)
{
    Console.WriteLine("{0}.Sayınızı giriniz : ", (i+1));
    try
    {
        
        sayiGiris = int.Parse(Console.ReadLine());
        while(sayiGiris < 0)
        {
            Console.WriteLine("{0}.Sayınız Negatif olamaz. Tekrar Giriniz : ", (i+1));
            sayiGiris = int.Parse(Console.ReadLine());
        }
        liste.Add(sayiGiris);
    }
    catch
    {
        Console.WriteLine("Hatalı giriş lütfen sayı giriniz : ");
         Console.WriteLine("{0}.Sayıyı Tekrar Giriniz : ", (i+1));
        sayiGiris = int.Parse(Console.ReadLine());
        liste.Add(sayiGiris);
    }
}




    foreach(int item in liste)
    {
        if(item == 0 || item == 1)
            noAsal.Add(item);

        else if(item == 2)
            asal.Add(item);

        else if(item % 2 == 0)
            noAsal.Add(item);

        else
            asal.Add(item);
    }
Hesaplamalar hesap = new Hesaplamalar();

Console.WriteLine("Asal sayıların büyükten küçüğe sıralanışı : ");
asal.Sort();
asal.Reverse();

foreach(int item in asal)
     Console.WriteLine(asal + " ");

Console.WriteLine("Şeklinde sıralanmıştır.");
Console.WriteLine("{0} Tane asal sayı vardır.", asal.Count);


Console.WriteLine("Asal olmayan sayıların büyükten küçüğe sıralanışı : ");
noAsal.Sort();
noAsal.Reverse();

foreach(int item in noAsal)
     Console.WriteLine(noAsal + " ");

Console.WriteLine("Şeklinde sıralanmıştır.");
Console.WriteLine("{0} Tane asal olmayan sayı vardır.", noAsal.Count);

Console.WriteLine("Asal sayıların toplamı ve ortapalaması  : ");
hesap.Ortalama(asal);

Console.WriteLine("Asal olmayan sayıların toplamı ve ortapalaması  : ");
hesap.Ortalama(noAsal);


class Hesaplamalar
{
    public ArrayList Asal_Islem(ArrayList arr)
    {
        arr.Sort();
        arr.Reverse();
        
        foreach(var item in arr)
            Console.WriteLine(arr + " ");
        Console.WriteLine("Şeklinde sıralanmıştır.");
        return arr;
    }
    public async void Ortalama(ArrayList arr)
    {
        var sum = 0;
        var avg = 0;
        foreach(int item in arr)
            sum += item;
        
        Console.WriteLine("Toplam : "+ sum);
        Console.WriteLine("Ortalama : "+ (sum/arr.Count));
    }
}