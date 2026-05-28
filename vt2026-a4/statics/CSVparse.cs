using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            catch { return 0; }
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
            try
            {

                string[] lines = File.ReadAllLines(path), subline;
                for (int i = 1; i < lines.Length; i++)
                {
                    subline = lines[i].Split(',');
                    switch (Enum.Parse<Category>(subline[1]))
                    {
                        case Category.BOOK:
                            Book obj1 = new(int.Parse(subline[0]), subline[2].Trim(), int.Parse(subline[3]), subline[5].Trim(), subline[6].Trim(), subline[7].Trim(), subline.Skip(8).ToArray());
                            obj1.Amount = uint.Parse(subline[4]);
                            list.Add(obj1);
                            break;
                        case Category.GAME:
                            Game obj2 = new(int.Parse(subline[0]), subline[2].Trim(), int.Parse(subline[3]), subline[5].Trim(), subline.Skip(6).ToArray());
                            obj2.Amount = uint.Parse(subline[4]);
                            list.Add(obj2);
                            break;
                        case Category.MOVIE:
                            Movie obj3 = new(int.Parse(subline[0]), subline[2].Trim(), int.Parse(subline[3]), subline[5].Trim(), DateTime.Parse(subline[6]), subline.Skip(7).ToArray());
                            obj3.Amount = uint.Parse(subline[4]);
                            list.Add(obj3);
                            break;
                        case Category.MISC:
                            Misc obj4 = new(int.Parse(subline[0]), subline[2].Trim(), int.Parse(subline[3]), 0, subline.Skip(5).ToArray());
                            obj4.Amount = uint.Parse(subline[4]);
                            list.Add(obj4);
                            break;
                    }
                }
            }
            catch (Exception) { }
            return list;
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
            string text = "(id , category , name , price , amount , tags)";
            foreach (SalesObject o in list)
            {
                text += "\n" + o.ToString();
            }
            File.WriteAllText(path, text);

        }
    }
}
