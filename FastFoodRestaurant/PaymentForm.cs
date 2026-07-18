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
        public string SelectedPaymentMethod { get; set; } = "Cash";

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

                    SelectedPaymentMethod = "Cash";
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

        private void btnConfirmCard_Click(object sender, EventArgs e)
        {
            string selectedCardType = "";

            if (rdoUnifiedNetwork.Checked)
                selectedCardType = "Unified Network";
            else if (rdoVisaCard.Checked)
                selectedCardType = "Visa Card";
            else if (rdoMasterCard.Checked)
                selectedCardType = "Master Card";

            if (string.IsNullOrEmpty(selectedCardType))
            {
                MessageBox.Show("Please select a card network type first.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string referenceNumber = txtCardReference.Text.Trim();

            if (string.IsNullOrEmpty(referenceNumber))
            {
                MessageBox.Show("Please enter the transaction reference number from the POS machine.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCardReference.Focus();
                return;
            }

            MessageBox.Show($"Card payment successfuly !\t\t\n\n Amount Charged : ${_orderNetTotal.ToString("0.0")}\n Network : {selectedCardType}\n Ref No{referenceNumber}", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            SelectedPaymentMethod = $"Card: ({selectedCardType}) \n- Ref: {referenceNumber}";
            this.DialogResult = DialogResult.OK;
            this.Close();

        }

        private void btnConfirmWallet_Click(object sender, EventArgs e)
        {
            String selectedWalletType = "";

            if (rdoWalletJaib.Checked)
                selectedWalletType = "Jaib";
            if (rdoWalletOneCash.Checked)
                selectedWalletType = "ONE Cash";
            if (rdoWalletJawali.Checked)
                selectedWalletType = "Jawali";
            if (rdoWalletKuraimi.Checked)
                selectedWalletType = "Kuraimi";
            if (rdoWalletFloosak.Checked)
                selectedWalletType = "Floosak";

            if (string.IsNullOrEmpty(selectedWalletType))
            {
                MessageBox.Show("Please select an E-Wallet provider first.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string transactionId = txtWalletTransactionId.Text.Trim();

            if (string.IsNullOrEmpty(transactionId))
            {
                MessageBox.Show("Please enter the mobile wallet transaction ID.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtWalletTransactionId.Focus();
                return;
            }

            MessageBox.Show($"\tE-Wallet payment processed successfully!\t\t\n\n\t\tAmount Received: ${_orderNetTotal.ToString("0.0")}\n\t\tWallet: {selectedWalletType}\n\t\tTxn ID: {transactionId}",
                    "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            SelectedPaymentMethod = $"E-Wallet: ({selectedWalletType}) \n- Txn ID: {transactionId}";
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

    }
}
