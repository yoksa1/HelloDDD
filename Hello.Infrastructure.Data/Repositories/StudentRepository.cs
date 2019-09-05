using Hello.Domain.Entities;
using Hello.Domain.Repositories;
using Hello.Infrastructure.Data.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Hello.Infrastructure.Data.Repositories
{
    public class StudentRepository : Repository<Student>, IStudentRepository
    {
        public StudentRepository(StudyContext context) : base(context)
        {
        }

        public Customer GetByEmail(string email)
        {
            throw new System.NotImplementedException();
        }

    }
}
