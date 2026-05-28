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
using vt2026_a4.forms;
using vt2026_a4.statics;

namespace vt2026_a4
{
    public partial class storeFrm : Form
    {
        private storeControler storeControler;
        private string path;
        public storeFrm(string path)
        {
            InitializeComponent();
            storeControler = new(path);
            this.path = path;
            System.Windows.Forms.Timer timer = new();
            timer.Interval = 1000;
            timer.Tick += new(delegate (object? o, EventArgs e) { timeLbl.Text = DateTime.Now.ToString(); });
            timer.Start();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            storeControler.UpdateInfo(nameLbl, categoryLbl, stockLbl, tagsLbl, somethingLbl, itemsLw);
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            try
            {
                storeControler.Add(itemsLw, shoppingcartLw, totalLbl);
                updateListbox();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void buyBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (recitCb.Checked) { Print(); }
                storeControler.Buy(shoppingcartLw, totalLbl, somethingLbl);

                updateListbox();

            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }


        private void shoppingcartLsbx_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                storeControler.Remove(shoppingcartLw, totalLbl);
                updateListbox();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void searchTxb_TextChanged(object sender, EventArgs e)
        {
            updateListbox();
        }

        private void storeFrm_FormClosing(object sender, FormClosingEventArgs e)
        {
            storeControler.MoveOrRemove(1); //will move all shoppingcart items back into the list before saving 
            storeControler.Save(path);
        }

        private void panel1_Click(object sender, EventArgs e)
        {
            bookRbtn.Checked = false;
            gameRbtn.Checked = false;
            movieRbtn.Checked = false;
            miscRbtn.Checked = false;
            updateListbox();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void returnItemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Popup returnitem = new("Return an item by id", "check the reciet with the warehouse for the id of the product");
            if (returnitem.ShowDialog() == DialogResult.OK)
            {
                int id;
                if (!int.TryParse(returnitem.txb.Text, out id)) { MessageBox.Show("thats not right"); return; }
                if (!storeControler.Buyback(id)) { MessageBox.Show("there is no such id in the system"); return; }
                MessageBox.Show("item successfully returned! talk with the cashier abt repayment");
                updateListbox();
            }
        }

        private void storeFrm_Load(object sender, EventArgs e)
        {
            storeControler.ShowTop10(somethingLbl);
            updateListbox();

        }
        /// <summary>
        /// calls filter func
        /// one of the only few worth commenting on so i guess that says enough abouth this
        /// class
        /// </summary>
        private void updateListbox()
        {
            storeControler.Filter(itemsLw, searchTxb.Text, searchNameRbtn.Checked, searchPriceRbtn.Checked, customRbtn.Checked, bookRbtn.Checked, gameRbtn.Checked, movieRbtn.Checked, miscRbtn.Checked);
        }

        private void printToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (recitCb.Checked) { recitCb.Checked = false; return; }
            recitCb.Checked = true;
        }


        /// <summary>
        /// how to handel printing recits was taken from https://www.youtube.com/watch?v=mbMGlbMkavA
        /// with very few alterations(nevermind), all props go to rashiCode. big thanks :pray:
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {

            e.Graphics.ScaleTransform(1000f/shoppingcartGb.Width, 1400f / shoppingcartGb.Height);//added, division to scale correctly to an A4 
            e.Graphics.DrawImage(bitmap, 0, 0);
        }
        private Bitmap bitmap;
        /// <summary>
        /// code from https://www.youtube.com/watch?v=mbMGlbMkavA works in conjuction
        /// with method above
        /// </summary>
        private void Print()
        {
            //lines removed
            Graphics graphics = shoppingcartPnl.CreateGraphics();
            Size size = new(shoppingcartGb.Size.Width, shoppingcartGb.Size.Height); //instead of =this.clientSize
            bitmap = new(size.Width, size.Height, graphics);
            graphics = Graphics.FromImage(bitmap);

            Point point = PointToScreen(shoppingcartPnl.Location/*Location*/);
            graphics.CopyFromScreen(point.X + tableLayoutPanel1.Width - size.Width, point.Y + buyBtn.Height, 0, 0, size);//adjusted
            //lines removed
            printPreviewDialog1.ShowDialog();
        }
    }
}
