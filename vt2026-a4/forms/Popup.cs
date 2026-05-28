using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace vt2026_a4.forms
{
    public partial class Popup : Form
    {
        public Popup(string lbl1, string lbl2,string txbDefualt="")
        {
            InitializeComponent();
            firstLbl.Text = lbl1;
            secondLbl.Text = lbl2;
            txb.Text = txbDefualt;
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Popup_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (DialogResult == DialogResult.OK) {return;}
            DialogResult = DialogResult.Cancel;
        }

        private void continueBtn_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            this.Hide();
        }
    }
}
