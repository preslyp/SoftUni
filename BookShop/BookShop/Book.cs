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

        public string Title
        {
            get 
            { 
                return this.title; 
            }

            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException("The name can't be null");
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

            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException("The name can't be null");
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

           set 
           {
               if (value < 0)
               {
                   throw new ArgumentOutOfRangeException("The price can't be negative");
               }

               this.price = value;
           } 
       }

       public override string ToString()
       {
           StringBuilder output = new StringBuilder();
           output.AppendFormat("-Type: {0}{1}", this.GetType().Name, Environment.NewLine);
           output.AppendFormat("-Author: {0}{1}", this.Author, Environment.NewLine);
           output.AppendFormat("-Price: {0}{1}", this.Price, Environment.NewLine);
           return output.ToString();
       }
    }
}
