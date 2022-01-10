using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp24
{
    class Article
    {
        public Article(string title, decimal price, List<string> tags)
        {

            Title = title;
            Price = price;
            Tags = new List<string>();
        }

        public string Title { get; set; }
        public decimal Price { get; set; }
        public List<string> Tags { get; set;}

        public void AddTag(string tag)
        {
            Tags.Add(tag);
        }


    }
}
