using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JavaRewrite
{
    public class Teacher : Person, ITalkable
    {
        private int Age { get; set; }

        public Teacher(int age, string name) : base(name) {  Age = age; }

        public string talk()
        {
            return "Don't forget to do the assigned reading!";
        }

        public string getName()
        {
            return Name;
        }
    }
}
