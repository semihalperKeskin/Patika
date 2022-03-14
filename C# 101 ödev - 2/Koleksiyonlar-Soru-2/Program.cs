// Klavyeden girilen 20 adet sayının en büyük 3 tanesi ve en küçük 3 tanesi bulan, her iki grubun kendi içerisinde ortalamalarını alan ve bu ortalamaları ve ortalama toplamlarını console'a yazdıran programı yazınız. (Array sınıfını kullanarak yazınız.

int n = 20;
int[] sayilar= new int[n];
int[] büyükSayi= new int[3];
int[] kücükSayi = new int[3];
int büyükSayiOrt;
int kücükSayiOrt;

for(int i = 0; i < n; i++)
{
    Console.WriteLine((i+1) +". Sayıyı Giriniz : ");
    sayilar[i] = int.Parse(Console.ReadLine());
}
Array.Sort(sayilar);
for(int i = 0; i < 3; i++)
{
    kücükSayi[i] = sayilar[i];
}
Array.Reverse(sayilar);
for(int i = 0; i < 3; i++)
{
    büyükSayi[i] = sayilar[i];
}

Islemler islem = new Islemler();
Console.WriteLine("En küçük 3 sayı : ");
islem.ArrayListe(kücükSayi);

Console.WriteLine("En büyük 3 sayı : ");
islem.ArrayListe(büyükSayi);
büyükSayiOrt = islem.Array_Islem(büyükSayi);
kücükSayiOrt = islem.Array_Islem(kücükSayi);

Console.WriteLine("Küçük sayıların ortalaması : "+ kücükSayiOrt);
Console.WriteLine("Büyük sayıların ortalaması : "+ büyükSayiOrt);

Console.WriteLine("Ortalamalar Toplamı : "+ (kücükSayiOrt + büyükSayiOrt));

class Islemler
{
    public int Array_Islem(int[] arr)
    {
        var sum = arr.Sum();
        var ortalamalar = sum / arr.Length;
        return ortalamalar;
    }
    public void ArrayListe(int[] arr)
    {
        foreach(var item in arr)
            Console.WriteLine(item + " ");
    }
}