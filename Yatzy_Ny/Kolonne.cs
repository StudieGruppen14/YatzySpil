using System;
namespace Yatzy
{
    public class Kolonne // Skal ligge point over i felterne fra Combobox (indeholder også SUM og bonus)
    {
        public PointFelt ettere = new PointFelt();
        public PointFelt Toere = new PointFelt();
        public PointFelt Treere = new PointFelt();
        public PointFelt Firere = new PointFelt();
        public PointFelt Femmere = new PointFelt();
        public PointFelt Seksere = new PointFelt();

        public int SimpelSum

        {
            get { return (ettere.Point + Toere.Point + Treere.Point + Firere.Point + Femmere.Point + Seksere.Point); }
        }

        public int Bonus
        {
            get
            {
                if (SimpelSum >= 63)
                { return 50; }
                else
                { return 0; }
            }
        }
    }
}

