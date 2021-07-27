using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TrainingCenterCRM.BLL.DTO;
using TrainingCenterCRM.DAL.Enttities;
using TrainingCenterCRM.Models;

namespace TrainingCenterCRM.Mappings
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<GroupDTO, Group>();
            CreateMap<Group, GroupDTO>();

            CreateMap<GroupDTO, GroupModel>();
            CreateMap<GroupModel, GroupDTO>();

            CreateMap<StudentDTO, Student>().ForMember(destination => destination.Group, opts => opts.MapFrom(source => source.Group));
            CreateMap<Student, StudentDTO>().ForMember(destination => destination.Group, opts => opts.MapFrom(source => source.Group));

            CreateMap<StudentDTO, StudentModel>();
            CreateMap<StudentModel, StudentDTO>();
        }
    }
}
