using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;

namespace Library
{
    public partial class AddBookForm : Form
    {
        public AddBookForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                MainForm.table.Rows.Add(Convert.ToInt32(textBoxID.Text), textBoxTitle.Text,
                    Convert.ToInt32(textBoxNumOfPages.Text), textBoxAuthors.Text, 
                    textBoxPublisher.Text, textBoxPublisherAdress.Text, textBoxStatus.Text);

                MainForm.books.Add(new Book(Convert.ToInt32(textBoxID.Text), textBoxTitle.Text,
                    Convert.ToInt32(textBoxNumOfPages.Text), textBoxAuthors.Text,
                    new PublishingHouse(0, textBoxPublisher.Text, textBoxPublisherAdress.Text), textBoxStatus.Text));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            Close();
        }
    }
}
