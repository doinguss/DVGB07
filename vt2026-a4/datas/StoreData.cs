using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using vt2026_a4.items;

namespace vt2026_a4.datas
{
    internal class storeData
    {
        internal List<SalesObject> List {  get; set; }
        internal List<SalesObject> Cart {  get; set; }

        public storeData(List<SalesObject> list,List<SalesObject> cart)
        {
            List = list??new();
            foreach (SalesObject obj in cart) { obj.Amount = 0; }
            Cart = cart??new();
        }
        /// <summary>
        /// obviously never used... the store sshouldnt have authority to adjust
        /// whats on the catalog
        /// </summary>
        /// <param name="index"></param>
        internal void Remove(int index)
        {
            List.RemoveAt(index);
        }
    }
}
