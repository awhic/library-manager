namespace LibraryItems
{
    partial class BookForm
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
            this.components = new System.ComponentModel.Container();
            this.titleLbl = new System.Windows.Forms.Label();
            this.pubLbl = new System.Windows.Forms.Label();
            this.copyLbl = new System.Windows.Forms.Label();
            this.loanLbl = new System.Windows.Forms.Label();
            this.callLbl = new System.Windows.Forms.Label();
            this.authorLbl = new System.Windows.Forms.Label();
            this.titleTxt = new System.Windows.Forms.TextBox();
            this.pubTxt = new System.Windows.Forms.TextBox();
            this.copyTxt = new System.Windows.Forms.TextBox();
            this.loanTxt = new System.Windows.Forms.TextBox();
            this.callTxt = new System.Windows.Forms.TextBox();
            this.authorTxt = new System.Windows.Forms.TextBox();
            this.okBtn = new System.Windows.Forms.Button();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // titleLbl
            // 
            this.titleLbl.AutoSize = true;
            this.titleLbl.Location = new System.Drawing.Point(24, 21);
            this.titleLbl.Name = "titleLbl";
            this.titleLbl.Size = new System.Drawing.Size(27, 13);
            this.titleLbl.TabIndex = 0;
            this.titleLbl.Text = "Title";
            // 
            // pubLbl
            // 
            this.pubLbl.AutoSize = true;
            this.pubLbl.Location = new System.Drawing.Point(24, 46);
            this.pubLbl.Name = "pubLbl";
            this.pubLbl.Size = new System.Drawing.Size(50, 13);
            this.pubLbl.TabIndex = 1;
            this.pubLbl.Text = "Publisher";
            // 
            // copyLbl
            // 
            this.copyLbl.AutoSize = true;
            this.copyLbl.Location = new System.Drawing.Point(24, 72);
            this.copyLbl.Name = "copyLbl";
            this.copyLbl.Size = new System.Drawing.Size(76, 13);
            this.copyLbl.TabIndex = 2;
            this.copyLbl.Text = "Copyright Year";
            this.copyLbl.Click += new System.EventHandler(this.Label1_Click);
            // 
            // loanLbl
            // 
            this.loanLbl.AutoSize = true;
            this.loanLbl.Location = new System.Drawing.Point(24, 97);
            this.loanLbl.Name = "loanLbl";
            this.loanLbl.Size = new System.Drawing.Size(64, 13);
            this.loanLbl.TabIndex = 3;
            this.loanLbl.Text = "Loan Period";
            // 
            // callLbl
            // 
            this.callLbl.AutoSize = true;
            this.callLbl.Location = new System.Drawing.Point(24, 123);
            this.callLbl.Name = "callLbl";
            this.callLbl.Size = new System.Drawing.Size(64, 13);
            this.callLbl.TabIndex = 4;
            this.callLbl.Text = "Call Number";
            // 
            // authorLbl
            // 
            this.authorLbl.AutoSize = true;
            this.authorLbl.Location = new System.Drawing.Point(24, 146);
            this.authorLbl.Name = "authorLbl";
            this.authorLbl.Size = new System.Drawing.Size(38, 13);
            this.authorLbl.TabIndex = 5;
            this.authorLbl.Text = "Author";
            // 
            // titleTxt
            // 
            this.titleTxt.Location = new System.Drawing.Point(107, 18);
            this.titleTxt.Name = "titleTxt";
            this.titleTxt.Size = new System.Drawing.Size(260, 20);
            this.titleTxt.TabIndex = 6;
            this.titleTxt.Validating += new System.ComponentModel.CancelEventHandler(this.RequiredTextFields_Validating);
            this.titleTxt.Validated += new System.EventHandler(this.AllFields_Validated);
            // 
            // pubTxt
            // 
            this.pubTxt.Location = new System.Drawing.Point(107, 43);
            this.pubTxt.Name = "pubTxt";
            this.pubTxt.Size = new System.Drawing.Size(260, 20);
            this.pubTxt.TabIndex = 7;
            this.pubTxt.Validating += new System.ComponentModel.CancelEventHandler(this.RequiredTextFields_Validating);
            this.pubTxt.Validated += new System.EventHandler(this.AllFields_Validated);
            // 
            // copyTxt
            // 
            this.copyTxt.Location = new System.Drawing.Point(107, 69);
            this.copyTxt.Name = "copyTxt";
            this.copyTxt.Size = new System.Drawing.Size(260, 20);
            this.copyTxt.TabIndex = 8;
            this.copyTxt.Validating += new System.ComponentModel.CancelEventHandler(this.RequiredTextFields_Validating);
            this.copyTxt.Validated += new System.EventHandler(this.AllFields_Validated);
            // 
            // loanTxt
            // 
            this.loanTxt.Location = new System.Drawing.Point(107, 94);
            this.loanTxt.Name = "loanTxt";
            this.loanTxt.Size = new System.Drawing.Size(260, 20);
            this.loanTxt.TabIndex = 9;
            this.loanTxt.Validating += new System.ComponentModel.CancelEventHandler(this.RequiredTextFields_Validating);
            this.loanTxt.Validated += new System.EventHandler(this.AllFields_Validated);
            // 
            // callTxt
            // 
            this.callTxt.Location = new System.Drawing.Point(107, 120);
            this.callTxt.Name = "callTxt";
            this.callTxt.Size = new System.Drawing.Size(260, 20);
            this.callTxt.TabIndex = 10;
            this.callTxt.Validating += new System.ComponentModel.CancelEventHandler(this.RequiredTextFields_Validating);
            this.callTxt.Validated += new System.EventHandler(this.AllFields_Validated);
            // 
            // authorTxt
            // 
            this.authorTxt.Location = new System.Drawing.Point(107, 146);
            this.authorTxt.Name = "authorTxt";
            this.authorTxt.Size = new System.Drawing.Size(260, 20);
            this.authorTxt.TabIndex = 11;
            this.authorTxt.Validating += new System.ComponentModel.CancelEventHandler(this.RequiredTextFields_Validating);
            this.authorTxt.Validated += new System.EventHandler(this.AllFields_Validated);
            // 
            // okBtn
            // 
            this.okBtn.Location = new System.Drawing.Point(107, 185);
            this.okBtn.Name = "okBtn";
            this.okBtn.Size = new System.Drawing.Size(75, 23);
            this.okBtn.TabIndex = 12;
            this.okBtn.Text = "OK";
            this.okBtn.Click += new System.EventHandler(this.okBtn_Click);
            // 
            // cancelBtn
            // 
            this.cancelBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelBtn.Location = new System.Drawing.Point(188, 185);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(75, 23);
            this.cancelBtn.TabIndex = 13;
            this.cancelBtn.Text = "Cancel";
            this.cancelBtn.UseVisualStyleBackColor = true;
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // BookForm
            // 
            this.AcceptButton = this.okBtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.cancelBtn;
            this.ClientSize = new System.Drawing.Size(431, 220);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.okBtn);
            this.Controls.Add(this.authorTxt);
            this.Controls.Add(this.callTxt);
            this.Controls.Add(this.loanTxt);
            this.Controls.Add(this.copyTxt);
            this.Controls.Add(this.pubTxt);
            this.Controls.Add(this.titleTxt);
            this.Controls.Add(this.authorLbl);
            this.Controls.Add(this.callLbl);
            this.Controls.Add(this.loanLbl);
            this.Controls.Add(this.copyLbl);
            this.Controls.Add(this.pubLbl);
            this.Controls.Add(this.titleLbl);
            this.Name = "BookForm";
            this.Text = "Book";
            this.Load += new System.EventHandler(this.BookForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titleLbl;
        private System.Windows.Forms.Label pubLbl;
        private System.Windows.Forms.Label copyLbl;
        private System.Windows.Forms.Label loanLbl;
        private System.Windows.Forms.Label callLbl;
        private System.Windows.Forms.Label authorLbl;
        private System.Windows.Forms.TextBox titleTxt;
        private System.Windows.Forms.TextBox pubTxt;
        private System.Windows.Forms.TextBox copyTxt;
        private System.Windows.Forms.TextBox loanTxt;
        private System.Windows.Forms.TextBox callTxt;
        private System.Windows.Forms.TextBox authorTxt;
        private System.Windows.Forms.Button okBtn;
        private System.Windows.Forms.Button cancelBtn;
        private System.Windows.Forms.ErrorProvider errorProvider;
    }
}