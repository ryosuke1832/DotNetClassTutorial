using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Method to create the payment receipt 
        public string GetReceipt()
        {
            // Write code to Initialize the variables for total proice and the recipt string
            double ;
            string ;

            // Write code to Process each selected food item and calculate the total price
            foreach (int items in )
            {
                // Write code to Concatenate the selected food items and their price.
                receipt = receipt +

                // Write code to Calculate the total price
                totalPrice += ;

            }
            // Write code to Add the total price to the Receipt
            receipt = receipt + ;

            // Write code to Return receipt
            return;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Call the GetReceipt() method and display the recipt in a Label
            string receipt = GetReceipt();

            // Show the receipt string in a Label in the Receipt Groupbox
            receiptText.Text = receipt;

        }

        private void menuItems_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
