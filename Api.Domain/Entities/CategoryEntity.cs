using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Api.Domain.Entities
{
    public class CategoryEntity : BaseEntity
    {
        [Required(ErrorMessage = "Categoria é campo obrigatório")]
        [MaxLength(90, ErrorMessage = "Número máximo de caracteres {1}")]
        public string Category { get; set; }

        public string Description { get; set; }

        public IEnumerable<EntriesAmountEntity> EntriesAmount { get; set; }
    }
}
