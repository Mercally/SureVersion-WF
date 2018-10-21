using System;

namespace SureVersion.Entities
{
    public class Proyect
    {
        public Proyect() { }

        public Proyect(string pId, string pName, string pCustomer, string pAttendant)
        {
            Id = string.IsNullOrEmpty(pId) ? null : new Guid(pId).ToString();
            Name = pName;
            Customer = pCustomer;
            TechnicalLeader = pAttendant;
        }

        public string Id { get; set; }
        public string Name { get; set; }
        public string Customer { get; set; }
        public string TechnicalLeader { get; set; }
    }
}
