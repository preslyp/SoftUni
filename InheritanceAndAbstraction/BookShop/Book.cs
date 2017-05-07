namespace BookShop
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Book
    {
        private string title;
        private string author;
        private double price;



        public Book(string title, string author, double price)
        {
            this.Title = title;
            this.Author = author;
            this.Price = price;
        }


        public Book(string type, string title, string author, double price)
        {
            this.Title = title;
            this.Author = author;
            this.Price = price;
        }



        public string Title
        {
            get
            {
                return this.title;
            }

            protected set
            {
                if (value == null)
                {
                    throw new ArgumentNullException("value","The title name con't ne null");
                }

                this.title = value;
            }
        }

        public string Author
        {
            get
            {
                return this.author;
            }

            protected set
            {
                if (value == null)
                {
                    throw new ArgumentNullException("value", "The author name con't ne null");
                }

                this.author = value;
            }
        }

        public virtual double Price
        {
            get
            {
                return this.price;
            }

            protected set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("value", "The value can't be negative");
                }

                this.price = value;
            }
        }

        public override string ToString()
        {
            StringBuilder output = new StringBuilder();
            output.AppendFormat("-Type: {0}{1}", GetType().Name, Environment.NewLine);
            output.AppendFormat("-Title: {0}{1}", this.Title, Environment.NewLine);
            output.AppendFormat("-Author: {0}{1}", this.Author, Environment.NewLine);
            output.AppendFormat("-Price: {0:F2}", this.Price);
            return output.ToString();
        }
    }
}
