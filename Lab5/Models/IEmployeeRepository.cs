using System.Collections.Generic;
using System.ServiceModel;

namespace Models
{
    public interface IEmployeeRepository
    {
        void Create(Employee obj);

        void Remove(Employee obj);

        string GetObjects();
        void Update(Employee obj);
    }
}
