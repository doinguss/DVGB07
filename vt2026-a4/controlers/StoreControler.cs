using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Drawing.Printing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using vt2026_a4.datas;
using vt2026_a4.items;
using vt2026_a4.statics;

namespace vt2026_a4.controlers
{
    internal class storeControler
    {
        private storeData storeData;
        private string path;
        public storeControler(string path)
        {
            storeData = new(
                CSVparse.GetList(path),
                CSVparse.GetList(path));
            this.path = path;
        }
        /// <summary>
        /// updates the listviewwith regards to search terms (if given) and
        /// the radio button result
        /// </summary>
        /// <param name="list"></param>
        /// <param name="filter1"></param>
        /// <param name="filter2"></param>
        /// <param name="sortbyname"></param>
        /// <param name="sortbyprice"></param>
        /// <param name="sortbycustome"></param>
        /// <param name="sortbystock"></param>
        /// <returns></returns>
        internal bool SetListView(ListView list, string filter1, string filter2, bool sortbyname, bool sortbyprice, bool sortbycustome, bool sortbystock)
        {
            try
            {
                if (!sortbyname && !sortbyprice && !sortbycustome && !sortbystock) { sortbycustome = true; }

                List<SalesObject> displaylist;
                if (filter1 != null && filter1.Length > 0 && filter1 != string.Empty)
                {
                    displaylist = SortFilter.Filter(filter1, storeData.List);
                }
                else
                {
                    displaylist = storeData.List;
                }
                if (filter2 != null && filter2.Length > 0 && filter2 != string.Empty)
                {
                    displaylist = SortFilter.Filter(filter2, displaylist);
                }

                if (sortbyname) displaylist = SortFilter.SortName(displaylist);
                if (sortbyprice) displaylist = SortFilter.SortPrice(displaylist);
                if (sortbycustome) displaylist = SortFilter.SortCustome(displaylist);
                if (sortbystock) displaylist = SortFilter.SortStock(displaylist);

                list.Items.Clear();
                foreach (SalesObject item in displaylist)
                {
                    if (item.Amount < 1) { continue; }
                    list.Items.Add(new ListViewItem([item.Name, item.Price.ToString(), item.Category.ToString(), item.TagString(), item.Amount.ToString(), item.Id.ToString()]));
                }

                return true;
            }
            catch { return false; }
        }
        /// <summary>
        /// saves 
        /// </summary>
        /// <param name="path"></param>
        internal void Save(string path) { CSVparse.Save(path, storeData.List); }
        /// <summary>
        /// 2 search terms, is used to only show products of specific types
        /// </summary>
        /// <param name="list"></param>
        /// <param name="text"></param>
        /// <param name="checked1"></param>
        /// <param name="checked2"></param>
        /// <param name="checked3"></param>
        /// <param name="checked4"></param>
        /// <param name="checked5"></param>
        /// <param name="checked6"></param>
        /// <param name="checked7"></param>
        internal void Filter(ListView list, string text, bool checked1, bool checked2, bool checked3, bool checked4, bool checked5, bool checked6, bool checked7)
        {
            string filter2 = "";
            if (checked4) { filter2 = Category.BOOK.ToString(); }
            if (checked5) { filter2 = Category.GAME.ToString(); }
            if (checked6) { filter2 = Category.MOVIE.ToString(); }
            if (checked7) { filter2 = Category.MISC.ToString(); }
            SetListView(list, text, filter2, checked1, checked2, checked3, false);

        }
        /// <summary>
        /// 
        /// it was made to display the info of selected item
        /// </summary>
        /// <param name="nameLbl"></param>
        /// <param name="categoryLbl"></param>
        /// <param name="stockLbl"></param>
        /// <param name="tagsLbl"></param>
        /// <param name="somethingLbl"></param>
        /// <param name="itemsLw"></param>
        internal void UpdateInfo(Label nameLbl, Label categoryLbl, Label stockLbl, Label tagsLbl, Label somethingLbl, ListView itemsLw)
        {
            if (itemsLw.SelectedItems.Count <= 0) { nameLbl.Text = ""; categoryLbl.Text = ""; stockLbl.Text = ""; tagsLbl.Text = ""; return; }
            nameLbl.Text = itemsLw.SelectedItems[0].SubItems[0].Text + "  : " + itemsLw.SelectedItems[0].SubItems[1].Text;
            categoryLbl.Text = itemsLw.SelectedItems[0].SubItems[2].Text;
            stockLbl.Text = itemsLw.SelectedItems[0].SubItems[4].Text;
            tagsLbl.Text = itemsLw.SelectedItems[0].SubItems[3].Text;
        }
        /// <summary>
        /// adds an item from the list to the shoppingcart
        /// throws exception  if conditions arent met, msg explains why 
        /// decraments amount in list and incraments in cart
        /// the cart has a 0 amount copy of every item already
        /// 
        /// not shown in thi method but this is reverted on app close incase someone adds
        /// stuff but never buys
        /// </summary>
        /// <param name="itemsLw"></param>
        /// <param name="shoppingcartLw"></param>
        /// <param name="total"></param>
        /// <returns></returns>
        internal bool Add(ListView itemsLw, ListView shoppingcartLw, Label total)
        {
            if (itemsLw.SelectedItems.Count != 1) { throw new("none selected"); }
            if (itemsLw.SelectedItems[0].SubItems[4].Text == "0") { throw new("none left"); }//4 should be the amount (5 id)
            for (int i = 0; i < storeData.List.Count; i++)
            {
                if (itemsLw.SelectedItems[0].SubItems[5].Text == storeData.List[i].Id.ToString())
                {
                    storeData.List[i].Amount--;
                }
                if (itemsLw.SelectedItems[0].SubItems[5].Text == storeData.Cart[i].Id.ToString()) //cart and list have the same items but are not exact coppies thus this works
                {
                    storeData.Cart[i].Amount++;
                }
            }
            UpdateCart(shoppingcartLw, total);
            return true;
        }
        /// <summary>
        /// updates the shoppingcart
        /// items of 0 amount arent shown
        /// 
        /// and also updates the total label 
        /// </summary>
        /// <param name="lw"></param>
        /// <param name="total"></param>
        /// <returns></returns>
        private float UpdateCart(ListView lw, Label total)
        {
            lw.Items.Clear();
            float totalAmount = 0;
            foreach (SalesObject o in storeData.Cart)
            {
                if (o.Amount == 0) { continue; }
                lw.Items.Add(new ListViewItem([(o.Price * o.Amount).ToString(), o.Amount.ToString(), o.Name, o.Id.ToString()]));
                totalAmount += o.Amount * o.Price;
            }
            total.Text = "total: " + totalAmount.ToString();
            return totalAmount;

        }
        /// <summary>
        /// puts item back from shoppingcart, basically just reverses the add method
        /// </summary>
        /// <param name="shoppingcartLw"></param>
        /// <param name="total"></param>
        /// <returns></returns>
        internal bool Remove(ListView shoppingcartLw, Label total)
        {
            if (shoppingcartLw.SelectedItems.Count != 1) { throw new("none selected"); }
            for (int i = 0; i < storeData.List.Count; i++) //dupe of the add function above, swwapped the incrament decraments tho
            {
                if (shoppingcartLw.SelectedItems[0].SubItems[3].Text == storeData.List[i].Id.ToString())
                {
                    storeData.List[i].Amount++;
                }
                if (shoppingcartLw.SelectedItems[0].SubItems[3].Text == storeData.Cart[i].Id.ToString())
                {
                    storeData.Cart[i].Amount--;
                }
            }
            UpdateCart(shoppingcartLw, total);
            return true;

        }
        /// <summary>
        /// if i is 1 it moves all items from the cart to the list
        /// if i is 0 the items in cart are simply removed 
        /// 
        /// hence the name
        /// 
        /// returns a string of what happened 
        /// </summary>
        /// <param name="i"></param>
        /// <returns></returns>
        internal string MoveOrRemove(int i)
        {
            string recit = "";
            foreach (SalesObject o in storeData.Cart)
            {
                for (int j = 0; j < storeData.List.Count; j++)
                {
                    if (storeData.List[j].Id == o.Id)
                    {
                        storeData.List[j].Amount = (uint)(storeData.List[j].Amount + o.Amount * i);
                        if (o.Amount == 0) { continue; }
                        recit += o.Id + "," + o.Amount + "," + o.Amount * o.Price + "," + DateTime.Now + "\n";
                    }
                }
                o.Amount = 0;
            }
            return recit;
        }
        /// <summary>
        /// empties shopingcart
        /// logs the income 
        /// saves
        /// updates top10 list
        /// </summary>
        /// <param name="shoppingcart"></param>
        /// <param name="total"></param>
        /// <param name="top10"></param>
        internal void Buy(ListView shoppingcart, Label total, Label top10)
        {

            string recit = MoveOrRemove(0); //will subtract all shoppingcart items from the total stock (not!! the subbing is done on ading to cart now, this just makes suree the items dont go back when closing the program), gone forever
            float money = UpdateCart(shoppingcart, total);
            //something with the money here too id thats ever needed 
            Sales.Log(recit);
            Save(path);
            ShowTop10(top10);
        }
        /// <summary>
        /// incraments the item with matching id in list
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        internal bool Buyback(int id)
        {
            for (int i = 0; i < storeData.List.Count; i++)
            {
                if (id == storeData.List[i].Id)
                {
                    storeData.List[i].Amount++;
                    return true;
                }
            }
            return false;
        }
        /// <summary>
        /// dissplays the 10 most popular items
        /// if any position is null will replace that with "---"
        /// instead of the name (its nnull in case say the salesdata.csv is empty)
        /// </summary>
        /// <param name="label"></param>
        internal void ShowTop10(Label label)
        {
            string output = "top sellers! :\n";
            foreach (int? i in Sales.Top10())
            {
                if (i == null) { output += "---\n"; continue; }
                for (int j = 0; j < storeData.List.Count; j++)
                {
                    if (storeData.List[j].Id == i)
                    {
                        output += storeData.List[j].Name + "\n";
                    }
                }

            }
            label.Text = output;
        }
    }
}
