
using System.Diagnostics;

namespace vt2026_a3
{
    public partial class Form1 : Form
    {
        private SaveManager SM;
        public Form1()
        {
            InitializeComponent();
            SM = new(txtfeildTxb);
            this.Text = SM.Filename;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            titleasterisk();
        }
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            switch (keyData)
            {
                case Keys.S | Keys.Control: return true;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }
        private void titleasterisk()
        {
            switch (SM.Altered, txtfeildTxb.Text == SM.InitialText)
            {
                case (true, true): SM.Altered = false; this.Text = SM.Filename; break;
                case (false, false): SM.Altered = true; this.Text = "*" + SM.Filename; break;
            }
        }

        private void exitTsmi_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void saveTsmi_Click(object sender, EventArgs e)
        {

        }

        private void saveAsTsmi_Click(object sender, EventArgs e)
        {

        }

        private void loadTsmi_Click(object sender, EventArgs e)
        {

        }

        private void newTsmi_Click(object sender, EventArgs e)
        {

        }
    }
}
