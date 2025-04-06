using CarListApp;
using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Araba listesini oluştur
        List<Car> arabalar = new List<Car>();

        // 3 farklı araba ekleyelim
        arabalar.Add(new Car
        {
            Marka = "Toyota",
            Model = "Corolla",
            FuelConsumption = 6.5,
            TotalDistance = 5000
        });

        arabalar.Add(new Car
        {
            Marka = "BMW",
            Model = "X5",
            FuelConsumption = 9.0,
            TotalDistance = 5000
        });

        arabalar.Add(new Car
        {
            Marka = "Mercedes",
            Model = "C200",
            FuelConsumption = 8.2,
            TotalDistance = 5000
        });

        // Her arabanın bilgilerini ve toplam yakıt tüketimini yazdıralım
        foreach (Car araba in arabalar)
        {
            double toplamYakit = araba.ToplamYakıtTüketimi();

            Console.WriteLine($"Marka: {araba.Marka}, Model: {araba.Model}, " +
                $"100 km'de Yaktığı Yakıt: {araba.FuelConsumption} litre, " +
                $"Toplam Yakıt Tüketimi: {toplamYakit} litre");
        }
    }
}
/*
Görsel Programlama Nedir?
Görsel programlama (Visual Programming), kullanıcıların kod yazmak yerine grafiksel arabirimler 
(sürükle-bırak bloklar, diyagramlar, düğmeler vb.)
aracılığıyla program oluşturmasına olanak tanıyan bir programlama yöntemidir.

Metin Tabanlı Programlamadan Farkları:
Görsel programlama, geleneksel metin tabanlı programlamaya göre birçok yönden farklılık gösterir.
Metin tabanlı programlama dillerinde kullanıcılar kodu doğrudan yazarak işlem yaparken,
görsel programlamada kullanıcılar grafiksel bileşenleri
(bloklar, düğmeler, akış diyagramları vb.) kullanarak program oluştururlar.*/