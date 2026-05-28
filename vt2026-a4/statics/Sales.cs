using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.Design;

namespace vt2026_a4.statics
{
    /// <summary>
    /// takes care of saving and retriving data retaining to sales, static class
    /// </summary>
    internal static class Sales
    {
        private static string path = "salesdata.csv";
        internal static void Log(string line)
        {
            File.AppendAllText(path, line);
        }
        /// <summary>
        /// funnels data into the Log(string) method above and it just like saves it to the file nothing special
        /// </summary>
        /// <param name="id"></param>
        /// <param name="amount"></param>
        /// <param name="cost"></param>
        /// <param name="date"></param>
        internal static void Log(int id, int amount, float cost, DateTime date)
        {
            Log(id.ToString() + "," + amount.ToString() + "," + cost.ToString() + "," + date.ToString() + "\n");
        }
        /// <summary>
        /// returns a list of string arrays where each entry in the list is an item and each 
        /// entry in the array is a specific data point but in a string format
        /// 
        /// arr[0]=id
        /// arr[1]=amount
        /// arr[2]= money made form this transaction
        /// arr[3]= date and time
        /// 
        /// </summary>
        /// <returns></returns>
        internal static List<string[]> Get()
        {
            List<string[]> result = new();
            foreach (string s in File.ReadLines(path))
            {
                result.Add(s.Split(','));
            }
            return result;
        }
        /// <summary>
        /// returns the id of the most prominent product to be sold in the file
        /// does not acount for amount bought in a purchase just how many diffrent purcheses
        /// this item appears in
        /// </summary>
        /// <param name="exclude"></param>
        /// <returns></returns>
        private static int? MostPopular(List<int?> exclude)
        {
            List<int> ids = new();
            foreach (string[] s in Get())
            {
                if (s.Length != 4) { continue; }
                try
                {
                    if (exclude.Contains(int.Parse(s[0]))) { continue; }
                    ids.Add(int.Parse(s[0]));
                }
                catch { }

            }
            // Source - https://stackoverflow.com/a/355977
            // Posted by Marc Gravell, modified by community. See post 'Timeline' for change history
            // Retrieved 2026-05-22, License - CC BY-SA 2.5
            int? most = null;
            try
            {
                most = ids.GroupBy(i => i).OrderByDescending(grp => grp.Count())
                      .Select(grp => grp.Key).First();
            }catch {}
            return most;
        }
        /// <summary>
        /// returns a 10 long list of the top 10 most popular purcheses using the method above
        /// </summary>
        /// <returns></returns>
        internal static List<int?> Top10()
        {
            List<int?> result = new();
            for (int i = 0; i < 10; i++)
            {
                result.Add(MostPopular(result));
            }
            return result;
        }
    }
}
