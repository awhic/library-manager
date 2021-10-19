// Program 2
// CIS 200-01
// Fall 2019
// M3738

// File: BookForm.cs
// This class creates the main GUI for the Book Form. The user enters a title,
// publisher, copyright year, loan period, call number and author, and the book
// is added to the list of books.

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryItems
{
    [Serializable]
    public partial class BookForm : Form
    {
        public BookForm()
        {
            InitializeComponent();
            CenterToParent();
        }

        internal string BookTitle
        {
            // Precondition:  None
            // Postcondition: The text of form's title field is returned
            get
            {
                return titleTxt.Text;
            }

            // Precondition:  None
            // Postcondition: The text of form's title field is set
            //                to specified value
            set
            {
                titleTxt.Text = value;
            }
        }

        internal string BookPublisher
        {
            // Precondition:  None
            // Postcondition: The text of form's publisher field is returned
            get
            {
                return pubTxt.Text;
            }

            // Precondition:  None
            // Postcondition: The text of form's publisher field is set
            //                to specified value
            set
            {
                pubTxt.Text = value;
            }
        }

        internal string BookCopyrightYear
        {
            // Precondition:  None
            // Postcondition: The text of form's copyright year field is returned
            get
            {
                return copyTxt.Text;
            }

            // Precondition:  None
            // Postcondition: The text of form's copyright year field is set
            //                to specified value
            set
            {
                copyTxt.Text = value;
            }
        }

        internal string BookLoanPeriod
        {
            // Precondition:  None
            // Postcondition: The text of form's loan period field is returned
            get
            {
                return loanTxt.Text;
            }

            // Precondition:  None
            // Postcondition: The text of form's loan period field is set
            //                to specified value
            set
            {
                loanTxt.Text = value;
            }
        }

        internal string BookCallNumber
        {
            // Precondition:  None
            // Postcondition: The text of form's call number field is returned
            get
            {
                return callTxt.Text;
            }

            // Precondition:  None
            // Postcondition: The text of form's call number field is set
            //                to specified value
            set
            {
                callTxt.Text = value;
            }
        }

        internal string BookAuthor
        {
            // Precondition:  None
            // Postcondition: The text of form's author field is returned
            get
            {
                return authorTxt.Text;
            }

            // Precondition:  None
            // Postcondition: The text of form's author field is set
            //                to specified value
            set
            {
                authorTxt.Text = value;
            }

        }

        private void RequiredTextFields_Validating(object sender, CancelEventArgs e)
        {
            // Downcast to sender as TextBox, so make sure you obey precondition!
            TextBox textbox = sender as TextBox; // Cast sender as TextBox
                                                 // Should always be a TextBox

            if (string.IsNullOrWhiteSpace(textbox.Text)) // Empty field
            {
                e.Cancel = true;

                errorProvider.SetError(textbox, "Must enter a value!");
            }
        }

        // Precondition:  Validating of sender not cancelled, so data OK
        //                sender is Control
        // Postcondition: Error provider cleared and focus allowed to change
        private void AllFields_Validated(object sender, EventArgs e)
        {
            Control control = sender as Control;

            errorProvider.SetError(control, "");
        }

        // Precondition:  User pressed on cancelBtn
        // Postcondition: Form closes and sends Cancel result
        private void CancelBtn_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
                this.DialogResult = DialogResult.Cancel;
        }

        // Precondition:  User clicked on okBtn
        // Postcondition: If invalid field on dialog, keep form open and 
        //                give first invalid field the focus. Else return 
        //                OK and close form.
        private void okBtn_Click(object sender, EventArgs e)
        {
            if (ValidateChildren())
                this.DialogResult = DialogResult.OK;

        }

        private void BookForm_Load(object sender, EventArgs e)
        {

        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }
    }
}
