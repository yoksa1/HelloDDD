using Hello.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Hello.Domain.Repositories
{
    public interface ICustomerRepository : IRepository<Customer>
    {
        Customer GetByEmail(string email);
    }
}
