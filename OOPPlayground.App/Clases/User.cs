using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
namespace OOPPlayground.app.Clases
{
    public class User
    {
        private string _firstName;

     

        protected string FirstName
        {
            get {
                return this._firstName;
            }
            set { 
                this._firstName = value;
            }
        }
      

        protected string LastName { get; set; }
        [JsonProperty("fullName")]

        public string FullName { get { return LastName + " " + FirstName; } }
        public User(string firstName,string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }

       public virtual string GetFullName()
        {
            return FirstName + " " + LastName;
        }

        public string GetUserSerilized()
        {
            return JsonConvert.SerializeObject(this);
        }
    }
}
