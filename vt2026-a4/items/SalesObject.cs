using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vt2026_a4.items
{
    internal abstract class SalesObject
    {
        internal int Id { get; set; }
        internal Category Category { get; set; }
        internal string Name { get; set; }
        internal float Price { get; set; }
        internal string[] Tags { get; set; }
        internal uint Amount { get; set; }

        internal SalesObject(int id, string name, float price,uint amount=0, params string[] tags)
        {
            Id = id;
            Name = name;
            Price = price;
            Tags = tags;
            Amount = amount;
        }
        internal SalesObject(SalesObject original)
        {
            Id = original.Id;
            Name = original.Name;
            Price = original.Price;
            Tags = original.Tags;
            Amount = original.Amount;
        }
        public override string ToString()
        {
            string output = Id + ", " + Category + ", " + Name + ", " + Price + ", " + Amount;
            foreach (string s in Tags)
            {
                output += ", " + s;
            }
            return output;
        }
        internal string TagString()
        {
            string output = "";
            for (int i = 0; i < Tags.Length; i++)
            {
                if (i != 0) { output += ", " + Tags[i]; continue; }
                output += Tags[i];
            }
            return output;
        }
    }
}
