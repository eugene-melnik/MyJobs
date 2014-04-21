using System;
using System.Threading;
using System.Text;
using Gtk;

namespace KPI
{
    public partial class MainWindow : Gtk.Window
    {

    // public section

        public MainWindow() : base(Gtk.WindowType.Toplevel)
        {
            Build();
            Title = Version.AppNameFull;
            TreeViewSetting();
        }

        /*
         * Loading jobs list from the disk
         */
        public void Load()
        {   
            Thread loadJobs = new Thread(LoadJobs);
            loadJobs.Start();
        }

    // private section

        private void TreeViewSetting()
        {
            TreeViewColumn colDone = new TreeViewColumn();
            colDone.Title = "Done";
            treeviewMain.AppendColumn (colDone);
            CellRendererToggle colDoneRender = new CellRendererToggle();
            colDone.PackStart (colDoneRender, true);

            TreeViewColumn colTitle = new TreeViewColumn();
            colTitle.Title = "Title";
            treeviewMain.AppendColumn (colTitle);
            CellRendererText colTitleRender = new CellRendererText();
            colTitle.PackStart (colTitleRender, true);
            colTitle.AddAttribute (colTitleRender, "text", 1);

            TreeViewColumn colDeadline = new TreeViewColumn();
            colDeadline.Title = "Deadline";
            treeviewMain.AppendColumn (colDeadline);
            CellRendererText colDeadlineRender = new CellRendererText();
            colDeadline.PackStart (colDeadlineRender, true);
            colDeadline.AddAttribute (colDeadlineRender, "text", 2);

            treeviewMain.Model = listStore;
        }
        
        private void LoadJobs()
        {   
            /*** TESTING ***/
            const int nbOfRecords = 3;

            for (int i = 0; i < nbOfRecords; i++)
            {
                Thread.Sleep(50);

                Gtk.Application.Invoke (delegate {
                    splash.Percent = (i+1)*33;
                    listStore.AppendValues (new CheckButton(), "Some very important job #" + i.ToString(), DateTime.Today.ToString());
                }); 
            }

            Gtk.Application.Invoke (delegate {
                splash.Hide();
                this.Show();
            });
        }

        protected void ShowToolbar (object sender, EventArgs e)
        {
            if (mbActionShowToolbar.Active)
            {
                toolbarMain.Show();
            }
            else
            {
                toolbarMain.Hide();
            }
        }

        private void OnExit (object sender, EventArgs args)
        {

            Application.Quit();
        }

        /*
         * Job creating
         */
        protected void OnCreateActivated (object sender, EventArgs e)
        {
            CreateJobWindow win = new CreateJobWindow (this);
            win.Show();
        }
        
        /*
         * Job editing
         */
        protected void OnActionEditActivated (object sender, EventArgs e)
        {
            CreateJobWindow win = new CreateJobWindow (this);
            win.Show();
        }
        
        /*
         * Job removing
         */
        protected void OnActionRemoveActivated (object sender, EventArgs e)
        {
            Gtk.MessageDialog win = new MessageDialog (this, DialogFlags.Modal, MessageType.Info, ButtonsType.Ok,
                                                       "Nothing to remove. Choose record first!");

            if ((ResponseType)win.Run() == ResponseType.Ok)
            {
                win.Destroy();
            }
        }

        protected void OnActionPreferencesActivated (object sender, EventArgs e)
        {
            PreferencesWindow win = new PreferencesWindow (this);
            win.Show();
        }

        protected void OnActionAboutActivated (object sender, EventArgs e)
        {
            AboutAppWindow win = new AboutAppWindow (this);
            win.Show();
        }

    // constants

    // variables

        private StartupWindow splash = new StartupWindow();
        private ListStore listStore = new ListStore(typeof(CheckButton), typeof(string), typeof(string));
    }
}

