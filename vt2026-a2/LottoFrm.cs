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
    public partial class LottoFrm : Form
    {
        public LottoFrm()
        {
            InitializeComponent();
            ld = new();
            rand = new();
            timer= new();
            timer.Tick += new EventHandler(async delegate (Object? o, EventArgs e) 
            {
                timer.Stop();
                List<Task> tasks = new();
                await ld.start(itterations,rand,tasks);
                while (tasks.Any(t => !t.IsCompleted)) { }// https://stackoverflow.com/questions/263116/waiting-for-all-threads-to-complete-with-a-timeout
                Debug.WriteLine("num of itterations: "+ld.Its);
                match5Txb.Text = ld.Match5.ToString();
                match6Txb.Text = ld.Match6.ToString();
                match7Txb.Text = ld.Match7.ToString();
                loadingLbl.Visible = false;
                itterateBtn.Enabled = true;
            });
        }

        private System.Windows.Forms.Timer timer;
        private LottoData ld;
        private Random rand;
        private uint itterations;
        /// <summary>
        /// pre: itteration number and all dataklass data is valid
        /// post: runs game as many times as the itteration number, updates txbs to show how many games had X matches
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void itterateBtn_Click(object sender, EventArgs e)
        {
            itterateBtn.Enabled = false;
            loadingLbl.Visible = true;
            loadingLbl.Text = "loading"; // this doesnt work but idk how to make it, leaving this in as to show intent
            timer.Start();
            
        }
        /// <summary>
        /// pre: true
        /// post: only enables the button if all position in the dataklass and the itteration number are valid
        /// </summary>
        private void validateTbxs() 
        {
            itterateBtn.Enabled = false;
            loadingLbl.Visible = true;
            loadingLbl.Text = "not all required feilds have correct input yet";

            ld.Clear();
            parse(num1Txb);
            parse(num2Txb);
            parse(num3Txb);
            parse(num4Txb);
            parse(num5Txb);
            parse(num6Txb);
            parse(num7Txb);
            if (!uint.TryParse(ittrationTxb.Text,out itterations)) { return; }
            if (ld.Getnum().Contains(null)) { return; } //early return

            itterateBtn.Enabled = true;
            loadingLbl.Visible = false;
        }
        /// <summary>
        /// pre: true
        /// post: assignes given values to corresponding space in the dataclass if reasonable otherwise null 
        /// </summary>
        /// <param name="tb"></param>
        private void parse(TextBox tb)
        {
            int i, index = int.Parse(tb.Name[3].ToString()); //3rd pos cuz the naming convention is num[index]Txb
            if (int.TryParse(tb.Text, out i)) { ld.Setnum(i, index); }
        }


        //***********************************************************************************************//
        /// <summary>
        /// the all call the same function 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void num1Txb_TextChanged(object sender, EventArgs e){validateTbxs();}
        private void num2Txb_TextChanged(object sender, EventArgs e){validateTbxs();}
        private void num3Txb_TextChanged(object sender, EventArgs e){validateTbxs();}
        private void num4Txb_TextChanged(object sender, EventArgs e){validateTbxs();}
        private void num5Txb_TextChanged(object sender, EventArgs e){validateTbxs();}
        private void num6Txb_TextChanged(object sender, EventArgs e){validateTbxs();}
        private void num7Txb_TextChanged(object sender, EventArgs e){validateTbxs();}
        private void ittrationTxb_TextChanged(object sender, EventArgs e){validateTbxs();}
        //*******************************************************//
    }
}
