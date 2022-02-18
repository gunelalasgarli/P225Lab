using System;
using System.Collections.Generic;
using System.Text;

namespace Task3
{
    class Book
    {
        static private int _count = 1000;
        public string Id { get; set; }
        public string BookName { get; set; }
        public double Price { get; set; }
        public double? DiscountedPrice = null;
        public int TotalCount { get; set; }

        public ProductGenre Genre;

        public Book(ProductGenre genre,double price)
        {
            _count++;
            TotalCount++;
            Price = price;
            BookName = BookName;
            Id = $"{genre.ToString()[0]}{_count}";
            if (genre == ProductGenre.Comic)
            {
                DiscountedPrice = Price - (0.2 * Price);
            }
            Genre = genre;

        }
    }
}
