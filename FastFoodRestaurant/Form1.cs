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

        private void resetBtn_Click(object sender, EventArgs e)
        {
            friesCheckBox.Checked = false;
            burgerCheckBox.Checked = false;
            saladCheckBox.Checked = false;
            sandwichCheckBox.Checked = false;
            chickenCheckBox.Checked = false;
            hotdogCheckBox.Checked = false;
            teaCheckBox.Checked = false;
            sodaCheckBox.Checked = false;
            waterCheckBox.Checked = false;
            chocolateCheckBox.Checked = false;
            pancakesCheckBox.Checked = false;
            cookiesCheckBox.Checked = false;

            totalPrice.Text = "$/..";
            discountPrice.Text = "$/..";
            NetTotalPrice.Text = "$/..";
        }

        private void priceBtn_Click(object sender, EventArgs e)
        {
            double priceFries = 1.0;
            double priceBurger = 4.0;
            double priceSalad = 2.0;
            double priceSandwich = 3.0;
            double priceChicken = 5.0;
            double priceHotdog = 2.0;
            double priceTea = 0.3;
            double priceSoda = 0.5;
            double priceWater = 0.2;
            double priceChocolate = 1.0;
            double pricePancakes = 3.0;
            double priceCookies = 2.0;

            double total = ((double)friesNum.Value * priceFries) +
                ((double)burgerNum.Value * priceBurger) +
                ((double)saladNum.Value * priceSalad) +
                ((double)sandwichNum.Value * priceSandwich) +
                ((double)chickenNum.Value * priceChicken) +
                ((double)hotdogNum.Value * priceHotdog) +
                ((double)teaNum.Value * priceTea) +
                ((double)sodaNum.Value * priceSoda) +
                ((double)waterNum.Value * priceWater) +
                ((double)chocolateNum.Value * priceChocolate) +
                ((double)pancakesNum.Value * pricePancakes) +
                ((double)cookiesNum.Value * priceCookies);

            double discount = total * 0.10;
            double netTotal = total - discount;

            totalPrice.Text = "$" + total;
            discountPrice.Text = "$" + discount;
            NetTotalPrice.Text = "$" + netTotal;


        }


    }
}
