using AutoMapper;
using AutoMapper.QueryableExtensions;
using Hello.Application.Services;
using Hello.Application.ViewModels;
using Hello.Domain.Entities;
using Hello.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace Hello.Application.Implements
{
    public class StudentAppService : IStudentAppService
    {
        //注意这里是要IoC依赖注入的，还没有实现
        private readonly IStudentRepository _StudentRepository;
        //用来进行DTO
        private readonly IMapper _mapper;

        public StudentAppService(
            IStudentRepository StudentRepository,
            IMapper mapper
            )
        {
            _StudentRepository = StudentRepository;
            _mapper = mapper;
        }

        public IEnumerable<StudentViewModel> GetAll()
        {
            return (_StudentRepository.GetAll()).ProjectTo<StudentViewModel>(_mapper.ConfigurationProvider);
        }

        public StudentViewModel GetById(Guid id)
        {
            return _mapper.Map<StudentViewModel>(_StudentRepository.GetById(id));
        }

        public void Register(StudentViewModel StudentViewModel)
        {
            //判断是否为空等等 还没有实现

            _StudentRepository.Add(_mapper.Map<Student>(StudentViewModel));
        }

        public void Update(StudentViewModel StudentViewModel)
        {
            _StudentRepository.Update(_mapper.Map<Student>(StudentViewModel));

        }

        public void Remove(Guid id)
        {
            _StudentRepository.Remove(id);

        }

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }
    }
}