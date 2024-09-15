using ResumeManagement.Core.Enums;

namespace ResumeManagement.Core.Entities
{
    public class Job : BaseEntity
    {
        public string Title { get; set; }
        public JobLevel Level { get; set; }
        public long CompanyId { get; set; }
        //Navigation
        public Company Company { get; set; }
        public ICollection<Candidate> Candidates { get; set; }
    }
}
