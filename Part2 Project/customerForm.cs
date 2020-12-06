using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Microsoft.VisualBasic;


namespace Part2_Project
{
    public partial class customerForm : Form
    {
        public CompCtx ctx = new CompCtx();
        int id;
        public customerForm()
        {
            InitializeComponent();
        }
        public customerForm(int id)
        {
            InitializeComponent();
            this.id = id;

        }

        private void customerForm_Load(object sender, EventArgs e)
        {
            string userName = ctx.Customers.Where(c => c.ID == id).Select(c => c.Username).Single();
            label1.Text = "Welcome " + userName + " select the product you want for your order :";
            listBox1.DataSource = ctx.Products.Select(p => p.Name).ToList();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            label2.Text = "Add Qantity for " + listBox1.SelectedItem;
        }
        //public ICollection<TransactionItem> transactionItems = new ICollection<TransactionItem>(
        private void button1_Click(object sender, EventArgs e)
        {
            int index = listBox1.SelectedIndex + 1;
            Product p = ctx.Products.Where(p => p.ID == index).Single();
            int quantity = Convert.ToInt32(QuantityTextBox.Text);
            TransactionItem TransactionI = new TransactionItem()
            {
                ProductID = index,
                Product = p,
                Quantity = quantity,
                CostPerItem = p.Price,
            };
            transactionItems.Add(TransactionI);
            int availableQ = p.InventoryLevel;
            if (quantity <= availableQ)
            {
                p.InventoryLevel -= quantity;
                ctx.TransactionItems.Add(TransactionI);
                ctx.SaveChanges();
                listBox2.DataSource = transactionItems;
            }
            else
                MessageBox.Show($"There are no enough items, the available items are {availableQ}");
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}