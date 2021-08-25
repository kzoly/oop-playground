using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vsFirstHomework.classes
{
  
    public class Shape
    {
        protected string Name { get; set; }
        public Shape(string name)
        {
            Name = name;
        }

        public string GetName()
        {
            return Name;
        }
    }
}
