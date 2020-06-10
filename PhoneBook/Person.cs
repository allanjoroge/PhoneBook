using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneBook
{
    class Person
    {

        public string firstname;
        public string lastname;
        public string phonenumber;
        public string email;
        //Created an instance of class Address enabling access its variables via Person class
        public Address addy = new Address();
        public Person()
        {
        }
        //Created a constructor to initialize all vaiables of each new contact created
        public Person(string firstname, string lastname, string phonenumber, string email, string streetaddress, string city, string zipcode, string state)
        {
            this.firstname = firstname;
            this.lastname = lastname;
            this.phonenumber = phonenumber;
            this.email = email;
            addy.streetaddress = streetaddress;
            addy.city = city;
            addy.zipcode = zipcode;
            addy.state = state;
        }
    }
}
