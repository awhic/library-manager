// Program 2
// CIS 200-01
// Fall 2019
// M3738

// File: CheckOutForm.cs
// This class creates the main GUI for editing existing patrons.

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
    public partial class EditPatronForm : Form
    {
        private List<LibraryPatron> patronList;
        public EditPatronForm(List<LibraryPatron> patrons)
        {
            InitializeComponent();
            CenterToParent();

            patronList = patrons;

            foreach (LibraryPatron p in patronList)
                patronCbo.Items.Add(p.PatronName);
        }

        internal int PatronIndex
        {

            // Precondition:  User has selected from patronCbo
            // Postcondition: The index of the selected patron returned
            get
            {
                return patronCbo.SelectedIndex;
            }

            // Precondition:  -1 <= value < patronList.Count
            // Postcondition: The specified index is selected in patronCbo
            set
            {
                if ((value >= -1) && (value < patronList.Count))
                    patronCbo.SelectedIndex = value;
                else
                    throw new ArgumentOutOfRangeException("PatronIndex", value,
                        "Index must be valid.");
            }
        }

        private void EditPatronForm_Load(object sender, EventArgs e)
        {

        }

        private void SelectBtn_Click(object sender, EventArgs e)
        {
            if (ValidateChildren())
                this.DialogResult = DialogResult.OK;
        }
    }
}
