using Addressbok;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Addressbook
{
    internal class NameBooks
    {
        Dictionary<string, addressBok> addressbook;

        public NameBooks()
        {
            addressbook = new Dictionary<string, addressBok>();
        }
        public void details(String name)
        {
            addressBok obj1 = new addressBok();
            addressbook[name] = obj1;
            CHOICE.Choice(1, obj1);
            //addressbook.Add(name,obj1);
        }
        public bool search(string find)
        {
            int flag = 0;

            foreach (var i in addressbook)                      //i represents the key part in the dictionary
            {
                //addressBook obj = new addressBook();
                if (i.Equals(find))
                {
                    CHOICE.Choice(1, i.Value);
                    flag++;
                    break;
                }
            }
            if (flag == 0)
            {
                return false;
            }
            return true;
        }
        public void addNames(String name)
        {

            addressbook[name].create();
            CHOICE.Choice(1, addressbook[name]);
        }

        public void printAll()
        {
            foreach (var i in addressbook)
            {
                Console.WriteLine("Addressbook name - " + i);
                i.Value.display();
            }
        }
    }
}