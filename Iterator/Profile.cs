using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterator
{
    internal class Profile
    {
        private string _name;
        private string _email;

        public Profile(string name, string email )
        {
            this._name = name;
            this._email = email;
        }

        public string getEmail()
        {
            return this._email;
        }

        public string getName()
        {
            return this._name;
        }
    }
}
