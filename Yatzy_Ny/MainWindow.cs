using System;
using Gtk;

public partial class MainWindow : Gtk.Window
{
    Bæger bæger = new Bæger();

    public MainWindow() : base(Gtk.WindowType.Toplevel)
    {
        Build();
    }

    protected void OnDeleteEvent(object sender, DeleteEventArgs a)
    {
        Application.Quit();
        a.RetVal = true;
    }

    protected void OnKastTerningKnapClicked(object sender, EventArgs e)
    {
        bæger.Terning1.HoldTerning(HoldTerning1.Active);
        bæger.Terning2.HoldTerning(HoldTerning2.Active);
        bæger.Terning3.HoldTerning(HoldTerning3.Active);
        bæger.Terning4.HoldTerning(HoldTerning4.Active);
        bæger.Terning5.HoldTerning(HoldTerning5.Active); // fordi check boksen er active 

        bæger.RystBæger();
        Terning1.Text = bæger.Terning1.AntalØjne.ToString();
        Terning2.Text = bæger.Terning2.AntalØjne.ToString();
        Terning3.Text = bæger.Terning3.AntalØjne.ToString();
        Terning4.Text = bæger.Terning4.AntalØjne.ToString();
        Terning5.Text = bæger.Terning5.AntalØjne.ToString();


        mulighederCombo.AppendText(bæger.Point1ere().ToString()); // skal bruges til at flytte point resultat til muligheder 

    }
}


