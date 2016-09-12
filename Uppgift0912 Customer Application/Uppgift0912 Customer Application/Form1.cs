using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Uppgift0912_Customer_Application
{
    public partial class Form1 : Form
    {
        public class Customer
        {
            public string firstName { get; set; }
            public string lastName { get; set; }
            public int ID { get; set; }

            public string fullname()
            {
                return string.Format("{0} {1}", firstName, lastName);
            }
        }

        public Form1()
        {
            InitializeComponent();
            label4.Text = "Du har 0st kunder";
        }

        public List<Customer> customers = new List<Customer>();

        private void button1_Click(object sender, EventArgs e)
        {
            if (customers.Count >= 100)
            {
                MessageBox.Show("Du har för många kunder");
                return;
            }
            Customer c = new Customer();
            c.firstName = tbFirstName.Text;
            c.lastName = tbLastName.Text;
            c.ID = 100 + customers.Count;

            customers.Add(c);

            customerlist.Items.Clear();
            foreach (Customer name in customers)
            {
                customerlist.Items.Add(name.fullname());
            }
            label4.Text = string.Format("Du har {0}st kunder", customers.Count);
        }

        private void customerlist_SelectedIndexChanged(object sender, EventArgs e)
        {
            Customer c = customers[customerlist.SelectedIndex];
            MessageBox.Show(string.Format("ID: {0}\nFörnamn: {1}\nEfternamn: {2}\nAktiv: True", c.ID, c.firstName, c.lastName));
        }
    }
}
