using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using vt2026_a4.statics;

namespace vt2026_a4.forms
{
    public partial class GraphsFrm : Form
    {
        Graph? stocks = null;
        Graph? prices = null;
        public GraphsFrm()
        {
            InitializeComponent();
            GenGraphs();

            System.Windows.Forms.Timer refreshcycle = new()
            {
                Interval = 1000 * 60,
            };
            refreshcycle.Tick += new(delegate (object? o, EventArgs e)
            {
                if (checkBox1.Checked) { return; }
                if (checkBox3.Checked) { return; }
                rldBtn.PerformClick();
            });
            refreshcycle.Start();
            label35.Hide();

        }

        private void GenGraphs()
        {
            Size size = new(800, 400);
            stocks = new(Logger.ReadStock(), size, 7, dateTimePicker1, checkBox1)
            {
                BackColor = Color.Black,
                Parent = panel1,
                Location = new(30, 10)
            };
            prices = new(Logger.ReadPrice(), size, 0.7f, dateTimePicker1, checkBox1)
            {
                BackColor = Color.Black,
                Parent = panel2,
                Location = new(30, 10)
            };
        }
        private void altgen()
        {
            Size size = new(800, 400);
            stocks = new(size, 7, dateTimePicker1, checkBox1)
            {
                BackColor = Color.Black,
                Parent = panel1,
                Location = new(30, 10)
            };
            prices = new(size, 0.7f, dateTimePicker1, checkBox1)
            {
                BackColor = Color.Black,
                Parent = panel2,
                Location = new(30, 10)
            };
        }

        private void GraphsFrm_Load(object sender, EventArgs e)
        {
            try
            {
                if (stocks == null || prices == null) { throw new(); }
                stocks.Show();
                prices.Show();

            }
            catch
            {
                System.Windows.Forms.Timer forceThisThing = new();
                forceThisThing.Tick += new(delegate (object? o, EventArgs e) { try { if (stocks == null || prices == null) { throw new(); } stocks.Show(); prices.Show(); forceThisThing.Stop(); } catch { GenGraphs(); } });
                forceThisThing.Start();
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Process.Start("notepad.exe", "loggerdata.csv"); //https://stackoverflow.com/questions/4055266/open-a-file-with-notepad-in-c-sharp
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            dateTimePicker1.Enabled = checkBox1.Checked;
            dateTimePicker2.Enabled = checkBox1.Checked;
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            timeChange();
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            timeChange();
        }
        private void timeChange()
        {
            DateTime dt = new(
                dateTimePicker1.Value.Year,
                dateTimePicker1.Value.Month,
                dateTimePicker1.Value.Day,
                dateTimePicker2.Value.Hour,
                dateTimePicker2.Value.Minute,
                dateTimePicker2.Value.Second
                );
            dateTimePicker1.Value = dt;

        }

        private void rldBtn_Click(object sender, EventArgs e)
        {
            if (stocks != null) { stocks.Dispose(); }
            if (prices != null) { prices.Dispose(); }
            if (checkBox2.Checked)
            {
                altgen();
                stocks.ApplyDataset(Logger.ReadStock(), (int)numericUpDown1.Value-1);
                prices.ApplyDataset(Logger.ReadPrice(), (int)numericUpDown1.Value-1);
                return;
            }
            GenGraphs();
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            numericUpDown1.Enabled = checkBox2.Checked;
        }
    }
}
