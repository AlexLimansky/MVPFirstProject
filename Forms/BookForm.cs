using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Data;
using Services;
using Services.Interfaces;

namespace Forms
{
    public partial class BookForm : Form, IBooksView
    {
        public int SelectedBookId { get; set; }
        public Book CurrentBook { get; set; }
        public IEnumerable<Book> BooksList { get; set; }

        public void ShowAllBooks()
        {
            BooksGrid.RowCount = 0;
            foreach (var book in BooksList)
            {
                BooksGrid.RowCount += 1;
                var rownum = BooksGrid.RowCount - 1;
                BooksGrid.Rows[rownum].Cells[0].Value = book.Id;
                BooksGrid.Rows[rownum].Cells[1].Value = book.Author;
                BooksGrid.Rows[rownum].Cells[2].Value = book.Title;
                BooksGrid.Rows[rownum].Cells[3].Value = book.Year;
                BooksGrid.Rows[rownum].Cells[4].Value = book.Amount;
            }
            if (BooksGrid.RowCount != 0)
            {
                BooksGrid.Rows[0].Cells[0].Selected = true;
            }           
        }

        public void ShowOneBook()
        {
            if (CurrentBook == null)
            {
                return;
            }
            authorBox.Text = CurrentBook.Author;
            titleBox.Text = CurrentBook.Title;
            yearBox.Text = CurrentBook.Year.ToString();
            amountBox.Text = CurrentBook.Amount.ToString();
        }

        public event EventHandler SelectedIdChanged = delegate { };
        public event EventHandler<BookEventArgs> BookCreated = delegate { };
        public event EventHandler<BookEventArgs> BookUpdated = delegate { };
        public event EventHandler<int> BookDeleted = delegate { };
      
        public BookForm()
        {
            InitializeComponent();           
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ShowAllBooks();
        }

        private void BooksGrid_SelectionChanged(object sender, EventArgs e)
        {
            var r = 0;
            if (BooksGrid.SelectedCells.Count != 0)
            {
                r = BooksGrid.SelectedCells[0].RowIndex;
            }
            if (BooksGrid.Rows[r].Cells[0].Value == null)
            {
                return;
            }
            SelectedBookId = (int)BooksGrid.Rows[r].Cells[0].Value;
            SelectedIdChanged(this, e);
            ShowOneBook();
        }

        private void AddABook_Click(object sender, EventArgs e)
        {
            var valMessage = Validator.Check(titleBox.Text, authorBox.Text, amountBox.Text, yearBox.Text);
            if (valMessage == "")
            {
                var book = new Book
                {
                    Author = authorBox.Text,
                    Title = titleBox.Text,
                    Year = Convert.ToInt32(yearBox.Text),
                    Amount = Convert.ToInt32(amountBox.Text)
                };
                BookCreated(this, new BookEventArgs(book));
            }
            else
            {
                MessageBox.Show(valMessage);
            }
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            authorBox.Text = "";
            titleBox.Text = "";
            yearBox.Text = "";
            amountBox.Text = "";
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            BookDeleted(this, SelectedBookId);
        }

        private void Edit_Click(object sender, EventArgs e)
        {
            var valMessage = Validator.Check(titleBox.Text, authorBox.Text, amountBox.Text, yearBox.Text);
            if (valMessage == "")
            {
                var book = new Book
                {
                    Author = authorBox.Text,
                    Title = titleBox.Text,
                    Year = Convert.ToInt32(yearBox.Text),
                    Amount = Convert.ToInt32(amountBox.Text)
                };
                BookUpdated(this, new BookEventArgs(book));
            }
            else
            {
                MessageBox.Show(valMessage);
            }
        }
        
    }
}
