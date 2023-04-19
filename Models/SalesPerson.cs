using System;

namespace profisee_project.Models
{
    public class SalesPerson
    {
        public int salesPersonId {get; set;}
        public string FirstName {get;set;}
        public string LastName {get;set;}
        public string Address {get;set;}
        public string PhoneNumber {get;set;}
        public DateTime StartDate {get;set;}
        public DateTime TerminationDate {get;set;}
        public int managerId {get; set;}
    }
}