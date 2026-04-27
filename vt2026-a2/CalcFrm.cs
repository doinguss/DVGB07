using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Diagnostics.Contracts;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace vt2026_a2
{
    public partial class CalcFrm : Form
    {
        private CalcData cd;
        public CalcFrm()
        {
            InitializeComponent();
            cd = new();
        }
        //uses cd (calculator data) to calculate whatevers in the input compute feild at the moment and
        //uppdates the label above to show previous calcs and their result 
        //input is devided into tokens at every "opperation" symbol, the symbols are also added as tokens and stored inorder
        //i know post order is supposed to be the fastest for compputers but i cant rly wrap my mind aorund how that would work
        //anyway its corrected and calculated, i chose to include order of opperations and fractions and so on
        //i know thats not required but i wanted to 
        private void eqlBtn_Click(object sender, EventArgs e)
        {
            cd.Entries.Insert(0, inputTxb.Text);
            inputTxb.Text += '?'; //end of expression added to force tokenize last number and useful for the correctsyntax method 
            string output = cd.CalcExpression(inputTxb.Text);

            warningFrm frm;
            switch (output)
            {
                case "err": frm = new("DONT DIVIDE BY 0!!"); showErrFrm(frm); return;
                case "err2": frm = new("hey thats some pretty\n uncool input buckaroo");showErrFrm(frm); return;
            }
            inputTxb.Text = output; // can change to "...= cd.entries[0]" (or '...=""' to clear it) here for the same equation to remain but wanted to make result extra clear
            cd.Entries[0] += "  =  " + output;

            outLbl.Text = "";
            for (int i = 0; i < int.Clamp(cd.Entries.Count, 0, 15); i++) { outLbl.Text = "\n" + cd.Entries[i] + outLbl.Text; }
        }

        //for key input, the txb is locked to prevent bogus input which also makes all the error handeling a bilion times easier 
        //the syntax here is taken from an earlier project of mine
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            Debug.WriteLine(keyData);
            switch (keyData)
            {
                /*********************== MISC ==************************/
                case Keys.E:
                case Keys.Space:
                case Keys.Enter: eqlBtn.PerformClick(); return true;
                case Keys.C:
                case Keys.Delete:
                case Keys.Back: clrBtn.PerformClick(); return true;
                case Keys.D8 | Keys.Shift: strpBtn.PerformClick(); return true;
                case Keys.D9 | Keys.Shift: endpBtn.PerformClick(); return true;
                case Keys.E | Keys.Control: warningFrm warning = new("bobs"); warning.Show(); ; return true;

                /********************== NUMBER KEYS ==******************/
                case Keys.NumPad1:
                case Keys.D1: n1Btn.PerformClick(); return true;
                case Keys.NumPad2:
                case Keys.D2: n2Btn.PerformClick(); return true;
                case Keys.NumPad3:
                case Keys.D3: n3Btn.PerformClick(); return true;
                case Keys.NumPad4:
                case Keys.D4: n4Btn.PerformClick(); return true;
                case Keys.NumPad5:
                case Keys.D5: n5Btn.PerformClick(); return true;
                case Keys.NumPad6:
                case Keys.D6: n6Btn.PerformClick(); return true;
                case Keys.NumPad7:
                case Keys.D7: n7Btn.PerformClick(); return true;
                case Keys.NumPad8:
                case Keys.D8: n8Btn.PerformClick(); return true;
                case Keys.NumPad9:
                case Keys.D9: n9Btn.PerformClick(); return true;
                case Keys.NumPad0:
                case Keys.D0: n0Btn.PerformClick(); return true;

                /*********************== OPPERATIONS ==*****************/
                case Keys.Oemplus:
                case Keys.Add: addBtn.PerformClick(); return true;
                case Keys.OemMinus:
                case Keys.Subtract: subBtn.PerformClick(); return true;
                case Keys.Oem2 | Keys.Shift:
                case Keys.Multiply: multBtn.PerformClick(); return true;
                case Keys.D7 | Keys.Shift:
                case Keys.Divide: divBtn.PerformClick(); return true;
                case Keys.OemSemicolon | Keys.Shift:
                    /*carry trhough*/
                    expBtn.PerformClick(); return true;
                case Keys.D1| Keys.Shift: factBtn.PerformClick(); return true;
            }
            this.Focus();
            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void showErrFrm(warningFrm frm) 
        {
            frm.Show();
            inputTxb.Text = "";
            return;
        }
        //
        //everythign below is too simple to comment on, it adds what u press into the compute feild or clears it for clrBtn
        //
        private void CalcFrm_Load(object sender, EventArgs e) { this.Focus(); }

        private void n1Btn_Click(object sender, EventArgs e) { inputTxb.Text += "1"; }

        private void n2Btn_Click(object sender, EventArgs e) { inputTxb.Text += "2"; }

        private void n3Btn_Click(object sender, EventArgs e) { inputTxb.Text += "3"; }

        private void n4Btn_Click(object sender, EventArgs e) { inputTxb.Text += "4"; }

        private void n5Btn_Click(object sender, EventArgs e) { inputTxb.Text += "5"; }

        private void n6Btn_Click(object sender, EventArgs e) { inputTxb.Text += "6"; }

        private void n7Btn_Click(object sender, EventArgs e) { inputTxb.Text += "7"; }

        private void n8Btn_Click(object sender, EventArgs e) { inputTxb.Text += "8"; }

        private void n9Btn_Click(object sender, EventArgs e) { inputTxb.Text += "9"; }

        private void n0Btn_Click(object sender, EventArgs e) { inputTxb.Text += "0"; }

        private void addBtn_Click(object sender, EventArgs e) { inputTxb.Text += "+"; }

        private void subBtn_Click(object sender, EventArgs e) { inputTxb.Text += "-"; }

        private void multBtn_Click(object sender, EventArgs e) { inputTxb.Text += "*"; }

        private void divBtn_Click(object sender, EventArgs e) { inputTxb.Text += "/"; }

        private void clrBtn_Click(object sender, EventArgs e) { inputTxb.Text = ""; }

        private void strpBtn_Click(object sender, EventArgs e) { inputTxb.Text += "("; }

        private void endpBtn_Click(object sender, EventArgs e) { inputTxb.Text += ")"; }

        private void expBtn_Click(object sender, EventArgs e) { inputTxb.Text += "^"; }

        private void factBtn_Click(object sender, EventArgs e) { inputTxb.Text += "!"; }
    }
}
