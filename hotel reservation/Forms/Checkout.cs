using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace hotel_reservation.Forms
{
    public partial class Checkout : Form
    {
        double itax, isubtotal, iTotal;
        public Checkout()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            tax.BackColor = Color.White;
            Price.Text = "";
            days.Text = "";
            subtotal.Text = "";
            tax.Text = "";
            total.Text = "";
        }

        private void days_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Tax cost = new Tax();
            cost.item1 = double.Parse(Price.Text);
            cost.item2 = double.Parse(days.Text);
            isubtotal = cost.GetAmount();
            itax = cost.CFindTax(isubtotal);
            iTotal = isubtotal + itax;
            tax.Text = String.Format("{0:c}", itax);
            subtotal.Text= String.Format("{0:c}", isubtotal);
            total.Text= String.Format("{0:c}", iTotal);
            tax.BackColor = Color.Azure;
        }
    }
}
