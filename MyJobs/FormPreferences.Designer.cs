namespace MyJobs
{
    partial class FormPreferences
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
            this.groupApplication = new System.Windows.Forms.GroupBox();
            this.checkSHowNotifications = new System.Windows.Forms.CheckBox();
            this.checkHideToTray = new System.Windows.Forms.CheckBox();
            this.checkShowSplashScreen = new System.Windows.Forms.CheckBox();
            this.groupJobs = new System.Windows.Forms.GroupBox();
            this.labelDays = new System.Windows.Forms.Label();
            this.textOlderThanDays = new System.Windows.Forms.TextBox();
            this.labelOlderThan = new System.Windows.Forms.Label();
            this.checkAutoremoveFailed = new System.Windows.Forms.CheckBox();
            this.checkAutoremoveDoned = new System.Windows.Forms.CheckBox();
            this.checkAutoremoveOld = new System.Windows.Forms.CheckBox();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonOK = new System.Windows.Forms.Button();
            this.groupApplication.SuspendLayout();
            this.groupJobs.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupApplication
            // 
            this.groupApplication.Controls.Add(this.checkSHowNotifications);
            this.groupApplication.Controls.Add(this.checkHideToTray);
            this.groupApplication.Controls.Add(this.checkShowSplashScreen);
            this.groupApplication.Location = new System.Drawing.Point(223, 12);
            this.groupApplication.Name = "groupApplication";
            this.groupApplication.Size = new System.Drawing.Size(205, 90);
            this.groupApplication.TabIndex = 0;
            this.groupApplication.TabStop = false;
            this.groupApplication.Text = "Application";
            // 
            // checkSHowNotifications
            // 
            this.checkSHowNotifications.AutoSize = true;
            this.checkSHowNotifications.Location = new System.Drawing.Point(6, 65);
            this.checkSHowNotifications.Name = "checkSHowNotifications";
            this.checkSHowNotifications.Size = new System.Drawing.Size(112, 17);
            this.checkSHowNotifications.TabIndex = 2;
            this.checkSHowNotifications.Text = "Show notifications";
            this.checkSHowNotifications.UseVisualStyleBackColor = true;
            // 
            // checkHideToTray
            // 
            this.checkHideToTray.AutoSize = true;
            this.checkHideToTray.Location = new System.Drawing.Point(6, 42);
            this.checkHideToTray.Name = "checkHideToTray";
            this.checkHideToTray.Size = new System.Drawing.Size(123, 17);
            this.checkHideToTray.TabIndex = 1;
            this.checkHideToTray.Text = "Hide to tray on close";
            this.checkHideToTray.UseVisualStyleBackColor = true;
            // 
            // checkShowSplashScreen
            // 
            this.checkShowSplashScreen.AutoSize = true;
            this.checkShowSplashScreen.Location = new System.Drawing.Point(6, 19);
            this.checkShowSplashScreen.Name = "checkShowSplashScreen";
            this.checkShowSplashScreen.Size = new System.Drawing.Size(171, 17);
            this.checkShowSplashScreen.TabIndex = 0;
            this.checkShowSplashScreen.Text = "Show splash screen on startup";
            this.checkShowSplashScreen.UseVisualStyleBackColor = true;
            // 
            // groupJobs
            // 
            this.groupJobs.Controls.Add(this.labelDays);
            this.groupJobs.Controls.Add(this.textOlderThanDays);
            this.groupJobs.Controls.Add(this.labelOlderThan);
            this.groupJobs.Controls.Add(this.checkAutoremoveFailed);
            this.groupJobs.Controls.Add(this.checkAutoremoveDoned);
            this.groupJobs.Controls.Add(this.checkAutoremoveOld);
            this.groupJobs.Location = new System.Drawing.Point(12, 12);
            this.groupJobs.Name = "groupJobs";
            this.groupJobs.Size = new System.Drawing.Size(205, 122);
            this.groupJobs.TabIndex = 1;
            this.groupJobs.TabStop = false;
            this.groupJobs.Text = "Jobs";
            // 
            // labelDays
            // 
            this.labelDays.AutoSize = true;
            this.labelDays.Location = new System.Drawing.Point(142, 92);
            this.labelDays.Name = "labelDays";
            this.labelDays.Size = new System.Drawing.Size(29, 13);
            this.labelDays.TabIndex = 5;
            this.labelDays.Text = "days";
            // 
            // textOlderThanDays
            // 
            this.textOlderThanDays.Location = new System.Drawing.Point(85, 89);
            this.textOlderThanDays.Name = "textOlderThanDays";
            this.textOlderThanDays.Size = new System.Drawing.Size(44, 20);
            this.textOlderThanDays.TabIndex = 4;
            // 
            // labelOlderThan
            // 
            this.labelOlderThan.AutoSize = true;
            this.labelOlderThan.Location = new System.Drawing.Point(21, 92);
            this.labelOlderThan.Name = "labelOlderThan";
            this.labelOlderThan.Size = new System.Drawing.Size(56, 13);
            this.labelOlderThan.TabIndex = 3;
            this.labelOlderThan.Text = "Older than";
            // 
            // checkAutoremoveFailed
            // 
            this.checkAutoremoveFailed.AutoSize = true;
            this.checkAutoremoveFailed.Location = new System.Drawing.Point(24, 68);
            this.checkAutoremoveFailed.Name = "checkAutoremoveFailed";
            this.checkAutoremoveFailed.Size = new System.Drawing.Size(54, 17);
            this.checkAutoremoveFailed.TabIndex = 2;
            this.checkAutoremoveFailed.Text = "Failed";
            this.checkAutoremoveFailed.UseVisualStyleBackColor = true;
            // 
            // checkAutoremoveDoned
            // 
            this.checkAutoremoveDoned.AutoSize = true;
            this.checkAutoremoveDoned.Location = new System.Drawing.Point(24, 44);
            this.checkAutoremoveDoned.Name = "checkAutoremoveDoned";
            this.checkAutoremoveDoned.Size = new System.Drawing.Size(58, 17);
            this.checkAutoremoveDoned.TabIndex = 1;
            this.checkAutoremoveDoned.Text = "Doned";
            this.checkAutoremoveDoned.UseVisualStyleBackColor = true;
            // 
            // checkAutoremoveOld
            // 
            this.checkAutoremoveOld.AutoSize = true;
            this.checkAutoremoveOld.Location = new System.Drawing.Point(7, 20);
            this.checkAutoremoveOld.Name = "checkAutoremoveOld";
            this.checkAutoremoveOld.Size = new System.Drawing.Size(122, 17);
            this.checkAutoremoveOld.TabIndex = 0;
            this.checkAutoremoveOld.Text = "Autoremove old jobs";
            this.checkAutoremoveOld.UseVisualStyleBackColor = true;
            this.checkAutoremoveOld.CheckedChanged += new System.EventHandler(this.ActionAutoremoveOld);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(353, 136);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 2;
            this.buttonCancel.Text = "&Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.ActionCancel);
            // 
            // buttonOK
            // 
            this.buttonOK.Location = new System.Drawing.Point(272, 136);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(75, 23);
            this.buttonOK.TabIndex = 3;
            this.buttonOK.Text = "&OK";
            this.buttonOK.UseVisualStyleBackColor = true;
            this.buttonOK.Click += new System.EventHandler(this.ActionOK);
            // 
            // FormPreferences
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(440, 171);
            this.Controls.Add(this.buttonOK);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.groupJobs);
            this.Controls.Add(this.groupApplication);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormPreferences";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Preferences";
            this.groupApplication.ResumeLayout(false);
            this.groupApplication.PerformLayout();
            this.groupJobs.ResumeLayout(false);
            this.groupJobs.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupApplication;
        private System.Windows.Forms.CheckBox checkSHowNotifications;
        private System.Windows.Forms.CheckBox checkHideToTray;
        private System.Windows.Forms.CheckBox checkShowSplashScreen;
        private System.Windows.Forms.GroupBox groupJobs;
        private System.Windows.Forms.CheckBox checkAutoremoveFailed;
        private System.Windows.Forms.CheckBox checkAutoremoveDoned;
        private System.Windows.Forms.CheckBox checkAutoremoveOld;
        private System.Windows.Forms.Label labelOlderThan;
        private System.Windows.Forms.Label labelDays;
        private System.Windows.Forms.TextBox textOlderThanDays;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonOK;
    }
}