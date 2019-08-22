using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace webapp.Models{
    public class EFEmployee : IEmployee
    {
        private readonly AppDbContext context;
        public EFEmployee(AppDbContext context){
            this.context = context;

        }
        public Employee AddData()
        {
            
            Employee employee = new Employee(){
                Id = 1,
                Name = "Omar",
                Address = "Ain-Shams",
                Age = 22,
                Mail = "Omar.Diaaeldin@nagwa.com"
            };
            //context.Employees.Add(employee);
            //context.Database.OpenConnection();
            //context.Database.ExecuteSqlCommand("SET IDENTITY_INSERT dbo.Employees ON");
            context.SaveChanges();
            //context.Database.ExecuteSqlCommand("SET IDENTITY_INSERT dbo.Employees OFF");
            return employee;
        }
        public Employee Add(Employee employee){
            context.Employees.Add(employee);
            context.Database.OpenConnection();
            context.Database.ExecuteSqlCommand("SET IDENTITY_INSERT dbo.Employees ON");
            context.SaveChanges();
            context.Database.ExecuteSqlCommand("SET IDENTITY_INSERT dbo.Employees OFF");
            return employee;
        }

        public Employee Delete(int id)
        {
            Employee employee = context.Employees.Find(id);
            if(employee != null){
                context.Employees.Remove(employee);
                context.SaveChanges();
            }
            return employee;
        }

        public IEnumerable<Employee> GetAll()
        {
            return context.Employees;
        }

        public Employee GetEmployee(int id)
        {
            Employee employee = context.Employees.Find(id);
            return employee;
        }

        public Employee Update(Employee emp)
        {
            var employee = context.Employees.Attach(emp);
            employee.State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            context.SaveChanges();
            return emp;
        }

        public Employee Add()
        {
            throw new NotImplementedException();
        }
    }
}