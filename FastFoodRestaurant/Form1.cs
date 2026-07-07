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

        private void burgerCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            burgerNum.Enabled = burgerCheckBox.Checked;

            if (!burgerCheckBox.Checked)
            {
                burgerNum.Value = 0;
            }
        }

        private void saladCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            saladNum.Enabled = saladCheckBox.Checked;

            if (!saladCheckBox.Checked)
            {
                saladNum.Value = 0;
            }
        }

        private void sandwichCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            sandwichNum.Enabled = sandwichCheckBox.Checked;

            if (!sandwichCheckBox.Checked)
            {
                sandwichNum.Value = 0;
            }
        }

        private void chickenCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            chickenNum.Enabled = chickenCheckBox.Checked;

            if (!chickenCheckBox.Checked)
            {
                chickenNum.Value = 0;
            }
        }

        private void hotdogCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            hotdogNum.Enabled = hotdogCheckBox.Checked;

            if (!hotdogCheckBox.Checked)
            {
                hotdogNum.Value = 0;
            }
        }

        private void teaCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            teaNum.Enabled = teaCheckBox.Checked;

            if (!teaCheckBox.Checked)
            {
                teaNum.Value = 0;
            }
        }

        private void sodaCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            sodaNum.Enabled = sodaCheckBox.Checked;

            if (!sodaCheckBox.Checked)
            {
                sodaNum.Value = 0;
            }
        }

        private void waterCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            waterNum.Enabled = waterCheckBox.Checked;

            if (!waterCheckBox.Checked)
            {
                waterNum.Value = 0;
            }
        }

        private void chocolateCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            chocolateNum.Enabled = chocolateCheckBox.Checked;

            if (!chocolateCheckBox.Checked)
            {
                chocolateNum.Value = 0;
            }
        }

        private void pancakesCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            pancakesNum.Enabled = pancakesCheckBox.Checked;

            if (!pancakesCheckBox.Checked)
            {
                pancakesNum.Value = 0;
            }
        }

        private void cookiesCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            cookiesNum.Enabled = cookiesCheckBox.Checked;

            if (!cookiesCheckBox.Checked)
            {
                cookiesNum.Value = 0;
            }
        }
    }
}
