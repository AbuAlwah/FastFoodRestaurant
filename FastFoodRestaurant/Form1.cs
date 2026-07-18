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

            totalPrice.Text = "$0.0";
            discountPrice.Text = "$0.0";
            NetTotalPrice.Text = "$0.0";

            displayRichTextBox.Clear();
        }

        private void CalculateInvoiceTotal()
        {
            decimal priceFries = 1.0m;
            decimal priceBurger = 4.0m;
            decimal priceSalad = 2.0m;
            decimal priceSandwich = 3.0m;
            decimal priceChicken = 5.0m;
            decimal priceHotdog = 2.0m;
            decimal priceTea = 0.3m;
            decimal priceSoda = 0.5m;
            decimal priceWater = 0.2m;
            decimal priceChocolate = 1.0m;
            decimal pricePancakes = 3.0m;
            decimal priceCookies = 2.0m;

            decimal total = (friesNum.Value * priceFries) +
                (burgerNum.Value * priceBurger) +
                (saladNum.Value * priceSalad) +
                (sandwichNum.Value * priceSandwich) +
                (chickenNum.Value * priceChicken) +
                (hotdogNum.Value * priceHotdog) +
                (teaNum.Value * priceTea) +
                (sodaNum.Value * priceSoda) +
                (waterNum.Value * priceWater) +
                (chocolateNum.Value * priceChocolate) +
                (pancakesNum.Value * pricePancakes) +
                (cookiesNum.Value * priceCookies);

            decimal discount = total * 0.10m;
            decimal netTotal = total - discount;

            totalPrice.Text = "$" + total.ToString("0.0");
            discountPrice.Text = "$" + discount.ToString("0.0");
            NetTotalPrice.Text = "$" + netTotal.ToString("0.0");

            displayRichTextBox.Clear();

            if (friesNum.Value > 0)
                displayRichTextBox.AppendText($"Fries\t\t{friesNum.Value}\t$1\t${friesNum.Value * 1m}\n");

            if (burgerNum.Value > 0)
                displayRichTextBox.AppendText($"Burger\t\t{burgerNum.Value}\t$4\t${burgerNum.Value * 4m}\n");

            if (saladNum.Value > 0)
                displayRichTextBox.AppendText($"Salad\t\t{saladNum.Value}\t$2\t${saladNum.Value * 2m}\n");

            if (sandwichNum.Value > 0)
                displayRichTextBox.AppendText($"Sandwich\t{sandwichNum.Value}\t$3\t${sandwichNum.Value * 3m}\n");

            if (chickenNum.Value > 0)
                displayRichTextBox.AppendText($"Chicken\t\t{chickenNum.Value}\t$5\t${chickenNum.Value * 5m}\n");

            if (hotdogNum.Value > 0)
                displayRichTextBox.AppendText($"Hot Dog\t\t{hotdogNum.Value}\t$2\t${hotdogNum.Value * 2m}\n");

            if (teaNum.Value > 0)
                displayRichTextBox.AppendText($"Tea\t\t{teaNum.Value}\t$0.3\t${teaNum.Value * 0.3m}\n");

            if (sodaNum.Value > 0)
                displayRichTextBox.AppendText($"Soda\t\t{sodaNum.Value}\t$0.5\t${sodaNum.Value * 0.5m}\n");

            if (waterNum.Value > 0)
                displayRichTextBox.AppendText($"Water\t\t{waterNum.Value}\t$0.2\t${waterNum.Value * 0.2m}\n");

            if (chocolateNum.Value > 0)
                displayRichTextBox.AppendText($"Chocolate\t{chocolateNum.Value}\t$1\t${chocolateNum.Value * 1m}\n");

            if (pancakesNum.Value > 0)
                displayRichTextBox.AppendText($"Pancakes\t{pancakesNum.Value}\t$3\t${pancakesNum.Value * 3m}\n");

            if (cookiesNum.Value > 0)
                displayRichTextBox.AppendText($"Cookies\t\t{cookiesNum.Value}\t$2\t${cookiesNum.Value * 2m}\n");

        }

        private void buyBtn_Click(object sender, EventArgs e)
        {
            bool isEverythingZero = true;

            foreach (Control c in this.Controls)
            {
                if (c is Panel || c is GroupBox)
                {
                    foreach (Control subControl in c.Controls)
                    {
                        if (subControl is NumericUpDown num && num.Value > 0)
                        {
                            isEverythingZero = false;
                            break;
                        }
                    }
                }
                else if (c is NumericUpDown num && num.Value > 0)
                {
                    isEverythingZero = false;
                    break;
                }

                if (!isEverythingZero) break;
            }

            if (isEverythingZero)
            {
                MessageBox.Show("Sorry, there are no items selected for purchase!\nPlease select items first.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


            try
            {
                string cleanNetTotal = NetTotalPrice.Text.Replace("$", "").Trim();

                if (decimal.TryParse(cleanNetTotal, out decimal finalNetTotal))
                {
                    PaymentForm paymentScreen = new PaymentForm(finalNetTotal);

                    if (paymentScreen.ShowDialog() == DialogResult.OK)
                    {
                        ClearOrderForm();
                        MessageBox.Show("Order cleared and ready for the next customer.", "System Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show("Error reading the total price format.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while opening the payment screen: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void rbDineIn_CheckedChanged(object sender, EventArgs e)
        {
            if (rbDineIn.Checked)
            {
                txtTableNumber.Visible = true;
                txtPhoneNumber.Visible = false;
                txtPhoneNumber.Text = null;
            }
        }

        private void rbDelivery_CheckedChanged(object sender, EventArgs e)
        {
            if (rbDelivery.Checked)
            {
                txtTableNumber.Visible = false;
                txtPhoneNumber.Visible = true;
                txtTableNumber.Text = null;
            }
        }

        private void rbTakeaway_CheckedChanged(object sender, EventArgs e)
        {
            if (rbTakeaway.Checked)
            {
                txtTableNumber.Visible = false;
                txtPhoneNumber.Visible = false;
                txtPhoneNumber.Visible = false;
                txtTableNumber.Text = null;
                txtPhoneNumber.Text = null;
            }
        }

        private void friesNum_ValueChanged(object sender, EventArgs e)
        {
            CalculateInvoiceTotal();
        }

        private void burgerNum_ValueChanged(object sender, EventArgs e)
        {
            CalculateInvoiceTotal();
        }

        private void saladNum_ValueChanged(object sender, EventArgs e)
        {
            CalculateInvoiceTotal();
        }

        private void sandwichNum_ValueChanged(object sender, EventArgs e)
        {
            CalculateInvoiceTotal();
        }

        private void chickenNum_ValueChanged(object sender, EventArgs e)
        {
            CalculateInvoiceTotal();
        }

        private void hotdogNum_ValueChanged(object sender, EventArgs e)
        {
            CalculateInvoiceTotal();
        }

        private void teaNum_ValueChanged(object sender, EventArgs e)
        {
            CalculateInvoiceTotal();
        }

        private void sodaNum_ValueChanged(object sender, EventArgs e)
        {
            CalculateInvoiceTotal();
        }

        private void waterNum_ValueChanged(object sender, EventArgs e)
        {
            CalculateInvoiceTotal();
        }

        private void chocolateNum_ValueChanged(object sender, EventArgs e)
        {
            CalculateInvoiceTotal();
        }

        private void pancakesNum_ValueChanged(object sender, EventArgs e)
        {
            CalculateInvoiceTotal();
        }

        private void cookiesNum_ValueChanged(object sender, EventArgs e)
        {
            CalculateInvoiceTotal();
        }

        private void ClearOrderForm()
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

            totalPrice.Text = "$0.0";
            discountPrice.Text = "$0.0";
            NetTotalPrice.Text = "$0.0";

            displayRichTextBox.Clear();
        }
    }
}
