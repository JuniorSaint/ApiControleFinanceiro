using System;
using System.ComponentModel.DataAnnotations;

namespace Api.Domain.Entities
{
    public class EntriesAmountEntity : BaseEntity
    {      
        public string Name { get; set; }       
        public string DescriptionValue { get; set; }        
        public string TypeEntry { get; set; }        
        public double Amount { get; set; }        
        public DateTime DateLaunch { get; set; }      
        public Guid  CategoryId { get; set; }
        public CategoryEntity Category { get; set; }
    }
}
