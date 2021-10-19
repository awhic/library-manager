// Program 2
// CIS 200-01
// Fall 2019
// M3738

// File: PatronForm.cs
// This class creates the main GUI for the Patron Form. The user enters a name
// and ID, and the Patron is added to the list of patrons.

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
    public partial class PatronForm : Form
    {
        // Precondition:  None
        // Postcondition: The form's GUI is prepared for display.
        public PatronForm()
        {
            InitializeComponent();
            CenterToParent();
        }

        internal string PatronName
        {
            // Precondition:  None
            // Postcondition: The text of form's name field is returned
            get
            {
                return nameTxt.Text;
            }

            // Precondition:  None
            // Postcondition: The text of form's name field is set
            //                to specified value
            set
            {
                nameTxt.Text = value;
            }
        }

        internal string PatronID
        {
            // Precondition:  None
            // Postcondition: The text of form's id field is returned
            get
            {
                return idTxt.Text;
            }

            // Precondition:  None
            // Postcondition: The text of form's id field is set
            //                to specified value
            set
            {
                idTxt.Text = value;
            }
        }

        // IGNORE
        private void Label1_Click(object sender, EventArgs e)
        {

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

        // IGNORE
        private void PatronForm_Load(object sender, EventArgs e)
        {

        }
    }
}
