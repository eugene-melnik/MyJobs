namespace MyJobs
{
    partial class FormMain
    {
        /// <summary>
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.menuMain = new System.Windows.Forms.MenuStrip();
            this.menuActionFile = new System.Windows.Forms.ToolStripMenuItem();
            this.menuActionFileExit = new System.Windows.Forms.ToolStripMenuItem();
            this.menuActionEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.menuActionEditShowToolbar = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripSeparator();
            this.menuActionEditPreferences = new System.Windows.Forms.ToolStripMenuItem();
            this.toolsActionStatistic = new System.Windows.Forms.ToolStripMenuItem();
            this.menuActionJobs = new System.Windows.Forms.ToolStripMenuItem();
            this.menuActionJobsCreate = new System.Windows.Forms.ToolStripMenuItem();
            this.menuActionJobsEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.menuActionJobsRemove = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripSeparator();
            this.menuActionJobsFind = new System.Windows.Forms.ToolStripMenuItem();
            this.menuActionHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.menuActionHelpAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuActionExit = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showToolbarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.preferencesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.jobsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.removeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolsMain = new System.Windows.Forms.ToolStrip();
            this.toolsActionCreate = new System.Windows.Forms.ToolStripButton();
            this.tollsActionEdit = new System.Windows.Forms.ToolStripButton();
            this.toolsActionRemove = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolsActionFind = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.toolsActionExit = new System.Windows.Forms.ToolStripButton();
            this.toolCreateJob = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton4 = new System.Windows.Forms.ToolStripButton();
            this.statusMain = new System.Windows.Forms.StatusStrip();
            this.statusLabelJobs = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusLJobs = new System.Windows.Forms.ToolStripStatusLabel();
            this.listMain = new System.Windows.Forms.ListView();
            this.colDone = new System.Windows.Forms.ColumnHeader();
            this.colTitle = new System.Windows.Forms.ColumnHeader();
            this.colDeadline = new System.Windows.Forms.ColumnHeader();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.findToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.timerAutosave = new System.Windows.Forms.Timer(this.components);
            this.menuMain.SuspendLayout();
            this.toolsMain.SuspendLayout();
            this.statusMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuMain
            // 
            this.menuMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuActionFile,
            this.menuActionEdit,
            this.menuActionJobs,
            this.menuActionHelp});
            this.menuMain.Location = new System.Drawing.Point(0, 0);
            this.menuMain.Name = "menuMain";
            this.menuMain.Size = new System.Drawing.Size(392, 24);
            this.menuMain.TabIndex = 0;
            // 
            // menuActionFile
            // 
            this.menuActionFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuActionFileExit});
            this.menuActionFile.Name = "menuActionFile";
            this.menuActionFile.Size = new System.Drawing.Size(35, 20);
            this.menuActionFile.Text = "&File";
            // 
            // menuActionFileExit
            // 
            this.menuActionFileExit.Image = global::MyJobs.Properties.Resources._1_File_Exit_16;
            this.menuActionFileExit.Name = "menuActionFileExit";
            this.menuActionFileExit.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Q)));
            this.menuActionFileExit.Size = new System.Drawing.Size(143, 22);
            this.menuActionFileExit.Text = "E&xit";
            this.menuActionFileExit.Click += new System.EventHandler(this.ActionExit);
            // 
            // menuActionEdit
            // 
            this.menuActionEdit.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuActionEditShowToolbar,
            this.toolStripMenuItem3,
            this.menuActionEditPreferences,
            this.toolsActionStatistic});
            this.menuActionEdit.Name = "menuActionEdit";
            this.menuActionEdit.Size = new System.Drawing.Size(37, 20);
            this.menuActionEdit.Text = "&Edit";
            // 
            // menuActionEditShowToolbar
            // 
            this.menuActionEditShowToolbar.Checked = true;
            this.menuActionEditShowToolbar.CheckOnClick = true;
            this.menuActionEditShowToolbar.CheckState = System.Windows.Forms.CheckState.Checked;
            this.menuActionEditShowToolbar.Name = "menuActionEditShowToolbar";
            this.menuActionEditShowToolbar.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.T)));
            this.menuActionEditShowToolbar.Size = new System.Drawing.Size(193, 22);
            this.menuActionEditShowToolbar.Text = "Show toolbar";
            this.menuActionEditShowToolbar.Click += new System.EventHandler(this.ActionShowToolbar);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(190, 6);
            // 
            // menuActionEditPreferences
            // 
            this.menuActionEditPreferences.Image = global::MyJobs.Properties.Resources._2_Edit_Properties;
            this.menuActionEditPreferences.Name = "menuActionEditPreferences";
            this.menuActionEditPreferences.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P)));
            this.menuActionEditPreferences.Size = new System.Drawing.Size(193, 22);
            this.menuActionEditPreferences.Text = "Preferences...";
            this.menuActionEditPreferences.Click += new System.EventHandler(this.ActionPreferences);
            // 
            // toolsActionStatistic
            // 
            this.toolsActionStatistic.Image = global::MyJobs.Properties.Resources.Statistic;
            this.toolsActionStatistic.Name = "toolsActionStatistic";
            this.toolsActionStatistic.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.toolsActionStatistic.Size = new System.Drawing.Size(193, 22);
            this.toolsActionStatistic.Text = "Statistic...";
            this.toolsActionStatistic.Click += new System.EventHandler(this.ActionStatistic);
            // 
            // menuActionJobs
            // 
            this.menuActionJobs.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuActionJobsCreate,
            this.menuActionJobsEdit,
            this.menuActionJobsRemove,
            this.toolStripMenuItem4,
            this.menuActionJobsFind});
            this.menuActionJobs.Name = "menuActionJobs";
            this.menuActionJobs.Size = new System.Drawing.Size(41, 20);
            this.menuActionJobs.Text = "&Jobs";
            // 
            // menuActionJobsCreate
            // 
            this.menuActionJobsCreate.Image = global::MyJobs.Properties.Resources._3_Jobs_Create;
            this.menuActionJobsCreate.Name = "menuActionJobsCreate";
            this.menuActionJobsCreate.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.menuActionJobsCreate.Size = new System.Drawing.Size(169, 22);
            this.menuActionJobsCreate.Text = "&Create...";
            this.menuActionJobsCreate.Click += new System.EventHandler(this.ActionCreateJob);
            // 
            // menuActionJobsEdit
            // 
            this.menuActionJobsEdit.Image = global::MyJobs.Properties.Resources._3_Jobs_Edit;
            this.menuActionJobsEdit.Name = "menuActionJobsEdit";
            this.menuActionJobsEdit.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.E)));
            this.menuActionJobsEdit.Size = new System.Drawing.Size(169, 22);
            this.menuActionJobsEdit.Text = "Ed&it...";
            // 
            // menuActionJobsRemove
            // 
            this.menuActionJobsRemove.Image = global::MyJobs.Properties.Resources._3_Jobs_Remove;
            this.menuActionJobsRemove.Name = "menuActionJobsRemove";
            this.menuActionJobsRemove.ShortcutKeys = System.Windows.Forms.Keys.Delete;
            this.menuActionJobsRemove.Size = new System.Drawing.Size(169, 22);
            this.menuActionJobsRemove.Text = "&Remove...";
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(166, 6);
            // 
            // menuActionJobsFind
            // 
            this.menuActionJobsFind.Image = global::MyJobs.Properties.Resources._3_Jobs_Find;
            this.menuActionJobsFind.Name = "menuActionJobsFind";
            this.menuActionJobsFind.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F)));
            this.menuActionJobsFind.Size = new System.Drawing.Size(169, 22);
            this.menuActionJobsFind.Text = "&Find...";
            this.menuActionJobsFind.Click += new System.EventHandler(this.ActionFind);
            // 
            // menuActionHelp
            // 
            this.menuActionHelp.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuActionHelpAbout});
            this.menuActionHelp.Name = "menuActionHelp";
            this.menuActionHelp.Size = new System.Drawing.Size(40, 20);
            this.menuActionHelp.Text = "&Help";
            // 
            // menuActionHelpAbout
            // 
            this.menuActionHelpAbout.Image = global::MyJobs.Properties.Resources._4_Help_About;
            this.menuActionHelpAbout.Name = "menuActionHelpAbout";
            this.menuActionHelpAbout.Size = new System.Drawing.Size(126, 22);
            this.menuActionHelpAbout.Text = "&About...";
            this.menuActionHelpAbout.Click += new System.EventHandler(this.ActionAbout);
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuActionExit});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(35, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // menuActionExit
            // 
            this.menuActionExit.Image = global::MyJobs.Properties.Resources._1_File_Exit_16;
            this.menuActionExit.Name = "menuActionExit";
            this.menuActionExit.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Q)));
            this.menuActionExit.Size = new System.Drawing.Size(143, 22);
            this.menuActionExit.Text = "E&xit";
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.editToolStripMenuItem.Text = "&Edit";
            // 
            // showToolbarToolStripMenuItem
            // 
            this.showToolbarToolStripMenuItem.Checked = true;
            this.showToolbarToolStripMenuItem.CheckOnClick = true;
            this.showToolbarToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.showToolbarToolStripMenuItem.Name = "showToolbarToolStripMenuItem";
            this.showToolbarToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.T)));
            this.showToolbarToolStripMenuItem.Size = new System.Drawing.Size(193, 22);
            this.showToolbarToolStripMenuItem.Text = "Show toolbar";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(190, 6);
            // 
            // preferencesToolStripMenuItem
            // 
            this.preferencesToolStripMenuItem.Image = global::MyJobs.Properties.Resources._2_Edit_Properties;
            this.preferencesToolStripMenuItem.Name = "preferencesToolStripMenuItem";
            this.preferencesToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P)));
            this.preferencesToolStripMenuItem.Size = new System.Drawing.Size(193, 22);
            this.preferencesToolStripMenuItem.Text = "Preferences...";
            // 
            // jobsToolStripMenuItem
            // 
            this.jobsToolStripMenuItem.Name = "jobsToolStripMenuItem";
            this.jobsToolStripMenuItem.Size = new System.Drawing.Size(41, 20);
            this.jobsToolStripMenuItem.Text = "&Jobs";
            // 
            // createToolStripMenuItem
            // 
            this.createToolStripMenuItem.Image = global::MyJobs.Properties.Resources._3_Jobs_Create;
            this.createToolStripMenuItem.Name = "createToolStripMenuItem";
            this.createToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.createToolStripMenuItem.Text = "Create...";
            // 
            // editToolStripMenuItem1
            // 
            this.editToolStripMenuItem1.Image = global::MyJobs.Properties.Resources._3_Jobs_Edit;
            this.editToolStripMenuItem1.Name = "editToolStripMenuItem1";
            this.editToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.editToolStripMenuItem1.Text = "Edit...";
            // 
            // removeToolStripMenuItem
            // 
            this.removeToolStripMenuItem.Image = global::MyJobs.Properties.Resources._3_Jobs_Remove;
            this.removeToolStripMenuItem.Name = "removeToolStripMenuItem";
            this.removeToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.removeToolStripMenuItem.Text = "Remove...";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(40, 20);
            this.helpToolStripMenuItem.Text = "&Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Image = global::MyJobs.Properties.Resources._4_Help_About;
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.aboutToolStripMenuItem.Text = "&About...";
            // 
            // toolsMain
            // 
            this.toolsMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolsActionCreate,
            this.tollsActionEdit,
            this.toolsActionRemove,
            this.toolStripSeparator3,
            this.toolsActionFind,
            this.toolStripSeparator4,
            this.toolsActionExit});
            this.toolsMain.Location = new System.Drawing.Point(0, 24);
            this.toolsMain.Name = "toolsMain";
            this.toolsMain.Size = new System.Drawing.Size(392, 25);
            this.toolsMain.TabIndex = 1;
            // 
            // toolsActionCreate
            // 
            this.toolsActionCreate.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolsActionCreate.Image = global::MyJobs.Properties.Resources._3_Jobs_Create;
            this.toolsActionCreate.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolsActionCreate.Name = "toolsActionCreate";
            this.toolsActionCreate.Size = new System.Drawing.Size(23, 22);
            this.toolsActionCreate.Text = "Create job";
            this.toolsActionCreate.Click += new System.EventHandler(this.ActionCreateJob);
            // 
            // tollsActionEdit
            // 
            this.tollsActionEdit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tollsActionEdit.Image = global::MyJobs.Properties.Resources._3_Jobs_Edit;
            this.tollsActionEdit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tollsActionEdit.Name = "tollsActionEdit";
            this.tollsActionEdit.Size = new System.Drawing.Size(23, 22);
            this.tollsActionEdit.Text = "Edit job";
            // 
            // toolsActionRemove
            // 
            this.toolsActionRemove.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolsActionRemove.Image = global::MyJobs.Properties.Resources._3_Jobs_Remove;
            this.toolsActionRemove.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolsActionRemove.Name = "toolsActionRemove";
            this.toolsActionRemove.Size = new System.Drawing.Size(23, 22);
            this.toolsActionRemove.Text = "Remove job";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // toolsActionFind
            // 
            this.toolsActionFind.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolsActionFind.Image = global::MyJobs.Properties.Resources._3_Jobs_Find;
            this.toolsActionFind.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolsActionFind.Name = "toolsActionFind";
            this.toolsActionFind.Size = new System.Drawing.Size(23, 22);
            this.toolsActionFind.Text = "Find job";
            this.toolsActionFind.Click += new System.EventHandler(this.ActionFind);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 25);
            // 
            // toolsActionExit
            // 
            this.toolsActionExit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolsActionExit.Image = global::MyJobs.Properties.Resources._1_File_Exit_16;
            this.toolsActionExit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolsActionExit.Name = "toolsActionExit";
            this.toolsActionExit.Size = new System.Drawing.Size(23, 22);
            this.toolsActionExit.Text = "Exit";
            this.toolsActionExit.Click += new System.EventHandler(this.ActionExit);
            // 
            // toolCreateJob
            // 
            this.toolCreateJob.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolCreateJob.Image = global::MyJobs.Properties.Resources._3_Jobs_Create;
            this.toolCreateJob.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolCreateJob.Name = "toolCreateJob";
            this.toolCreateJob.Size = new System.Drawing.Size(23, 22);
            this.toolCreateJob.Text = "Create job";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = global::MyJobs.Properties.Resources._3_Jobs_Edit;
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton1.Text = "Edit job";
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton2.Image = global::MyJobs.Properties.Resources._3_Jobs_Remove;
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton2.Text = "Remove job";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton3.Image = global::MyJobs.Properties.Resources._3_Jobs_Find;
            this.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton3.Text = "Find job";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButton4
            // 
            this.toolStripButton4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton4.Image = global::MyJobs.Properties.Resources._1_File_Exit_16;
            this.toolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton4.Name = "toolStripButton4";
            this.toolStripButton4.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton4.Text = "toolStripButton4";
            // 
            // statusMain
            // 
            this.statusMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusLabelJobs,
            this.statusLJobs});
            this.statusMain.Location = new System.Drawing.Point(0, 299);
            this.statusMain.Name = "statusMain";
            this.statusMain.Size = new System.Drawing.Size(392, 22);
            this.statusMain.TabIndex = 2;
            // 
            // statusLabelJobs
            // 
            this.statusLabelJobs.Name = "statusLabelJobs";
            this.statusLabelJobs.Size = new System.Drawing.Size(99, 17);
            this.statusLabelJobs.Text = "Jobs (active/total):";
            // 
            // statusLJobs
            // 
            this.statusLJobs.Name = "statusLJobs";
            this.statusLJobs.Size = new System.Drawing.Size(23, 17);
            this.statusLJobs.Text = "0/0";
            // 
            // listMain
            // 
            this.listMain.CheckBoxes = true;
            this.listMain.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colDone,
            this.colTitle,
            this.colDeadline});
            this.listMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listMain.FullRowSelect = true;
            this.listMain.Location = new System.Drawing.Point(0, 49);
            this.listMain.Name = "listMain";
            this.listMain.Size = new System.Drawing.Size(392, 250);
            this.listMain.TabIndex = 3;
            this.listMain.UseCompatibleStateImageBehavior = false;
            this.listMain.View = System.Windows.Forms.View.Details;
            // 
            // colDone
            // 
            this.colDone.Text = "Done";
            this.colDone.Width = 50;
            // 
            // colTitle
            // 
            this.colTitle.Text = "Title";
            this.colTitle.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.colTitle.Width = 220;
            // 
            // colDeadline
            // 
            this.colDeadline.Text = "Deadline";
            this.colDeadline.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.colDeadline.Width = 110;
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(149, 6);
            // 
            // findToolStripMenuItem
            // 
            this.findToolStripMenuItem.Image = global::MyJobs.Properties.Resources._3_Jobs_Find;
            this.findToolStripMenuItem.Name = "findToolStripMenuItem";
            this.findToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.findToolStripMenuItem.Text = "Find...";
            // 
            // timerAutosave
            // 
            this.timerAutosave.Enabled = true;
            this.timerAutosave.Interval = 200000;
            this.timerAutosave.Tick += new System.EventHandler(this.ActionAutosave);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(392, 321);
            this.Controls.Add(this.listMain);
            this.Controls.Add(this.statusMain);
            this.Controls.Add(this.toolsMain);
            this.Controls.Add(this.menuMain);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuMain;
            this.MinimumSize = new System.Drawing.Size(400, 350);
            this.Name = "FormMain";
            this.Load += new System.EventHandler(this.FormLoad);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ActionClosing);
            this.menuMain.ResumeLayout(false);
            this.menuMain.PerformLayout();
            this.toolsMain.ResumeLayout(false);
            this.toolsMain.PerformLayout();
            this.statusMain.ResumeLayout(false);
            this.statusMain.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuMain;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuActionExit;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showToolbarToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem preferencesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem jobsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem createToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem removeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStrip toolsMain;
        private System.Windows.Forms.ToolStripButton toolCreateJob;
        private System.Windows.Forms.StatusStrip statusMain;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton toolStripButton4;
        private System.Windows.Forms.ListView listMain;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem findToolStripMenuItem;
        private System.Windows.Forms.ColumnHeader colDone;
        private System.Windows.Forms.ColumnHeader colTitle;
        private System.Windows.Forms.ColumnHeader colDeadline;
        private System.Windows.Forms.ToolStripMenuItem menuActionFile;
        private System.Windows.Forms.ToolStripMenuItem menuActionFileExit;
        private System.Windows.Forms.ToolStripMenuItem menuActionEdit;
        private System.Windows.Forms.ToolStripMenuItem menuActionEditShowToolbar;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem menuActionEditPreferences;
        private System.Windows.Forms.ToolStripMenuItem menuActionJobs;
        private System.Windows.Forms.ToolStripMenuItem menuActionJobsCreate;
        private System.Windows.Forms.ToolStripMenuItem menuActionJobsEdit;
        private System.Windows.Forms.ToolStripMenuItem menuActionJobsRemove;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem menuActionJobsFind;
        private System.Windows.Forms.ToolStripMenuItem menuActionHelp;
        private System.Windows.Forms.ToolStripMenuItem menuActionHelpAbout;
        private System.Windows.Forms.ToolStripButton toolsActionCreate;
        private System.Windows.Forms.ToolStripButton tollsActionEdit;
        private System.Windows.Forms.ToolStripButton toolsActionRemove;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton toolsActionFind;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripButton toolsActionExit;
        private System.Windows.Forms.ToolStripStatusLabel statusLabelJobs;
        private System.Windows.Forms.ToolStripStatusLabel statusLJobs;
        private System.Windows.Forms.ToolStripMenuItem toolsActionStatistic;
        private System.Windows.Forms.Timer timerAutosave;
    }
}

