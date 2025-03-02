using System;
class Program
{
    static void Main(string[] args)
    {
        Bmw bmw = new Bmw();
        bmw.markaModelYaz("BMW", "X5");

        Porsche porsche = new Porsche();
        porsche.markaModelYaz("Porsche", "Carrera");

        Mercedes mercedes = new Mercedes();
        mercedes.markaModelYaz("Mercedes", "C200");

        Togg togg = new Togg();
        togg.markaModelYaz("Togg", "T10X");

        Audi audi = new Audi();
        audi.markaModelYaz("Audi", "A6");

        Toyota toyota = new Toyota();
        toyota.markaModelYaz("Toyota", "Corolla");
    }
}
