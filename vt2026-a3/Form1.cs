
using System.Diagnostics;

namespace vt2026_a3
{
    public partial class Form1 : Form
    {
        private SaveManager SM;
        public Form1()
        {
            InitializeComponent();
            SM = SaveManager.getInstance(txtfeildTxb);
            this.Text = SM.Filename;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            try
            {
                SM.Titleasterisk(this);
            }
            catch (Exception) { Debug.WriteLine("cannot access 'titleasterisk' from sm (savemanager)"); }
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
            try
            {
                if (SM.Altered) { SM.SaveAs(); }
            }
            catch (Exception) { Debug.WriteLine("cannot access property 'altered' from sm (savemanager)"); }
            this.Close();
        }

        private void saveTsmi_Click(object sender, EventArgs e)
        {
            try{
                SM.Save();
                SM.Titleasterisk(this);
            }catch(Exception) { Debug.WriteLine("cannot access savemanger (save, titleasterisk)"); }
        }

        private void saveAsTsmi_Click(object sender, EventArgs e)
        {
            try{
                SM.SaveAs();
                SM.Titleasterisk(this);
            }catch (Exception) { Debug.WriteLine("cannot access savemanger (saveas, titleasterisk)"); }
        }

        private void loadTsmi_Click(object sender, EventArgs e)
        {
            try{
                SM.Load();
                SM.Titleasterisk(this);
            }catch (Exception) { Debug.WriteLine("cannot access savemanger (load, titleasterisk)"); }
        }

        private void newTsmi_Click(object sender, EventArgs e)
        {
            try{
                SM.New();
                SM.Titleasterisk(this);
            }catch (Exception) { Debug.WriteLine("cannot access savemanger (new, titleasterisk)"); }
        }
    }
}
