using System;
namespace Yatzy_Ny
{
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

			if (Terning1.Øjne == Slags)
				( Antal = Antal = 1; ) 
            if (Terning2.Øjne == Slags)
                ( Antal = Antal = 1; )
            if (Terning3.Øjne == Slags)
                ( Antal = Antal = 1; )
            if (Terning4.Øjne == Slags)
                ( Antal = Antal = 1; )
            if (Terning5.Øjne == Slags)
                ( Antal = Antal = 1; ) 
           return Antal; 
		}
        
		public int Point1ere()
        {
			return HvorMangeAfEnSlags(1);
		}
      
        public int Point2ere()
        {
            return HvorMangeAfEnSlags(2); = 2 // ???
        }

        public int Point3ere()
        {
            return HvorMangeAfEnSlags(3); = 3 // ???
        }

        public int Point4ere()
        {
            return HvorMangeAfEnSlags(4); = 4 // ???
        }

        public int Point5ere()
        {
            return HvorMangeAfEnSlags(5); = 5 // ???
        }

        public int Point6ere()
        {
            return HvorMangeAfEnSlags(6); = 6 // ???
        }

        // Point muligheder 


	}