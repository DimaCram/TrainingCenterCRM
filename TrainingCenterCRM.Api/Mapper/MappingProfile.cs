using AutoMapper;
using TrainingCenterCRM.Api.Dto;
using TrainingCenterCRM.Core.Filters;
using TrainingCenterCRM.Core.Models;

namespace TrainingCenterCRM.WebAngular.Mapper
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Student, StudentDto>().ReverseMap();

            CreateMap<Course, CourseDto>().ReverseMap();

            CreateMap<Topic, TopicDto>().ReverseMap();

            CreateMap<StudentRequest, StudentRequestDto>()
                .ForMember(sr => sr.Status, map => map.MapFrom(sr => sr.RequestStatus))
                .ReverseMap();

            CreateMap<Teacher, TeacherDto>().ReverseMap();

            CreateMap<Group, GroupDto>()
                .ForMember(sr => sr.Status, map => map.MapFrom(sr => sr.GroupStatus))
                .ReverseMap();

            CreateMap<File, FileDto>().ReverseMap();

            CreateMap<Material, MaterialDto>().ReverseMap();

            CreateMap<PaginationFilter, PaginationDto>().ReverseMap();
        }
    }   
}
