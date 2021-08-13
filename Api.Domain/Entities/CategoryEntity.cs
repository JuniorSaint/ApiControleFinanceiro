using System;

namespace Api.Domain.Entities
{
    public class CategoryEntity : BaseEntity
    {   
        public string Category { get; set; }
        public string Description { get; set; }       
    }
}
