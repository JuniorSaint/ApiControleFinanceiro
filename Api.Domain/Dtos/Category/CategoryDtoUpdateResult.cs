using System;
namespace Api.Domain.Dtos.Category
{
    public class CategoryDtoUpdateResult
    {
        public Guid Id { get; set; }
        public string Category { get; set; }
        public string Description { get; set; }
        public DateTime UpdatedAt { get; set; }       
    }
}
