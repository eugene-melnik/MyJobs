using System;
using Gtk;

namespace KPI
{
    public partial class CreateJobWindow : Gtk.Window
    {
        public CreateJobWindow(Gtk.Window parent) : base(Gtk.WindowType.Toplevel)
        {
            Build();
            TransientFor = parent;
        }
        
        protected void OnButtonOkClicked (object sender, EventArgs e)
        {
            Hide();
        }
        
        protected void OnButtonCancelClicked (object sender, EventArgs e)
        {
            Hide();
        }

        protected void OnCheckIndefinitelyToggled (object sender, EventArgs e)
        {
            if (checkIndefinitely.Active)
            {
                calendarDeadline.Sensitive = false;
            }
            else
            {
                calendarDeadline.Sensitive = true;
            }
        }
    }
}

