using Hello.Application.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace Hello.Application.Services
{
    public interface IStudentAppService : IDisposable
    {
        void Register(StudentViewModel customerViewModel);
        IEnumerable<StudentViewModel> GetAll();
        StudentViewModel GetById(Guid id);
        void Update(StudentViewModel customerViewModel);
        void Remove(Guid id);
    }
}
