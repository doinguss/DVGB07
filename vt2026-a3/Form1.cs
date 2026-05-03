
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;

namespace vt2026_a3
{
    public partial class Form1 : Form
    {
        private SaveManager SM;
        private bool lazyskipp;
        private bool frmCount;
        private uint mspf;

        public Form1()
        {
            InitializeComponent();
            SM = SaveManager.getInstance(txtfeildTxb, aniTsmi);
            this.Text = SM.Filename;
            this.lazyskipp = false;
            mspf = 16;
        }
        private bool txtchangeCheck()
        {
            try
            {
                SM.Titleasterisk(this);
            }
            catch (Exception e) { Debug.WriteLine("cannot access 'titleasterisk' from sm (savemanager)"); Debug.WriteLine(e); }
            try
            {
                charTssl.Text = "characters: " + DocStats.SymbolCount(txtfeildTxb.Text);
                exCharTssl.Text = "(excl whitespace): " + DocStats.NonWhitspaceCount(txtfeildTxb.Text);
                wordsTssl.Text = "words: " + DocStats.WordCount(txtfeildTxb.Text);
                linesTssl.Text = "lines: " + DocStats.LineCount(txtfeildTxb.Text);
            }
            catch (Exception) { Debug.WriteLine("cannot access docstats"); }
            return true;
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (lazyskipp) { return; }

            txtchangeCheck();
        }
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            switch (keyData)
            {
                case Keys.S | Keys.Control: saveTsmi.PerformClick(); return true;
                case Keys.W | Keys.Control: saveAsTsmi.PerformClick(); return true;
                case Keys.L | Keys.Control: loadTsmi.PerformClick(); return true;
                case Keys.N | Keys.Control: newTsmi.PerformClick(); return true;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void exitTsmi_Click(object sender, EventArgs e)
        {
            progrssloss(this.Close);
        }

        private void saveTsmi_Click(object sender, EventArgs e)
        {
            try
            {
                SM.Save();
                txtchangeCheck();
                lazyskipp = false;
            }
            catch (Exception) { Debug.WriteLine("cannot access savemanger (save, titleasterisk)"); }

        }

        private void saveAsTsmi_Click(object sender, EventArgs e)
        {
            try
            {
                SM.SaveAs();
                txtchangeCheck();
                lazyskipp = false;
            }
            catch (Exception) { Debug.WriteLine("cannot access savemanger (saveas, titleasterisk)"); }
        }

        private void loadTsmi_Click(object sender, EventArgs e)
        {
            progrssloss(SM.Load);
            lazyskipp = false;
        }

        private void newTsmi_Click(object sender, EventArgs e)
        {
            progrssloss(SM.New);
            lazyskipp = false;

        }
        private bool progrssloss(Action p)
        {
            try
            {
                if (!SM.Altered) { p(); txtchangeCheck(); return true; }
                switch (MessageBox.Show("proceed without saving?", "save?", MessageBoxButtons.YesNoCancel))
                {
                    case DialogResult.Yes: p(); txtchangeCheck(); return true;
                    case DialogResult.No: bool o = SM.Save(); p(); txtchangeCheck(); return o;
                    case DialogResult.Cancel: txtchangeCheck(); return false;
                }
            }
            catch (Exception e) { Debug.WriteLine(e); }
            return false;
        }
        private bool progrssloss()
        {
            try
            {
                if (!SM.Altered) { txtchangeCheck(); return true; }
                switch (MessageBox.Show("proceed without saving?", "save?", MessageBoxButtons.YesNoCancel))
                {
                    case DialogResult.Yes: txtchangeCheck(); return true;
                    case DialogResult.No: return SM.Save() && txtchangeCheck();
                    case DialogResult.Cancel: txtchangeCheck(); return false;
                }
            }
            catch (Exception e) { Debug.WriteLine(e); }
            return false;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = !progrssloss(); //https://stackoverflow.com/questions/55887874/how-to-stop-windows-form-from-closing-but-hide-upon-clicking-the-x
        }

        private void txtfeildTxb_DragDrop(object sender, DragEventArgs e)
        {
            if (e.Data == null) { return; }
            switch (e.AllowedEffect)
            {
                case DragDropEffects.Move: progrssloss(() => { txtfeildTxb.Text = (e.Data.GetData(DataFormats.Text) ?? "").ToString(); }); break;
                case DragDropEffects.Copy: progrssloss(() => { txtfeildTxb.Text += (e.Data.GetData(DataFormats.Text) ?? "").ToString(); }); break;
                case DragDropEffects.Link:/*insert at cursor*/; break;
            }

        }
        private void txtfeildTxb_DragOver(object sender, DragEventArgs e) //https://learn.microsoft.com/en-us/dotnet/desktop/winforms/advanced/walkthrough-performing-a-drag-and-drop-operation-in-windows-forms
        {
            if (e.Data == null) { return; }
            if (e.Data.GetDataPresent(DataFormats.Text))
            {
                e.Effect = DragDropEffects.Move;
            }
            else
                e.Effect = DragDropEffects.None;
        }

        private void txtfeildTxb_DragEnter(object sender, DragEventArgs e)
        {

            if (e.Data == null) { return; }
            if (e.Data.GetDataPresent(DataFormats.Text))
            {
                e.Effect = DragDropEffects.Move;
            }
            else
                e.Effect = DragDropEffects.None;
        }
        /// <summary>
        /// pre: sm.animationcheck passed (=> anistep assigned and play animation tsmi enabled) 
        /// post: plays animation yay :D then leaves it on last frame, also ativates a bypass to avoid unneccessary calculations and checks
        /// the names residual from eralier drafts
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void playToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lazyskipp = true;
            SM.AnimateStart(frmCount, mspf);
        }

        private void fpmsTstb_TextChanged(object sender, EventArgs e)
        {
            ValidateAnimaationParam();
        }

        private void frmcountTstb_TextChanged(object sender, EventArgs e)
        {
            ValidateAnimaationParam();
        }
        private void ValidateAnimaationParam()
        {

            playTsmi.Enabled = false;
            switch (frmcountTstb.Text.Trim())
            {
                case "y":
                case "Y":
                case "yes":
                case "Yes":
                case "YES":
                case "true":
                case "True":
                case "TRUE": frmCount = true; break;
                case "n":
                case "N":
                case "no":
                case "No":
                case "NO":
                case "false":
                case "False":
                case "FALSE": frmCount = false; break;
                default: return;
            }
            if (!uint.TryParse((fpmsTstb.Text ?? " ").Trim(), out mspf)) { return; }
            if (mspf == 0) { return; }
            playTsmi.Enabled = true;
        }
    }
}
