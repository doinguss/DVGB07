namespace vt2026_a4
{
    /// <summary>
    /// mega simple form, hands down the filepath so that its easy to edit and adjust
    /// if desired 
    /// begins wither of the two subforms depending on which button is clicked but not both
    /// this is done by hiding this form while using the showdialog method 
    /// as im sure u can see
    /// </summary>
    public partial class selectFrm : Form
    {
        private static string filepath = "savefile.csv";
        public selectFrm()
        {
            InitializeComponent();
        }
        private void warehouseBtn_Click(object? sender, EventArgs e)
        {
            warehouseFrm form = new(filepath);
            Hide();
            form.ShowDialog();
            Close();
        }

        private void storeBtn_Click(object sender, EventArgs e)
        {
            try
            {
            storeFrm form = new(filepath);
            Hide();
            form.ShowDialog();
            Close();

            }
            catch { }
        }
    }
}
