using System;
using Gtk;

public partial class MainWindow : Gtk.Window
{
    Bæger bæger;
    int SpillerNr = 1;
    int AntalSlagTilbage = 3;

    public YatzySpiller Spiller1; // vi skal kigge på det her - skal det være her eller over turtæller koden
    public YatzySpiller Spiller2;
    public YatzySpiller Spiller3;

    public MainWindow() : base(Gtk.WindowType.Toplevel)
    {
        Build();
        bæger = new Bæger(new global::Gtk.Entry[] { Terning1, Terning2, Terning3, Terning4, Terning5 },
                          new global::Gtk.CheckButton[] { HoldTerning1, HoldTerning2, HoldTerning3, HoldTerning4, HoldTerning5 });

        Spiller1 = new YatzySpiller(NavnSpiller1, 
                                    enereSpiller1, 
                                    toereSpiller1, 
                                    treensSpiller1, 
                                    fireensSpiller1, 
                                    femmereSpiller1, 
                                    seksereSpiller1, 
                                    DelSumSpiller1, 
                                    BonusSpiller1, 
                                    toparSpiller1, 
                                    treensSpiller1, 
                                    fireensSpiller1, 
                                    LilleSpiller1, 
                                    StorSpiller1, 
                                    HusSpiller1, 
                                    ChancenSpiller1, 
                                    YatzySpiller1, 
                                    SumSpiller1);

        Spiller2 = new YatzySpiller(NavnSpiller2,
                                    enereSpiller2,
                                    toereSpiller2,
                                    treensSpiller2,
                                    fireensSpiller2,
                                    femmereSpiller2,
                                    seksereSpiller2,
                                    DelSumSpiller2,
                                    BonusSpiller2,
                                    toparSpiller2,
                                    treensSpiller2,
                                    fireensSpiller2,
                                    LilleSpiller2,
                                    StorSpiller2,
                                    HusSpiller2,
                                    ChancenSpiller2,
                                    YatzySpiller2,
                                    SumSpiller2);

        Spiller3 = new YatzySpiller(NavnSpiller3,
                                    enereSpiller3,
                                    toereSpiller3,
                                    treensSpiller3,
                                    fireensSpiller3,
                                    femmereSpiller3,
                                    seksereSpiller3,
                                    DelSumSpiller3,
                                    BonusSpiller3,
                                    toparSpiller3,
                                    treensSpiller3,
                                    fireensSpiller3,
                                    LilleSpiller3,
                                    StorSpiller3,
                                    HusSpiller3,
                                    ChancenSpiller3,
                                    YatzySpiller3,
                                    SumSpiller3);
    }

    protected void OnDeleteEvent(object sender, DeleteEventArgs a)
    {
        Application.Quit();
        a.RetVal = true;
    }

    protected void OnKastTerningKnapClicked(object sender, EventArgs e)
    {
        if (AntalSlagTilbage > 0) {
            TurTæller();
            bæger.RystBæger();
            OpdaterMuligheder(Streg.Active);
        }
    }

    public void OpdaterMuligheder(bool visAlle)
    {
        // 15 == max antal linjer
        for (int i = 0; i < 15; i++)
        {
            mulighederCombo2.RemoveText(0);
        }

        // Se om vi har slået med terning
        if (Terning1.Text != "")
        {
            if (bæger.Point1ere() > 0 || visAlle) { mulighederCombo2.AppendText("1'ere"); } // skal bruges til at flytte point resultat til muligheder 
            if (bæger.Point2ere() > 0 || visAlle) { mulighederCombo2.AppendText("2'ere"); }
            if (bæger.Point3ere() > 0 || visAlle) { mulighederCombo2.AppendText("3'ere"); }
            if (bæger.Point4ere() > 0 || visAlle) { mulighederCombo2.AppendText("4'ere"); }
            if (bæger.Point5ere() > 0 || visAlle) { mulighederCombo2.AppendText("5'ere"); }
            if (bæger.Point6ere() > 0 || visAlle) { mulighederCombo2.AppendText("6'ere"); }
            if (bæger.Point1par() > 0 || visAlle) { mulighederCombo2.AppendText("1 Par"); }
            if (bæger.Point2par() > 0 || visAlle) { mulighederCombo2.AppendText("2 Par"); }
            if (bæger.Point3ens() > 0 || visAlle) { mulighederCombo2.AppendText("3 Ens"); }
            if (bæger.Point4ens() > 0 || visAlle) { mulighederCombo2.AppendText("4 Ens"); }
            if (bæger.PointLille() > 0 || visAlle) { mulighederCombo2.AppendText("Lille Straight"); }
            if (bæger.PointStor() > 0 || visAlle) { mulighederCombo2.AppendText("Stor Straight"); }
            if (bæger.PointHus() > 0 || visAlle) { mulighederCombo2.AppendText("Fuldt Hus"); }
            if (bæger.PointChancen() > 0 || visAlle) { mulighederCombo2.AppendText("Chancen"); }
            if (bæger.PointYatzy() > 0 || visAlle) { mulighederCombo2.AppendText("Yatzy"); }
        }
    }

    public void TurTæller()
    {
        if (AntalSlagTilbage == 0)
        {
            AntalSlagTilbage = 2;
            HoldTerning1.Active = false;
            HoldTerning2.Active = false;
            HoldTerning3.Active = false;
            HoldTerning4.Active = false;
            HoldTerning5.Active = false;

            if (SpillerNr == 3)
            { 
                SpillerNr = 1;
            }
            else {
                SpillerNr = SpillerNr + 1;
            }
        }
        else
        {
            AntalSlagTilbage = AntalSlagTilbage - 1;
        }

        AntalKastTilbage.Text = AntalSlagTilbage.ToString();

        if (SpillerNr == 2 && NavnSpiller2.Text == "") // hvis navnefelt 2 ikke er fyldt skifter den til spiller 1
        {
            SpillerNr = 1;
        }

        if (SpillerNr == 3 && NavnSpiller3.Text == "") // hvis navnefelt 3 ikke er fyldt skifter den til spiller 2
        {
            SpillerNr = 1;
        }

        if (SpillerNr == 1) // Den tager navnet og retunerer i tekstfeltet. 
        {
            TurSpillerNavn.Text = NavnSpiller1.Text;
        }

        if (SpillerNr == 2)
        {
            TurSpillerNavn.Text = NavnSpiller2.Text;
        }

        if (SpillerNr == 3)
        {
            TurSpillerNavn.Text = NavnSpiller3.Text;
        }
    }

    protected void OnStartSpilKnapClicked(object sender, EventArgs e)
    {
        Spiller1.Ryd();
        Spiller2.Ryd();
        Spiller3.Ryd();

        Terning1.Text = "";
        Terning2.Text = "";
        Terning3.Text = "";
        Terning4.Text = "";
        Terning5.Text = "";

        HoldTerning1.Active = false;
        HoldTerning2.Active = false;
        HoldTerning3.Active = false;
        HoldTerning4.Active = false;
        HoldTerning5.Active = false;

        TurSpillerNavn.Text = "";

        AntalKastTilbage.Text = "";

        OpdaterMuligheder(Streg.Active);
    }

    protected void OnGemClicked(object sender, EventArgs e)
    {
        string valgt = mulighederCombo2.ActiveText;


    }

    protected void OnStregToggled(object sender, EventArgs e)
    {
        OpdaterMuligheder(Streg.Active);
    }
}