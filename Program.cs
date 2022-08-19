using System;
namespace overload{
class program{ 
    static void Main(string[] args){
    string sayi="999";
    bool sonuc=int.TryParse(sayi, out int outSayi);
    if (sonuc){
        Console.WriteLine("Sonuç Başarılı");
        Console.WriteLine(outSayi); 
        }
        else
        {
            Console.WriteLine("Sonuç Başarısız");
      }
       metotlar instance = new metotlar();
     instance.Topla(4,5,out int toplamSonucu);
     int ifade=999;
     instance.EkranaYazdir(Convert.ToString(ifade));
     instance.EkranaYazdir(ifade);
     instance.EkranaYazdir("Zikriye","Ürkmez");
    }
  }
  class metotlar{
    public void Topla(int a,int b,out int toplam){
        toplam=a+b;
    }
    public void EkranaYazdir(string veri){
        Console.WriteLine(veri);
    }
       public void EkranaYazdir(int veri){
        Console.WriteLine(veri);
       }
      public void EkranaYazdir(string veri1,string veri2){
        Console.WriteLine(veri1+veri2);
      }

}


}
