using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vt2026_a4.items
{
    internal class Book : SalesObject
    {
        internal string Author { get; set; }
        internal string Genre { get; set; }
        internal string Format { get; set; }
        public Book(int id, string name, float price, string author, string genre, string format, params string[] tags) : base(id, name, price, 0,tags)
        {
            Author = author;
            Genre = genre;
            Format = format;
            Category = Category.BOOK;
        }
        public override string ToString()
        {
            string output = Id + "," + Category + "," + Name + "," + Price + "," + Amount + ',' + Author + ',' + Genre + ',' + Format;
            foreach (string s in Tags)
            {
                output += ',' + s;
            }
            return output;
        }
    }
}
