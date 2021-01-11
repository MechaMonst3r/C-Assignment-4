//Name: Lukas Bowden    
//Student Number: T00040951
//Due Date: 2020-13-02
//Description: Implementaion file for the customer maintenance form
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CustomerMaintenance
{
    public partial class frmCustomers : Form
    {
        //Customer list that is equal to null.
        List<Customer> customers = null;
        public frmCustomers()
        {
            InitializeComponent();
        }

        //Opens up the Add Customer Form, grabs input, and returns input based on the form.
        //Updates the listbox with the new customer, saves it to the database, then refreshes the
        //List box.
        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmAddCustomer newForm = new frmAddCustomer();

            Customer customer = newForm.GetNewCustomer();

            if(customer != null)
            {
                lstCustomers.Items.Add(customer.getDisplayText());
                customers.Add(customer);
                CustomerDB.SaveCustomers(customers);
                lstCustomers.Refresh();
            }
        }

        //Grabs the list of customers stored in the database and then
        //Adds it to the Listbox.
        private void btnLoad_Click(object sender, EventArgs e)
        {
            //Copies everything stored in the databse and stores in the current list.
            customers = CustomerDB.GetCustomers();

            //Iterates through the new list, adds each customer to the list box and formats it.
            for(int i = 0; i < customers.Count; i++)
            {
                lstCustomers.Items.Add(customers[i].getDisplayText());
            }
        }

        //Deletes a selected item off the list and listbox, updates the database, then
        //confirms the item has been successfully deleted.
        private void btnDelete_Click(object sender, EventArgs e)
        {
            customers.RemoveAt(lstCustomers.SelectedIndex);
            lstCustomers.Items.RemoveAt(lstCustomers.SelectedIndex);
            CustomerDB.SaveCustomers(customers);
            lstCustomers.Refresh();
            MessageBox.Show("Selected Customer has been Removed.");
        }

        //Exits the form.
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}