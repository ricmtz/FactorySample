using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactorySample
{
    class Sword : Item
    {
        private String name;
        private int damage;
        private String descrip;

        public Sword(){
            this.name = "excalibur";
            this.damage = 999;
            this.descrip = "Sword that only the chosen one can handle.";
        }

        public void Description(){
            Console.WriteLine("-------------------------------------");
            Console.WriteLine("Item: {0}", this.name);
            Console.WriteLine("Damage: {0}", this.damage);
            Console.WriteLine("Description: {0}", this.descrip);
            Console.WriteLine("-------------------------------------");
        }
    }
}
