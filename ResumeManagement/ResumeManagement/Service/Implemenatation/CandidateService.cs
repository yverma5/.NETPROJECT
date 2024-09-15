using ResumeManagement.Core.Context;
using ResumeManagement.Service.Interface;

namespace ResumeManagement.Service.Implemenatation
{
    public class CandidateService:ICandidateService
    {
        private readonly ApplicationDbContext context;

        public CandidateService(ApplicationDbContext context)
        {
            this.context = context;
        }
    }
}
