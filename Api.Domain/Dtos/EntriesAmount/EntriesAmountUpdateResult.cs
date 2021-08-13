using System;
using Api.Domain.Dtos.Category;

namespace Api.Domain.Dtos.EntriesAmount
{
    public class EntriesAmountUpdateResult
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string DescriptionValue { get; set; }
        public string TypeEntry { get; set; }
        public double Amount { get; set; }
        public DateTime DateLaunch { get; set; }
        public Guid CategoryId { get; set; }
        public CategoryDto category { get; set; }
        public DateTime UpdatedAt { get; set; }
    }
}
