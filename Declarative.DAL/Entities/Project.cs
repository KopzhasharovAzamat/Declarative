﻿namespace Declarative.DAL.Entities
{
    public class Project
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int ProjectLeaderId { get; set;  } 
        public Employee ProjectLeader { get; set; }
        public int Priority { get; set; }
        public int Status { get; set; }
        public int CustomerCompanyId { get; set; }
        public Company CustomerCompany { get; set; }
        //public int PerformerCompanyId { get; set; }
        //public Company PerformerCompany { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
    }
}
