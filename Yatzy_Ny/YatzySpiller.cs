using System;
public class YatzySpiller
{
    int delSum = 0; //delsum starter ved 0
    int sum = 0; //summen starter ved 0
    bool bonusErGivet = false; //bonus er ikke givet fra start

    public Gtk.Entry Navn;
    public Gtk.Entry enere;
    public Gtk.Entry toere;
    public Gtk.Entry treere;
    public Gtk.Entry fireere;
    public Gtk.Entry femmere;
    public Gtk.Entry seksere;
    public Gtk.Entry DelSum;
    public Gtk.Entry Bonus;
    public Gtk.Entry etpar;
    public Gtk.Entry topar;
    public Gtk.Entry treens;
    public Gtk.Entry fireens;
    public Gtk.Entry Lille;
    public Gtk.Entry Stor;
    public Gtk.Entry Hus;
    public Gtk.Entry Chancen;
    public Gtk.Entry Yatzy;
    public Gtk.Entry Sum; // her fortælles hvad en spiller har af pointfelter. Nedenunder sættes de til noget af contructoren.

    public YatzySpiller(Gtk.Entry Navn, // en contructor, der hedder det samme som klassen + ikke har en returtype. En Yatzyspiller vil altså ALTID indeholde nedenstående felter (det bestemmer contructoren)
                        Gtk.Entry enere,
                        Gtk.Entry toere,
                        Gtk.Entry treere,
                        Gtk.Entry fireere,
                        Gtk.Entry femmere,
                        Gtk.Entry seksere,
                        Gtk.Entry DelSum,
                        Gtk.Entry Bonus,
                        Gtk.Entry etpar,
                        Gtk.Entry topar,
                        Gtk.Entry treens,
                        Gtk.Entry fireens,
                        Gtk.Entry Lille,
                        Gtk.Entry Stor,
                        Gtk.Entry Hus,
                        Gtk.Entry Chancen,
                        Gtk.Entry Yatzy,
                        Gtk.Entry Sum //argumenter til contructoren
                       ) 
    {
        this.Navn = Navn; //argumenterne fra contructoren sættes til variabler
        this.enere = enere;
        this.toere = toere;
        this.treere = treere;
        this.fireere = fireere;
        this.femmere = femmere;
        this.seksere = seksere;
        this.DelSum = DelSum;
        this.Bonus = Bonus;
        this.etpar = etpar;
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

    public void Ryd() //Variablerne sættes til tomt, når der ryddes (ved nyt spil)
    {
        sum = 0;
        delSum = 0;
        Navn.Text = "";
        enere.Text = "";
        toere.Text = "";
        treere.Text = "";
        fireere.Text = "";
        femmere.Text = "";
        seksere.Text = "";
        DelSum.Text = "";
        Bonus.Text = "";
        etpar.Text = "";
        topar.Text = "";
        treens.Text = "";
        fireens.Text = "";
        Lille.Text = "";
        Stor.Text = "";
        Hus.Text = "";
        Chancen.Text = "";
        Yatzy.Text = "";
        bonusErGivet = false;
        Sum.Text = "";
    }

    public String OpdaterSum(int værdi) //Her opdaterer vi sum
    {
        sum += værdi; //sum + værdien vi lige har fået
        Sum.Text = sum.ToString(); //værdien sættes til string, så vi kan se det i GUI

        // Bonus regel check
        if (delSum >= 63 && bonusErGivet == false) //hvis delsum>= 63 og bonus ikke er givet endnu:
        {
            sum += 50; //sum plus 50
            Bonus.Text = "50"; //50 vises i pointfelt
            bonusErGivet = true; //nu er bonus givet 
        }

        return værdi.ToString();
    }

    public String OpdaterDelSum(int værdi) //Her opdaterer vi delsummen
    {
        delSum += værdi; //delsummen + den værdi vi lige har fået
        DelSum.Text = delSum.ToString(); //værdien sættes til string, så vi kan se det i pointfeltet
        OpdaterSum(værdi); //den samlede sum opdateres

        return værdi.ToString(); //værdien vises laves til string, så den kan vises i GUI
    }

    public void GivPoint(string mulighed, Bæger bæger) //Tager teksten fra combo-boksen og laver den om til bægerets antal øjne
    {
        switch (mulighed)
        {
            case "1'ere":
                enere.Text = OpdaterDelSum(bæger.Point1ere()); //delsummen opdateres hver gang point1'erne sættes
                break;
            case "2'ere":
                toere.Text = OpdaterDelSum(bæger.Point2ere());
                break;
            case "3'ere":
                treere.Text = OpdaterDelSum(bæger.Point3ere());
                break;
            case "4'ere":
                fireere.Text = OpdaterDelSum(bæger.Point4ere());
                break;
            case "5'ere":
                femmere.Text = OpdaterDelSum(bæger.Point5ere());
                break;
            case "6'ere":
                seksere.Text = OpdaterDelSum(bæger.Point6ere());
                break;
            case "1 Par":
                etpar.Text = OpdaterSum(bæger.Point1par());
                break;
            case "2 Par":
                topar.Text = OpdaterSum(bæger.Point2par());
                break;
            case "3 Ens":
                treens.Text = OpdaterSum(bæger.Point3ens());
                break;
            case "4 Ens":
                fireens.Text = OpdaterSum(bæger.Point4ens());
                break;
            case "Lille Straight":
                Lille.Text = OpdaterSum(bæger.PointLille());
                break;
            case "Stor Straight":
                Stor.Text = OpdaterSum(bæger.PointStor());
                break;
            case "Fuldt Hus":
                Hus.Text = OpdaterSum(bæger.PointHus());
                break;
            case "Chancen":
                Chancen.Text = OpdaterSum(bæger.PointChancen());
                break;
            case "Yatzy":
                Yatzy.Text = OpdaterSum(bæger.PointYatzy());
                break;
        }
    }

    public void SetStreg(string mulighed) //Her streger vi
    {
        switch (mulighed)
        {
            case "1'ere": //når vi vælger 1erne i combo-boksen, vises 0 i pointfeltet
                enere.Text = 0.ToString();
                break;
            case "2'ere":
                toere.Text = 0.ToString();
                break;
            case "3'ere":
                treere.Text = 0.ToString();
                break;
            case "4'ere":
                fireere.Text = 0.ToString();
                break;
            case "5'ere":
                femmere.Text = 0.ToString();
                break;
            case "6'ere":
                seksere.Text = 0.ToString();
                break;
            case "1 Par":
                etpar.Text = 0.ToString();
                break;
            case "2 Par":
                topar.Text = 0.ToString();
                break;
            case "3 Ens":
                treens.Text = 0.ToString();
                break;
            case "4 Ens":
                fireens.Text = 0.ToString();
                break;
            case "Lille Straight":
                Lille.Text = 0.ToString();
                break;
            case "Stor Straight":
                Stor.Text = 0.ToString();
                break;
            case "Fuldt Hus":
                Hus.Text = 0.ToString();
                break;
            case "Chancen":
                Chancen.Text = 0.ToString();
                break;
            case "Yatzy":
                Yatzy.Text = 0.ToString();
                break;
        }
    }
}
