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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            imageListTabIcons = new ImageList(components);
            panel1 = new Panel();
            pictureBackPayment = new PictureBox();
            LbPaymentOptions = new Label();
            tabEWallet = new TabPage();
            tabCard = new TabPage();
            tabCash = new TabPage();
            pictureBox1 = new PictureBox();
            guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            guna2HtmlLabel4 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            guna2HtmlLabel3 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            guna2HtmlLabel2 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            guna2TextBox2 = new Guna.UI2.WinForms.Guna2TextBox();
            guna2TextBox1 = new Guna.UI2.WinForms.Guna2TextBox();
            tabControlPayment = new TabControl();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBackPayment).BeginInit();
            tabCash.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            tabControlPayment.SuspendLayout();
            SuspendLayout();
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
            LbPaymentOptions.Location = new Point(270, 19);
            LbPaymentOptions.Name = "LbPaymentOptions";
            LbPaymentOptions.Size = new Size(251, 47);
            LbPaymentOptions.TabIndex = 0;
            LbPaymentOptions.Text = "Payment Options";
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
            // tabCard
            // 
            tabCard.BackColor = Color.WhiteSmoke;
            tabCard.ImageIndex = 3;
            tabCard.Location = new Point(4, 35);
            tabCard.Name = "tabCard";
            tabCard.Padding = new Padding(3);
            tabCard.Size = new Size(792, 324);
            tabCard.TabIndex = 1;
            tabCard.Text = "Card";
            // 
            // tabCash
            // 
            tabCash.BackColor = Color.WhiteSmoke;
            tabCash.Controls.Add(pictureBox1);
            tabCash.Controls.Add(guna2Button1);
            tabCash.Controls.Add(guna2HtmlLabel4);
            tabCash.Controls.Add(guna2HtmlLabel3);
            tabCash.Controls.Add(guna2HtmlLabel2);
            tabCash.Controls.Add(guna2HtmlLabel1);
            tabCash.Controls.Add(guna2TextBox2);
            tabCash.Controls.Add(guna2TextBox1);
            tabCash.ForeColor = Color.IndianRed;
            tabCash.ImageIndex = 1;
            tabCash.Location = new Point(4, 35);
            tabCash.Name = "tabCash";
            tabCash.Padding = new Padding(3);
            tabCash.Size = new Size(792, 324);
            tabCash.TabIndex = 0;
            tabCash.Text = "Cash";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.payment;
            pictureBox1.Location = new Point(8, 35);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(301, 255);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 9;
            pictureBox1.TabStop = false;
            // 
            // guna2Button1
            // 
            guna2Button1.BackColor = Color.White;
            guna2Button1.BorderRadius = 12;
            guna2Button1.CustomizableEdges = customizableEdges1;
            guna2Button1.DisabledState.BorderColor = Color.DarkGray;
            guna2Button1.DisabledState.CustomBorderColor = Color.DarkGray;
            guna2Button1.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            guna2Button1.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            guna2Button1.FillColor = Color.Red;
            guna2Button1.Font = new Font("Segoe UI Emoji", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            guna2Button1.ForeColor = Color.White;
            guna2Button1.Location = new Point(418, 211);
            guna2Button1.Name = "guna2Button1";
            guna2Button1.ShadowDecoration.CustomizableEdges = customizableEdges2;
            guna2Button1.Size = new Size(288, 39);
            guna2Button1.TabIndex = 8;
            guna2Button1.Text = "Confirm and Print Invoice";
            // 
            // guna2HtmlLabel4
            // 
            guna2HtmlLabel4.BackColor = Color.Transparent;
            guna2HtmlLabel4.Font = new Font("Tahoma", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            guna2HtmlLabel4.ForeColor = Color.Black;
            guna2HtmlLabel4.Location = new Point(712, 15);
            guna2HtmlLabel4.Name = "guna2HtmlLabel4";
            guna2HtmlLabel4.Size = new Size(34, 23);
            guna2HtmlLabel4.TabIndex = 7;
            guna2HtmlLabel4.Text = "$/..";
            guna2HtmlLabel4.TextAlignment = ContentAlignment.MiddleCenter;
            // 
            // guna2HtmlLabel3
            // 
            guna2HtmlLabel3.BackColor = Color.Transparent;
            guna2HtmlLabel3.Font = new Font("Tahoma", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            guna2HtmlLabel3.ForeColor = Color.Red;
            guna2HtmlLabel3.Location = new Point(649, 15);
            guna2HtmlLabel3.Name = "guna2HtmlLabel3";
            guna2HtmlLabel3.Size = new Size(57, 23);
            guna2HtmlLabel3.TabIndex = 6;
            guna2HtmlLabel3.Text = "Total : ";
            guna2HtmlLabel3.TextAlignment = ContentAlignment.MiddleCenter;
            // 
            // guna2HtmlLabel2
            // 
            guna2HtmlLabel2.BackColor = Color.Transparent;
            guna2HtmlLabel2.Font = new Font("Tahoma", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            guna2HtmlLabel2.ForeColor = Color.Red;
            guna2HtmlLabel2.Location = new Point(353, 129);
            guna2HtmlLabel2.Name = "guna2HtmlLabel2";
            guna2HtmlLabel2.Size = new Size(253, 23);
            guna2HtmlLabel2.TabIndex = 4;
            guna2HtmlLabel2.Text = "Customer Remaining Balance";
            guna2HtmlLabel2.TextAlignment = ContentAlignment.MiddleCenter;
            // 
            // guna2HtmlLabel1
            // 
            guna2HtmlLabel1.BackColor = Color.Transparent;
            guna2HtmlLabel1.Font = new Font("Tahoma", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            guna2HtmlLabel1.ForeColor = Color.Red;
            guna2HtmlLabel1.Location = new Point(456, 78);
            guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            guna2HtmlLabel1.Size = new Size(113, 23);
            guna2HtmlLabel1.TabIndex = 3;
            guna2HtmlLabel1.Text = "Amount Paid";
            guna2HtmlLabel1.TextAlignment = ContentAlignment.MiddleCenter;
            // 
            // guna2TextBox2
            // 
            guna2TextBox2.BorderColor = Color.Black;
            guna2TextBox2.BorderRadius = 12;
            guna2TextBox2.BorderThickness = 2;
            customizableEdges3.BottomRight = false;
            customizableEdges3.TopLeft = false;
            guna2TextBox2.CustomizableEdges = customizableEdges3;
            guna2TextBox2.DefaultText = "";
            guna2TextBox2.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            guna2TextBox2.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            guna2TextBox2.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            guna2TextBox2.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            guna2TextBox2.Enabled = false;
            guna2TextBox2.FocusedState.BorderColor = Color.Red;
            guna2TextBox2.Font = new Font("Segoe UI", 9F);
            guna2TextBox2.HoverState.BorderColor = Color.Red;
            guna2TextBox2.Location = new Point(626, 122);
            guna2TextBox2.Margin = new Padding(3, 4, 3, 4);
            guna2TextBox2.Name = "guna2TextBox2";
            guna2TextBox2.PlaceholderText = "";
            guna2TextBox2.SelectedText = "";
            guna2TextBox2.ShadowDecoration.CustomizableEdges = customizableEdges4;
            guna2TextBox2.Size = new Size(86, 37);
            guna2TextBox2.TabIndex = 5;
            // 
            // guna2TextBox1
            // 
            guna2TextBox1.BorderColor = Color.Black;
            guna2TextBox1.BorderRadius = 12;
            guna2TextBox1.BorderThickness = 2;
            customizableEdges5.BottomRight = false;
            customizableEdges5.TopLeft = false;
            guna2TextBox1.CustomizableEdges = customizableEdges5;
            guna2TextBox1.DefaultText = "";
            guna2TextBox1.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            guna2TextBox1.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            guna2TextBox1.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            guna2TextBox1.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            guna2TextBox1.FocusedState.BorderColor = Color.Red;
            guna2TextBox1.Font = new Font("Segoe UI", 9F);
            guna2TextBox1.HoverState.BorderColor = Color.Red;
            guna2TextBox1.Location = new Point(626, 71);
            guna2TextBox1.Margin = new Padding(3, 4, 3, 4);
            guna2TextBox1.Name = "guna2TextBox1";
            guna2TextBox1.PlaceholderText = "";
            guna2TextBox1.SelectedText = "";
            guna2TextBox1.ShadowDecoration.CustomizableEdges = customizableEdges6;
            guna2TextBox1.Size = new Size(86, 37);
            guna2TextBox1.TabIndex = 2;
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
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBackPayment).EndInit();
            tabCash.ResumeLayout(false);
            tabCash.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            tabControlPayment.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Panel panel1;
        private ImageList imageListTabIcons;
        private Label LbPaymentOptions;
        private PictureBox pictureBackPayment;
        private TabPage tabEWallet;
        private TabPage tabCard;
        private TabPage tabCash;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel4;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel3;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel2;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2TextBox guna2TextBox2;
        private Guna.UI2.WinForms.Guna2TextBox guna2TextBox1;
        private TabControl tabControlPayment;
        private PictureBox pictureBox1;
    }
}