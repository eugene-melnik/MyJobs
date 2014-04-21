using System;
using Gtk;

namespace KPI
{
    public partial class PreferencesWindow : Gtk.Window
    {
        public PreferencesWindow(Gtk.Window parent) : base(Gtk.WindowType.Toplevel)
        {
            Build();
            TransientFor = parent;
        }
    }
}

