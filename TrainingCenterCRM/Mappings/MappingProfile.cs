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
            CreateMap<GroupDTO, Group>().ReverseMap();
            
            CreateMap<GroupDTO, GroupModel>().ReverseMap();

            CreateMap<StudentDTO, Student>().ForMember(destination => destination.Group, opts => opts.MapFrom(source => source.Group))
                                            .ReverseMap();

            CreateMap<StudentDTO, StudentModel>().ReverseMap();

            CreateMap<TeacherDTO, Teacher>().ReverseMap();
            CreateMap<TeacherDTO, TeacherModel>().ReverseMap();
        }
    }
}
