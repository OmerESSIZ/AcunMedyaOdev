using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UrunUygulama
{
    public class Urun
    {
        public string UrunAdi { get; set; }
        public int Fiyat { get; set; }
    }

}


/*ARAŞTIRMA ÖDEVİ: Reflection Nedir?
🎯 Adım 1: "Reflection nedir?" sorusuna kısa ve anlaşılır bir cevap yazın
Reflection, C# gibi nesne tabanlı dillerde, çalışma zamanında bir sınıfın, metodun, özelliğin, alanın veya başka bir yapının bilgilerini dinamik olarak almak için kullanılan bir tekniktir. Reflection sayesinde program çalışırken sınıf yapıları hakkında bilgi edinebiliriz ve bu bilgilere göre işlem yapabiliriz.

🎯 Adım 2: Reflection’ın ne işe yaradığını anlatın
Reflection, sınıfların, metodların, özelliklerin veya diğer yapılar üzerinde işlem yapabilmek için kullanılır. Bu teknoloji özellikle şunlar için faydalıdır:

Dinamik Programlama: Çalışma zamanında hangi sınıfın veya metodun kullanılacağını belirleme.

Veri Keşfi: Özellikle veritabanı tablosu gibi dinamik verilerle çalışırken, bu verilerle ilişkili sınıf ve özellikler hakkında bilgi alma.

Test ve Mocking: Yazılım testlerinde nesnelerin çalışma zamanında davranışlarını değiştirme ve test etme.

Dinamik Nesne Oluşturma: Yeni nesneleri dinamik olarak oluşturma veya metotları çalışma zamanında çağırma.*/

/*static void Main()
    {
        // Urun sınıfının bir örneği
        Urun urun = new Urun { UrunAdi = "Bilgisayar", Fiyat = 25000 };

        // Reflection kullanarak Urun sınıfının özelliklerine eriş
        PropertyInfo[] properties = typeof(Urun).GetProperties();

        // Özellikleri döngü ile yazdır
        foreach (var property in properties)
        {
            Console.WriteLine($"{property.Name}: {property.GetValue(urun)}");
        }

        // Programın hemen kapanmaması için
        Console.WriteLine("Press any key to continue...");
        Console.ReadKey();
    }*/