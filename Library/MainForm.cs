using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;
using Timer = System.Windows.Forms.Timer;

namespace Library
{
    public partial class MainForm : Form
    {
        public static List<Book> books { get; set; }
        public static DataTable table = new DataTable();
        public static DataTable selectedTable = new DataTable();
        Helper helper = new Helper();

        public MainForm()
        {
            InitializeComponent();
            table.Columns.Add("ID", typeof(int));
            table.Columns.Add("Назва", typeof(string));
            table.Columns.Add("Кількість сторінок", typeof(int));
            table.Columns.Add("Автори", typeof(string));
            table.Columns.Add("Видання", typeof(string));
            table.Columns.Add("Місце видання", typeof(string));
            table.Columns.Add("Статус", typeof(string));

            selectedTable.Columns.Add("ID", typeof(int));
            selectedTable.Columns.Add("Назва", typeof(string));
            selectedTable.Columns.Add("Кількість сторінок", typeof(int));
            selectedTable.Columns.Add("Автори", typeof(string));
            selectedTable.Columns.Add("Видання", typeof(string));
            selectedTable.Columns.Add("Місце видання", typeof(string));
            selectedTable.Columns.Add("Статус", typeof(string));

            helper.Timer = timer1;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            books = new List<Book>
            {
                new Book(1,"t1", 200, "a1, a2", new PublishingHouse(1, "ph1", "ad1"), "reading"),
                new Book(2,"t2", 340, "a1, a3", new PublishingHouse(02, "ph1", "ad2"), "not started"),
                new Book(3,"t3", 400, "a2, a5", new PublishingHouse(03, "ph1", "ad2"), "finished"),
            };

            foreach (var item in books)
            {
                table.Rows.Add(item.Id, item.Title, item.NumberOfPages, item.Authors, item.Publisher.Name,
                    item.Publisher.Adress, item.Status);
            }

            dataGridView1.DataSource = table;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int id = dataGridView1.CurrentCell.RowIndex;
                table.Rows.RemoveAt(id);
                books.RemoveAt(id);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            AddBookForm newForm = new AddBookForm();
            newForm.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int id = dataGridView1.CurrentCell.RowIndex;
                Book selectedBook = books[id];
                UpdateBookForm newForm = new UpdateBookForm(selectedBook, id);
                newForm.Show();
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            AboutBox1 aboutBox1 = new AboutBox1();
            aboutBox1.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string path = @"D:\cyber_knu\degree2\oop\Library\Library\data.json";
            using (FileStream fstream = new FileStream(path, FileMode.Create))
            {
                JsonSerializer.Serialize(fstream, books, new JsonSerializerOptions { WriteIndented = true });
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            var selectedBooks = helper.SearchByAuthor(books, textBox1.Text);

            selectedTable.Clear();
            foreach (var item in selectedBooks)
            {
                selectedTable.Rows.Add(item.Id, item.Title, item.NumberOfPages, item.Authors, item.Publisher.Name,
                    item.Publisher.Adress, item.Status);
            }

            dataGridView1.DataSource = selectedTable;
            textBox1.Text = "";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            int num = textBox2.Text == "" ? int.MaxValue : Convert.ToInt32(textBox2.Text);
            var selectedBooks = helper.SearchByNumOfPages(books, num);

            selectedTable.Clear();
            foreach (var item in selectedBooks)
            {
                selectedTable.Rows.Add(item.Id, item.Title, item.NumberOfPages, item.Authors, item.Publisher.Name,
                    item.Publisher.Adress, item.Status);
            }

            dataGridView1.DataSource = selectedTable;
            textBox2.Text = "";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            var selectedBooks = helper.SearchByPublisherAdress(books, textBox3.Text);

            selectedTable.Clear();
            foreach (var item in selectedBooks)
            {
                selectedTable.Rows.Add(item.Id, item.Title, item.NumberOfPages, item.Authors, item.Publisher.Name,
                    item.Publisher.Adress, item.Status);
            }

            dataGridView1.DataSource = selectedTable;
            textBox3.Text = "";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = table;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            MessageBox.Show("Ваш час сплив! Дякуємо, що використовуєте наші послуги. Для необмеженого" +
                " по часу доступу придбаєте професійну версію!", "Повідомлення", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            Close();
        }
    }
    public class Helper
    {
        public Timer Timer { get; set; }

        public List<Book> SearchByAuthor(List<Book> books, string authors)
        {
            var selectedBooks = books.Where(p => p.Authors.Contains(authors)).ToList();
            return selectedBooks;
        }
        public List<Book> SearchByNumOfPages(List<Book> books, int num)
        {
            var selectedBooks = (from p in books
                                where p.NumberOfPages < num 
                                select p).ToList();
            return selectedBooks;
        }
        public List<Book> SearchByPublisherAdress(List<Book> books, string adress)
        {
            var selectedBooks = books.Where(p => p.Publisher.Adress == adress).ToList();
            return selectedBooks;
        }
    }
}
