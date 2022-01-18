using AutoMapper;
using WebCourseRepo.Dtos;
using WebCourseRepo.Models;

namespace WebCourseRepo.Profiles
{
    public class CourseProfile : Profile
    {
        public CourseProfile()
        {
            //source -> Target
            CreateMap<Course, CourseReadDto>();
            CreateMap<CourseDto, Course>();
            CreateMap<CourseUpdateDto, Course>();
            CreateMap<Course, CourseUpdateDto>();

        }
    }
}
