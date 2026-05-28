using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vt2026_a4.items
{
    internal class Movie : SalesObject
    {
        internal string Format { get; set; }
        internal DateTime Playtime { get; set; }
        public Movie(int id, string name, float price, string format, DateTime playtime, params string[] tags) : base(id, name, price,0, tags)
        {
            Format = format;
            Playtime = playtime;
            Category = Category.MOVIE;
        }
        public override string ToString()
        {
            string output = Id + "," + Category + "," + Name + "," + Price + "," + Amount + ',' + Format + ',' + Playtime;
            foreach (string s in Tags)
            {
                output += ',' + s;
            }
            return output;
        }
    }
}
