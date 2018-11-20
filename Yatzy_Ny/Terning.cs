using System;

public class Terning
{
    private int Øjne;
    private static Random r = new Random(); // static = det betyder at der er én random generator
    private Boolean HoldMig = false;

    public Terning()
    {
        KastTerning();
    }

    public void KastTerning()
    {
        if (HoldMig == false)
        {
            Øjne = r.Next(1, 7);
        }
    }
    public void HoldTerning(Boolean Hold)
    {
        HoldMig = Hold;
    }

    public int AntalØjne
    {
        get { return Øjne; } // gør at man ikke kan ændre på terningens værdi i spillet
    }
}
