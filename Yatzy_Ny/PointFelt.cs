using System;
namespace Yatzy
{
    public class PointFelt
    {
            private Boolean ErStreget = false;
            private int AntalPoint = 0; 

            public Boolean Streg 
            {
                get { return ErStreget;  }
                set { ErStreget = value; } // hvorfor skriver man value her og ikke true?
            }

            public int Point 
            {
                get { return AntalPoint; }
                set { AntalPoint = value; }
            }
            
        }
    }
