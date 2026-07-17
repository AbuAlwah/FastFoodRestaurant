using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FastFoodRestaurant
{
    public partial class PaymentForm : Form
    {
        private decimal _orderNetTotal = 0m;

        public PaymentForm(decimal finalNetTotal)
        {
            InitializeComponent();

            _orderNetTotal = finalNetTotal;

            txtTotalCashPage.Text = "$" + _orderNetTotal.ToString("0.0");
        }

        private void PaymentForm_Load(object sender, EventArgs e)
        {

        }

        private void btnBackPaymentPage_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtAmountPaid_TextChanged(object sender, EventArgs e)
        {
            if (decimal.TryParse(txtAmountPaid.Text, out decimal amountPaid))
            {
                decimal remaining = amountPaid - _orderNetTotal;

                txtRemainingBalance.Text = remaining.ToString("0.0");

            }
            else
            {
                txtRemainingBalance.Text = "0.0";
            }

        }

        private void btnConfirmCash_Click(object sender, EventArgs e)
        {
            if (decimal.TryParse(txtAmountPaid.Text, out decimal amountPaid))
            {
                if (amountPaid >= _orderNetTotal)
                {
                    decimal finalRemaining = amountPaid - _orderNetTotal;

                    MessageBox.Show($"Payment completed successfully!\n\nReceived: ${amountPaid.ToString("0.0")}\nChange: ${finalRemaining.ToString("0.0")}",
                                    "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);


                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    MessageBox.Show("The amount paid is less than the total invoice! Please enter the remaining amount.",
                                    "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtAmountPaid.Focus(); 
                }
            }
            else
            {
                MessageBox.Show("Please enter a valid paid amount first.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtAmountPaid.Focus();
            }
        }
    }
}
