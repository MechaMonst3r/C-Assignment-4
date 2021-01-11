//Name: Lukas Bowden    
//Student Number: T00040951
//Due Date: 2020-13-02
//Description: Implementation file for the Customer class.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerMaintenance
{
    public class Customer
    {   
        //Setting up variables
        public string FirstName, LastName, Email;

        //Default Constructor.
        public Customer()
        {
            FirstName = "";
            LastName = "";
            Email = "";
        }

        //Paramaterized Constructor
        public Customer(string newFirstName, string newLastName, string newEmail)
        {
            FirstName = newFirstName;
            LastName = newLastName;
            Email = newEmail;
        }

        //Mutators (getters and setters)
        public string getFirstName()
        {
            return FirstName;
        }

        public string getLastName() 
        {
            return LastName;
        }

        public string getEmail() 
        {
            return Email;
        }

        public void setFirstName(string newFirstName) 
        {
            FirstName = newFirstName;
        }

        public void setLastName(string newLastName) 
        {
            LastName = newLastName;
        }

        public void setEmail(string newEmail) 
        {
            Email = newEmail;
        }

        //Concatinates all fields into a single string then returns it.
        public string getDisplayText() 
        {
          return FirstName.ToString() + " " + LastName.ToString() + ", " + Email.ToString();  
        }
    }
}
