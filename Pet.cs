using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JavaRewrite
{
    public abstract class Pet
    {
        protected string Name { get; set; }
        public Pet(string name) { Name = name; }
    }
}
