namespace vt2026_a2
{
    public partial class Form1 : Form
    {
        private LottoFrm lottoFrm;
        private CalcFrm calcFrm;
        public Form1()
        {
            InitializeComponent();
            lottoFrm = new();
            calcFrm = new(); // these are here to supress warnings
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void lottoBtn_Click(object sender, EventArgs e)
        {
            lottoFrm = new();
            lottoFrm.Show();
        }

        private void calcBtn_Click(object sender, EventArgs e)
        {
            calcFrm = new();
            calcFrm.Show();
        }
    }
}
