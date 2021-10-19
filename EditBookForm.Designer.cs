namespace LibraryItems
{
    partial class EditBookForm
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
            this.selectBtn = new System.Windows.Forms.Button();
            this.chooseLbl = new System.Windows.Forms.Label();
            this.bookCbo = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // selectBtn
            // 
            this.selectBtn.Location = new System.Drawing.Point(64, 72);
            this.selectBtn.Name = "selectBtn";
            this.selectBtn.Size = new System.Drawing.Size(216, 23);
            this.selectBtn.TabIndex = 5;
            this.selectBtn.Text = "Select";
            this.selectBtn.UseVisualStyleBackColor = true;
            // 
            // chooseLbl
            // 
            this.chooseLbl.AutoSize = true;
            this.chooseLbl.Location = new System.Drawing.Point(12, 33);
            this.chooseLbl.Name = "chooseLbl";
            this.chooseLbl.Size = new System.Drawing.Size(46, 13);
            this.chooseLbl.TabIndex = 4;
            this.chooseLbl.Text = "Choose:";
            // 
            // bookCbo
            // 
            this.bookCbo.FormattingEnabled = true;
            this.bookCbo.Location = new System.Drawing.Point(64, 30);
            this.bookCbo.Name = "bookCbo";
            this.bookCbo.Size = new System.Drawing.Size(255, 21);
            this.bookCbo.TabIndex = 3;
            // 
            // EditBookForm
            // 
            this.AcceptButton = this.selectBtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(331, 125);
            this.Controls.Add(this.selectBtn);
            this.Controls.Add(this.chooseLbl);
            this.Controls.Add(this.bookCbo);
            this.Name = "EditBookForm";
            this.Text = "Edit Book";
            this.Load += new System.EventHandler(this.EditBookForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button selectBtn;
        private System.Windows.Forms.Label chooseLbl;
        private System.Windows.Forms.ComboBox bookCbo;
    }
}