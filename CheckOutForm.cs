// Program 2
// CIS 200-01
// Fall 2019
// M3738

// File: CheckOutForm.cs
// This class creates the main GUI for checking out items.

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
    public partial class CheckOutForm : Form
    {
        private List<LibraryItem> itemSelectList;
        private List<LibraryPatron> patronSelectList;

        public string checkedOut = "Item Unavailable";

        // Precondition: None
        // Postcondition: The form's GUI is prepared for display.
        public CheckOutForm(List<LibraryItem> items, List<LibraryPatron> patrons)
        {
            InitializeComponent();
            CenterToParent();

            itemSelectList = items;
            patronSelectList = patrons;
        }

        internal int ItemSelectIndex
        {
            // Precondition:  User has selected from itemSelectCbo
            // Postcondition: The index of the selected item returned
            get
            { 
                return itemSelectCbo.SelectedIndex;
            }

            // Precondition:  -1 <= value < addressList.Count
            // Postcondition: The specified index is selected in originAddCbo
            set
            {
                if ((value >= -1) && (value < itemSelectList.Count))
                    itemSelectCbo.SelectedIndex = value;
                else
                    throw new ArgumentOutOfRangeException("ItemSelectIndex", value,
                        "Index must be valid");
            }
        }

        internal int PatronSelectIndex
        {
            // Precondition:  User has selected from itemSelectCbo
            // Postcondition: The index of the selected item returned
            get
            {
                return patronSelectCbo.SelectedIndex;
            }

            // Precondition:  -1 <= value < patronSelectList.Count
            // Postcondition: The specified index is selected in originAddCbo
            set
            {
                if ((value >= -1) && (value < patronSelectList.Count))
                    patronSelectCbo.SelectedIndex = value;
                else
                    throw new ArgumentOutOfRangeException("PatronSelectIndex", value,
                        "Index must be valid");
            }
        }

        private void CheckOutForm_Load(object sender, EventArgs e)
        {
            foreach (LibraryItem i in itemSelectList)
            {
                string co = checkedOut;

                itemSelectCbo.Items.Add(i.Title);
                if (i.IsCheckedOut() == true)
                {
                    itemSelectCbo.Items.Add(co);
                    itemSelectCbo.Items.Remove(i.Title);
                }
            }

            foreach (LibraryPatron p in patronSelectList)
            {
                patronSelectCbo.Items.Add(p.PatronName);
            }
        }

        // Precondition:  Focus shifting from one of the item combo boxes
        //                sender is ComboBox
        // Postcondition: If no item selected, focus remains and error provider
        //                highlights the field
        private void itemSelectCbo_Validating(object sender, CancelEventArgs e)
        {
            // Downcast to sender as ComboBox, so make sure you obey precondition!
            ComboBox cbo = sender as ComboBox; // Cast sender as combo box

            if (cbo.SelectedIndex == -1) // -1 means no item selected
            {
                e.Cancel = true;
                errorProvider.SetError(cbo, "Must select an item");
            }

            if (cbo.SelectedIndex.ToString() == checkedOut)
            {
                e.Cancel = true;
                errorProvider.SetError(cbo, "Item is unavailable. Please select another item.");
            }

        }

        // Precondition:  Focus shifting from one of the patron combo boxes
        //                sender is ComboBox
        // Postcondition: If no patron selected, focus remains and error provider
        //                highlights the field
        private void patronSelectCbo_Validating(object sender, CancelEventArgs e)
        {
            // Downcast to sender as ComboBox, so make sure you obey precondition!
            ComboBox cbo = sender as ComboBox; // Cast sender as combo box

            if (cbo.SelectedIndex == -1) // -1 means no item selected
            {
                e.Cancel = true;
                errorProvider.SetError(cbo, "Must select a patron");
            }
        }

        // Precondition:  User pressed on cancelBtn
        // Postcondition: Form closes
        private void cancelBtn_MouseDown(object sender, MouseEventArgs e)
        {
            // This handler uses MouseDown instead of Click event because
            // Click won't be allowed if other field's validation fails

            if (e.Button == MouseButtons.Left) // Was it a left-click?
                this.DialogResult = DialogResult.Cancel;
        }

        private void OkBtn_Click(object sender, EventArgs e)
        {
            if(ValidateChildren())
                this.DialogResult = DialogResult.OK;
        }
    }
}
