namespace LibraryItems
{
    partial class EditPatronForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.patronCbo = new System.Windows.Forms.ComboBox();
            this.chooseLbl = new System.Windows.Forms.Label();
            this.selectBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // patronCbo
            // 
            this.patronCbo.FormattingEnabled = true;
            this.patronCbo.Location = new System.Drawing.Point(64, 32);
            this.patronCbo.Name = "patronCbo";
            this.patronCbo.Size = new System.Drawing.Size(224, 21);
            this.patronCbo.TabIndex = 0;
            // 
            // chooseLbl
            // 
            this.chooseLbl.AutoSize = true;
            this.chooseLbl.Location = new System.Drawing.Point(12, 35);
            this.chooseLbl.Name = "chooseLbl";
            this.chooseLbl.Size = new System.Drawing.Size(46, 13);
            this.chooseLbl.TabIndex = 1;
            this.chooseLbl.Text = "Choose:";
            // 
            // selectBtn
            // 
            this.selectBtn.Location = new System.Drawing.Point(64, 74);
            this.selectBtn.Name = "selectBtn";
            this.selectBtn.Size = new System.Drawing.Size(182, 23);
            this.selectBtn.TabIndex = 2;
            this.selectBtn.Text = "Select";
            this.selectBtn.UseVisualStyleBackColor = true;
            this.selectBtn.Click += new System.EventHandler(this.SelectBtn_Click);
            // 
            // EditPatronForm
            // 
            this.AcceptButton = this.selectBtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(300, 136);
            this.Controls.Add(this.selectBtn);
            this.Controls.Add(this.chooseLbl);
            this.Controls.Add(this.patronCbo);
            this.Name = "EditPatronForm";
            this.Text = "Edit Patron";
            this.Load += new System.EventHandler(this.EditPatronForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox patronCbo;
        private System.Windows.Forms.Label chooseLbl;
        private System.Windows.Forms.Button selectBtn;
    }
}