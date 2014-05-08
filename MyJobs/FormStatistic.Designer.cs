namespace MyJobs
{
    partial class FormStatistic
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
            this.panelDiagram = new System.Windows.Forms.Panel();
            this.labelCompleted = new System.Windows.Forms.Label();
            this.labelRemaining = new System.Windows.Forms.Label();
            this.labelExpired = new System.Windows.Forms.Label();
            this.labelTotalJobs = new System.Windows.Forms.Label();
            this.lTotalJobs = new System.Windows.Forms.Label();
            this.labelActiveJobs = new System.Windows.Forms.Label();
            this.lActiveJobs = new System.Windows.Forms.Label();
            this.labelCompletedJobs = new System.Windows.Forms.Label();
            this.lCompletedJobs = new System.Windows.Forms.Label();
            this.labelExpiredJobs = new System.Windows.Forms.Label();
            this.lExpiredJobs = new System.Windows.Forms.Label();
            this.labelEfficiency = new System.Windows.Forms.Label();
            this.lEfficiency = new System.Windows.Forms.Label();
            this.buttonClose = new System.Windows.Forms.Button();
            this.labelArrow = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // panelDiagram
            // 
            this.panelDiagram.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.panelDiagram.Location = new System.Drawing.Point(12, 12);
            this.panelDiagram.Name = "panelDiagram";
            this.panelDiagram.Size = new System.Drawing.Size(256, 256);
            this.panelDiagram.TabIndex = 0;
            this.panelDiagram.Paint += new System.Windows.Forms.PaintEventHandler(this.RedrawDiagram);
            // 
            // labelCompleted
            // 
            this.labelCompleted.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelCompleted.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.labelCompleted.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelCompleted.Location = new System.Drawing.Point(320, 12);
            this.labelCompleted.Name = "labelCompleted";
            this.labelCompleted.Size = new System.Drawing.Size(100, 20);
            this.labelCompleted.TabIndex = 1;
            this.labelCompleted.Text = "COMPLETED";
            this.labelCompleted.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelRemaining
            // 
            this.labelRemaining.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelRemaining.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.labelRemaining.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelRemaining.Location = new System.Drawing.Point(320, 31);
            this.labelRemaining.Name = "labelRemaining";
            this.labelRemaining.Size = new System.Drawing.Size(100, 20);
            this.labelRemaining.TabIndex = 2;
            this.labelRemaining.Text = "REMAINING";
            this.labelRemaining.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelExpired
            // 
            this.labelExpired.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelExpired.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.labelExpired.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelExpired.Location = new System.Drawing.Point(320, 50);
            this.labelExpired.Name = "labelExpired";
            this.labelExpired.Size = new System.Drawing.Size(100, 20);
            this.labelExpired.TabIndex = 3;
            this.labelExpired.Text = "EXPIRED";
            this.labelExpired.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelTotalJobs
            // 
            this.labelTotalJobs.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelTotalJobs.AutoSize = true;
            this.labelTotalJobs.Location = new System.Drawing.Point(283, 92);
            this.labelTotalJobs.Name = "labelTotalJobs";
            this.labelTotalJobs.Size = new System.Drawing.Size(56, 13);
            this.labelTotalJobs.TabIndex = 4;
            this.labelTotalJobs.Text = "Total jobs:";
            // 
            // lTotalJobs
            // 
            this.lTotalJobs.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lTotalJobs.Location = new System.Drawing.Point(369, 92);
            this.lTotalJobs.Name = "lTotalJobs";
            this.lTotalJobs.Size = new System.Drawing.Size(50, 13);
            this.lTotalJobs.TabIndex = 5;
            this.lTotalJobs.Text = "0";
            this.lTotalJobs.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // labelActiveJobs
            // 
            this.labelActiveJobs.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelActiveJobs.AutoSize = true;
            this.labelActiveJobs.Location = new System.Drawing.Point(283, 107);
            this.labelActiveJobs.Name = "labelActiveJobs";
            this.labelActiveJobs.Size = new System.Drawing.Size(62, 13);
            this.labelActiveJobs.TabIndex = 6;
            this.labelActiveJobs.Text = "Active jobs:";
            // 
            // lActiveJobs
            // 
            this.lActiveJobs.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lActiveJobs.Location = new System.Drawing.Point(369, 107);
            this.lActiveJobs.Name = "lActiveJobs";
            this.lActiveJobs.Size = new System.Drawing.Size(50, 13);
            this.lActiveJobs.TabIndex = 7;
            this.lActiveJobs.Text = "0";
            this.lActiveJobs.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // labelCompletedJobs
            // 
            this.labelCompletedJobs.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelCompletedJobs.AutoSize = true;
            this.labelCompletedJobs.Location = new System.Drawing.Point(283, 122);
            this.labelCompletedJobs.Name = "labelCompletedJobs";
            this.labelCompletedJobs.Size = new System.Drawing.Size(82, 13);
            this.labelCompletedJobs.TabIndex = 8;
            this.labelCompletedJobs.Text = "Completed jobs:";
            // 
            // lCompletedJobs
            // 
            this.lCompletedJobs.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lCompletedJobs.Location = new System.Drawing.Point(369, 122);
            this.lCompletedJobs.Name = "lCompletedJobs";
            this.lCompletedJobs.Size = new System.Drawing.Size(50, 13);
            this.lCompletedJobs.TabIndex = 9;
            this.lCompletedJobs.Text = "0";
            this.lCompletedJobs.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // labelExpiredJobs
            // 
            this.labelExpiredJobs.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelExpiredJobs.AutoSize = true;
            this.labelExpiredJobs.Location = new System.Drawing.Point(283, 137);
            this.labelExpiredJobs.Name = "labelExpiredJobs";
            this.labelExpiredJobs.Size = new System.Drawing.Size(67, 13);
            this.labelExpiredJobs.TabIndex = 10;
            this.labelExpiredJobs.Text = "Expired jobs:";
            // 
            // lExpiredJobs
            // 
            this.lExpiredJobs.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lExpiredJobs.Location = new System.Drawing.Point(369, 137);
            this.lExpiredJobs.Name = "lExpiredJobs";
            this.lExpiredJobs.Size = new System.Drawing.Size(50, 13);
            this.lExpiredJobs.TabIndex = 11;
            this.lExpiredJobs.Text = "0";
            this.lExpiredJobs.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // labelEfficiency
            // 
            this.labelEfficiency.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelEfficiency.AutoSize = true;
            this.labelEfficiency.Location = new System.Drawing.Point(283, 162);
            this.labelEfficiency.Name = "labelEfficiency";
            this.labelEfficiency.Size = new System.Drawing.Size(56, 13);
            this.labelEfficiency.TabIndex = 12;
            this.labelEfficiency.Text = "Efficiency:";
            // 
            // lEfficiency
            // 
            this.lEfficiency.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lEfficiency.Location = new System.Drawing.Point(369, 162);
            this.lEfficiency.Name = "lEfficiency";
            this.lEfficiency.Size = new System.Drawing.Size(50, 13);
            this.lEfficiency.TabIndex = 13;
            this.lEfficiency.Text = "0";
            this.lEfficiency.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // buttonClose
            // 
            this.buttonClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonClose.Location = new System.Drawing.Point(345, 244);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(75, 23);
            this.buttonClose.TabIndex = 14;
            this.buttonClose.Text = "&Close";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.ActionClose);
            // 
            // labelArrow
            // 
            this.labelArrow.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelArrow.AutoSize = true;
            this.labelArrow.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelArrow.Location = new System.Drawing.Point(285, 33);
            this.labelArrow.Name = "labelArrow";
            this.labelArrow.Size = new System.Drawing.Size(31, 16);
            this.labelArrow.TabIndex = 15;
            this.labelArrow.Text = "<---";
            // 
            // FormStatistic
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(432, 281);
            this.Controls.Add(this.labelArrow);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.lEfficiency);
            this.Controls.Add(this.labelEfficiency);
            this.Controls.Add(this.lExpiredJobs);
            this.Controls.Add(this.labelExpiredJobs);
            this.Controls.Add(this.lCompletedJobs);
            this.Controls.Add(this.labelCompletedJobs);
            this.Controls.Add(this.lActiveJobs);
            this.Controls.Add(this.labelActiveJobs);
            this.Controls.Add(this.lTotalJobs);
            this.Controls.Add(this.labelTotalJobs);
            this.Controls.Add(this.labelExpired);
            this.Controls.Add(this.labelRemaining);
            this.Controls.Add(this.labelCompleted);
            this.Controls.Add(this.panelDiagram);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(440, 310);
            this.Name = "FormStatistic";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Statistic";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelDiagram;
        private System.Windows.Forms.Label labelCompleted;
        private System.Windows.Forms.Label labelRemaining;
        private System.Windows.Forms.Label labelExpired;
        private System.Windows.Forms.Label labelTotalJobs;
        private System.Windows.Forms.Label lTotalJobs;
        private System.Windows.Forms.Label labelActiveJobs;
        private System.Windows.Forms.Label lActiveJobs;
        private System.Windows.Forms.Label labelCompletedJobs;
        private System.Windows.Forms.Label lCompletedJobs;
        private System.Windows.Forms.Label labelExpiredJobs;
        private System.Windows.Forms.Label lExpiredJobs;
        private System.Windows.Forms.Label labelEfficiency;
        private System.Windows.Forms.Label lEfficiency;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.Label labelArrow;
    }
}