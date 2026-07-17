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
            // 1. محاولة قراءة المبلغ المدفوع من التكست بوكس
            // نستخدم decimal.TryParse لتفادي حدوث خطأ إذا كان التكست بوكس فارغاً أو يحتوي نصاً غير رقمي
            if (decimal.TryParse(txtAmountPaid.Text, out decimal amountPaid))
            {
                // 2. حساب الباقي (المبلغ المدفوع - الإجمالي الذي استلمناه من الشاشة الرئيسية)
                decimal remaining = amountPaid - _orderNetTotal;

                // 3. عرض النتيجة في مربع نص الباقي
                // تنسيق الرقم بـ "0.0" ليظهر بشكل مرتب
                txtRemainingBalance.Text = remaining.ToString("0.0");

            }
            else
            {
                // إذا مسح الكاشير الرقم أو كتب شيئاً خاطئاً، نجعل الباقي فارغاً أو صفراً
                txtRemainingBalance.Text = "0.0";
            }

        }

        private void btnConfirmCash_Click(object sender, EventArgs e)
        {
            // 1. Check if the entered amount is a valid decimal number
            if (decimal.TryParse(txtAmountPaid.Text, out decimal amountPaid))
            {
                // 2. Ensure the paid amount is greater than or equal to the net total
                if (amountPaid >= _orderNetTotal)
                {
                    // Calculate the final remaining balance
                    decimal finalRemaining = amountPaid - _orderNetTotal;

                    // Success message with transaction details
                    MessageBox.Show($"Payment completed successfully!\n\nReceived: ${amountPaid.ToString("0.0")}\nChange: ${finalRemaining.ToString("0.0")}",
                                    "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // 💡 Future print logic will be called here

                    // Set dialog result and close the payment form
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    // If the paid amount is insufficient
                    MessageBox.Show("The amount paid is less than the total invoice! Please enter the remaining amount.",
                                    "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtAmountPaid.Focus(); // Set focus back to input for quick editing
                }
            }
            else
            {
                // If the field is empty or contains non-numeric characters
                MessageBox.Show("Please enter a valid paid amount first.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtAmountPaid.Focus();
            }
        }
    }
}
