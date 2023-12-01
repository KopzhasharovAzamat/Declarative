using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Entities
{
    public class Employee
    {
        public int Id { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string email { get; set; }
        public string position { get; set; }
    }

    public class ProjectTask
    {
        public int Id { get; set; }
        public string name { get; set; }
        public string description { get; set; }
        public int author { get; set; }
        public int performer { get; set; }
        public int status { get; set; }
        public string comment { get; set; }
        public DateTime created { get; set; }
        public int priority { get; set; }
    }

    public class Project
    {
        public int Id { get; set; }
        public string name { get; set; }
        public string description { get; set; }
        public int leader { get; set; }
        public int priority { get; set; }
        public int status { get; set; }
        public string customerCompany { get; set; }
        public string performerCompany { get; set; }
        public DateTime startDate { get; set; }
        public DateTime endDate { get; set; }
    }
    public class ProjectLeader
    {
        public int Id { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string email { get; set; }
        public string position { get; set; }
        public int project { get; set; }
    }
    public class Company
    {
        public int Id { get; set; }
        public string name { get; set; }
        public string description { get; set; }
        public int employee { get; set; }
        public int project { get; set; }
    }
}
