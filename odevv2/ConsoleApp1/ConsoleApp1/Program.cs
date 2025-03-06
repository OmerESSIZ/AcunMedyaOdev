// See https://aka.ms/new-console-template for more information
using ConsoleApp1.Abstracts;
using ConsoleApp1.classes;


araba a = new araba();



Bmw bmw = new Bmw();
bmw.marka = "bmw";
bmw.denizdeYuzen(bmw.marka);
bmw.HavadaUcan(bmw.marka);
bmw.Hizli(bmw.marka);

Porche po = new Porche();
po.marka = "porche";
po.HavadaUcan(po.marka);

Mercedes mer = new Mercedes();
mer.marka = "mercedes";
mer.denizdeYuzen(mer.marka);
mer.HavadaUcan(mer.marka);



GenelMudur gm = new GenelMudur();
Mudur mu = new Mudur();
Programci pr = new Programci();
Stajyer st = new Stajyer();

double toplamMaas = 0.0;
toplamMaas += gm.maasinizNedir();
toplamMaas += mu.maasinizNedir();
toplamMaas += pr.maasinizNedir();
toplamMaas += st.maasinizNedir();

Console.WriteLine( toplamMaas + " TL maas aliyor..");


double toplamLitre = 0.0;
toplamLitre += bmw.kacLitre();
toplamLitre += mer.kacLitre();
toplamLitre += po.kacLitre();

Console.WriteLine(toplamLitre + " litre benzin harcıyorlar.");






/*
 Dizi(dizi), aynı veri türünden çok sayıda değişken anlamına gelir. Diziye ait değişkenler, sıra numarası verilmiş bir liste gibidir. Bu listeye ait olan ilerlemelere de sıra numarasıyla erişilir.
Örneğin 50 öğe olan bir sonlu dizin biçimi aşağıdaki gibidir.

d = {d[0], d[1], d[2], d[3], d[4], ….. , d[49]}

Neden Kullanılır ?

Genel olarak bilgisayarlarda işlenen veri sayısı kabul edilebilir. Çok fazla sayıda verinin bilgisayara girilmesi, hızlı bir şekilde çalıştırılabilmesi, uygun şekilde saklanabilmesi için Array kullanılır.
Array'ler üç başlık altında incelenebilir.
Tek Boyutlu Arrayler: “Vektör” olarak sunulan ve tek satırdan oluşan dizi sistemidir.
İki Boyutlu Arrayler: “Matris” olarak sunulan ve satır-sütun ilişkisi bulunan dizi sistemidir.
Çok Boyutlu Arrayler: Üç veya daha fazla boyutlu arrayler.
Tüm bu tanımlamalardan sonra herkesin bildiği matematik dizileri mutlaka benimsenmiştir. Arrayler, matematikteki sonlu dizi görünümüne benzeyen bir veri yapısıdır.

*/

