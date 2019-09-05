using Hello.Domain.Entities;
using Hello.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace Hello.Infrastructure.Data.Repositories
{
    public class CustomerRepository : Repository<Customer>, ICustomerRepository
    {
        public Customer GetByEmail(string email)
        {
            throw new System.NotImplementedException();
        }
    }
}
