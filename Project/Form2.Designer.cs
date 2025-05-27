namespace Project
{
    partial class Form2
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
            nameLabel = new Label();
            textBox1 = new TextBox();
            phoneLabel = new Label();
            textBox2 = new TextBox();
            locationLabel = new Label();
            textBox3 = new TextBox();
            button1 = new Button();
            groupBox1 = new GroupBox();
            totalPriceLabel = new Label();
            prodSixPrice = new Label();
            prodFivePrice = new Label();
            prodFourPrice = new Label();
            prodThreePrice = new Label();
            prodTwoPrice = new Label();
            prodOnePrice = new Label();
            groupBox2 = new GroupBox();
            listBox1 = new ListBox();
            saveFileDialog1 = new SaveFileDialog();
            button2 = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Location = new Point(260, 23);
            nameLabel.Margin = new Padding(2, 0, 2, 0);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new Size(61, 15);
            nameLabel.TabIndex = 12;
            nameLabel.Text = "Full Name";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(260, 40);
            textBox1.Margin = new Padding(2);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(283, 23);
            textBox1.TabIndex = 13;
            // 
            // phoneLabel
            // 
            phoneLabel.AutoSize = true;
            phoneLabel.Location = new Point(260, 62);
            phoneLabel.Margin = new Padding(2, 0, 2, 0);
            phoneLabel.Name = "phoneLabel";
            phoneLabel.Size = new Size(88, 15);
            phoneLabel.TabIndex = 14;
            phoneLabel.Text = "Phone Number";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(260, 79);
            textBox2.Margin = new Padding(2);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(283, 23);
            textBox2.TabIndex = 15;
            // 
            // locationLabel
            // 
            locationLabel.AutoSize = true;
            locationLabel.Location = new Point(260, 103);
            locationLabel.Margin = new Padding(2, 0, 2, 0);
            locationLabel.Name = "locationLabel";
            locationLabel.Size = new Size(53, 15);
            locationLabel.TabIndex = 16;
            locationLabel.Text = "Location";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(260, 119);
            textBox3.Margin = new Padding(2);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(283, 23);
            textBox3.TabIndex = 17;
            // 
            // button1
            // 
            button1.Location = new Point(318, 259);
            button1.Margin = new Padding(2);
            button1.Name = "button1";
            button1.Size = new Size(146, 20);
            button1.TabIndex = 18;
            button1.Text = "Get Receipt";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(totalPriceLabel);
            groupBox1.Controls.Add(prodSixPrice);
            groupBox1.Controls.Add(prodFivePrice);
            groupBox1.Controls.Add(prodFourPrice);
            groupBox1.Controls.Add(prodThreePrice);
            groupBox1.Controls.Add(prodTwoPrice);
            groupBox1.Controls.Add(prodOnePrice);
            groupBox1.Location = new Point(260, 143);
            groupBox1.Margin = new Padding(2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(2);
            groupBox1.Size = new Size(281, 107);
            groupBox1.TabIndex = 19;
            groupBox1.TabStop = false;
            groupBox1.Text = "Total Price";
            // 
            // totalPriceLabel
            // 
            totalPriceLabel.AutoSize = true;
            totalPriceLabel.Location = new Point(14, 80);
            totalPriceLabel.Margin = new Padding(2, 0, 2, 0);
            totalPriceLabel.Name = "totalPriceLabel";
            totalPriceLabel.Size = new Size(0, 15);
            totalPriceLabel.TabIndex = 6;
            // 
            // prodSixPrice
            // 
            prodSixPrice.AutoSize = true;
            prodSixPrice.Location = new Point(94, 56);
            prodSixPrice.Margin = new Padding(2, 0, 2, 0);
            prodSixPrice.Name = "prodSixPrice";
            prodSixPrice.Size = new Size(0, 15);
            prodSixPrice.TabIndex = 5;
            // 
            // prodFivePrice
            // 
            prodFivePrice.AutoSize = true;
            prodFivePrice.Location = new Point(94, 41);
            prodFivePrice.Margin = new Padding(2, 0, 2, 0);
            prodFivePrice.Name = "prodFivePrice";
            prodFivePrice.Size = new Size(0, 15);
            prodFivePrice.TabIndex = 4;
            // 
            // prodFourPrice
            // 
            prodFourPrice.AutoSize = true;
            prodFourPrice.Location = new Point(94, 25);
            prodFourPrice.Margin = new Padding(2, 0, 2, 0);
            prodFourPrice.Name = "prodFourPrice";
            prodFourPrice.Size = new Size(0, 15);
            prodFourPrice.TabIndex = 3;
            // 
            // prodThreePrice
            // 
            prodThreePrice.AutoSize = true;
            prodThreePrice.Location = new Point(14, 56);
            prodThreePrice.Margin = new Padding(2, 0, 2, 0);
            prodThreePrice.Name = "prodThreePrice";
            prodThreePrice.Size = new Size(0, 15);
            prodThreePrice.TabIndex = 2;
            // 
            // prodTwoPrice
            // 
            prodTwoPrice.AutoSize = true;
            prodTwoPrice.Location = new Point(14, 41);
            prodTwoPrice.Margin = new Padding(2, 0, 2, 0);
            prodTwoPrice.Name = "prodTwoPrice";
            prodTwoPrice.Size = new Size(0, 15);
            prodTwoPrice.TabIndex = 1;
            // 
            // prodOnePrice
            // 
            prodOnePrice.AutoSize = true;
            prodOnePrice.Location = new Point(14, 25);
            prodOnePrice.Margin = new Padding(2, 0, 2, 0);
            prodOnePrice.Name = "prodOnePrice";
            prodOnePrice.Size = new Size(0, 15);
            prodOnePrice.TabIndex = 0;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(listBox1);
            groupBox2.Location = new Point(12, 23);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(200, 227);
            groupBox2.TabIndex = 7;
            groupBox2.TabStop = false;
            groupBox2.Text = "Checkout Product Summary";
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(6, 25);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(188, 184);
            listBox1.TabIndex = 7;
            listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // saveFileDialog1
            // 
            saveFileDialog1.FileOk += saveFileDialog1_FileOk;
            // 
            // button2
            // 
            button2.Location = new Point(12, 256);
            button2.Name = "button2";
            button2.Size = new Size(200, 23);
            button2.TabIndex = 7;
            button2.Text = "Start Over";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(568, 292);
            Controls.Add(button2);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(button1);
            Controls.Add(textBox3);
            Controls.Add(locationLabel);
            Controls.Add(textBox2);
            Controls.Add(phoneLabel);
            Controls.Add(textBox1);
            Controls.Add(nameLabel);
            Margin = new Padding(2);
            Name = "Form2";
            Text = "Form2";
            Load += Form2_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion


        private Label nameLabel;
        private TextBox textBox1;
        private Label phoneLabel;
        private TextBox textBox2;
        private Label locationLabel;
        private TextBox textBox3;
        private Button button1;
        private GroupBox groupBox1;
        private Label totalPriceLabel;
        private Label prodSixPrice;
        private Label prodFivePrice;
        private Label prodFourPrice;
        private Label prodThreePrice;
        private Label prodTwoPrice;
        private Label prodOnePrice;
        private GroupBox groupBox2;
        private ListBox listBox1;
        private SaveFileDialog saveFileDialog1;
        private Button button2;
    }
}