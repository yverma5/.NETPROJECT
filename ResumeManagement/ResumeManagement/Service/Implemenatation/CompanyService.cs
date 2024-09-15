using AutoMapper;
using ResumeManagement.Core.Context;
using ResumeManagement.Core.Dtos;
using ResumeManagement.Core.Entities;
using ResumeManagement.Service.Interface;

namespace ResumeManagement.Service.Implemenatation
{
    public class CompanyService : ICompanyService
    {
        private readonly ApplicationDbContext context;
        private readonly IMapper mapper;

        public CompanyService(ApplicationDbContext context,IMapper mapper)
        {
            this.context = context;
            this.mapper = mapper;
        }

        public async Task<bool> CreateCompany(CreateCompanyDto dto)
        {
            try
            {
                Company company = mapper.Map<Company>(dto);
                await context.AddAsync(company);
                await context.SaveChangesAsync();
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }
    }
}
