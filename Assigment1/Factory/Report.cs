using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assigment1.Factory
{
    public class Report
    {
        public string id { get; private set; }
        public string name { get; private set; }
        public string description { get; private set; }
        public string d { get; private set; }
        public string employee { get; private set; }

        internal Report(string id, string name, string description, string d, string employee)
        {
            // TODO: Complete member initialization
            this.id = id;
            this.name = name;
            this.description = description;
            this.d = d;
            this.employee = employee;
        }
    }
}
