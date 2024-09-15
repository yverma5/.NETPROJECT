﻿namespace ResumeManagement.Core.Entities
{
    public class Candidate:BaseEntity
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string CoverLetter { get; set; }
        public string ResumeUrl { get; set; }
        public long JobId { get; set; }
        //Navigvation Properties
        public Job Job { get; set; }

    }
}
