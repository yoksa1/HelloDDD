using AutoMapper;
using Hello.Application.ViewModels;
using Hello.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Hello.Application.AutoMapper
{
    public class ViewModelToDomainMappingProfile : Profile
    {
        public ViewModelToDomainMappingProfile()
        {
            CreateMap<StudentViewModel, Student>();
        }
    }
}
