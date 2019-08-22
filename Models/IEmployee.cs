using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using webapp.Models;

namespace webapp{
    public interface IEmployee{
        Employee GetEmployee(int id);
        IEnumerable<Employee> GetAll();
        Employee AddData();
        Employee Add(Employee emp);
        Employee Update(Employee emp);
        Employee Delete(int id);
    }
}