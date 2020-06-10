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

            List<Person> people = new List<Person>();
            int command = 0;

            do
            {
                Console.Write("Choose a Command: \n1.Add contact \n2.Search contact by first name\n3.Search contact by last name\n4.Search contact by City\n5.Delete a contact\n6.Sort by first name\n7.Exit\n");
                command = Convert.ToInt32(Console.ReadLine());

                switch (command)
                {
                    case 1:
                        Person someone = new Person();

                        Console.Write("First Name: ");
                        someone.firstname = Console.ReadLine();
                        Console.Write("Last Name: ");
                        someone.lastname = Console.ReadLine();
                        Console.Write("Phone Number: ");
                        someone.phonenumber = Console.ReadLine();
                        Console.Write("Email: ");
                        someone.email = Console.ReadLine();
                        Console.Write("Street Address: ");
                        someone.addy.streetaddress = Console.ReadLine();
                        Console.Write("City: ");
                        someone.addy.city = Console.ReadLine();
                        Console.Write("Zip Code: ");
                        someone.addy.zipcode = Console.ReadLine();
                        Console.Write("State: ");
                        someone.addy.state = Console.ReadLine();

                        people.Add(someone);
                        break;

                    case 2:
                        Console.Write("First Name? ");
                        string fn = Console.ReadLine();
                        foreach (Person inf in people)
                        {
                            if (fn.Equals(inf.firstname))
                            {
                                Console.WriteLine(inf.firstname + "\n" + inf.lastname + "\n" + inf.phonenumber + "\n" + inf.email + "\n" + inf.addy.streetaddress + "\n" + inf.addy.city + "\n" + inf.addy.zipcode + "\n" + inf.addy.state);
                            }
                        }
                        break;

                    case 3:
                        Console.Write("Last Name? ");
                        string ln = Console.ReadLine();
                        foreach (Person inf in people)
                        {
                            if (ln.Equals(inf.lastname))
                            {
                                Console.WriteLine(inf.firstname + "\n" + inf.lastname + "\n" + inf.phonenumber + "\n" + inf.email + "\n" + inf.addy.streetaddress + "\n" + inf.addy.city + "\n" + inf.addy.zipcode + "\n" + inf.addy.state);
                            }
                        }
                        break;

                    case 4:
                        Console.Write("City? ");
                        string cty = Console.ReadLine();
                        foreach (Person inf in people)
                        {
                            if (cty.Equals(inf.addy.city))
                            {
                                Console.WriteLine(inf.firstname + "\n" + inf.lastname + "\n" + inf.phonenumber + "\n" + inf.email + "\n" + inf.addy.streetaddress + "\n" + inf.addy.city + "\n" + inf.addy.zipcode + "\n" + inf.addy.state);
                            }
                        }
                        break;

                    case 5:
                        Console.Write("First name? ");
                        string delete = Console.ReadLine();
                        foreach (Person inf in people)
                        {
                            if (delete.Equals(inf.firstname))
                            {
                                Console.WriteLine(inf.firstname + "\n" + inf.addy.streetaddress);
                                people.Remove(inf);
                                break; //break the loop, otherwise the program will crash
                            }
                        }
                        break;

                    case 6:
                        List<Person> SortedContacts = people.OrderBy(a => a.firstname).ToList();
                        foreach (Person Sort in SortedContacts)
                        {
                            Console.WriteLine(Sort.firstname);
                        }
                        break;

                    case 7:
                        Console.WriteLine("EXIT");
                        break;

                    default:
                        Console.WriteLine("INVALID COMMAND!!");
                        break;
                }
            } while (command != 7);
        }
    }
}
