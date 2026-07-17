namespace FastFoodRestaurant
{
    partial class PaymentForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PaymentForm));
            tabControlPayment = new TabControl();
            tabCash = new TabPage();
            tabCard = new TabPage();
            tabEWallet = new TabPage();
            imageListTabIcons = new ImageList(components);
            panel1 = new Panel();
            pictureBackPayment = new PictureBox();
            LbPaymentOptions = new Label();
            tabControlPayment.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBackPayment).BeginInit();
            SuspendLayout();
            // 
            // tabControlPayment
            // 
            tabControlPayment.Controls.Add(tabCash);
            tabControlPayment.Controls.Add(tabCard);
            tabControlPayment.Controls.Add(tabEWallet);
            tabControlPayment.Cursor = Cursors.Hand;
            tabControlPayment.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tabControlPayment.ImageList = imageListTabIcons;
            tabControlPayment.Location = new Point(0, 88);
            tabControlPayment.Multiline = true;
            tabControlPayment.Name = "tabControlPayment";
            tabControlPayment.SelectedIndex = 0;
            tabControlPayment.Size = new Size(800, 363);
            tabControlPayment.SizeMode = TabSizeMode.Fixed;
            tabControlPayment.TabIndex = 0;
            // 
            // tabCash
            // 
            tabCash.BackColor = Color.White;
            tabCash.ImageIndex = 1;
            tabCash.Location = new Point(4, 35);
            tabCash.Name = "tabCash";
            tabCash.Padding = new Padding(3);
            tabCash.Size = new Size(792, 324);
            tabCash.TabIndex = 0;
            tabCash.Text = "Cash";
            // 
            // tabCard
            // 
            tabCard.BackColor = Color.White;
            tabCard.ImageIndex = 3;
            tabCard.Location = new Point(4, 35);
            tabCard.Name = "tabCard";
            tabCard.Padding = new Padding(3);
            tabCard.Size = new Size(792, 324);
            tabCard.TabIndex = 1;
            tabCard.Text = "Card";
            // 
            // tabEWallet
            // 
            tabEWallet.BackColor = Color.White;
            tabEWallet.ImageIndex = 6;
            tabEWallet.Location = new Point(4, 35);
            tabEWallet.Name = "tabEWallet";
            tabEWallet.Padding = new Padding(3);
            tabEWallet.Size = new Size(792, 324);
            tabEWallet.TabIndex = 2;
            tabEWallet.Text = "E-Wallet";
            // 
            // imageListTabIcons
            // 
            imageListTabIcons.ColorDepth = ColorDepth.Depth32Bit;
            imageListTabIcons.ImageStream = (ImageListStreamer)resources.GetObject("imageListTabIcons.ImageStream");
            imageListTabIcons.TransparentColor = Color.Transparent;
            imageListTabIcons.Images.SetKeyName(0, "8313018.png");
            imageListTabIcons.Images.SetKeyName(1, "Alex Fadeev(JPG).jpg");
            imageListTabIcons.Images.SetKeyName(2, "credit-card-icon-flat-line-style-vector-21541808.jpg");
            imageListTabIcons.Images.SetKeyName(3, "pngtree(JPG).jpg");
            imageListTabIcons.Images.SetKeyName(4, "SOOUYU TAMPAN wahyu824(JPG).jpg");
            imageListTabIcons.Images.SetKeyName(5, "Vecteezy(JPG)_1.jpg");
            imageListTabIcons.Images.SetKeyName(6, "wallet-62.png");
            // 
            // panel1
            // 
            panel1.BackColor = Color.Red;
            panel1.Controls.Add(pictureBackPayment);
            panel1.Controls.Add(LbPaymentOptions);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 82);
            panel1.TabIndex = 1;
            // 
            // pictureBackPayment
            // 
            pictureBackPayment.Cursor = Cursors.Hand;
            pictureBackPayment.Image = Properties.Resources.Arrow_left;
            pictureBackPayment.Location = new Point(12, 21);
            pictureBackPayment.Name = "pictureBackPayment";
            pictureBackPayment.Size = new Size(53, 45);
            pictureBackPayment.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBackPayment.TabIndex = 1;
            pictureBackPayment.TabStop = false;
            pictureBackPayment.Click += pictureBox1_Click;
            // 
            // LbPaymentOptions
            // 
            LbPaymentOptions.AutoSize = true;
            LbPaymentOptions.BackColor = Color.Red;
            LbPaymentOptions.Font = new Font("Traditional Arabic", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LbPaymentOptions.ForeColor = Color.White;
            LbPaymentOptions.Location = new Point(241, 19);
            LbPaymentOptions.Name = "LbPaymentOptions";
            LbPaymentOptions.Size = new Size(251, 47);
            LbPaymentOptions.TabIndex = 0;
            LbPaymentOptions.Text = "Payment Options";
            // 
            // PaymentForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            Controls.Add(tabControlPayment);
            FormBorderStyle = FormBorderStyle.None;
            Name = "PaymentForm";
            ShowIcon = false;
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterParent;
            Text = "PaymentForm";
            tabControlPayment.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBackPayment).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControlPayment;
        private TabPage tabCash;
        private TabPage tabCard;
        private TabPage tabEWallet;
        private Panel panel1;
        private ImageList imageListTabIcons;
        private Label LbPaymentOptions;
        private PictureBox pictureBackPayment;
    }
}