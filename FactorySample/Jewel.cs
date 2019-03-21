using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactorySample
{
    class Jewel : Item
    {
        private String name;
        private int price;
        private String descrip;

        public Jewel()
        {
            this.name = "Diamond";
            this.price = 9999;
            this.descrip = "Rare jewel, could be sold for so much money";
        }

        public void Description()
        {
            Console.WriteLine("-------------------------------------");
            Console.WriteLine("Item: {0}", this.name);
            Console.WriteLine("Price: {0}", this.price);
            Console.WriteLine("Description: {0}", this.descrip);
            Console.WriteLine("-------------------------------------");
        }
    }
}
