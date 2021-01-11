//Name: Lukas Bowden    
//Student Number: T00040951
//Due Date: 2020-13-02
//Description: Implementation file for the Add Customer form.
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
    public partial class frmAddCustomer : Form
    {
        //Creating null customer object.
        Customer customer = null;
        public frmAddCustomer()
        {
            InitializeComponent();
        }
        
        //Checks to see if all entries are valid and existing, then creates a new Customer object.
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (Validator.IsPresent(txtFirstName) && Validator.IsPresent(txtLastName) && Validator.IsPresent(txtEmail))
            {
                if (Validator.IsValidEmail(txtEmail))
                {
                    //Sets the customer object with the text field properties.
                    Customer tempCust = new Customer(txtFirstName.Text, txtLastName.Text, txtEmail.Text);
                    customer = tempCust;
                    this.Close();
                }
            }

        }

        //Creates an instance of this form and then returns a customer object
        //That is filled with user-entered data.
        public Customer GetNewCustomer() 
        {
            frmAddCustomer newForm = new frmAddCustomer();
            if (newForm.ShowDialog(this) == DialogResult.OK) 
            {
                customer = newForm.customer;
            }

            return newForm.customer;
        }

        //Closes the form.
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //Accidentally created a second save button click, cant delete without errors.
        private void btnSave_Click_1(object sender, EventArgs e)
        {

        }
    }
}