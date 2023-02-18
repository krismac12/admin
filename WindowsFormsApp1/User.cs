using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class User
    {
        public int ID;
        public string name;
        public string key;

        public User(int ID, string name, string key)
        {
            this.ID = ID;
            this.name = name;
            this.key = key;
        }
    }
}
