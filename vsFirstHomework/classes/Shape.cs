using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vsFirstHomework.classes
{
  
    public class Shape
    {
        [JsonProperty("Name")]
        protected string Name { get; set; }

        [JsonProperty("A")]
        protected int A { get; set; }
        [JsonProperty("B")]
        protected int B { get; set; }
        public Shape(string name, int a, int b= default(int))
        {
            Name = name;
            A = a;
            B = b;
            
        }

        public string GetName()
        {
           // return Name;
            return JsonConvert.SerializeObject(this.Name);
        }

        public string GetArea()
        {
            double PI = 3.14;
            if (this.Name == "Square" || this.Name == "Rectangle")
                return JsonConvert.SerializeObject((this.A + this.B).ToString());
            else
                if (this.Name == "Circle")
                return JsonConvert.SerializeObject((PI * this.A*this.A).ToString());
            else
                return JsonConvert.SerializeObject("Err of calculating area");
        }
        public string GetPerimeter()
        {
            double PI = 3.14;
            if (this.Name == "Square" || this.Name == "Rectangle")
                return JsonConvert.SerializeObject((2*(this.A + this.B)).ToString());
            else
                if (this.Name == "Circle")
                return JsonConvert.SerializeObject((2 * PI * this.A).ToString());
            else
                return JsonConvert.SerializeObject("Err of calculating perimeter");
        }
        public string GetShapeSerilized()
        {
            return JsonConvert.SerializeObject(this);
        }
    }
}
