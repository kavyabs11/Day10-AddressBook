﻿using Addressbok;
using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Addressbok;

Console.WriteLine("Welcome to Address Book Program in Address Book Main class on Master Branch");
Console.WriteLine("Enter your choice");
Console.WriteLine("Enter your choice");
Console.WriteLine("1 - for adding contacts");
Console.WriteLine("2 - for editing a contact");
Console.WriteLine("3 - for deleting a contact ");
Console.WriteLine("4 - for displaying the list stored in addressbook a contact ");
Console.WriteLine("5 - exiting the program ");
int choice = Convert.ToInt16(Console.ReadLine());
CHOICE.Choice(choice);