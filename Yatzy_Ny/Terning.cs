using System;

public class Terning //Det understående, som terningen indeholder = variabler
{
    private int Øjne; //En terning indeholder øjne
    private static Random random = new Random(); // static = det betyder at der er én random generator, der kaster terningerne
    private Gtk.Entry entry; //En terning har en entry
    private Gtk.CheckButton checkButton; //en terning har en Hold-knap

    public Terning(Gtk.Entry entry, Gtk.CheckButton checkButton) //en contructor, som kaldes hver gang, der oprettes en terning. Den sikrer, at vi har understående 2 ting. Contructoren har samme navn som klassen og har ingen returtype f.eks int
    {
        this.entry = entry; //Vi skal kunne vise antal øjne
        this.checkButton = checkButton; //Vi skal kunne holde en terning
    }

    public void KastTerning() //Vores metode, der kaster terningen
    {
        if (checkButton.Active == false) //Hvis vi ikke har holdt terningen
        {
            Øjne = random.Next(1, 7); //så sættes øjnene til et random tal mellem 1 og 6
            entry.Text = Øjne.ToString(); //Tal fra øjne laves til en string, så den kan vises i GUI
        }
    }
    public void HoldTerning(Boolean Hold) 
    {
        checkButton.Active = Hold; //Hvis vi har holdt terningen, skal den ikke skifte øjne på terningen
    }

    public int AntalØjne //AntalØjne er en proporty - kan ses fordi der står "get"
    {
        get { return Øjne; } // pga "get" kan man ændre på terningens værdi i spillet
    }

    public void Nulstil() //Metode der nulstiller alle terningerne, så den ryddes til næste spillers tur
    { 
        HoldTerning(false);
        Øjne = 0;
        entry.Text = ""; //teksten vises tom, fordi i realiteten kan terningen ikke være 0
    }
}
