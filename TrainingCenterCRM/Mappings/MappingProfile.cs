using AutoMapper;
using TrainingCenterCRM.Core.Models;
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

            CreateMap<StudentRequest, StudentRequestModel>()
                .ForMember(sr => sr.Status, map => map.MapFrom(sr => sr.RequestStatus))
                .ReverseMap();

            CreateMap<File, FileModel>().ReverseMap();

            CreateMap<Material, MaterialModel>().ReverseMap();
        }
    }
}
