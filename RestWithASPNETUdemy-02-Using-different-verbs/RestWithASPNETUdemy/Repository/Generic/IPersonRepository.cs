using RestWithASPNETUdemy.Model;
using System.Collections.Generic;

namespace RestWithASPNETUdemy.Repository.Generic
{
    public interface IPersonRepository : IGenericRepository<Person>
    {
        List<Person> FindByName(string firstName, string lastName);
    }
}
