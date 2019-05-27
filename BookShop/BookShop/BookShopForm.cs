using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookShop
{
    public partial class BookShopForm : Form
    {
        List<string> customerNames = new List<string>();
        List<string> contacts = new List<string>();
        List<string> addresses = new List<string>();
        List<string> orders = new List<string>();
        List<int> quantites = new List<int>();
        List<double> totalBills = new List<double>();

        int price;

        public BookShopForm()
        {
            InitializeComponent();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            int index = 0;
            string message = "";

            try
            {
                customerNames.Add(nameTextBox.Text);
                contacts.Add(contactNoTextBox.Text);
                addresses.Add(addressTextBox.Text);
                orders.Add(orderComboBox.Text);
                quantites.Add(Convert.ToInt32(quantityTextBox.Text));

                if (orders[index].Equals("Math"))
                {
                    price = 120;
                }
                else if (orders[index].Equals("English"))
                {
                    price = 100;
                }
                else if (orders[index].Equals("Bangla"))
                {
                    price = 90;
                }
                else if (orders[index].Equals("Art"))
                {
                    price = 80;
                }

                totalBills.Add(quantites[index] * price);

                foreach(int totalBill in totalBills)
                {
                    message = message + "\t Customer No. [" + (index + 1) + "] Order Information \n\t\t---------------------------\n\n  Name : " + customerNames[index] + "\n  Contact No : " + contacts[index] + "\n  Address : " + addresses[index] + "\n  Ordered item : " + orders[index] + "\n  Quantity : " + quantites[index] + "\n  Total Bill : " + totalBill + " Tk.\n\n\t        Thank you for stay with us...\n\n\n\n";
                    index++;
                }

                showRichTextBox.Text = message;

                nameTextBox.Clear();
                contactNoTextBox.Clear();
                addressTextBox.Clear();
                orderComboBox.SelectedIndex = -1;
                quantityTextBox.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
