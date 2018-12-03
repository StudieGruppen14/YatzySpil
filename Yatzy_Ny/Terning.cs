using System;

public class Terning
{
    private int Øjne;
    private static Random r = new Random(); // static = det betyder at der er én random generator
    private global::Gtk.Entry entry;
    private global::Gtk.CheckButton checkButton;

    public Terning(global::Gtk.Entry entry, global::Gtk.CheckButton checkButton)
    {
        this.entry = entry;
        this.checkButton = checkButton;
    }

    public void KastTerning()
    {
        if (checkButton.Active == false)
        {
            Øjne = r.Next(1, 7);
            entry.Text = Øjne.ToString();
        }
    }
    public void HoldTerning(Boolean Hold)
    {
        checkButton.Active = Hold;
    }

    public int AntalØjne
    {
        get { return Øjne; } // gør at man ikke kan ændre på terningens værdi i spillet
    }
}
