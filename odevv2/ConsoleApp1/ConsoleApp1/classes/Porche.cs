using ConsoleApp1.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.classes
{
    public class Porche : araba, IHavadaUcan, ILitre
    {
        public void HavadaUcan(string marka)
        {
            Console.WriteLine(marka + " havada ucar.");
        }

        public double kacLitre()
        {
            return 60.0;
        }
    }
}
