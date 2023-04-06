using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JavaRewrite.Animals
{
    public class Dog : Pet, ITalkable
    {
        private Boolean Friendly { get; set; }

        public Dog(bool friendly, string name) : base(name)
        {
            Friendly = friendly;
        }

        public string toString()
        {
            return "Dog: " + "name=" + Name + " mousesKilled" + Friendly;
        }

        public string talk()
        {
            return "Bark";
        }

        public string getName()
        {
            return Name;
        }
    }
}
