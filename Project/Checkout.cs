using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project
{
    public partial class Checkout : Form
    {
        int ThisItemCount;
        Product[] checkoutProducts; 
        // pass in array of products 
        public Checkout(Product[] products, int itemCount)
        {
            InitializeComponent();
            checkoutProducts = products;
            itemCount = itemCount;
        }

        private void Checkout_Load(object sender, EventArgs e)
        {
            // for loop that prints label, and uses array to index into values and display them 
            for (int i = 0; i < ThisItemCount; i++) { 
                

            }

        }
    }
}
