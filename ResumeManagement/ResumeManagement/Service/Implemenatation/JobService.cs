using ResumeManagement.Core.Context;
using ResumeManagement.Service.Interface;

namespace ResumeManagement.Service.Implemenatation
{
    public class JobService:IJobService
    {
        private readonly ApplicationDbContext context;

        public JobService(ApplicationDbContext context)
        {
            this.context = context;
        }
    }
}
