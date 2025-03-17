// See https://aka.ms/new-console-template for more information
using constructor;
using constructor.Constructors;





Matematik m = new Matematik();

int toplamSonucu = m.Topla(10, 3, 5);
int carpimSonucu = m.Carp(10, 3, 5);
Console.WriteLine("toplam: " + toplamSonucu);
Console.WriteLine("Carpimi: " + carpimSonucu);


Marka marka = new Marka("BMW");
Model model = new Model("X5");
Kapi kapi = new Kapi(4);
Pencere pencere = new Pencere(4);
Kasa kasa = new Kasa("sedan");
Fiyat fiyat = new Fiyat(2000000);

Araba araba = new Araba(marka, model, kapi, pencere, kasa, fiyat);
YeniAraba yeni = new YeniAraba(araba);
yeni.Ozellikler();

/*
Garbage Collector, 0. nesil nesnelerini temizledikten sonra belleği sıkıştırarak kalan nesneleri 1. nesile taşır. 
Eğer 0. nesilde yeterli bellek temizlenemezse, işlem 1. nesil nesneleri üzerinde gerçekleştirilir. 
Bu işlemi de geçen nesneler, 2. nesile yükseltilir ve burada uzun süre tutulur.

bellekte yeterli alan yoksa ne olur?

Bellek yetersiz kaldığında, Garbage Collector devreye girer ve artık kullanılmayan tüm nesneleri temizler. 
Eğer hala yeterli alan sağlanamazsa, sistem "OutOfMemoryException" hatası vererek çalışmayı durdurabilir.
Özetle; "new" anahtar kelimesi ile oluşturulan nesneler heap (yığın) belleğe yerleştirilir. 
Ancak bellekte yeterli alan yoksa, Garbage Collector devralarak bellek tahsisini yönetir ve gereksiz nesneleri temizler.

### Generic Classlar ve Metotlar

Generic yapılar, bir sınıfın veya metodun birden fazla veri türü ile parametre almasını sağlar. 
Bu sayede aynı sınıf yapısı, farklı veri türleri için yeniden kullanılabilir hale gelir.
Örneğin, bir koleksiyon sınıfı oluşturulurken generic metotlar kullanılarak, farklı veri türleriyle aynı işlemler yapılabilir.

Generic yapılar, kod tekrarını azaltarak daha okunaklı ve kolay bakım yapılabilir hale getirir. 
Ayrıca, performans açısından daha verimli çalışmasını sağlar ve tip güvenliği sunarak hataları en aza indirir.
Diğer liste ve koleksiyon yapılarından temel farkları ise **performans** ve **tip güvenliği** avantajlarıdır.

### Boxing & Unboxing

Boxing (Kutulama), bir değer türünün referans türüne dönüştürülmesidir.
Yani, bir `int`, `double` gibi değer tipleri `object` içine alınarak heap bellekte saklanır.
Unboxing (Kutudan Çıkarma) ise tam tersidir; referans türünden değer türüne geri dönüşümü ifade eder.

1. **Boxing (Kutulama)**
   - Boxing, bir değer türünü `object` türüne veya herhangi bir arayüz türüne dönüştürme işlemidir.
   - .NET çalışma zamanı (CLR), değeri `System.Object` içerisine sararak heap bellekte depolar.
   - Boxing işlemi örtük (implicit) bir işlemdir, ancak ekstra bellek tahsisi gerektirdiği için performansa olumsuz etkisi olabilir.

2. **Unboxing (Kutudan Çıkarma)**
   - Unboxing, `object` veya bir arayüz nesnesinden değer türüne açık (explicit) bir dönüşümdür.
   - Unboxing sürecinde, CLR önce nesnenin uygun bir kutulanmış değer içerdiğini doğrular, ardından değeri çıkartıp değişken içine kopyalar.
   - Eğer yanlış türde bir değer çıkarılmaya çalışılırsa `InvalidCastException` hatası oluşur.

Yanlış türden bir `object` değerini kutudan çıkarmaya çalışmak `InvalidCastException` hatasına, boş (`null`) bir değeri kutudan çıkarmaya çalışmak ise `NullReferenceException` hatasına neden olabilir.

Boxing ve Unboxing işlemleri ek bellek tahsisi gerektirdiği için performans açısından maliyetlidir. 
Özellikle büyük veri işlemlerinde gereksiz Boxing ve Unboxing kullanımından kaçınılmalıdır.

Aşağıda programlama sırasında istemeden Boxing & Unboxing’e sebep olabilecek yaygın hatalar bulunmaktadır:

1. `foreach` döngüsünde değer türü kullanma  
2. Değer türlerini referans tabanlı koleksiyonlarda saklama  
3. Değer türlerini `as` operatörüyle kullanma  
4. `is` operatörü ile değer türü kontrolü yapma  
5. `object` türünü metot parametresi olarak kullanma  
6. Değer türlerini `lock` ile senkronize etme  
7. Değer türlerini `Dictionary` anahtarı olarak kullanma  
8. `ref` veya `out` anahtar sözcüklerini değer türleriyle kullanma  
9. Değer türleriyle aşırı yüklenmiş metotlar yazma  
10. LINQ sorgularında değer türleri kullanma  
11. `dynamic` türünü değer türleriyle birlikte kullanma  
12. `object` türünü genel bir tür argümanı olarak kullanma  

Performans kaybını önlemek için **Generic yapılar** kullanılmalı ve gereksiz tür dönüşümlerinden kaçınılmalıdır.
*/