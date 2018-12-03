using System;
using Gtk;

class MainClass //denne klasse laves helt automatisk, når vi opretter et projekt - når spillet starter
{
    public static void Main(string[] args) 
    {
          Application.Init(); 
         MainWindow win = new MainWindow();
         win.Show();
         Application.Run(); //
       
       
    }
}
