namespace MyJobs
{
    partial class FormCreateJob
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
            this.labelTitle = new System.Windows.Forms.Label();
            this.textTitle = new System.Windows.Forms.TextBox();
            this.textDescription = new System.Windows.Forms.TextBox();
            this.labelDescription = new System.Windows.Forms.Label();
            this.labelDeadline = new System.Windows.Forms.Label();
            this.checkTermless = new System.Windows.Forms.CheckBox();
            this.calendarDeadline = new System.Windows.Forms.MonthCalendar();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonOK = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Location = new System.Drawing.Point(12, 9);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(30, 13);
            this.labelTitle.TabIndex = 0;
            this.labelTitle.Text = "Title:";
            // 
            // textTitle
            // 
            this.textTitle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.textTitle.Location = new System.Drawing.Point(12, 25);
            this.textTitle.Name = "textTitle";
            this.textTitle.Size = new System.Drawing.Size(288, 20);
            this.textTitle.TabIndex = 1;
            // 
            // textDescription
            // 
            this.textDescription.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.textDescription.Location = new System.Drawing.Point(12, 69);
            this.textDescription.Multiline = true;
            this.textDescription.Name = "textDescription";
            this.textDescription.Size = new System.Drawing.Size(288, 59);
            this.textDescription.TabIndex = 2;
            // 
            // labelDescription
            // 
            this.labelDescription.AutoSize = true;
            this.labelDescription.Location = new System.Drawing.Point(12, 53);
            this.labelDescription.Name = "labelDescription";
            this.labelDescription.Size = new System.Drawing.Size(63, 13);
            this.labelDescription.TabIndex = 3;
            this.labelDescription.Text = "Description:";
            // 
            // labelDeadline
            // 
            this.labelDeadline.AutoSize = true;
            this.labelDeadline.Location = new System.Drawing.Point(15, 137);
            this.labelDeadline.Name = "labelDeadline";
            this.labelDeadline.Size = new System.Drawing.Size(52, 13);
            this.labelDeadline.TabIndex = 4;
            this.labelDeadline.Text = "Deadline:";
            // 
            // checkTermless
            // 
            this.checkTermless.AutoSize = true;
            this.checkTermless.Location = new System.Drawing.Point(15, 154);
            this.checkTermless.Name = "checkTermless";
            this.checkTermless.Size = new System.Drawing.Size(68, 17);
            this.checkTermless.TabIndex = 3;
            this.checkTermless.Text = "Termless";
            this.checkTermless.UseVisualStyleBackColor = true;
            this.checkTermless.CheckedChanged += new System.EventHandler(this.ActionTermless);
            // 
            // calendarDeadline
            // 
            this.calendarDeadline.Location = new System.Drawing.Point(12, 173);
            this.calendarDeadline.Name = "calendarDeadline";
            this.calendarDeadline.ShowWeekNumbers = true;
            this.calendarDeadline.TabIndex = 4;
            // 
            // buttonCancel
            // 
            this.buttonCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCancel.Location = new System.Drawing.Point(225, 310);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 6;
            this.buttonCancel.Text = "&Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.ActionCancel);
            // 
            // buttonOK
            // 
            this.buttonOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonOK.Location = new System.Drawing.Point(225, 281);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(75, 23);
            this.buttonOK.TabIndex = 5;
            this.buttonOK.Text = "&OK";
            this.buttonOK.UseVisualStyleBackColor = true;
            this.buttonOK.Click += new System.EventHandler(this.ActionOK);
            // 
            // FormCreateJob
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(312, 341);
            this.Controls.Add(this.buttonOK);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.calendarDeadline);
            this.Controls.Add(this.checkTermless);
            this.Controls.Add(this.labelDeadline);
            this.Controls.Add(this.labelDescription);
            this.Controls.Add(this.textDescription);
            this.Controls.Add(this.textTitle);
            this.Controls.Add(this.labelTitle);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(320, 370);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(320, 370);
            this.Name = "FormCreateJob";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Create job";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.TextBox textTitle;
        private System.Windows.Forms.TextBox textDescription;
        private System.Windows.Forms.Label labelDescription;
        private System.Windows.Forms.Label labelDeadline;
        private System.Windows.Forms.CheckBox checkTermless;
        private System.Windows.Forms.MonthCalendar calendarDeadline;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonOK;
    }
}