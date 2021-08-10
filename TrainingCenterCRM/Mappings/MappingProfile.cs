using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TrainingCenterCRM.BLL.Models;
using TrainingCenterCRM.Models;

namespace TrainingCenterCRM.Mappings
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Group, GroupModel>().ReverseMap();

            CreateMap<Student, StudentModel>().ReverseMap();

            CreateMap<Teacher, TeacherModel>().ReverseMap();

            CreateMap<Course, CourseModel>().ReverseMap();

            CreateMap<Topic, TopicModel>().ReverseMap();
        }
    }
}
