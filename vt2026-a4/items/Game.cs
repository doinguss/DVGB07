using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vt2026_a4.items
{
    internal class Game : SalesObject
    {
        internal string Platform {  get; set; }
        public Game(int id, string name, float price,string platform, params string[] tags) : base(id, name, price, 0,tags)
        {
            Platform = platform;
            Category = Category.GAME;
        }
        public override string ToString()
        {
            string output = Id + "," + Category + "," + Name + "," + Price + "," + Amount+','+Platform;
            foreach (string s in Tags)
            {
                output += ',' + s;
            }
            return output;
        }
    }
}
