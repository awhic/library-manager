// Program 2
// CIS 200-01
// Fall 2019
// M3738

// File: Prog2Form.cs
// This class creates the main GUI for Program 2. It provides a
// File menu with About and Exit items, an Insert menu with Patron and Book
// items, an Item menu with CheckOut and Return items, and a Report menu with
// Patron List, Item List and Checked Out Items items.

using System;
using System.Text;
using System.Windows.Forms;
using System.Collections.Generic;
using System.IO; // IO using clause
using System.Runtime.Serialization.Formatters.Binary; // Binary Formatter using clause
using System.Runtime.Serialization; // Serialization using clause

namespace LibraryItems
{
    [Serializable]
    public partial class Prog2Form : Form
    {
        private Library lib; // The Library

        private BinaryFormatter formatter = new BinaryFormatter(); // Binary Formatter

        // Precondition:  None
        // Postcondition: The form's GUI is prepared for display. A few test
        //                patrons and books are added to the list of
        //                patrons and books.
        public Prog2Form()
        {
            InitializeComponent();
            CenterToScreen();

            lib = new Library();

            // Test data - Items
            lib.AddLibraryBook("The Wright Guide to C#", "UofL Press", 2010, 14,
                "ZZ25 3G", "Andrew Wright");
            lib.AddLibraryBook("1984", "Harcourt", 1949, 12,
                "XX38 2F", "George Orwell");
            lib.AddLibraryBook("The Hobbit", "Random House", 1937, 11,
                "RR17 5E", "J.R.R. Tolkien");
            lib.AddLibraryBook("A Farewell to Arms", "Charles Scribners' Sons",
                1929, 13, "HH12 4K", "Ernest Hemingway");
            lib.AddLibraryMovie("Andrew's Super-Duper Movie", "UofL Movies", 2011, 7,
            "MM33 2D", 92.5, "Andrew L. Wright", LibraryMediaItem.MediaType.BLURAY,
            LibraryMovie.MPAARatings.PG);
            lib.AddLibraryMusic("C# - The Album", "UofL Music", 2014, 14,
            "CD44 4Z", 84.3, "Dr. A", LibraryMediaItem.MediaType.CD, 10);
            lib.AddLibraryJournal("Journal of C# Goodness", "UofL Journals", 2017, 14,
            "JJ12 7M", 1, 2, "Information Systems", "Andrew Wright");
            lib.AddLibraryMagazine("C# Monthly", "UofL Mags", 2019, 14,
            "MA53 9A", 16, 7);
            lib.AddLibraryMovie("Star Wars", "Lucasfilm", 1977, 10, "NH77 3M", 94.6,
                "George Lucas", LibraryMediaItem.MediaType.VHS, LibraryMovie.MPAARatings.PG);
            lib.AddLibraryMovie("Shawshank Redemption", "Sony", 1992, 12, "TT45 4U", 101,
                "Steven Spielberg", LibraryMediaItem.MediaType.DVD, LibraryMovie.MPAARatings.PG13);


            // Test data - Patrons
            lib.AddPatron("Ima Reader", "12345");
            lib.AddPatron("Alexander Hickey", "22101");
            lib.AddPatron("Alfred Hitchcock", "10108");
            lib.AddPatron("Lamar Jackson", "72617");
            lib.AddPatron("Jane Doe", "11223");
        }

        private void AboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string nl = Environment.NewLine; // new line variable

            MessageBox.Show($"Program 2 Make-up{nl}M3738{nl}CIS 200-01{nl}2019",
                "About Program 2");
        }

        // IGNORE
        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit(); // exits the application
        }

        // IGNORE
        private void FileToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        // IGNORE
        private void Prog2Form_Load(object sender, EventArgs e)
        {

        }

        private void PatronToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PatronForm patronForm = new PatronForm();
            DialogResult result = patronForm.ShowDialog();

            if (result == DialogResult.OK)
                lib.AddPatron(patronForm.PatronName, patronForm.PatronID);

            patronForm.Dispose();
        }

        private void ExitToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Application.Exit(); // exits the application
        }

        private void BookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BookForm bookForm = new BookForm();
            DialogResult result = bookForm.ShowDialog();
            int year;
            int loan;

            if (result == DialogResult.OK)
            {
                if (int.TryParse(bookForm.BookCopyrightYear, out year) &&
                    int.TryParse(bookForm.BookLoanPeriod, out loan))
                {
                    lib.AddLibraryBook(bookForm.BookTitle, bookForm.BookPublisher, year, loan,
                    bookForm.BookCallNumber,
                    bookForm.BookAuthor);
                }
                else
                {
                    MessageBox.Show("Problem with Book Validation!", "Validation Error");
                }
            }

            bookForm.Dispose();
        }

        private void PatronListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StringBuilder result = new StringBuilder();

            string nl = Environment.NewLine;

            result.Append("Patrons:");
            result.Append(nl); // Remember, \n doesn't always work in GUIs
            result.Append(nl);

            foreach (LibraryPatron p in lib.GetPatronsList())
            {
                result.Append(p.ToString());
                result.Append(nl);
                result.Append("------------------------------");
                result.Append(nl);
            }

            result.Append(nl);
            result.Append("Patron Count: ");
            result.Append(lib.GetPatronCount());

            reportTxt.Text = result.ToString();

        }

        private void ItemListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StringBuilder result = new StringBuilder();

            string nl = Environment.NewLine;

            result.Append("Items:");
            result.Append(nl);
            result.Append(nl);

            foreach (LibraryItem l in lib.GetItemsList())
            {
                result.Append(l.ToString());
                result.Append(nl);
                result.Append("------------------------------");
                result.Append(nl);
            }

            result.Append(nl);
            result.Append("Items Count: ");
            result.Append(lib.GetItemCount());

            reportTxt.Text = result.ToString();
        }

        private void CheckedOutItemsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StringBuilder result = new StringBuilder();

            string nl = Environment.NewLine;

            if (lib.GetCheckedOutCount() > 0)
            {
                result.Append("Checked Out Items:");
                result.Append(nl);
                result.Append(nl);

                foreach (LibraryItem c in lib.GetItemsList())
                {
                    if (c.IsCheckedOut())
                    {
                        result.Append(c.ToString());
                        result.Append(nl);
                        result.Append("------------------------------");
                        result.Append(nl);
                    }
                }

                result.Append(nl);
                result.Append("Checked Out Items Count: ");
                result.Append(lib.GetCheckedOutCount());
            }
            else
                result.Append("No checked out items");

            reportTxt.Text = result.ToString();

        }

        private void OpenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BinaryFormatter reader = new BinaryFormatter();
            FileStream input = null;
            DialogResult result;
            string fileName;
            Library temp;

            using (OpenFileDialog fileChooser = new OpenFileDialog())
            {
                result = fileChooser.ShowDialog();
                fileName = fileChooser.FileName;
            }

            if (result == DialogResult.OK)
            {
                if (fileName == string.Empty)
                {
                    MessageBox.Show("Invalid File Name", "Error",
                       MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    try
                    {
                        input = new FileStream(
                           fileName, FileMode.Open, FileAccess.Read);

                        temp = (Library)reader.Deserialize(input);

                        lib = temp;
                    }
                    catch (IOException)
                    {
                        MessageBox.Show("Error reading from the data file",
                           "File Error", MessageBoxButtons.OK,
                           MessageBoxIcon.Error);
                    }
                    catch (SerializationException)
                    {
                        MessageBox.Show("Serialization Error Writing to file.", "Error Message",
                           MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        input?.Close();
                    }
                }
            }
        }

        private void SaveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BinaryFormatter formatter = new BinaryFormatter();
            FileStream output = null;
            DialogResult result;
            string fileName;

            using (SaveFileDialog fileChooser = new SaveFileDialog())
            {
                fileChooser.CheckFileExists = false;

                result = fileChooser.ShowDialog();
                fileName = fileChooser.FileName;
            }

            if (result == DialogResult.OK)
            {
                if (fileName == string.Empty)
                {
                    MessageBox.Show("Invalid File Name", "Error",
                       MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    try
                    {
                        output = new FileStream(fileName,
                           FileMode.Create, FileAccess.Write);

                        formatter.Serialize(output, lib);
                    }
                    catch (IOException)
                    {
                        MessageBox.Show("I/O Error Writing to file.", "Error Message",
                           MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    catch (SerializationException)
                    {
                        MessageBox.Show("Serialization Error Writing to file.", "Error Message",
                           MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        output?.Close();
                    }
                }
            }
        }

        private void PatronEditToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (lib.GetPatronCount() > 0)
            {
                EditPatronForm editPatronForm = new EditPatronForm(lib.GetPatronsList());
                DialogResult result = editPatronForm.ShowDialog();

                if (result == DialogResult.OK)
                {
                    int editIndex;
                    editIndex = editPatronForm.PatronIndex;

                    if (editIndex >= 0)
                    {
                        LibraryPatron editPatron = lib.GetPatronsList()[editIndex];
                        PatronForm patronForm = new PatronForm();

                        patronForm.PatronName = editPatron.PatronName;
                        patronForm.PatronID = editPatron.PatronID;

                        result = patronForm.ShowDialog();

                        if (result == DialogResult.OK)
                        {
                            editPatron.PatronName = patronForm.PatronName;
                            editPatron.PatronID = patronForm.PatronID;
                        }
                    }
                }
            }
        }

        private void BookEditToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // close but not quite
            if (lib.GetItemCount() > 0)
            {
                MessageBox.Show("Close but not quite...");

                EditBookForm editBookForm = new EditBookForm(); // = new EditBookForm(lib.GetItemsList() as LibraryBook);
                DialogResult result = editBookForm.ShowDialog();

                if (result == DialogResult.OK)
                {
                    int editIndex;
                    editIndex = editBookForm.BookIndex;

                    if (editIndex >= 0)
                    {
                        List<LibraryBook> books = null; // = lib.GetItemsList()[editIndex] as LibraryBook;
                        LibraryBook editBook = books[editIndex];
                        BookForm bookForm = new BookForm();

                        bookForm.BookTitle = editBook.Title;
                        bookForm.BookPublisher = editBook.Publisher;
                        bookForm.BookCopyrightYear = $"{editBook.CopyrightYear}";
                        bookForm.BookLoanPeriod = $"{editBook.LoanPeriod}";
                        bookForm.BookCallNumber = editBook.CallNumber;
                        bookForm.BookAuthor = editBook.Author;

                        result = bookForm.ShowDialog();

                        if (result == DialogResult.OK)
                        {
                            editBook.Title = bookForm.BookTitle;
                            editBook.Publisher = bookForm.BookPublisher;
                            if (int.TryParse(bookForm.BookCopyrightYear, out int year))
                                editBook.CopyrightYear = year;
                            else
                                MessageBox.Show("Problem with Copyright Year Validation!");
                            if (int.TryParse(bookForm.BookLoanPeriod, out int loan))
                                editBook.LoanPeriod = loan;
                            else
                                MessageBox.Show("Problem with Loan Period Validation!");
                            editBook.CallNumber = bookForm.BookCallNumber;
                            editBook.Author = bookForm.BookAuthor;
                        }
                    }
                }
            }
        }

        private void CheckOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (lib.GetCheckedOutCount() == 0)
            {
                CheckOutForm checkOutForm;
                DialogResult result;

                checkOutForm = new CheckOutForm(lib.GetItemsList(), lib.GetPatronsList());
                result = checkOutForm.ShowDialog();

                if (result == DialogResult.OK)
                {
                    lib.CheckOut(checkOutForm.ItemSelectIndex,
                        checkOutForm.PatronSelectIndex);
                    MessageBox.Show("Item has been checked out.", "Success");
                }

                checkOutForm.Dispose();
            }

            else
            {
                CheckOutForm checkOutForm;
                DialogResult result;

                checkOutForm = new CheckOutForm(lib.GetItemsList(), lib.GetPatronsList());
                result = checkOutForm.ShowDialog();

                if (result == DialogResult.OK)
                {
                    lib.CheckOut(checkOutForm.ItemSelectIndex,
                        checkOutForm.PatronSelectIndex);
                    MessageBox.Show("Item has been checked out.", "Success");
                }

                checkOutForm.Dispose();
            }

        }

        // IGNORE
        private void DebugToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StringBuilder result = new StringBuilder();

            result.Append(lib.GetCheckedOutCount());

            reportTxt.Text = result.ToString();
        }

        // IGNORE
        private void CheckedOutCountToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StringBuilder result = new StringBuilder();

            result.Append(lib.GetCheckedOutCount());

            reportTxt.Text = result.ToString();
        }

        private void ReturnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (lib.GetCheckedOutCount() > 0)
            {
                ReturnForm returnForm;
                DialogResult result;

                returnForm = new ReturnForm(lib.GetItemsList());
                result = returnForm.ShowDialog();

                if (result == DialogResult.OK)
                {
                    lib.ReturnToShelf(returnForm.ItemSelectIndex);
                    MessageBox.Show("Item has been returned.", "Success");
                }

                returnForm.Dispose();
            }
            else
                MessageBox.Show("There are no checked out items.", "Error");
        }
    }
}
