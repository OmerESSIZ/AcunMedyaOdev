using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Bmw : Araba
{
    public void markaModelYaz(string marka, string model)
    {
        Console.WriteLine(marka + " " + model + " düz viteslidir.");
    }
}

public class Porsche : Araba
{
    public void markaModelYaz(string marka, string model)
    {
        Console.WriteLine(marka + " " + model + " otomatik viteslidir.");
    }
}
public class Mercedes : Araba
{
    public void markaModelYaz(string marka, string model)
    {
        Console.WriteLine(marka + " " + model + " yarı otomatik viteslidir.");
    }
}

public class Togg : Araba
{
    public void markaModelYaz(string marka, string model)
    {
        Console.WriteLine(marka + " " + model + " elektriklidir.");
    }
}

public class Audi : Araba
{
    public void markaModelYaz(string marka, string model)
    {
        Console.WriteLine(marka + " " + model + " otomatik viteslidir.");
    }
}

public class Toyota : Araba
{
    public void markaModelYaz(string marka, string model)
    {
        Console.WriteLine(marka + " " + model + " hibrit viteslidir.");
    }
}
