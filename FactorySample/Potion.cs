using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactorySample
{
    class Potion: Item
    {
        private String name;
        private int healing;
        private String descrip;

        public Potion() {
            this.name = "Ultra potion";
            this.healing = 150;
            this.descrip = "Healing a big portion of health";
        }

        public void Description() {
            Console.WriteLine("-------------------------------------");
            Console.WriteLine("Item: {0}", this.name);
            Console.WriteLine("Healing: {0}", this.healing);
            Console.WriteLine("Description: {0}", this.descrip);
            Console.WriteLine("-------------------------------------");
        }
    }
}
