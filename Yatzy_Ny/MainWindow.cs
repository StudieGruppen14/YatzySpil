using System;
using Gtk;

public partial class MainWindow : Gtk.Window
{
    Bæger bæger; //Dette sker når vi starter spil
    int SpillerNr;
    YatzySpiller spiller;
    int AntalSlagTilbage = 3; //Hver spiller har 3 slag pr. runde

    public YatzySpiller Spiller1; // Her definerer vi, at vi har 3 spillere, der kan spille med
    public YatzySpiller Spiller2;
    public YatzySpiller Spiller3;

    public MainWindow() : base(Gtk.WindowType.Toplevel)
    {
        Build(); //Automatisk kommet - bygger GUI op

        //Her begynder festen
        bæger = new Bæger(new global::Gtk.Entry[] { Terning1, Terning2, Terning3, Terning4, Terning5 },
                          new global::Gtk.CheckButton[] { HoldTerning1, HoldTerning2, HoldTerning3, HoldTerning4, HoldTerning5 }); 
        //Vi bruger to lister til at adskille tekstfelterne og Hold-boksene

        Spiller1 = new YatzySpiller(NavnSpiller1, 
                                    enereSpiller1, 
                                    toereSpiller1, 
                                    treensSpiller1, 
                                    fireensSpiller1, 
                                    femmereSpiller1, 
                                    seksereSpiller1, 
                                    DelSumSpiller1, 
                                    BonusSpiller1,
                                    etparSpiller1,
                                    toparSpiller1, 
                                    treensSpiller1, 
                                    fireensSpiller1, 
                                    LilleSpiller1, 
                                    StorSpiller1, 
                                    HusSpiller1, 
                                    ChancenSpiller1, 
                                    YatzySpiller1, 
                                    SumSpiller1); //Vi kobler spillerne på felterne. Felterne er variabler (indeholder data)

        Spiller2 = new YatzySpiller(NavnSpiller2,
                                    enereSpiller2,
                                    toereSpiller2,
                                    treensSpiller2,
                                    fireensSpiller2,
                                    femmereSpiller2,
                                    seksereSpiller2,
                                    DelSumSpiller2,
                                    BonusSpiller2,
                                    etparSpiller2,
                                    toparSpiller2,
                                    treensSpiller2,
                                    fireensSpiller2,
                                    LilleSpiller2,
                                    StorSpiller2,
                                    HusSpiller2,
                                    ChancenSpiller2,
                                    YatzySpiller2,
                                    SumSpiller2); //Det samme

        Spiller3 = new YatzySpiller(NavnSpiller3,
                                    enereSpiller3,
                                    toereSpiller3,
                                    treensSpiller3,
                                    fireensSpiller3,
                                    femmereSpiller3,
                                    seksereSpiller3,
                                    DelSumSpiller3,
                                    BonusSpiller3,
                                    etparSpiller3,
                                    toparSpiller3,
                                    treensSpiller3,
                                    fireensSpiller3,
                                    LilleSpiller3,
                                    StorSpiller3,
                                    HusSpiller3,
                                    ChancenSpiller3,
                                    YatzySpiller3,
                                    SumSpiller3); //Det samme

        setSpiller(1); // Spiller 1 er den første spiller
    }

    protected void OnKastTerningKnapClicked(object sender, EventArgs e)
    {
        if (AntalSlagTilbage > 0) { //Hvis den er >0, kan vi kaste igen
            bæger.RystBæger(); //Vi kalder metode (RystBæger), som kaster terningerne
            OpdaterMuligheder(Streg.Active); //Vi kalder metoden, der opdaterer Combo-boksens muligheden, hver gang vi kaster terningen
            AntalKastTilbage.Text = (--AntalSlagTilbage).ToString(); //Vi trækker -1 slag tilbage fra, hver gang terningen kastes
            setSpiller(SpillerNr); // Metoden sikrer, at spillernavnet bliver sat, hver gang vi kaster terningen
        }
    }

    public void OpdaterMuligheder(bool visAlle) //
    {
        // 15 == max antal linjer
        for (int i = 0; i < 15; i++) //for-løkken nulstiller combo-boksen. i = en tæller. i sættes til 0 + hvis i er under 15, skal vi køre videre + i plus 1 (indtil vi når til 15
        {
            mulighederCombo2.RemoveText(0);
        }

        // Se om vi har slået med terning. Vi kører først if-sætningen, hvis terning ikke = 0
        if (Terning1.Text != "")
        {
            if ((spiller.enere.Text == "") && (bæger.Point1ere() > 0 || visAlle)) { mulighederCombo2.AppendText("1'ere"); } // Hvis tekstfeltet er tomt (1erne ikke allerede er valgt) og muligheden er tilstede (>0) eller (||) vi skal viseAlle (til streg), skal den vise muligheden i combo-boksen
            if ((spiller.toere.Text == "") && (bæger.Point2ere() > 0 || visAlle)) { mulighederCombo2.AppendText("2'ere"); }
            if ((spiller.treere.Text == "") && (bæger.Point3ere() > 0 || visAlle)) { mulighederCombo2.AppendText("3'ere"); }
            if ((spiller.fireere.Text == "") && (bæger.Point4ere() > 0 || visAlle)) { mulighederCombo2.AppendText("4'ere"); }
            if ((spiller.femmere.Text == "") && (bæger.Point5ere() > 0 || visAlle)) { mulighederCombo2.AppendText("5'ere"); }
            if ((spiller.seksere.Text == "") && (bæger.Point6ere() > 0 || visAlle)) { mulighederCombo2.AppendText("6'ere"); }
            if ((spiller.etpar.Text == "") && (bæger.Point1par() > 0 || visAlle)) { mulighederCombo2.AppendText("1 Par"); }
            if ((spiller.topar.Text == "") && (bæger.Point2par() > 0 || visAlle)) { mulighederCombo2.AppendText("2 Par"); }
            if ((spiller.treens.Text == "") && (bæger.Point3ens() > 0 || visAlle)) { mulighederCombo2.AppendText("3 Ens"); }
            if ((spiller.fireens.Text == "") && (bæger.Point4ens() > 0 || visAlle)) { mulighederCombo2.AppendText("4 Ens"); }
            if ((spiller.Lille.Text == "") && (bæger.PointLille() > 0 || visAlle)) { mulighederCombo2.AppendText("Lille Straight"); }
            if ((spiller.Stor.Text == "") && (bæger.PointStor() > 0 || visAlle)) { mulighederCombo2.AppendText("Stor Straight"); }
            if ((spiller.Hus.Text == "") && (bæger.PointHus() > 0 || visAlle)) { mulighederCombo2.AppendText("Fuldt Hus"); }
            if ((spiller.Chancen.Text == "") && (bæger.PointChancen() > 0 || visAlle)) { mulighederCombo2.AppendText("Chancen"); }
            if ((spiller.Yatzy.Text == "") && (bæger.PointYatzy() > 0 || visAlle)) { mulighederCombo2.AppendText("Yatzy"); }
        }
    } // || = eller

    public void NæsteTur() //Metode der afgør, hvem der spiller nu
    {
        if (SpillerNr == 3) { //Hvis spillerNr. 3 spiller, skal spiller 1 spille næste gang
            setSpiller(1);
        } else {
            setSpiller(SpillerNr + 1); //Spillernr. +1 hvergang, medmindre der kun er 1 spiller:
        }

        if (SpillerNr == 2 && NavnSpiller2.Text == "") // hvis navnefelt 2 ikke er fyldt skifter den til spiller 1
        {
            setSpiller(1);
        } 
        else if (SpillerNr == 3 && NavnSpiller3.Text == "") // hvis navnefelt 3 ikke er fyldt skifter den til spiller 1
        {
            setSpiller(1);
        }

        AntalSlagTilbage = 3; //*Hver spiller har 3 slag. AntalKastTilbage = variabel, der peger på et objekt (vores entry), som har en proporty .Text som sættes til AntalSlagTilbage 
        AntalKastTilbage.Text = AntalSlagTilbage.ToString(); //Antal slag tilbage skal laves til string og sættes i tekstboksen
        bæger.NulstilAlleTerninger(); //metode, der gør at alle terningerne og holdknapper nulstilles
    }

    void setSpiller(int spillerNr) {
        this.SpillerNr = spillerNr; //this peger på objektet selv, som har en variabel ved navn SpillerNr. Ved at bruge this, kan man skelne mellem variabel i objektet og metodens argument ved samme navn

        //Swich er anden form for if; sætter en værdi
        switch (SpillerNr) {
            case 1: //Hvis spillerNr. = 1, gør vi det under case 1 - ellers går vi videre til case 2
                spiller = Spiller1;
                break;
            case 2:
                spiller = Spiller2;
                break;
            case 3:
                spiller = Spiller3;
                break; //Stopper swich, så den ikke hopper videre til næste case
        }

        TurSpillerNavn.Text = spiller.Navn.Text; //Vises i vores SpillerNavn.Entry
    }

    protected void OnStartSpilKnapClicked(object sender, EventArgs e) //når vi trykker på start, ryder vi:
    {
        Spiller1.Ryd(); //spiller-felter ryddes
        Spiller2.Ryd();
        Spiller3.Ryd();

        bæger.NulstilAlleTerninger(); //Vi kalder metoden, der nulstiller alle terningerne 

        TurSpillerNavn.Text = ""; //SpillerNavn ryddes

        AntalSlagTilbage = 3; //Første spiller har 3 slag
        AntalKastTilbage.Text = ""; //Vises tom, når spiller ikke er startet endnu
        setSpiller(1); //spiller 1 starter

        OpdaterMuligheder(Streg.Active);
    }

    protected void OnGemClicked(object sender, EventArgs e) //Gem-knappen
    {
        string valgt = mulighederCombo2.ActiveText; //Når vi har "valgt" en tekst/mulighed i combo-boksen:

        if (string.IsNullOrEmpty(valgt) == false) { //Hvis der ikke er valgt noget, kan vi ikke gemme
            if (Streg.Active) //bliver kun gældende, hvis første "if" gælder. Hvis vi klikker i "streg"
            {
                spiller.SetStreg(valgt); //Hvis vi vælger i "streg", streges det valgte
            }
            else
            {
                spiller.GivPoint(valgt, bæger); //Hvis vi vælger i "muligheder", føres point over
            }
            NæsteTur(); //èn af de to vælges - og derefter er det næstes tur
        }
    }

    protected void OnStregToggled(object sender, EventArgs e) //Her vælger vi mellem "Streg" og "Muligheder". Kører når der vælges imellem de to. Bestemmer combo-boksens indhold
    {
        OpdaterMuligheder(Streg.Active); 
    }
}