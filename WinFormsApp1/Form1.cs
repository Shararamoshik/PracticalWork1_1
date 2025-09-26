using Core;
using System;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        private BookService bookService = new BookService();

        public Form1()
        {
            InitializeComponent();
            RefreshBooksList();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            bookService.CreateBook(txtTitle.Text, txtAuthor.Text, int.Parse(nudYear.Text));
            MessageBox.Show("Книга создана!");
            RefreshBooksList();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (listBoxBooks.SelectedItem is Book selectedBook)
            {
                bookService.DeleteBook(selectedBook.Id);
                RefreshBooksList();
            }
        }

        private void RefreshBooksList()
        {
            var books = bookService.GetAllBooks();
            listBoxBooks.DataSource = null;
            listBoxBooks.DataSource = books;
            listBoxBooks.DisplayMember = "Title";


        }

        private void listBoxBooks_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxBooks.SelectedItem is Book selectedBook)
            {
                txtTitle.Text = selectedBook.Title;
                txtAuthor.Text = selectedBook.Author;
                nudYear.Text = selectedBook.Year.ToString();
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (listBoxBooks.SelectedItem is Book selectedBook)
            {
                bookService.UpdateBook(selectedBook.Id, txtTitle.Text, txtAuthor.Text, int.Parse(nudYear.Text));
                RefreshBooksList();
            }
        }

        private void btnGroupByAuthor_Click(object sender, EventArgs e)
        {
            var groups = bookService.GroupByAuthor();
            string message = "";
            foreach (var group in groups)
            {
                message += $"Автор: {group.Key}\n";
                foreach (var book in group.Value)
                {
                    message += $"  {book.Title} ({book.Year})\n";
                }
            }
            MessageBox.Show(message);
        }

        private void btnSearchByYear_Click(object sender, EventArgs e)
        {
            var yearForm = new Form();
            yearForm.Text = "Поиск по году";
            yearForm.Size = new Size(300, 150);
            yearForm.StartPosition = FormStartPosition.CenterParent;

            var numericUpDown = new NumericUpDown();
            numericUpDown.Minimum = 0;
            numericUpDown.Maximum = 2100;
            numericUpDown.Value = 2025;
            numericUpDown.Location = new Point(20, 20);
            numericUpDown.Width = 100;

            var button = new Button();
            button.Text = "Найти";
            button.Location = new Point(130, 20);
            button.Width = 100;

            yearForm.Controls.Add(numericUpDown);
            yearForm.Controls.Add(button);

            button.Click += (s, args) =>
            {
                var books = bookService.GetBooksByYear((int)numericUpDown.Value);
                listBoxBooks.DataSource = books;
                yearForm.Close();
            };

            yearForm.ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            RefreshBooksList();
        }


    }
}