using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vt2026_a4.items
{
    internal class Misc : SalesObject
    {
        internal Misc(int id, string name, float price,uint amount=0, params string[] tags) : base(id, name, price,amount, tags)
        {
            Category = Category.MISC;
        }
    }
}
