using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactorySample
{
    class Armor : Item
    {
        private String name;
        private int def;
        private String descrip;

        public Armor()
        {
            this.name = "Daedric";
            this.def = 100;
            this.descrip = "Legendary armor from a special mineral";
        }

        public void Description()
        {
            Console.WriteLine("-------------------------------------");
            Console.WriteLine("Item: {0}", this.name);
            Console.WriteLine("Def: {0}", this.def);
            Console.WriteLine("Description: {0}", this.descrip);
            Console.WriteLine("-------------------------------------");
        }
    }
}
