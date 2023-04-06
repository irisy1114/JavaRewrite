using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JavaRewrite
{
    public abstract class Person
    {
        protected string Name { get; set; }
        public Person(string name)
        {
            Name = name;
        }
    }
}
