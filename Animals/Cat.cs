using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JavaRewrite.Animals
{
    public class Cat : Pet, ITalkable
    {
        private int MousesKilled { get; set; }

        public Cat(int mousesKilled, string name) : base(name)
        {
            MousesKilled = mousesKilled;
        }

        public void addMouse() { MousesKilled++; }

        
        public string talk()
        {
            return "Meow";
        }

        public string toString()
        {
            return "Cat: " + "name=" + Name + " mousesKilled=" + MousesKilled;
        }

        public string getName()
        {
            return Name;
        }
    }  
}
