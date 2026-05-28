using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using vt2026_a4.items;

namespace vt2026_a4.statics
{
    internal static class Logger
    {
        private const string path = "loggerdata.csv";
        internal static void Log(List<SalesObject> list)
        {
            string stamp = "";
            foreach (SalesObject s in list)
            {
                stamp += "\n" + s.Id.ToString() + "," + s.Amount.ToString() + "," + s.Price.ToString() + "," + DateTime.Now.ToString();
            }
            File.AppendAllText(path, stamp);

        }
        internal static List<string[]> Read()
        {
            List<string[]> output = new();
            string[] list = File.ReadAllLines(path);
            foreach (string s in list)
            {
                output.Add(s.Split(','));
            }
            return output;
        }
        internal static List<string[]> ReadPrice()
        {
            List<string[]> output = new();
            string[] list = File.ReadAllLines(path),temp;
            foreach (string s in list)
            {
                temp=s.Split(",");
                string[] item ={ temp[0],temp[2],temp[3]};
                output.Add(item);
            }
            return output;
        }
        internal static List<string[]> ReadStock()
        {
            List<string[]> output = new();
            string[] list = File.ReadAllLines(path), temp;
            foreach (string s in list)
            {
                temp = s.Split(",");
                string[] item = { temp[0], temp[1], temp[3] };
                output.Add(item);
            }
            return output;
        }
    }
}
