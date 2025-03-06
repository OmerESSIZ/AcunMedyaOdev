
using ConsoleApp1.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.classes
{
    public class Bmw : araba, IHizli, IHavadaUcan, IDenizdeYuzen, ILitre
    {
        public void denizdeYuzen(string marka)
        {
            Console.WriteLine(marka + " denizde yuzer.");
        }

        public void HavadaUcan(string marka)
        {
            Console.WriteLine(marka + " havada ucar.");
        }

        public void Hizli(string marka)
        {
            Console.WriteLine(marka + " cok hizlidir..");
        }

        public double kacLitre()
        {
            return 80.0;
        }
    }
}
