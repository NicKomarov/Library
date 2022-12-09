using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library
{
    public partial class UpdateBookForm : Form
    {
        Book book;
        int id;
        public UpdateBookForm(Book b, int id)
        {
            InitializeComponent();
            book = b;
            this.id = id;

            textBoxID.Text = Convert.ToString(b.Id);
            textBoxAuthors.Text = b.Authors;
            textBoxTitle.Text = b.Title;
            textBoxNumOfPages.Text = Convert.ToString(b.NumberOfPages);
            textBoxPublisher.Text = b.Publisher.Name;
            textBoxPublisherAdress.Text = b.Publisher.Adress;
            textBoxStatus.Text = b.Status;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Book newBook = new Book(Convert.ToInt32(textBoxID.Text), textBoxTitle.Text,
                    Convert.ToInt32(textBoxNumOfPages.Text), textBoxAuthors.Text,
                    new PublishingHouse(0, textBoxPublisher.Text, textBoxPublisherAdress.Text), textBoxStatus.Text);

            MainForm.books[id] = newBook;

            MainForm.table.Rows[id]["ID"] = newBook.Id;
            MainForm.table.Rows[id]["Назва"] = newBook.Title;
            MainForm.table.Rows[id]["Кількість сторінок"] = newBook.NumberOfPages;
            MainForm.table.Rows[id]["Автори"] = newBook.Authors;
            MainForm.table.Rows[id]["Видання"] = newBook.Publisher.Name;
            MainForm.table.Rows[id]["Місце видання"] = newBook.Publisher.Adress;
            MainForm.table.Rows[id]["Статус"] = newBook.Status;

            Close();
        }
    }
}
