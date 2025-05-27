using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Project
{
    public partial class Form2 : Form
    {
        int currentItemCount;
        Product[] original;
        List<Product> products = [];
        String name;
        String phoneNumber;
        String location;
        StreamWriter outputFile;
        int quantity = 0;
        double price = 0;
        double totalPrice = 0;


        public Form2(Product[] products, int itemCount)
        {
            InitializeComponent();
            original = products;
            currentItemCount = itemCount;
            textBox2.KeyPress += TextBox2_KeyPress;
            textBox1.KeyPress += TextBox1_KeyPress;
        }

        private void TextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (char.IsDigit(e.KeyChar))
            {
                MessageBox.Show("Please Enter only Letters in the Name text box");


                textBox1.Text = "";



                e.Handled = true;
            }
        }
        private void TextBox2_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {

                MessageBox.Show("Please Enter only Numbers in the phone number text box");

                textBox2.Text = "";

                e.Handled = true;

            }
        }
        private void Form2_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < 6; i++)
            {
                if (original[i].quantity != 0)
                {
                    products.Add(original[i]);
                }


            }
            for (int i = 0; i < products.Count; i++)
            {
                price = products[i].price;
                quantity = products[i].quantity;
                totalPrice += price * quantity;
                int switchVariable = products.Count - (products.Count - i);

                switch (switchVariable)
                {
                    case 0:
                        listBox1.Items.Add(products[i].name);
                        listBox1.Items.Add(products[i].quantity.ToString());
                        prodOnePrice.Text = "Item " + (i + 1) + " " + (price * quantity).ToString("F2") + " BD   ";
                        break;
                    case 1:
                        listBox1.Items.Add(products[i].name);
                        listBox1.Items.Add(products[i].quantity.ToString());
                        prodTwoPrice.Text = "Item " + (i + 1) + " " + (price * quantity).ToString("F2") + " BD   ";
                        break;
                    case 2:
                        listBox1.Items.Add(products[i].name);
                        listBox1.Items.Add(products[i].quantity.ToString());
                        prodThreePrice.Text = "Item " + (i + 1) + " " + (price * quantity).ToString("F2") + " BD   ";
                        break;
                    case 3:
                        listBox1.Items.Add(products[i].name);
                        listBox1.Items.Add(products[i].quantity.ToString());
                        prodFourPrice.Text = "          Item " + (i + 1) + " " + (price * quantity).ToString("F2") + " BD";
                        break;
                    case 4:
                        listBox1.Items.Add(products[i].name);
                        listBox1.Items.Add(products[i].quantity.ToString());
                        prodFivePrice.Text = "          Item " + (i + 1) + " " + (price * quantity).ToString("F2") + " BD";
                        break;
                    case 5:
                        listBox1.Items.Add(products[i].name);
                        listBox1.Items.Add(products[i].quantity.ToString());
                        prodSixPrice.Text = "          Item " + (i + 1) + " " + (price * quantity).ToString("F2") + " BD";
                        break;
                }

            }
            totalPriceLabel.Text = "Your total Bill is: " + totalPrice.ToString("F2") + " BD";

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "")
            {
                MessageBox.Show("Please fill out everything");
                return;
            }

            string name = textBox1.Text;
            string phoneNumber = textBox2.Text;
            string location = textBox3.Text;

            SaveFileDialog saveFileDialog = new SaveFileDialog
            {
                Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*",
                DefaultExt = ".txt",
                FileName = "receipt.txt"
            };

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {

                using (StreamWriter outputFile = new StreamWriter(saveFileDialog.FileName))
                {
                    outputFile.WriteLine("Name: " + name);
                    outputFile.WriteLine("Phone Number: " + phoneNumber);
                    outputFile.WriteLine("Location: " + location);


                    for (int i = 0; i < products.Count; i++)
                    {
                        outputFile.WriteLine("Product " + (i + 1) + " Name: " + products[i].name);
                        outputFile.WriteLine("Product " + (i + 1) + " Quantity: " + products[i].quantity);
                        outputFile.WriteLine("Product " + (i + 1) + " Price: " + products[i].price);
                    }
                    outputFile.WriteLine("Total Price: " + totalPrice.ToString("F2"));
                }
                MessageBox.Show("Receipt saved successfully!");
            }
        }


        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void saveFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            Form1 form = new Form1();
            form.Show();
        }
    }
}
