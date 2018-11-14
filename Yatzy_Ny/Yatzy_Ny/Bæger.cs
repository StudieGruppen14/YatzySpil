using System;

public class Bæger
{
    public Terning Terning1 = new Terning();
    public Terning Terning2 = new Terning();
    public Terning Terning3 = new Terning();
    public Terning Terning4 = new Terning();
    public Terning Terning5 = new Terning();

    public void RystBæger()
    {
        Terning1.KastTerning();
        Terning2.KastTerning();
        Terning3.KastTerning();
        Terning4.KastTerning();
        Terning5.KastTerning();
    }

    private int HvorMangeAfEnSlags(int Slags)
    {
        int Antal = 0;

        if (Terning1.AntalØjne == Slags)
        { Antal++; }
        if (Terning2.AntalØjne == Slags)
        { Antal++; }
        if (Terning3.AntalØjne == Slags)
        { Antal++; }
        if (Terning4.AntalØjne == Slags)
        { Antal++; }
        if (Terning5.AntalØjne == Slags) // ++ betyder at antal = antal plus 1
        { Antal++; }
        return Antal;
    }

    public int Point1ere()
    {
        return HvorMangeAfEnSlags(1);
    }

    public int Point2ere()
    {
        return HvorMangeAfEnSlags(2);
    }

    public int Point3ere()
    {
        return HvorMangeAfEnSlags(3);
    }

    public int Point4ere()
    {
        return HvorMangeAfEnSlags(4);
    }

    public int Point5ere()
    {
        return HvorMangeAfEnSlags(5);
    }

    public int Point6ere()
    {
        return HvorMangeAfEnSlags(6);
    }

    // Point muligheder 

}
