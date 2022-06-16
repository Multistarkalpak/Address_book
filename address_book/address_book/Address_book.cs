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

