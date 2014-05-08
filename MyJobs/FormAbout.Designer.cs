namespace MyJobs
{
    partial class FormAbout
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
            this.pictureMain = new System.Windows.Forms.PictureBox();
            this.lAppName = new System.Windows.Forms.Label();
            this.lAppVersion = new System.Windows.Forms.Label();
            this.lAppLicense = new System.Windows.Forms.LinkLabel();
            this.lAppAuthor = new System.Windows.Forms.LinkLabel();
            this.buttonClose = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureMain)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureMain
            // 
            this.pictureMain.Image = global::MyJobs.Properties.Resources.cat_poo;
            this.pictureMain.Location = new System.Drawing.Point(12, 12);
            this.pictureMain.Name = "pictureMain";
            this.pictureMain.Size = new System.Drawing.Size(70, 70);
            this.pictureMain.TabIndex = 0;
            this.pictureMain.TabStop = false;
            this.pictureMain.Click += new System.EventHandler(this.ActionEasterEgg);
            // 
            // lAppName
            // 
            this.lAppName.AutoSize = true;
            this.lAppName.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lAppName.Location = new System.Drawing.Point(89, 13);
            this.lAppName.Name = "lAppName";
            this.lAppName.Size = new System.Drawing.Size(138, 31);
            this.lAppName.TabIndex = 1;
            this.lAppName.Text = "appName";
            // 
            // lAppVersion
            // 
            this.lAppVersion.AutoSize = true;
            this.lAppVersion.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lAppVersion.Location = new System.Drawing.Point(92, 46);
            this.lAppVersion.Name = "lAppVersion";
            this.lAppVersion.Size = new System.Drawing.Size(90, 13);
            this.lAppVersion.TabIndex = 2;
            this.lAppVersion.Text = "appVersionFull";
            // 
            // lAppLicense
            // 
            this.lAppLicense.AutoSize = true;
            this.lAppLicense.Location = new System.Drawing.Point(92, 77);
            this.lAppLicense.Name = "lAppLicense";
            this.lAppLicense.Size = new System.Drawing.Size(62, 13);
            this.lAppLicense.TabIndex = 4;
            this.lAppLicense.TabStop = true;
            this.lAppLicense.Text = "appLicense";
            // 
            // lAppAuthor
            // 
            this.lAppAuthor.AutoSize = true;
            this.lAppAuthor.Location = new System.Drawing.Point(92, 61);
            this.lAppAuthor.Name = "lAppAuthor";
            this.lAppAuthor.Size = new System.Drawing.Size(56, 13);
            this.lAppAuthor.TabIndex = 5;
            this.lAppAuthor.TabStop = true;
            this.lAppAuthor.Text = "appAuthor";
            // 
            // buttonClose
            // 
            this.buttonClose.Location = new System.Drawing.Point(235, 133);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(75, 23);
            this.buttonClose.TabIndex = 6;
            this.buttonClose.Text = "&Close";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.ActionClose);
            // 
            // FormAbout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(322, 168);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.lAppAuthor);
            this.Controls.Add(this.lAppLicense);
            this.Controls.Add(this.lAppVersion);
            this.Controls.Add(this.lAppName);
            this.Controls.Add(this.pictureMain);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormAbout";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "About";
            ((System.ComponentModel.ISupportInitialize)(this.pictureMain)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureMain;
        private System.Windows.Forms.Label lAppName;
        private System.Windows.Forms.Label lAppVersion;
        private System.Windows.Forms.LinkLabel lAppLicense;
        private System.Windows.Forms.LinkLabel lAppAuthor;
        private System.Windows.Forms.Button buttonClose;
    }
}