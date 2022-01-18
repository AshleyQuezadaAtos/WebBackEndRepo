using AutoMapper;
using WebCourseRepo.Dtos;
using WebCourseRepo.Models;

namespace WebCourseRepo.Mappers
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<Course, CourseDto>();
            CreateMap<Status, StatusDto>();
        }
    }
}