using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using vt2026_a4.datas;
using vt2026_a4.forms;
using vt2026_a4.items;
using vt2026_a4.statics;

namespace vt2026_a4.controlers
{
    /// <summary>
    /// takes care of all temporary opperations making use of userinput 
    /// trhough its paramiters wihtout being tied specifically to the form
    /// although the use of contorlls as params would make migration more difficult than
    /// desired. doesnt take care of persistance beyond 
    /// </summary>
    internal class warehouseControler
    {
        private warehouseData wd;
        internal warehouseControler(string path)
        {
            wd = new(
                CSVparse.GetSeedId(path),
                CSVparse.GetList(path)
                );
        }
        /// <summary>
        /// called when the controll for making a new item is used
        /// 
        /// makes a new item if the checks pass.
        /// will throw an error with error msg if the contorls dont specifying why
        /// also trutrns true if it worked if that would be usefull for the interface
        /// 
        /// doesnt refresh visual components!! make sure to do that urself afterwards
        /// unless the interface handles that for u
        /// </summary>
        /// <param name="name"></param>
        /// <param name="price"></param>
        /// <param name="category"></param>
        /// <param name="author"></param>
        /// <param name="genre"></param>
        /// <param name="format"></param>
        /// <param name="platform"></param>
        /// <param name="playtime"></param>
        /// <param name="tags"></param>
        /// <returns></returns>
        internal bool AddNewItem(string name, string price, Category category = Category.MISC, string author = "", string genre = "", string format = "", string platform = "", DateTime playtime = new(), string tags = "")
        {
            float checkedprice;
            if (!(name.Length > 0) || !(price.Length > 0)) { throw new("name and price feilds required"); } //error
            if (!float.TryParse(price, out checkedprice)) { throw new("price is not valid"); } // error
            if (name.Contains(',') || price.Contains(',') || author.Contains(',') || genre.Contains(',') || format.Contains(',') || platform.Contains(',')) { throw new("you are not allowed to use ',' in any feild except tags"); }
            if (name.Contains('\n') || price.Contains('\n') || author.Contains('\n') || genre.Contains('\n') || format.Contains('\n') || platform.Contains('\n') || tags.Contains('\n')) { throw new("no linebreaks allowed"); }
            wd.Add(category, name, checkedprice, author, genre, format, platform, playtime, tags);
            return true;
        }
        /// <summary>
        /// refreshes the visual component for the listview
        /// 
        /// no checks, if it for some reason fails will return false
        /// takes in params for filter options as well as sorting options
        /// </summary>
        /// <param name="list"></param>
        /// <param name="filter"></param>
        /// <param name="sortbyname"></param>
        /// <param name="sortbyprice"></param>
        /// <param name="sortbycustome"></param>
        /// <param name="sortbystock"></param>
        /// <returns></returns>
        internal bool SetListView(ListView list, string filter, bool sortbyname, bool sortbyprice, bool sortbycustome, bool sortbystock)
        {
            try
            {
                if (!sortbyname && !sortbyprice && !sortbycustome && !sortbystock) { sortbycustome = true; }

                List<SalesObject> displaylist;
                if (filter != null && filter.Length > 0 && filter != string.Empty)
                {
                    displaylist = SortFilter.Filter(filter, wd.List);
                }
                else
                {
                    displaylist = wd.List;
                }
                if (sortbyname) displaylist = SortFilter.SortName(displaylist);
                if (sortbyprice) displaylist = SortFilter.SortPrice(displaylist);
                if (sortbycustome) displaylist = SortFilter.SortCustome(displaylist);
                if (sortbystock) displaylist = SortFilter.SortStock(displaylist);

                list.Items.Clear();
                foreach (SalesObject item in displaylist)
                {
                    list.Items.Add(new ListViewItem([item.Id.ToString(), item.Category.ToString(), item.Name, item.Price.ToString(), item.Amount.ToString()]));
                }

                return true;
            }
            catch { return false; }
        }
        /// <summary>
        /// deletes selected item from the listview in the internal list in WarehouseData(wd)
        /// 
        /// throws if conditions for the functions arent met, error msg describes why 
        /// 
        /// gets id of slelcted item and scans list for the same id then deletes said item
        /// 
        /// Does not update the visual component!! make sure to update it manually
        /// </summary>
        /// <param name="itemsLw"></param>
        /// <returns></returns>
        internal bool Delete(ListView itemsLw)
        {
            if (itemsLw.SelectedItems.Count <= 0) { throw new("please select an item before trying to delete it"); }
            if (itemsLw.SelectedItems == null) { throw new("please select an item before trying to delete it"); }
            if (itemsLw.SelectedIndices[0] < 0) { throw new("please select an item before trying to delete it"); }
            int i;
            for (i = 0; i < wd.List.Count; i++)
            {
                if (int.Parse(itemsLw.SelectedItems[0].SubItems[0].Text) == wd.List[i].Id)
                {
                    wd.Remove(i);
                    return true;
                }
            }
            return false;
        }
        /// <summary>
        /// displays a popup that allows the user to specify how many of selected item to order
        /// and then increases the stock by that number
        /// 
        /// will throw errors if conditions arent met, error msg will say why
        /// 
        /// the number is accessed through the txb(TextBox) property set to public
        /// returns true if successful and false if it wasnt for  some reason
        /// 
        /// uses the custome popup form class
        /// </summary>
        /// <param name="itemsLw"></param>
        /// <returns></returns>
        internal bool ProptOrder(ListView itemsLw)
        {
            if (itemsLw.SelectedItems == null) { throw new("no item selected"); }
            if (itemsLw.SelectedItems.Count <= 0) { throw new("no item selected"); }

            Popup order = new("new order", "how many do you want to order?");
            if (order.ShowDialog() != DialogResult.OK) { return true; }

            uint number;
            if (!uint.TryParse(order.txb.Text, out number)) { throw new("input couldnt be parsed to positive whole number"); }

            int i;
            for (i = 0; i < wd.List.Count; i++)
            {
                if (int.Parse(itemsLw.SelectedItems[0].SubItems[0].Text) == wd.List[i].Id)
                {
                    wd.List[i].Amount += number;
                    return true;
                }
            }
            return false;


        }
        /// <summary>
        /// shows a custome popup that allows user to manually specify stock amount
        /// the value is defaulted to current value
        /// 
        /// will throw an excenption in case of error, error msg will explain why
        /// </summary>
        /// <param name="itemsLw"></param>
        /// <returns></returns>
        internal bool AdjustStock(ListView itemsLw)
        {
            if (itemsLw.SelectedItems == null) { throw new("no item selected"); }
            if (itemsLw.SelectedItems.Count <= 0) { throw new("no item selected"); }
            Popup order = new("adjust stock", "what should it be adjusted to?", itemsLw.SelectedItems[0].SubItems[4].Text);
            if (order.ShowDialog() != DialogResult.OK) { return true; }

            uint number;
            if (!uint.TryParse(order.txb.Text, out number)) { throw new("input could not be parsed to appropriate number"); }

            int i;
            for (i = 0; i < wd.List.Count; i++)
            {
                if (int.Parse(itemsLw.SelectedItems[0].SubItems[0].Text) == wd.List[i].Id)
                {
                    wd.List[i].Amount = number;
                    return true;
                }
            }
            throw new("selected item couldnt be found in the list for some reason");
        }
        /// <summary>
        /// puts all the info from selected item in the appropriate new item feilds, except amount
        /// and deletes the selected item from the list
        /// 
        /// exception will be throw in conditions arent met, error msg explains why 
        /// 
        /// trurns true if successfull and false if not 
        /// </summary>
        /// <param name="itemsLw"></param>
        /// <param name="newItemNameTxb"></param>
        /// <param name="newItemPriceTxb"></param>
        /// <param name="authorTxb"></param>
        /// <param name="formatTxb"></param>
        /// <param name="genreTxb"></param>
        /// <param name="platformTxb"></param>
        /// <param name="tagsTxb"></param>
        /// <param name="playtimeDtp"></param>
        /// <param name="categoryCbx"></param>
        /// <returns></returns>
        internal bool EditItem(ListView itemsLw, TextBox newItemNameTxb, TextBox newItemPriceTxb, TextBox authorTxb, TextBox formatTxb, TextBox genreTxb, TextBox platformTxb, TextBox tagsTxb, DateTimePicker playtimeDtp, ComboBox categoryCbx)
        {
            if (itemsLw.SelectedItems.Count <= 0) { throw new("no item selected"); }
            SalesObject? item = null;

            for (int i = 0; i < wd.List.Count; i++)
            {
                if (int.Parse(itemsLw.SelectedItems[0].SubItems[0].Text) == wd.List[i].Id)
                {
                    item = wd.List[i];
                }
            }
            if (item == null) { return false; }
            Delete(itemsLw);

            newItemNameTxb.Text = item.Name;
            newItemPriceTxb.Text = item.Price.ToString();
            tagsTxb.Text = item.TagString();
            switch (item.Category)
            {
                case Category.BOOK:
                    categoryCbx.SelectedIndex = 0;
                    authorTxb.Text = (item as Book).Author;
                    formatTxb.Text = (item as Book).Format;
                    genreTxb.Text = (item as Book).Genre;
                    break;

                case Category.GAME:
                    categoryCbx.SelectedIndex = 1;
                    platformTxb.Text = (item as Game).Platform;
                    break;

                case Category.MOVIE:
                    categoryCbx.SelectedIndex = 2;
                    formatTxb.Text = (item as Movie).Format;
                    playtimeDtp.Text = (item as Movie).Playtime.ToString();
                    break;

                case Category.MISC:
                    categoryCbx.SelectedIndex = 3;
                    break;
            }

            return true;
        }
        /// <summary>
        /// saves to specifed path 
        /// </summary>
        /// <param name="path"></param>
        internal void save(string path) { CSVparse.Save(path, wd.List); }
    }
}
