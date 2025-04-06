using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarListApp
{
    public class Car
    {
        public string Marka { get; set; }   
        public string Model { get; set; }
        public double FuelConsumption { get; set; }  // 100 km'de harcanan yakıt
        public double TotalDistance { get; set; }    // toplam gidilen km

        // Toplam yakıt tüketimini hesaplayan method
        public double ToplamYakıtTüketimi()
        {
            return (TotalDistance / 100) * FuelConsumption;
        }
    }

}
