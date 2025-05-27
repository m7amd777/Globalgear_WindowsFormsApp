using System.Xml.Linq;
using WMPLib;
using static System.Net.WebRequestMethods;

namespace Project
{
    public partial class Form1 : Form
    {

        Product product1 = new Product("Barca Shirt", 15.9, 0);
        Product product2 = new Product("Porto Shirt", 20.9, 0);
        Product product3 = new Product("Arsen Shirt", 17.9, 0);
        Product product4 = new Product("Juven Shirt", 15.9, 0);
        Product product5 = new Product("GOAT Shirt", 20.9, 0);
        Product product6 = new Product("Ahly Shirt", 17.9, 0);
        Product[] products = new Product[6];
        int itemCount = 0;
        String text;
        int length;
        int counter = 0;
        String howDidYouHearAboutUs;

        public Form1()
        {
            InitializeComponent();

            products[0] = product1;
            products[1] = product2;
            products[2] = product3;
            products[3] = product4;
            products[4] = product5;
            products[5] = product6;







        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            int hoodie1Quantity = Int32.Parse(label4.Text);
            if (hoodie1Quantity <= 0)
            {

                MessageBox.Show("You have nothing!");
            }
            else
            {
                label4.Text = (--hoodie1Quantity).ToString();
                if (hoodie1Quantity == 0)
                {
                    label4.BackColor = Color.Transparent;
                }
                product1.quantity--;
                //  MessageBox.Show(product1.quantity.ToString());
                label25.Text = (--itemCount).ToString();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int hoodie1Quantity = Int32.Parse(label4.Text);
            label4.Text = (++hoodie1Quantity).ToString();

            product1.quantity++;
            //MessageBox.Show(product1.quantity.ToString());
            label25.Text = (++itemCount).ToString();
            label4.BackColor = Color.Orange;

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

            int hoodie1Quantity = Int32.Parse(label5.Text);
            label5.Text = (++hoodie1Quantity).ToString();
            product2.quantity++;
            //MessageBox.Show(product2.quantity.ToString());
            label25.Text = (++itemCount).ToString();
            label5.BackColor = Color.Orange;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int hoodie1Quantity = Int32.Parse(label5.Text);
            if (hoodie1Quantity <= 0)
            {
                MessageBox.Show("You have nothing!");
            }
            else
            {

                label5.Text = (--hoodie1Quantity).ToString();
                if (hoodie1Quantity == 0)
                {
                    label5.BackColor = Color.Transparent;
                }
                product2.quantity--;
                //  MessageBox.Show(product2.quantity.ToString());
                label25.Text = (--itemCount).ToString();


            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            int hoodie1Quantity = Int32.Parse(label9.Text);
            label9.Text = (++hoodie1Quantity).ToString();
            product3.quantity++;
            //MessageBox.Show(product3.quantity.ToString());
            label25.Text = (++itemCount).ToString();
            label9.BackColor = Color.Orange;

        }

        private void button6_Click(object sender, EventArgs e)
        {
            int hoodie1Quantity = Int32.Parse(label9.Text);
            if (hoodie1Quantity <= 0)
            {
                MessageBox.Show("You have nothing!");
            }
            else
            {

                label9.Text = (--hoodie1Quantity).ToString();
                if (hoodie1Quantity == 0)
                {
                    label9.BackColor = Color.Transparent;
                }
                product3.quantity--;
                //   MessageBox.Show(product3.quantity.ToString());
                label25.Text = (--itemCount).ToString();


            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button11_Click(object sender, EventArgs e)
        {
            int hoodie1Quantity = Int32.Parse(label21.Text);
            label21.Text = (++hoodie1Quantity).ToString();
            product4.quantity++;
            // MessageBox.Show(product4.quantity.ToString());
            label25.Text = (++itemCount).ToString();
            label21.BackColor = Color.Orange;

        }

        private void button12_Click(object sender, EventArgs e)
        {
            int hoodie1Quantity = Int32.Parse(label21.Text);
            if (hoodie1Quantity <= 0)
            {
                MessageBox.Show("You have nothing!");
            }
            else
            {
                label21.Text = (--hoodie1Quantity).ToString();
                if (hoodie1Quantity == 0)
                {
                    label21.BackColor = Color.Transparent;
                }
                product4.quantity--;
                //MessageBox.Show(product4.quantity.ToString());
                label25.Text = (--itemCount).ToString();


            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            int hoodie1Quantity = Int32.Parse(label17.Text);
            label17.Text = (++hoodie1Quantity).ToString();
            product5.quantity++;
            //  MessageBox.Show(product5.quantity.ToString());
            label25.Text = (++itemCount).ToString();
            label17.BackColor = Color.Orange;

        }

        private void button10_Click(object sender, EventArgs e)
        {
            int hoodie1Quantity = Int32.Parse(label17.Text);
            if (hoodie1Quantity <= 0)
            {
                MessageBox.Show("You have nothing!");
            }
            else
            {
                label17.Text = (--hoodie1Quantity).ToString();
                product5.quantity--;
                //    MessageBox.Show(product5.quantity.ToString());
                label25.Text = (--itemCount).ToString();


            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            int hoodie1Quantity = Int32.Parse(label13.Text);
            label13.Text = (++hoodie1Quantity).ToString();
            product6.quantity++;
            //MessageBox.Show(product6.quantity.ToString());
            label25.Text = (++itemCount).ToString();
            label13.BackColor = Color.Orange;

        }

        private void button8_Click(object sender, EventArgs e)
        {
            int hoodie1Quantity = Int32.Parse(label13.Text);
            if (hoodie1Quantity <= 0)
            {
                MessageBox.Show("You have nothing!");
            }
            else
            {
                label13.Text = (--hoodie1Quantity).ToString();
                if (hoodie1Quantity == 0)
                {
                    label13.BackColor = Color.Transparent;
                }
                product6.quantity--;
                //  MessageBox.Show(product6.quantity.ToString());
                label25.Text = (--itemCount).ToString();


            }
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {


            if (itemCount <= 0 || ( !instagramRadioButton.Checked && !websiteRadioButton.Checked  && !wordOfMouthRadioButton.Checked ))
            {
                MessageBox.Show("Buy something first! And make sure to tell us how you heard about us!");
            }
            else
            {
                if (instagramRadioButton.Checked)
                {
                    howDidYouHearAboutUs = "Instagram";
                }
                else if (websiteRadioButton.Checked)
                {
                    howDidYouHearAboutUs = "Website";
                }
                else
                {
                    howDidYouHearAboutUs = "Word Of Mouth";
                }
                Form2 checkout = new Form2(products, itemCount);
                axWindowsMediaPlayer1.Ctlcontrols.stop();
                this.Hide();
                checkout.Show();

                //MessageBox.Show("Next Page Yay");

            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void label24_Click(object sender, EventArgs e)
        {

        }



        private void Form1_Load(object sender, EventArgs e)
        {
            text = label26.Text;
            length = text.Length;
            label26.Text = "";
            timer1.Start();
            // If you face a freeze in the screen, comment down the video

            //var videoPath = Path.Combine(
            //    Application.StartupPath,
            //    "Resources",
            //    "video.mp4"
            //);
            //axWindowsMediaPlayer1.URL = videoPath;
            //axWindowsMediaPlayer1.Ctlcontrols.play();
        }

        private void axWindowsMediaPlayer1_Enter(object sender, EventArgs e)
        {

           
        
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            counter++;
            if (counter > length)
            {
                counter = 0;
                label26.Text = "";
            }
            else
            {
                label26.Text = text.Substring(0, counter);
            }

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }

    public class Product
    {
        public string name;
        public double price;
        public int quantity;

        public Product(string n, double p, int q) 
        {
            name = n;
            price = p;
            quantity = q;
        }

    }



}
