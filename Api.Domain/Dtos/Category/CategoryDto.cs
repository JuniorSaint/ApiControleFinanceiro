using System;
namespace Api.Domain.Dtos.Category
{
    public class CategoryDto
    {
        public Guid Id { get; set; }
        public string Category { get; set; }
        public string Description { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}
