using ResumeManagement.Core.Dtos;

namespace ResumeManagement.Service.Interface
{
    public interface ICompanyService
    {
        Task<bool> CreateCompany(CreateCompanyDto dto);
    }
}
