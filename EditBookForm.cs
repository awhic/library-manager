// Program 2
// CIS 200-01
// Fall 2019
// M3738

// File: CheckOutForm.cs
// This class creates the main GUI for editing existing items.

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
    public partial class EditBookForm : Form
    {
        private List<LibraryBook> bookList;

        public EditBookForm()
        {
        }

        public EditBookForm(List<LibraryBook> books)
        {
            InitializeComponent();
            CenterToParent();
            Visible = false;

            bookList = books;

            foreach (LibraryItem item in books)
            {
                if (item is LibraryBook)
                    bookList.Add(item as LibraryBook);
            }
        }

        internal int BookIndex
        {

            // Precondition:  User has selected from bookCbo
            // Postcondition: The index of the selected book returned
            get
            {
                return bookCbo.SelectedIndex;
            }

            // Precondition:  -1 <= value < bookList.Count
            // Postcondition: The specified index is selected in bookCbo
            set
            {
                if ((value >= -1) && (value < bookList.Count))
                    bookCbo.SelectedIndex = value;
                else
                    throw new ArgumentOutOfRangeException("PatronIndex", value,
                        "Index must be valid.");
            }
        }

        private void EditBookForm_Load(object sender, EventArgs e)
        {

        }
    }
}
