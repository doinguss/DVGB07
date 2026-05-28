using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using vt2026_a4.datas;
using vt2026_a4.items;

namespace vt2026_a4.statics
{
    internal static class SortFilter
    {
        /// <summary>
        /// sorts salesobjects by price
        /// </summary>
        /// <param name="list"></param>
        /// <returns></returns>
        internal static List<SalesObject> SortPrice(List<SalesObject> list)
        {
            List<SalesObject> output = new();
            foreach (SalesObject o in list)
            {
                for (int i = 0; i < output.Count; i++)
                {
                    if (o.Price < output[i].Price)
                    {
                        output.Insert(i, o);
                        break;
                    }
                    else if (i == output.Count - 1)
                    {
                        output.Add(o);
                        break;
                    }
                }
                if (output.Count == 0) { output.Add(o); }
            }

            return output;
        }
        /// <summary>
        /// sorts salesobjects by stock
        /// </summary>
        /// <param name="list"></param>
        /// <returns></returns>
        internal static List<SalesObject> SortStock(List<SalesObject> list)
        {
            List<SalesObject> output = new();
            foreach (SalesObject o in list)
            {
                for (int i = 0; i < output.Count; i++)
                {
                    if (o.Amount < output[i].Amount)
                    {
                        output.Insert(i, o);
                        break;
                    }
                    else if (i == output.Count - 1)
                    {
                        output.Add(o);
                        break;
                    }
                }
                if (output.Count == 0) { output.Add(o); }
            }

            return output;
        }
        /// <summary>
        /// sorts salesobjects by name
        /// </summary>
        /// <param name="list"></param>
        /// <returns></returns>
        internal static List<SalesObject> SortName(List<SalesObject> list)
        {
            List<SalesObject> output = new();
            foreach (SalesObject o in list)
            {
                for (int i = 0; i < output.Count; i++)
                {
                    if (o.Name[0] < output[i].Name[0])
                    {
                        output.Insert(i, o);
                        break;
                    }
                    else if (i == output.Count - 1)
                    {
                        output.Add(o);
                        break;
                    }
                }
                if (output.Count == 0) { output.Add(o); }
            }

            return output;
        }
        /// <summary>
        /// sorts salesobject by id
        /// </summary>
        /// <param name="list"></param>
        /// <returns></returns>
        internal static List<SalesObject> SortCustome(List<SalesObject> list)
        {

            List<SalesObject> output = new();
            foreach (SalesObject o in list)
            {
                for (int i = 0; i < output.Count; i++)
                {
                    if (o.Id < output[i].Id)
                    {
                        output.Insert(i, o);
                        break;
                    }
                    else if (i == output.Count - 1)
                    {
                        output.Add(o);
                        break;
                    }
                }
                if (output.Count == 0) { output.Add(o); }
            }

            return output;
        }
        /// <summary>
        /// hides objects that dont abide the filter 
        /// </summary>
        /// <param name="filter"></param>
        /// <param name="list"></param>
        /// <returns></returns>
        internal static List<SalesObject> Filter(string filter, List<SalesObject> list)
        {
            List<SalesObject> output = new();
            foreach (SalesObject o in list)
            {
                if (o.ToString().ToLower().Contains(filter.ToLower()))
                {
                    output.Add(o);
                }
            }
            return output;
            //return list;
        }
    }
}
