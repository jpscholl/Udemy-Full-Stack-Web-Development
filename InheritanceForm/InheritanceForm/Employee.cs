using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceForm
{
    class Employee : Human
    {
        protected string Position { get; set; }
        public double Salary { get; set; }
        public void SetValues()
        {
            Name = "Jon";
            ID = 1;
            Gender = 'M';
            Age = 35;
        }
    }
}
