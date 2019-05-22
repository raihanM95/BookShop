using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment_2
{
    public partial class BookShop : Form
    {
        public BookShop()
        {
            InitializeComponent();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            try
            {
                string name = nameTextBox.Text;
                string contactNo = contactNoTextBox.Text;
                string address = addressTextBox.Text;
                string order = orderComboBox.Text;
                int quantity = Convert.ToInt32(quantityTextBox.Text);

                showRichTextBox.Text = "\t\tOrder Information" + Environment.NewLine + "\t\t---------------------------" + Environment.NewLine + Environment.NewLine + "  Name : " + name + Environment.NewLine + "  Contact No : " + contactNo + Environment.NewLine + "  Address : " + address + Environment.NewLine + "  Your ordered item : " + order + Environment.NewLine + "  Quantity : " + quantity + Environment.NewLine + Environment.NewLine + "\t        Thank you for stay with us...";

                nameTextBox.Text = "";
                contactNoTextBox.Text = "";
                addressTextBox.Text = "";
                orderComboBox.SelectedIndex = -1;
                quantityTextBox.Text = "";

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
