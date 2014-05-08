namespace MyJobs
{
    partial class FormSplashscreen
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
            this.lAppNameFull = new System.Windows.Forms.Label();
            this.lAppAuthor = new System.Windows.Forms.Label();
            this.lAppLicense = new System.Windows.Forms.Label();
            this.lStatus = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lAppNameFull
            // 
            this.lAppNameFull.AutoSize = true;
            this.lAppNameFull.BackColor = System.Drawing.Color.Transparent;
            this.lAppNameFull.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lAppNameFull.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lAppNameFull.Location = new System.Drawing.Point(10, 10);
            this.lAppNameFull.Name = "lAppNameFull";
            this.lAppNameFull.Size = new System.Drawing.Size(189, 31);
            this.lAppNameFull.TabIndex = 0;
            this.lAppNameFull.Text = "AppNameFull";
            // 
            // lAppAuthor
            // 
            this.lAppAuthor.AutoSize = true;
            this.lAppAuthor.BackColor = System.Drawing.Color.Transparent;
            this.lAppAuthor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lAppAuthor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lAppAuthor.Location = new System.Drawing.Point(13, 44);
            this.lAppAuthor.Name = "lAppAuthor";
            this.lAppAuthor.Size = new System.Drawing.Size(71, 16);
            this.lAppAuthor.TabIndex = 1;
            this.lAppAuthor.Text = "AppAuthor";
            // 
            // lAppLicense
            // 
            this.lAppLicense.AutoSize = true;
            this.lAppLicense.BackColor = System.Drawing.Color.Transparent;
            this.lAppLicense.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lAppLicense.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lAppLicense.Location = new System.Drawing.Point(13, 63);
            this.lAppLicense.Name = "lAppLicense";
            this.lAppLicense.Size = new System.Drawing.Size(79, 16);
            this.lAppLicense.TabIndex = 2;
            this.lAppLicense.Text = "appLicense";
            // 
            // lStatus
            // 
            this.lStatus.AutoSize = true;
            this.lStatus.BackColor = System.Drawing.Color.Transparent;
            this.lStatus.ForeColor = System.Drawing.Color.Gray;
            this.lStatus.Location = new System.Drawing.Point(12, 218);
            this.lStatus.Name = "lStatus";
            this.lStatus.Size = new System.Drawing.Size(54, 13);
            this.lStatus.TabIndex = 3;
            this.lStatus.Text = "Loading...";
            // 
            // FormSplashscreen
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.BackgroundImage = global::MyJobs.Properties.Resources.bg;
            this.ClientSize = new System.Drawing.Size(320, 240);
            this.Controls.Add(this.lStatus);
            this.Controls.Add(this.lAppLicense);
            this.Controls.Add(this.lAppAuthor);
            this.Controls.Add(this.lAppNameFull);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormSplashscreen";
            this.Opacity = 0.99;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.TopMost = true;
            this.Load += new System.EventHandler(this.FadeIn);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FadeOut);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lAppNameFull;
        private System.Windows.Forms.Label lAppAuthor;
        private System.Windows.Forms.Label lAppLicense;
        private System.Windows.Forms.Label lStatus;

    }
}