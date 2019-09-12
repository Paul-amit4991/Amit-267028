using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CoffeShop
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            string name = nameTextBox.Text;
            string contact =contactTextBox.Text;
            string address = adressTextBox.Text;
            string order = orderComboBox.Text;
            if (orderComboBox.Text == "")
            {
               MessageBox.Show("Please, Select an item");
            }
            else
            {
                MessageBox.Show("Successfully Added");
            }
            int quantity = Convert.ToInt32(quantityTextBox.Text);
            int price = 0;

            if (orderComboBox.Text == "Black-120")
            {
                price =  quantity*120;
            }
            else if(orderComboBox.Text == "Cold-100")
            {
                price = 100 * quantity;
            }
            else if(orderComboBox.Text == "Hot-90")
            {
                 price = 90 * quantity;
            }
            else if(orderComboBox.Text=="Regular-80")
            {
                 price = 80 * quantity;
            }

            displayTextBox.AppendText("Customer Name : "+name +"\n Contact No. : " +contact +"\n Adress : "+address+"\n Order : "+order+"\n Quantity : " +quantity+"\n Total Price : "+ price);
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            nameTextBox.Text = "";
            contactTextBox.Text = "";
            adressTextBox.Text = "";
            orderComboBox.Text = "";
            quantityTextBox.Text = "";
            displayTextBox.Clear();

            nameTextBox.Focus();
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
