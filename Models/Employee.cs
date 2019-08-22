using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
namespace webapp.Models{
    public class Employee{
        public int Id {get; set;}

        public string Name {get; set;}
        public string Department{get; set;}
        public string Mail {get; set;}
        public int Age {get; set;}
        public string Address {get; set;}

        public Employee(){}
    }
}
