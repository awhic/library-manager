namespace LibraryItems
{
    partial class ReturnForm
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
            this.cancelBtn = new System.Windows.Forms.Button();
            this.okBtn = new System.Windows.Forms.Button();
            this.itemSelectLbl = new System.Windows.Forms.Label();
            this.itemSelectCbo = new System.Windows.Forms.ComboBox();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // cancelBtn
            // 
            this.cancelBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelBtn.Location = new System.Drawing.Point(245, 74);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(75, 23);
            this.cancelBtn.TabIndex = 15;
            this.cancelBtn.Text = "Cancel";
            this.cancelBtn.UseVisualStyleBackColor = true;
            // 
            // okBtn
            // 
            this.okBtn.Location = new System.Drawing.Point(92, 74);
            this.okBtn.Name = "okBtn";
            this.okBtn.Size = new System.Drawing.Size(75, 23);
            this.okBtn.TabIndex = 14;
            this.okBtn.Text = "OK";
            this.okBtn.UseVisualStyleBackColor = true;
            this.okBtn.Click += new System.EventHandler(this.OkBtn_Click);
            // 
            // itemSelectLbl
            // 
            this.itemSelectLbl.AutoSize = true;
            this.itemSelectLbl.Location = new System.Drawing.Point(23, 33);
            this.itemSelectLbl.Name = "itemSelectLbl";
            this.itemSelectLbl.Size = new System.Drawing.Size(63, 13);
            this.itemSelectLbl.TabIndex = 11;
            this.itemSelectLbl.Text = "Select Item:";
            // 
            // itemSelectCbo
            // 
            this.itemSelectCbo.FormattingEnabled = true;
            this.itemSelectCbo.Location = new System.Drawing.Point(92, 30);
            this.itemSelectCbo.Name = "itemSelectCbo";
            this.itemSelectCbo.Size = new System.Drawing.Size(228, 21);
            this.itemSelectCbo.TabIndex = 10;
            this.itemSelectCbo.Validating += new System.ComponentModel.CancelEventHandler(this.itemSelectCbo_Validating);
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // ReturnForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(378, 125);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.okBtn);
            this.Controls.Add(this.itemSelectLbl);
            this.Controls.Add(this.itemSelectCbo);
            this.Name = "ReturnForm";
            this.Text = "Return";
            this.Load += new System.EventHandler(this.ReturnForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cancelBtn;
        private System.Windows.Forms.Button okBtn;
        private System.Windows.Forms.Label itemSelectLbl;
        private System.Windows.Forms.ComboBox itemSelectCbo;
        private System.Windows.Forms.ErrorProvider errorProvider;
    }
}