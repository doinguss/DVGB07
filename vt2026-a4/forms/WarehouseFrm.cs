using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using vt2026_a4.controlers;
using vt2026_a4.datas;
using vt2026_a4.items;
using vt2026_a4.statics;

namespace vt2026_a4
{
    public partial class warehouseFrm : Form
    {
        private warehouseControler warehouseControler;
        private string path;
        public warehouseFrm(string path)
        {
            InitializeComponent();
            warehouseControler = new(path);
            categoryCbx.DataSource = Enum.GetValues(typeof(Category));
            categoryCbx.SelectedIndex = 3;
            playtimeDtp.Format = DateTimePickerFormat.Custom;
            playtimeDtp.CustomFormat = "H:mm:ss";
            playtimeDtp.Value = new(2000, 1, 1, 0, 0, 0);
            this.path = path;
        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            warehouseControler.SetListView(itemsLw, searchTxb.Text, sortNameRbtn.Checked, sortPriceRbtn.Checked, sortCustomeRbtn.Checked, stockRbtn.Checked);
        }

        private void addNewItemBtn_Click(object sender, EventArgs e)
        {
            try
            {
                warehouseControler.AddNewItem(newItemNameTxb.Text, newItemPriceTxb.Text, Enum.Parse<Category>(categoryCbx.SelectedValue.ToString()), authorTxb.Text, genreTxb.Text, formatTxb.Text, platformTxb.Text, playtimeDtp.Value, tagsTxb.Text);
                searchBtn.PerformClick();
                newItemNameTxb.Text = "";
                newItemPriceTxb.Text = "";
                authorTxb.Text = "";
                genreTxb.Text = "";
                formatTxb.Text = "";
                platformTxb.Text = "";
                tagsTxb.Text = "";
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }

        }


        private void categoryCbx_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (Enum.Parse<Category>(categoryCbx.SelectedValue.ToString()))
            {
                case Category.BOOK:
                    authorTxb.Enabled = true;
                    formatTxb.Enabled = true;
                    genreTxb.Enabled = true;
                    platformTxb.Enabled = false;
                    playtimeDtp.Enabled = false;
                    break;
                case Category.MOVIE:
                    authorTxb.Enabled = false;
                    formatTxb.Enabled = true;
                    genreTxb.Enabled = false;
                    platformTxb.Enabled = false;
                    playtimeDtp.Enabled = true;
                    break;
                case Category.GAME:
                    authorTxb.Enabled = false;
                    formatTxb.Enabled = false;
                    genreTxb.Enabled = false;
                    platformTxb.Enabled = true;
                    playtimeDtp.Enabled = false;
                    break;
                case Category.MISC:
                    authorTxb.Enabled = false;
                    formatTxb.Enabled = false;
                    genreTxb.Enabled = false;
                    platformTxb.Enabled = false;
                    playtimeDtp.Enabled = false;
                    break;
            }
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (itemsLw.SelectedItems[0].SubItems[4].Text.Trim() != "0")
                {
                    if (MessageBox.Show("theres still product left, continue anyways?", "continue?", MessageBoxButtons.YesNo) != DialogResult.Yes)
                    {
                        return;
                    }
                }
                warehouseControler.Delete(itemsLw);
                searchBtn.PerformClick();

            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void orderBtn_Click(object sender, EventArgs e)
        {
            try
            {
                warehouseControler.ProptOrder(itemsLw);
                searchBtn.PerformClick();

            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void stockBtn_Click(object sender, EventArgs e)
        {
            try
            {
                warehouseControler.AdjustStock(itemsLw);
                searchBtn.PerformClick();

            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void editBtn_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("edditing the porperties of an item will reset the stock amount to 0, continue?", "continue?", MessageBoxButtons.YesNo) != DialogResult.Yes)
            {
                return;
            }
            try
            {
                warehouseControler.EditItem(itemsLw, newItemNameTxb, newItemPriceTxb, authorTxb, formatTxb, genreTxb, platformTxb, tagsTxb, playtimeDtp, categoryCbx);
                searchBtn.PerformClick();

            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void warehouseFrm_FormClosing(object sender, FormClosingEventArgs e)
        {
            warehouseControler.save(path);
        }

        private void warehouseFrm_Load(object sender, EventArgs e)
        {
            searchBtn.PerformClick();
        }
    }
}
