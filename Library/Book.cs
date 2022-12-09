using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public class Book
    {
        public int Id { get; protected set; }
        public string Title { get; set; }
        public int NumberOfPages { get; set; }
        public string Authors { get; set; }
        public PublishingHouse Publisher { get; set; }
        public string Status { get; set; }

        public Book(int id, string title, int numberOfPaegs, string authors,
                    PublishingHouse publisher, string status)
        {
            Id = id;
            Title = title;
            NumberOfPages = numberOfPaegs;
            Authors = authors;
            Status = status;
            Publisher = publisher;
        }
    }
    public class PublishingHouse
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Adress { get; set; }

        public PublishingHouse(int id, string name, string adress)
        {
            Id = id;
            Name = name;
            Adress = adress;
        }
    }
}
