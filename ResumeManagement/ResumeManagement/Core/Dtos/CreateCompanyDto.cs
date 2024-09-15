using ResumeManagement.Core.Enums;

namespace ResumeManagement.Core.Dtos
{
    public class CreateCompanyDto
    {
        public string Name { get; set; }
        public CompanySize Size { get; set; }

    }
}
