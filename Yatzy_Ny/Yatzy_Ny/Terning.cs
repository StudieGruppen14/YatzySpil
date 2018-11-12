using System;
namespace Yatzy_Ny
{
    internal class Terning
    {
        private int AntalØjne;
        private static Random r = new Random();
        private Boolean HoldMig = false;

        public int Øjne
        {
            get ( return AntalØjne; )

        }

    public Boolean Holdt
    {
        get ( return HoldMig; )
        }

        public void KastTerning()
    {
        if (HoldMig == false)
        { AntalØjne = r.Next(1, 7); }
    }

    public void HoldTerning()
    {
        HoldMig = true;
    }

    public void TagTerningMed()
    {
        HoldMig = false;
    }
}
}
