using Microsoft.EntityFrameworkCore;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using WebApplication1;

namespace WcfServer
{
    public class Repository : IEmployeeRepository
    {
        private string _connectionString;
        private DbContextOptions<LvivFilialDBContext> dbOptions;

        public Repository()
        {
            _connectionString = "Server = localhost\\SQLExpress; Database = LvivFilialDB; Trusted_Connection = True;";
            dbOptions = new DbContextOptionsBuilder<LvivFilialDBContext>()
                .UseSqlServer(_connectionString).Options;
        }

        public void Create(Employee obj)
        {
            if (obj == null) throw new ArgumentNullException();

            using (var context = new LvivFilialDBContext(dbOptions))
            {
                context.Add(obj);
                context.SaveChanges();
            }
        }

        public void Remove(Employee obj)
        {
            if (obj == null) throw new ArgumentNullException();
            using (var context = new LvivFilialDBContext(dbOptions))
            {
                context.Remove(obj);
                context.SaveChanges();
            }
        }

        public IList<Employee> GetObjects()
        {
            using (var context = new LvivFilialDBContext(dbOptions))
            {
                return context.Employee.ToList();
            }
        }

        public void Update(Employee obj)
        {
            if (obj == null) throw new ArgumentNullException();
            using (var context = new LvivFilialDBContext(dbOptions))
            {
                context.Update(obj);
                context.SaveChanges();
            }

        }
    }
}
