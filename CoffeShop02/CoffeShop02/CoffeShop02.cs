using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CoffeShop02
{
    public partial class CoffeShop02 : Form
    {
        List<string> names = new List<string> { };
        List<string> contacts = new List<string> { };
        List<string> adress  = new List<string> { };
        List<string> orders = new List<string> { };
        List<int> quantitys = new List<int> { };
       
        int price = 0;
        public CoffeShop02()
        {
            InitializeComponent();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
           
            if (!string.IsNullOrEmpty(nameTextBox.Text))
            {
                names.Add(nameTextBox.Text);
            }
            else
            {
                MessageBox.Show("Please Select a Name..!!!");
                return;
            }

            if (!string.IsNullOrEmpty(contactTextBox.Text))
            {
                contacts.Add(contactTextBox.Text);    
                }
            else
            {
                MessageBox.Show("Please Give Contact Number..!!!");
                return;
            }
            if (!string.IsNullOrEmpty(adressTextBox.Text))
            {
                adress.Add(adressTextBox.Text);
            }
            else
            {
                MessageBox.Show("Please Give Adress..!!!");
                return;
            }
            if (!string.IsNullOrEmpty(orderComboBox.Text))
            {
                orders.Add(orderComboBox.Text);
            }
            else
            {
                MessageBox.Show("Please Select an Item..!!!");
                return;
            }
            if (!string.IsNullOrEmpty(quantityTextBox.Text))
            {
                quantitys.Add(Convert.ToInt32(quantityTextBox.Text));
            }
            else
            {
                MessageBox.Show("Please give the quantity..!!!");
                return;
            }
            if ((orderComboBox.Text) == "Black")
            {
                price = Convert.ToInt32(quantityTextBox.Text) * 120;
            }
            else if ((orderComboBox.Text) == "Cold")
            {
                price = Convert.ToInt32(quantityTextBox.Text) * 100;
            }
            else if ((orderComboBox.Text) == "Hot")
            {
                price = Convert.ToInt32(quantityTextBox.Text) * 90;
            }
            else if ((orderComboBox.Text) == "Regular")
            {
                price = Convert.ToInt32(quantityTextBox.Text) * 80;
            }
             string Message = "";
            for (int i = 0; i < names.Count(); i++)
            {
                Message = "Name : " + names[i] + "\n" + "Contact : " + contacts[i] + "\n" + "Orders : " + orders[i] + " \n" + "Quantity : " + quantitys[i] + "\n" + "Price: " + price + "\n\n";
            }

            displayRichTextBox.AppendText(Message);

            nameTextBox.Text = "";
            contactTextBox.Text = "";
            adressTextBox.Text = "";
            orderComboBox.Text = "select item";
            quantityTextBox.Text = "";
            nameTextBox.Focus();
        }

        private void showButton_Click(object sender, EventArgs e)
        {
            
            for (int i = 0; i < names.Count(); i++)
            {
                
                display02RichTextBox.AppendText("Name : " + names[i] + "\n" + "Contact : " + contacts[i] + "\n" + "Orders : " + orders[i] + " \n" + "Quantity : " + quantitys[i] + "\n" + "Price: " + price + "\n\n");
                
            }
            displayRichTextBox.Clear();
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            nameTextBox.Text = "";
            contactTextBox.Text = "";
            adressTextBox.Text = "";
            orderComboBox.Text = "select item";
            quantityTextBox.Text = "";
            nameTextBox.Focus();

            displayRichTextBox.Clear();
            display02RichTextBox.Clear();
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
