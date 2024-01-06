using Proje_OOP.Entity;

namespace Proje_OOP.Examples
{
    public class Class1
    {
        void metot()
        {
            //Sınıfların içindeki öğelere erişim sağlamak için
            //sınıftan bir nesne türetilir
            //SınıfAdı nesneadı = new SınıfAdı();
            //Çağrılan sınıfın içindeki değerlere ulaşabilmek için sınıfı metot içinde çağırmak gerekmektedir
            Product p = new Product();
            p.Name = "Test";
        }

        public void Topla()
        {
            int sayi1 = 10;
            int sayi2 = 20;
            int sonuc = sayi1 + sayi2;

        }
        void Carp()
        {
            int s1 = 10;
            int s2 = 20;
            int sonuc = s1 * s2;
        }
    }
}
