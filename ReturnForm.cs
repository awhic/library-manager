// Program 2
// CIS 200-01
// Fall 2019
// M3738

// File: CheckOutForm.cs
// This class creates the main GUI for returning items.

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
    public partial class ReturnForm : Form
    {
        private List<LibraryItem> itemSelectList;

        // Precondition: None
        // Postcondition: The form's GUI is prepared for display.
        public ReturnForm(List<LibraryItem> items)
        {
            InitializeComponent();
            CenterToParent();

            itemSelectList = items;
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
                errorProvider.SetError(cbo, "Must select an address");
            }
        }

        private void ReturnForm_Load(object sender, EventArgs e)
        {
            foreach (LibraryItem i in itemSelectList)
            {
                if (i.IsCheckedOut())
                    itemSelectCbo.Items.Add(i.Title);
            }
        }

        private void OkBtn_Click(object sender, EventArgs e)
        {
            if (ValidateChildren())
            this.DialogResult = DialogResult.OK;
        }
    }
}
