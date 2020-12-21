using Models;
using System;
using System.Linq;
using WcfServer;
using WebApplication1;

namespace RepositoryTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            var rep = new Repository();
            rep.GetTables().ForEach(i => Console.WriteLine(i));

            var o = rep.GetObjects("Invoice");
            var em = o.First() as Employee;
            Console.WriteLine(em.FirstName);


            em.FirstName = em.FirstName + " 545";
            rep.Update(em);
        }
    }
}
