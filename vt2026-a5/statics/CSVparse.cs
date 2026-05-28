using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using vt2026_a4.items;

namespace vt2026_a4.statics
{
    internal static class CSVparse
    {
        /// <summary>
        /// scanns the given csv file (assuming that its formated)
        /// and returns the id of the lastitem in the file
        /// 
        /// since objects are added with a list.add method theyre always appended
        /// and none of the sort functions actually adjust the lists themselves 
        /// only the displayed versions 
        /// 
        /// and since theyre always appeneded the lowest item will also always have 
        /// the highest id value, the id incraments on new item, and that garantees that
        /// no two items get the same id untill an overflow happens but good luck getting
        /// to that point 
        /// </summary>
        /// <param name="path"></param>
        /// <returns></returns>
        internal static int GetSeedId(string path)
        {
            try
            {
                string[] lines = File.ReadAllLines(path);
                return int.Parse(lines[lines.Length - 1].Split(',')[0]) + 1;
            }
            catch { return 16; }
        }
        /// <summary>
        /// reads csv file and derives a list from that
        /// needs the file to be formaated correctly 
        /// </summary>
        /// <param name="path"></param>
        /// <returns></returns>
        internal static List<SalesObject> GetList(string path)
        {
            List<SalesObject> list = new();

            //code taken from OH material at https://canvas.kau.se/courses/26836/pages/forelasningar-modul-5?module_item_id=821150 22:29 - 25/5 2026
            WebClient client = new WebClient();//this looks to be obsolete? are u guys sure this is how u want to do this
            var text = client.DownloadString("https://hex.cse.kau.se/~jonavest/csharp-api");
            XmlDocument doc = new XmlDocument();
            doc.LoadXml(text);
            // end of copied code from https://canvas.kau.se/courses/26836/pages/forelasningar-modul-5?module_item_id=821150
            
            foreach (XmlElement e1 in doc.FirstChild.ChildNodes)
            {
                if (e1.Name == "error") { throw new(e1.InnerText); }
                if (e1.Name != "products") { continue; }

                foreach (XmlElement e2 in e1.ChildNodes)
                {
                    List<string> tags = new();
                    string? genre = null, format = null, platform = null, playtime = null;
                    string name = "";
                    int id = -1;
                    uint? stock = null;
                    float price = -1;
                    foreach (XmlElement e3 in e2.ChildNodes)
                    {
                        if (e3.Name == "id") { id = int.Parse(e3.InnerText); continue; }
                        if (e3.Name == "name") { name = e3.InnerText; continue; }
                        if (e3.Name == "price") { price = float.Parse(e3.InnerText); continue; }
                        if (e3.Name == "stock") { stock = uint.Parse(e3.InnerText); continue; }
                        if (e3.Name == "genre") { genre = e3.InnerText; continue; }
                        if (e3.Name == "format") { format = e3.InnerText; continue; }
                        if (e3.Name == "Platform") { platform = e3.InnerText; continue; }
                        if (e3.Name == "playtime") { playtime = e3.InnerText; continue; }
                        tags.Add(e3.InnerText);
                    }
                    if (name == "" || id == -1 || stock == null || price == -1) { throw new("error reading from file"); }
                    switch (e2.Name)
                    {
                        case "book": list.Add(new Book(id, name, price, (uint)stock, genre, format, tags.ToArray())); break;
                        case "game": list.Add(new Game(id, name, price, (uint)stock, platform, tags.ToArray())); break;
                        case "movie": tags.Add(format ?? ""); tags.Add("min: " + playtime ?? "..."); list.Add(new Movie(id, name, price, (uint)stock, format, playtime, tags.ToArray())); break;
                        default: list.Add(new Misc(id, name, price, (uint)stock, tags.ToArray())); break;
                    }
                }

            }
            return list;
            //string[] lines = File.ReadAllLines(path), subline;
            //for (int i = 1; i < lines.Length; i++)
            //{
            //    subline = lines[i].Split(',');
            //    switch (Enum.Parse<Category>(subline[1]))
            //    {
            //        case Category.BOOK:
            //            Book obj1 = new(int.Parse(subline[0]), subline[2].Trim(), int.Parse(subline[3]), subline[5].Trim(), subline[6].Trim(), subline[7].Trim(), subline.Skip(8).ToArray());
            //            obj1.Amount = uint.Parse(subline[4]);
            //            list.Add(obj1);
            //            break;
            //        case Category.GAME:
            //            Game obj2 = new(int.Parse(subline[0]), subline[2].Trim(), int.Parse(subline[3]), subline[5].Trim(), subline.Skip(6).ToArray());
            //            obj2.Amount = uint.Parse(subline[4]);
            //            list.Add(obj2);
            //            break;
            //        case Category.MOVIE:
            //            Movie obj3 = new(int.Parse(subline[0]), subline[2].Trim(), int.Parse(subline[3]), subline[5].Trim(), DateTime.Parse(subline[6]), subline.Skip(7).ToArray());
            //            obj3.Amount = uint.Parse(subline[4]);
            //            list.Add(obj3);
            //            break;
            //        case Category.MISC:
            //            Misc obj4 = new(int.Parse(subline[0]), subline[2].Trim(), int.Parse(subline[3]), 0, subline.Skip(5).ToArray());
            //            obj4.Amount = uint.Parse(subline[4]);
            //            list.Add(obj4);
            //            break;
            //    }
            //}
        }
        /// <summary>
        /// saves the list to the csvfile 
        /// firsst line is reserved for categorys which is common good practice
        /// 
        /// this will replace the current csvfile or create it if it doesnt exist
        ///
        /// </summary>
        /// <param name="path"></param>
        /// <param name="list"></param>
        internal static void Save(string path, List<SalesObject> list)
        {
            //path does nothing 

            List<SalesObject> remote=GetList(path);
            foreach (SalesObject item in list)
            {
                foreach (SalesObject item2 in remote)
                {
                    if(item.Id == item2.Id && item.Amount!=item2.Amount)
                    {
                        string request = "https://hex.cse.kau.se/~jonavest/csharp-api/?action=update&id=" + item.Id.ToString() + "&stock=" +item.Amount.ToString();
                        HttpClient client = new();
                        client.GetAsync(request);
                    }
                }
            }

            string text = "(id , category , name , price , amount , tags)";
            foreach (SalesObject o in list)
            {
                text += "\n" + o.ToString();
            }
            File.WriteAllText(path, text);

        }
    }
}
