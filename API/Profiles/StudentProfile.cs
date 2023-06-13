using API.Entities;
using API.Models.DTO;
using AutoMapper;

namespace API.Profiles
{
    public class StudentProfile : Profile
    {
        public StudentProfile()
        {
            CreateMap<Student, StudentDetailDto>();
        }
    }
}
