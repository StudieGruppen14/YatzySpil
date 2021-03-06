﻿using System;

public class Bæger //et bærger har 5 terninger
{
    public Terning Terning1;
    public Terning Terning2;
    public Terning Terning3;
    public Terning Terning4;
    public Terning Terning5;

    public Bæger(Gtk.Entry[] entries, Gtk.CheckButton[] checkButtons)
    {
        Terning1 = new Terning(entries[0], checkButtons[0]); //hver terning har en entry og en Hold-knap. Vi kalder contructoren fra Terning-klassen
        Terning2 = new Terning(entries[1], checkButtons[1]);
        Terning3 = new Terning(entries[2], checkButtons[2]);
        Terning4 = new Terning(entries[3], checkButtons[3]);
        Terning5 = new Terning(entries[4], checkButtons[4]);
    }

    public void RystBæger() //metode der ryster bæger/kaster terninger
    {
        Terning1.KastTerning();
        Terning2.KastTerning();
        Terning3.KastTerning();
        Terning4.KastTerning();
        Terning5.KastTerning();
    }

    public void NulstilAlleTerninger() //Metode, der nulstiller terningerne
    {  
        Terning1.Nulstil();
        Terning2.Nulstil();
        Terning3.Nulstil();
        Terning4.Nulstil();
        Terning5.Nulstil();
    }

    private int HvorMangeAfEnSlags(int Slags) //Metode, der bruges til flere ting: hvor mange terninger har vi af hver slags
    {
        int Antal = 0; // Hvis ikke andet, så er den 0 i starten

        if (Terning1.AntalØjne == Slags) //Hvis terning 1s antal øjne er den slags, vi leder efter = tæller vi én op af den slags, vi har (++)
        { Antal++; }
        if (Terning2.AntalØjne == Slags)
        { Antal++; }
        if (Terning3.AntalØjne == Slags)
        { Antal++; }
        if (Terning4.AntalØjne == Slags)
        { Antal++; }
        if (Terning5.AntalØjne == Slags) // ++ betyder at antal = antal plus 1
        { Antal++; }

        return Antal; // vi returnerer det antal vi har
    }

    // HVOR MANGE AF EN SLAGS (1-6)

    public int Point1ere()
    {
        return HvorMangeAfEnSlags(1) * 1; 
    }

    public int Point2ere()
    {
        return HvorMangeAfEnSlags(2) * 2;
    }

    public int Point3ere()
    {
        return HvorMangeAfEnSlags(3) * 3;
    }

    public int Point4ere()
    {
        return HvorMangeAfEnSlags(4) * 4;
    }

    public int Point5ere()
    {
        return HvorMangeAfEnSlags(5) * 5;
    }

    public int Point6ere()
    {
        return HvorMangeAfEnSlags(6) * 6; //Vi ganger med tallet for at returnere antal point
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
        for (int i = 6; i >= 1; --i) //*for-lykken kan vendes om, så man tæller op fra 1 i stedet for tæller ned fra 6
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
        if (HvorMangeAfEnSlags(1) == 1 && HvorMangeAfEnSlags(2) == 1 && HvorMangeAfEnSlags(3) == 1 && HvorMangeAfEnSlags(4) == 1 && HvorMangeAfEnSlags(5) == 1)
            return 15;
        else
            return 0;
    }


    // STOR 

    public int PointStor()

    {
        if (HvorMangeAfEnSlags(2) == 1 && HvorMangeAfEnSlags(3) == 1 && HvorMangeAfEnSlags(4) == 1 && HvorMangeAfEnSlags(5) == 1 && HvorMangeAfEnSlags(6) == 1)
            return 20;

        else

            return 0;
    }

    // HUS

    public int PointHus()     {
        int EtPar = 0;
        int TreEns = 0;

        for (int i = 6; i >= 1; --i)
        {
            if (HvorMangeAfEnSlags(i) == 3)
            {
                TreEns = i * 3;
            }
            else if (HvorMangeAfEnSlags(i) == 2)
            {
                EtPar = i * 2;
            }
            if (EtPar != 0 && TreEns != 0)
            {
                return EtPar + TreEns;
            }
        }
        return 0;
    }

   // CHANCEN 

    public int PointChancen()
    {
        return Terning1.AntalØjne + Terning2.AntalØjne + Terning3.AntalØjne + Terning4.AntalØjne + Terning5.AntalØjne;
    }


    // YATZY 

    public int PointYatzy()
    {
        for (int i = 6; i >= 1; --i)
        {
            if (HvorMangeAfEnSlags(i) == 5)
            {
                return 50;
            }
        }
        return 0;
    }
}
