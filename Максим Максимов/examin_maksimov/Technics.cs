using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace examin_maksimov
{
    internal class Technics
    {
        private string _name;
        private int _price;
        private int _count;
        
        public string Name
        {
            get { return _name; }
        }

        public int Price
        {
            get { return _price; }
        }

        public int Count
        {
            get { return _count; }
        }

        public Technics(string name, int price, int count)
        {
            _name= name;
            _price= price;
            _count= count;
        }
    }
}
