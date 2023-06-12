using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P11_CSharp
{
    internal class Human
    {

        public string Name { get; set; } = "No name";

        public DateTime BirthDay { get; set; }


        private int id;

        public int ID
        {
            get { return id; }
            set { id = value; }
        }

    }
}
