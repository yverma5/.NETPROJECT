using AutoMapper;
using ResumeManagement.Core.Dtos;
using ResumeManagement.Core.Entities;

namespace ResumeManagement.Core.AutoMapper
{
    public class AutoMapperConfigProfile:Profile
    {
        public AutoMapperConfigProfile()
        {
            //COMPANY
            CreateMap<CreateCompanyDto, Company>();
        }
    }
}
