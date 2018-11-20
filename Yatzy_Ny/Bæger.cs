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

    // HVOR MANGE AF EN SLAGS (1-6)

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

    // ET PAR 

    public int Point1par()
    {
        for (int i = 6; i >= 1; --i)
        {
            if (HvorMangeAfEnSlags(i) > 1)
            { return HvorMangeAfEnSlags(i) * 2; }
        }
        return 0;
    }

    // TO PAR 

    public int Point2par()
    {
        int FørstePar = 0;
        int AndetPar = 0;

        for (int i = 6; i >= 1; --i)
        {
            if (HvorMangeAfEnSlags(i) > 1)
            {
                if (FørstePar == 0)
                {
                    FørstePar = HvorMangeAfEnSlags(i) * 2;
                }
                else
                {
                    AndetPar = HvorMangeAfEnSlags(i) * 2;
                    return FørstePar + AndetPar;
                }
            }

        }
        return 0;

    }

    // 3 ENS 

    public int Point3ens()
    {
        for (int i = 6; i >= 1; --i)
        {
            if (HvorMangeAfEnSlags(i) > 2)
            { return HvorMangeAfEnSlags(i) * 3; }
        }
        return 0;
    }

    // 4 ENS 

    public int Point4ens()
    {
        for (int i = 6; i >= 1; --i)
        {
            if (HvorMangeAfEnSlags(i) > 3)
            { return HvorMangeAfEnSlags(i) * 4; }
        }
        return 0;
    }

    // LILLE 

    public int PointLille()

    {
        if (HvorMangeAfEnSlags(1) == 1 && HvorMangeAfEnSlags(1) == 2 && HvorMangeAfEnSlags(1) == 3 && HvorMangeAfEnSlags(1) == 4 && HvorMangeAfEnSlags(1) == 5)
            return 15;

        else

            return 0;
        }


    // STOR 


    // HUS

    public int PointHus()
    {
        int FørstePar = 0;
        int TreEns = 0;

        for (int i = 6; i >= 1; --i)
        {
            if (HvorMangeAfEnSlags(i) == 2)
            {
                if (TreEns == 0)
                {
                    FørstePar = i * 2;
                }
                else
                    return TreEns + i * 2;

                if (HvorMangeAfEnSlags(i) == 3)
                {
                    if (FørstePar == 0)
                    {
                        TreEns = i * 3;
                    }
                    else
                        return FørstePar + i * 3;
                }
            }
        }
        return 0;

    }

    // CHANCEN 




    // YATZY 

    public int PointYatzy()
    {
        for (int i = 6; i >= 1; --i)
        {
            if (HvorMangeAfEnSlags(i) > 4)
            { return HvorMangeAfEnSlags(i) * 5; }
        }
        return 0;
    }

}