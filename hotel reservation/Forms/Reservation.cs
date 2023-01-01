using System;
using System.Windows.Forms;
namespace hotel_reservation.Forms
{
    public partial class Reservation : Form
    {
        internal DbConnector Db { get; }

        public Reservation()
        {
            InitializeComponent();
            Db = new DbConnector();
            
        }


        private void tabPage3_Click(object sender, EventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {


        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void tabPageAddReservation_Click(object sender, EventArgs e)
        {
           
        }
        
    

        private void button1_Click(object sender, EventArgs e)
        {
         
        }

        private void dataGridViewReservation_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void tabPageSearchReservation_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            dataGridViewReservation.Rows.Add(comboBox2.Text, comboBox2.Text, textBox1.Text, dateTimePicker4.Text, dateTimePicker3.Text, textBox2.Text);
        }
    }
}
