using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reciepe_Book
{
    class Ingredients
    {
        private string Name, Size;
        private int Amount;

        public Ingredients(string name, int amount, string size)
        {
            Name = name;
            Size = size;
            Amount = amount;
        }

        public string getName { get { return Name; } }
        public int getAmount { get { return Amount; } }
        public string getSize { get { return Size; } }
    }
}
