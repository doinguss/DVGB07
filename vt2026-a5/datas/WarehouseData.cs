using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using vt2026_a4.items;

namespace vt2026_a4.datas
{
    internal class warehouseData
    {
        internal List<SalesObject> List { get; set; }
        private int id;
        internal warehouseData(int? id, List<SalesObject>? list)
        {
            this.id = id ?? 0;
            this.List = list ?? new();
        }
        internal void Add(Category category, string name, float price, string author="", string genre="", string format="", string platform="", DateTime playtime=new(), string tags="")
        {
            switch (category)
            {
                case Category.BOOK:     AddBook(    name, price, author, genre, format, tags);  break;
                case Category.GAME:     AddGame(    name, price, platform, tags);               break;
                case Category.MOVIE:    AddMovie(   name, price, format, playtime, tags);       break;
                case Category.MISC:     AddMisc(    name, price, tags);                         break;
            }

        }
        internal void Remove(int index)
        {
            List.RemoveAt(index);
        }
        private void AddBook(string name, float price, string author, string genre, string format, string tags)
        {
            List.Add(new Book(id++, name, price, author, genre, format, tags.Split(',')));
        }
        private void AddGame(string name, float price, string platform, string tags)
        {
            List.Add(new Game(id++, name, price, platform, tags.Split(',')));
        }
        private void AddMovie(string name, float price, string format, DateTime playtime, string tags)
        {
            List.Add(new Movie(id++, name, price, format, playtime, tags.Split(',')));
        }
        private void AddMisc(string name, float price, string tags)
        {
            List.Add(new Misc(id++, name, price, 0,tags.Split(',')));
        }
    }
}
