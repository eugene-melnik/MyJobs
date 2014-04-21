using System;
using Gtk;

namespace KPI
{
    public partial class AboutAppWindow : Gtk.Window
    {
        public AboutAppWindow(Gtk.Window parent) : base(Gtk.WindowType.Toplevel)
        {
            this.Build();
            this.TransientFor = parent;
        }

        protected void OnKeyPressEvent(object sender, KeyPressEventArgs arg)
        {
            if (arg.Event.Key == Gdk.Key.Escape)
            {
                this.Destroy();
            }
        }
    }
}

