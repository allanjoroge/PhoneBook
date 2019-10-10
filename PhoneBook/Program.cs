using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneBook
{
    class Program
    {
        static void Main(string[] args)
        {
            Contact();
        }

        //LISTS
        public static List<Person> people = new List<Person>();
        public static List<Address> location = new List<Address>();
        //INSTANCES OF MY CLASSES
        public static Person someone = new Person();
        public static Address addy = new Address();

        public static void Contact()
        {
  
            string command = "";
            while (command != "exit")
            {

                Console.Write("COMMAND? ");
                command = Console.ReadLine();

                switch (command)
                {

                    case "ac":
                        Console.Write("First Name: ");
                        someone.firstname = Console.ReadLine();
                        Console.Write("Last Name: ");
                        someone.lastname = Console.ReadLine();
                        Console.Write("Phone Number: ");
                        someone.phonenumber = Console.ReadLine();
                        Console.Write("Email: ");
                        someone.email = Console.ReadLine();
                        Console.Write("Street Address: ");
                        addy.streetaddress = Console.ReadLine();
                        Console.Write("City: ");
                        addy.city = Console.ReadLine();
                        Console.Write("Zip Code: ");
                        addy.zipcode = Console.ReadLine();
                        Console.Write("State: ");
                        addy.state = Console.ReadLine();

                        people.Add(someone);
                        location.Add(addy);
                        break;

                    case "sbfn":
                        Console.Write("search by first name? ");
                        string fn = Console.ReadLine();
                        if (someone.firstname.Equals(fn))
                        {

                            foreach (Person info in people)
                            {
                                Console.WriteLine(info.firstname);
                                Console.WriteLine(info.lastname);
                                Console.WriteLine(info.phonenumber);
                                Console.WriteLine(info.email);

                                foreach (Address locat in location)
                                {
                                    Console.WriteLine(locat.streetaddress);
                                    Console.WriteLine(locat.city);
                                    Console.WriteLine(locat.zipcode);
                                    Console.WriteLine(locat.state);
                                }
                            }
                        }
                        break;

                    case "sbln":
                        Console.Write("search by last name? ");
                        string ln = Console.ReadLine();
                        if (someone.lastname.Equals(ln))
                        {

                            foreach (Person info in people)
                            {
                                Console.WriteLine(info.firstname);
                                Console.WriteLine(info.lastname);
                                Console.WriteLine(info.phonenumber);
                                Console.WriteLine(info.email);

                                foreach (Address locat in location)
                                {
                                    Console.WriteLine(locat.streetaddress);
                                    Console.WriteLine(locat.city);
                                    Console.WriteLine(locat.zipcode);
                                    Console.WriteLine(locat.state);
                                }
                            }
                        }
                        break;

                    case "sbly":
                        Console.Write("search by city? ");
                        string cty = Console.ReadLine();
                        if (addy.city.Equals(cty))
                        {

                            foreach (Person info in people)
                            {
                                Console.WriteLine(info.firstname);
                                Console.WriteLine(info.lastname);
                                Console.WriteLine(info.phonenumber);
                                Console.WriteLine(info.email);

                                foreach (Address locat in location)
                                {
                                    Console.WriteLine(locat.streetaddress);
                                    Console.WriteLine(locat.city);
                                    Console.WriteLine(locat.zipcode);
                                    Console.WriteLine(locat.state);
                                }
                            }
                        }
                        break;

                    case "print names":

                        Console.WriteLine(people);

                        break;

                    case "d":
                        Console.Write("which contact do you want to delete by fn? ");
                        string delete = Console.ReadLine();
                        if (someone.firstname.Equals(delete))
                        {
                            people.Remove(someone);
                            foreach (Person info in people)
                            {
                               
                                Console.WriteLine(info.firstname);
                                Console.WriteLine(info.lastname);
                                Console.WriteLine(info.phonenumber);
                                Console.WriteLine(info.email);

                                foreach (Address locat in location)
                                {
                                    Console.WriteLine(locat.streetaddress);
                                    Console.WriteLine(locat.city);
                                    Console.WriteLine(locat.zipcode);
                                    Console.WriteLine(locat.state);
                                }
                            }
                        }
                        break;

                    default:
                        Console.WriteLine("THAT'S NOT AN OPTION!!");
                        break;
                }
            }
            Console.ReadLine();
        }
    }
}
