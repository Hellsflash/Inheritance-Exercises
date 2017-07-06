using System;
using System.Linq;
using System.Text;

namespace Book_Shop
{
    public class Book
    {
        private string title;
        private string author;
        private decimal price;

        public Book(string author, string title, decimal price)
        {
            this.Author = author;
            this.Title = title;
            this.Price = price;
        }
        protected virtual decimal Price
        {
            get { return this.price; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Price not valid!");

                }
                this.price = value;
            }
        }

        protected string Author
        {
            get { return this.author; }
            set
            {
                var names = value
                    .Trim()
                    .Split(" ".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);


                if (names.Length == 2)
                {
                    if (char.IsDigit(value.Split()[1][0]))
                    {
                        throw new ArgumentException("Author not valid!");
                    }
                }
                this.author = value;
            }
        }

        protected  string Title
        {
            get { return this.title; }
            set
            {
                if (value.Length < 3)
                {
                    throw new ArgumentException("Title not valid!");
                }
                this.title = value;
            }
        }

        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("Type: ").AppendLine(this.GetType().Name)
                .Append("Title: ").AppendLine(this.Title)
                .Append("Author: ").AppendLine(this.Author)
                .Append("Price: ").Append($"{this.Price:F1}")
                .AppendLine();
            return sb.ToString();
        }
    }
}
