using System;
using Gtk;

namespace KPI
{
    public partial class StartupWindow : Gtk.Window
    {
        public StartupWindow() : base(Gtk.WindowType.Toplevel)
        {
            Build();
            labelAppNameFull.Markup = "<span font='30' weight='bold'>" + Version.AppNameFull + "</span>";
            labelAuthor.Text = Version.Author;
        }

        public string Status {
            set {
                labelStatus.Text = value;
            }
        }

        public int Percent {
            set {
                labelStatus.Text = "Loading... " + value.ToString() + "%";
            }
        }
    }
}

