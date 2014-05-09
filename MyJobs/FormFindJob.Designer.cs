namespace MyJobs
{
    partial class FormFindJob
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
            this.labelKeyword = new System.Windows.Forms.Label();
            this.textKeyword = new System.Windows.Forms.TextBox();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.labelResults = new System.Windows.Forms.Label();
            this.listMain = new System.Windows.Forms.ListView();
            this.columnStatus = new System.Windows.Forms.ColumnHeader();
            this.columnTitle = new System.Windows.Forms.ColumnHeader();
            this.columnDeadline = new System.Windows.Forms.ColumnHeader();
            this.columnCompleted = new System.Windows.Forms.ColumnHeader();
            this.checkActive = new System.Windows.Forms.CheckBox();
            this.checkCompleted = new System.Windows.Forms.CheckBox();
            this.checkExpired = new System.Windows.Forms.CheckBox();
            this.buttonClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelKeyword
            // 
            this.labelKeyword.AutoSize = true;
            this.labelKeyword.Location = new System.Drawing.Point(13, 13);
            this.labelKeyword.Name = "labelKeyword";
            this.labelKeyword.Size = new System.Drawing.Size(51, 13);
            this.labelKeyword.TabIndex = 0;
            this.labelKeyword.Text = "Keyword:";
            // 
            // textKeyword
            // 
            this.textKeyword.Location = new System.Drawing.Point(13, 30);
            this.textKeyword.Name = "textKeyword";
            this.textKeyword.Size = new System.Drawing.Size(399, 20);
            this.textKeyword.TabIndex = 1;
            this.textKeyword.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ActionKeyDown);
            // 
            // buttonSearch
            // 
            this.buttonSearch.Location = new System.Drawing.Point(418, 29);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(75, 23);
            this.buttonSearch.TabIndex = 2;
            this.buttonSearch.Text = "&Search";
            this.buttonSearch.UseVisualStyleBackColor = true;
            this.buttonSearch.Click += new System.EventHandler(this.ActionSearch);
            // 
            // labelResults
            // 
            this.labelResults.AutoSize = true;
            this.labelResults.Location = new System.Drawing.Point(13, 89);
            this.labelResults.Name = "labelResults";
            this.labelResults.Size = new System.Drawing.Size(45, 13);
            this.labelResults.TabIndex = 3;
            this.labelResults.Text = "Results:";
            // 
            // listMain
            // 
            this.listMain.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnStatus,
            this.columnTitle,
            this.columnDeadline,
            this.columnCompleted});
            this.listMain.Location = new System.Drawing.Point(13, 106);
            this.listMain.Name = "listMain";
            this.listMain.Size = new System.Drawing.Size(480, 168);
            this.listMain.TabIndex = 4;
            this.listMain.UseCompatibleStateImageBehavior = false;
            this.listMain.View = System.Windows.Forms.View.Details;
            // 
            // columnStatus
            // 
            this.columnStatus.Text = "Status";
            this.columnStatus.Width = 50;
            // 
            // columnTitle
            // 
            this.columnTitle.Text = "Title";
            this.columnTitle.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnTitle.Width = 220;
            // 
            // columnDeadline
            // 
            this.columnDeadline.Text = "Deadline";
            this.columnDeadline.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnDeadline.Width = 100;
            // 
            // columnCompleted
            // 
            this.columnCompleted.Text = "Completed";
            this.columnCompleted.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnCompleted.Width = 100;
            // 
            // checkActive
            // 
            this.checkActive.AutoSize = true;
            this.checkActive.Checked = true;
            this.checkActive.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkActive.Location = new System.Drawing.Point(13, 62);
            this.checkActive.Name = "checkActive";
            this.checkActive.Size = new System.Drawing.Size(56, 17);
            this.checkActive.TabIndex = 5;
            this.checkActive.Text = "Active";
            this.checkActive.UseVisualStyleBackColor = true;
            // 
            // checkCompleted
            // 
            this.checkCompleted.AutoSize = true;
            this.checkCompleted.Checked = true;
            this.checkCompleted.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkCompleted.Location = new System.Drawing.Point(96, 62);
            this.checkCompleted.Name = "checkCompleted";
            this.checkCompleted.Size = new System.Drawing.Size(76, 17);
            this.checkCompleted.TabIndex = 6;
            this.checkCompleted.Text = "Completed";
            this.checkCompleted.UseVisualStyleBackColor = true;
            // 
            // checkExpired
            // 
            this.checkExpired.AutoSize = true;
            this.checkExpired.Checked = true;
            this.checkExpired.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkExpired.Location = new System.Drawing.Point(199, 62);
            this.checkExpired.Name = "checkExpired";
            this.checkExpired.Size = new System.Drawing.Size(61, 17);
            this.checkExpired.TabIndex = 7;
            this.checkExpired.Text = "Expired";
            this.checkExpired.UseVisualStyleBackColor = true;
            // 
            // buttonClose
            // 
            this.buttonClose.Location = new System.Drawing.Point(418, 281);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(75, 23);
            this.buttonClose.TabIndex = 8;
            this.buttonClose.Text = "&Close";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.ActionClose);
            // 
            // FormFindJob
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(505, 314);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.checkExpired);
            this.Controls.Add(this.checkCompleted);
            this.Controls.Add(this.checkActive);
            this.Controls.Add(this.listMain);
            this.Controls.Add(this.labelResults);
            this.Controls.Add(this.buttonSearch);
            this.Controls.Add(this.textKeyword);
            this.Controls.Add(this.labelKeyword);
            this.Name = "FormFindJob";
            this.Text = "Find job";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelKeyword;
        private System.Windows.Forms.TextBox textKeyword;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.Label labelResults;
        private System.Windows.Forms.ListView listMain;
        private System.Windows.Forms.ColumnHeader columnStatus;
        private System.Windows.Forms.ColumnHeader columnTitle;
        private System.Windows.Forms.ColumnHeader columnDeadline;
        private System.Windows.Forms.ColumnHeader columnCompleted;
        private System.Windows.Forms.CheckBox checkActive;
        private System.Windows.Forms.CheckBox checkCompleted;
        private System.Windows.Forms.CheckBox checkExpired;
        private System.Windows.Forms.Button buttonClose;
    }
}