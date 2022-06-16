using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Adressbook1
{

        class Adressbook1
        {


            public List<Contact> people = new List<Contact>();

        public void Addperson()
        {

            Contact person = new Contact();

            Console.WriteLine("Enter the First Name: ");
            person.Firstname = Console.ReadLine();
            foreach (var contact in people)
            {
                if (contact.Firstname.ToLower() == person.Firstname.ToLower())
                {
                    Console.WriteLine("Contact Alredy exists");
                    return;
                }
            }
            Console.WriteLine("Enter the Last Name: ");
            person.Lastname = Console.ReadLine();
            Console.WriteLine("Enter the city Name: ");
            person.PhoneNumber = Console.ReadLine();
            Console.WriteLine("Enter the PhoneNumber: ");
            person.city = Console.ReadLine();
            Console.WriteLine("Enter the Zip: ");
            person.Zip = Console.ReadLine();
            Console.WriteLine("Enter the Email: ");
            person.Email = Console.ReadLine();
            Console.WriteLine("Enter the Adress: ");
            person.Adress = Console.ReadLine();

            people.Add(person);
        }

        public void Display()
            {
                foreach (var contact in people)
                {
                    Console.WriteLine($"Firstname \t{contact.Firstname}\n Lastname \t{contact.Lastname}\n PhoneNumber \t{contact.PhoneNumber}\n city \t{contact.city}\n Zip \t{contact.Zip}\n Email \t{contact.Email}\n Adress \t{contact.Adress}\n ");

                }
                Console.ReadLine();
            }
           
        }
    
}

