using ResumeManagement.Core.Enums;

namespace ResumeManagement.Core.Entities
{
    public class Company : BaseEntity
    {
        public string Name { get; set; }
        public CompanySize Size { get; set; }

        //Navigation Properties
        public ICollection<Job> Jobs { get; set; }
    }
}
