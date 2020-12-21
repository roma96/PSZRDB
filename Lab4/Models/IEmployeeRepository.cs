using System.Collections.Generic;
using System.ServiceModel;

namespace Models
{
    [ServiceContract]
    public interface IEmployeeRepository
    {
        [OperationContract]
        void Create(Employee obj);

        [OperationContract]
        void Remove(Employee obj);

        [OperationContract]
        IList<Employee> GetObjects();

        [OperationContract]
        void Update(Employee obj);
    }
}
