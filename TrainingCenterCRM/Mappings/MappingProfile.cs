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

            CreateMap<StudentDTO, Student>().ForMember(dest => dest.BirthDate, opt => opt.MapFrom((source, dest) => dest.BirthDate = new DateTime(DateTime.Now.Year - source.Age, 1, 1)));
            CreateMap<Student, StudentDTO>().ForMember(dest => dest.Age, opt => opt.MapFrom((source, dest) => dest.Age = DateTime.Now.Year - source.BirthDate.Year ));

            CreateMap<StudentDTO, StudentModel>().ReverseMap();

            CreateMap<TeacherDTO, Teacher>().ReverseMap();
            CreateMap<TeacherDTO, TeacherModel>().ReverseMap();
        }
    }
}
