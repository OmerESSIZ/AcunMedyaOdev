using System;


public class Araba
{
    public string marka = " ";
    public string model = " ";
    public int kapiSayisi;
    public int pencereSayisi;

    public void git(string marka, string model)
    {
        Console.WriteLine(marka + " " + model + " gidiyor...");
    }
}
