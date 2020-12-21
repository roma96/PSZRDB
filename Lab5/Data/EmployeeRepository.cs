using Microsoft.EntityFrameworkCore;
using Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using WebApplication1;

namespace WcfServer
{
    public class EmployeeRepository : MarshalByRefObject, IEmployeeRepository
    {
        private string _connectionString;
        private DbContextOptions<LvivFilialDBContext> dbOptions;

        public override object InitializeLifetimeService()
        {
            return null;
        }

        public EmployeeRepository()
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

        public string GetObjects()
        {
            using (var context = new LvivFilialDBContext(dbOptions))
            {
                return JsonConvert.SerializeObject(context.Employee.ToList());
                //return context.Employee.ToList();
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
