using System;
using Gtk;

namespace KPI
{
	class MyJobs
	{
		public static void Main(string[] args)
        {
            //Gdk.Threads.Init();
            Gtk.Application.Init(Version.AppName, ref args);

            MainWindow mainWin = new MainWindow();
            mainWin.Hide();
            mainWin.Load();

            Gtk.Application.Run();
		}
	}
}
