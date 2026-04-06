using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
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

        private void eqlBtn_Click(object sender, EventArgs e)
        {
            cd.Entries.Insert(0,inputTxb.Text);
            inputTxb.Text += '?'; //end of expression
            string output = cd.CalcExpression(inputTxb.Text);

            inputTxb.Text=output;
            cd.Entries[0] += "  =  " + output;

            outLbl.Text="";
            for (int i = 0; i < int.Clamp(cd.Entries.Count, 0, 15); i++) { outLbl.Text = "\n" + cd.Entries[i] + outLbl.Text; }
        }
        
        private void CalcFrm_KeyPress(object sender, KeyPressEventArgs e)
        {
            switch (e.KeyChar) 
            {
                case '1': n1Btn.PerformClick(); break;
                case '2': n2Btn.PerformClick(); break;
                case '3': n3Btn.PerformClick(); break;
                case '4': n4Btn.PerformClick(); break;
                case '5': n5Btn.PerformClick(); break;
                case '6': n6Btn.PerformClick(); break;
                case '7': n7Btn.PerformClick(); break;
                case '8': n8Btn.PerformClick(); break;
                case '9': n9Btn.PerformClick(); break;
                case '0': n0Btn.PerformClick(); break;
                case '+': addBtn.PerformClick(); break;
                case '-': subBtn.PerformClick(); break;
                case '*': multBtn.PerformClick(); break;
                case '/': divBtn.PerformClick(); break;
                case (char)Keys.Escape:
                case (char)Keys.Delete:
                case 'c': clrBtn.PerformClick(); break;
                case (char)Keys.Enter:
                case '=': eqlBtn.PerformClick(); break;
            }
            this.Focus();
        }

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
    }
}
