namespace LibraryItems
{
    partial class CheckOutForm
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
            this.itemSelectCbo = new System.Windows.Forms.ComboBox();
            this.itemSelectLbl = new System.Windows.Forms.Label();
            this.patronSelectLbl = new System.Windows.Forms.Label();
            this.patronSelectCbo = new System.Windows.Forms.ComboBox();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.okBtn = new System.Windows.Forms.Button();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // itemSelectCbo
            // 
            this.itemSelectCbo.FormattingEnabled = true;
            this.itemSelectCbo.Location = new System.Drawing.Point(97, 28);
            this.itemSelectCbo.Name = "itemSelectCbo";
            this.itemSelectCbo.Size = new System.Drawing.Size(228, 21);
            this.itemSelectCbo.TabIndex = 0;
            this.itemSelectCbo.Validating += new System.ComponentModel.CancelEventHandler(this.itemSelectCbo_Validating);
            // 
            // itemSelectLbl
            // 
            this.itemSelectLbl.AutoSize = true;
            this.itemSelectLbl.Location = new System.Drawing.Point(28, 31);
            this.itemSelectLbl.Name = "itemSelectLbl";
            this.itemSelectLbl.Size = new System.Drawing.Size(63, 13);
            this.itemSelectLbl.TabIndex = 1;
            this.itemSelectLbl.Text = "Select Item:";
            // 
            // patronSelectLbl
            // 
            this.patronSelectLbl.AutoSize = true;
            this.patronSelectLbl.Location = new System.Drawing.Point(17, 78);
            this.patronSelectLbl.Name = "patronSelectLbl";
            this.patronSelectLbl.Size = new System.Drawing.Size(74, 13);
            this.patronSelectLbl.TabIndex = 2;
            this.patronSelectLbl.Text = "Select Patron:";
            // 
            // patronSelectCbo
            // 
            this.patronSelectCbo.FormattingEnabled = true;
            this.patronSelectCbo.Location = new System.Drawing.Point(97, 75);
            this.patronSelectCbo.Name = "patronSelectCbo";
            this.patronSelectCbo.Size = new System.Drawing.Size(228, 21);
            this.patronSelectCbo.TabIndex = 3;
            this.patronSelectCbo.Validating += new System.ComponentModel.CancelEventHandler(this.patronSelectCbo_Validating);
            // 
            // cancelBtn
            // 
            this.cancelBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelBtn.Location = new System.Drawing.Point(250, 132);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(75, 23);
            this.cancelBtn.TabIndex = 9;
            this.cancelBtn.Text = "Cancel";
            this.cancelBtn.UseVisualStyleBackColor = true;
            this.cancelBtn.MouseDown += new System.Windows.Forms.MouseEventHandler(this.cancelBtn_MouseDown);
            // 
            // okBtn
            // 
            this.okBtn.Location = new System.Drawing.Point(97, 132);
            this.okBtn.Name = "okBtn";
            this.okBtn.Size = new System.Drawing.Size(75, 23);
            this.okBtn.TabIndex = 8;
            this.okBtn.Text = "OK";
            this.okBtn.UseVisualStyleBackColor = true;
            this.okBtn.Click += new System.EventHandler(this.OkBtn_Click);
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // CheckOutForm
            // 
            this.AcceptButton = this.okBtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.cancelBtn;
            this.ClientSize = new System.Drawing.Size(386, 186);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.okBtn);
            this.Controls.Add(this.patronSelectCbo);
            this.Controls.Add(this.patronSelectLbl);
            this.Controls.Add(this.itemSelectLbl);
            this.Controls.Add(this.itemSelectCbo);
            this.Name = "CheckOutForm";
            this.Text = "Check Out";
            this.Load += new System.EventHandler(this.CheckOutForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox itemSelectCbo;
        private System.Windows.Forms.Label itemSelectLbl;
        private System.Windows.Forms.Label patronSelectLbl;
        private System.Windows.Forms.ComboBox patronSelectCbo;
        private System.Windows.Forms.Button cancelBtn;
        private System.Windows.Forms.Button okBtn;
        private System.Windows.Forms.ErrorProvider errorProvider;
    }
}