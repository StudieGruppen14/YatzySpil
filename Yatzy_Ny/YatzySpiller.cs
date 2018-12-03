using System;
public class YatzySpiller
{
    Gtk.Entry Navn;
    Gtk.Entry enere;
    Gtk.Entry toere;
    Gtk.Entry treere;
    Gtk.Entry fireere;
    Gtk.Entry femmere;
    Gtk.Entry seksere;
    Gtk.Entry DelSum;
    Gtk.Entry Bonus;
    Gtk.Entry topar;
    Gtk.Entry treens;
    Gtk.Entry fireens;
    Gtk.Entry Lille;
    Gtk.Entry Stor;
    Gtk.Entry Hus;
    Gtk.Entry Chancen;
    Gtk.Entry Yatzy;
    Gtk.Entry Sum;

    public YatzySpiller(Gtk.Entry Navn,
                        Gtk.Entry enere,
                        Gtk.Entry toere,
                        Gtk.Entry treere,
                        Gtk.Entry fireere,
                        Gtk.Entry femmere,
                        Gtk.Entry seksere,
                        Gtk.Entry DelSum,
                        Gtk.Entry Bonus,
                        Gtk.Entry topar,
                        Gtk.Entry treens,
                        Gtk.Entry fireens,
                        Gtk.Entry Lille,
                        Gtk.Entry Stor,
                        Gtk.Entry Hus,
                        Gtk.Entry Chancen,
                        Gtk.Entry Yatzy,
                        Gtk.Entry Sum
                       ) {
        this.Navn = Navn;
        this.enere = enere;
        this.toere = toere;
        this.treere = treere;
        this.fireere = fireere;
        this.femmere = femmere;
        this.seksere = seksere;
        this.DelSum = DelSum;
        this.Bonus = Bonus;
        this.topar = topar;
        this.treens = treens;
        this.fireens = fireens;
        this.Lille = Lille;
        this.Stor = Stor;
        this.Hus = Hus;
        this.Chancen = Chancen;
        this.Yatzy = Yatzy;
        this.Sum = Sum;
    }

    public void Ryd() {
        Navn.Text = "";
        enere.Text = "";
        toere.Text = "";
        treere.Text = "";
        fireere.Text = "";
        femmere.Text = "";
        seksere.Text = "";
        DelSum.Text = "";
        Bonus.Text = "";
        topar.Text = "";
        treens.Text = "";
        fireens.Text = "";
        Lille.Text = "";
        Stor.Text = "";
        Hus.Text = "";
        Chancen.Text = "";
        Yatzy.Text = "";
        Sum.Text = "";
    }
}
