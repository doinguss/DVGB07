using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using vt2026_a2.Properties;

namespace vt2026_a2
{
    public partial class warningFrm : Form
    {
        SoundPlayer soundPlayer;
        public warningFrm(string warning)
        {
            InitializeComponent();
            button1.Text = warning;
            soundPlayer = new SoundPlayer(Resources.alarm);
        }
        private void warningFrm_Load(object sender, EventArgs e)
        {
            soundPlayer.Play(); //doesnt work as intended 
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //=====credits to resources=====
        //background giff:
        // RedstoneGyerek -- https://tenor.com/view/szirena-siren-light-warning-light-warning-signal-gif-15160758 
        //
        //intended sound:
        // apples "alarm" ringtone -- apple sound team (?) -- https://www.youtube.com/watch?v=48qVYSDur-k 
    }
}
