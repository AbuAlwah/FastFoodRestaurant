namespace FastFoodRestaurant
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Datelb1.Text = DateTime.Now.ToLongTimeString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Datelb1.Text = DateTime.Now.ToLongDateString();
            timer1.Start();
        }

        private void exitLb_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void friesCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            friesNum.Enabled = friesCheckBox.Checked;

            if (!friesCheckBox.Checked) 
            {
                friesNum.Value = 0;
            }
        }
    }
}
