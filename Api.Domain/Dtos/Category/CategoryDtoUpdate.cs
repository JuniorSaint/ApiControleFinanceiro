using System;
using System.ComponentModel.DataAnnotations;

namespace Api.Domain.Dtos.Category
{
    public class CategoryDtoUpdate
    {
        [Required(ErrorMessage = "Categoria é campo obrigatório")]
        public Guid Id { get; set; }

        [Required(ErrorMessage = "Categoria é campo obrigatório")]
        [MaxLength(90, ErrorMessage = "Número máximo de caracteres {1}")]
        public string Category { get; set; }

        public string Description { get; set; }
    }
}
