﻿using AddressBok;
using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AddressBook;

Console.WriteLine("Welcome to Address Book Program in Address Book Main class on Master Branch");
Console.WriteLine("Enter the details to create a contact");
Address obj = new Address();
obj.create();
obj.display();
