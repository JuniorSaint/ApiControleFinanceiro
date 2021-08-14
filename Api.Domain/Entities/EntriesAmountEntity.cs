using System;
using System.ComponentModel.DataAnnotations;

namespace Api.Domain.Entities
{
    public class EntriesAmountEntity : BaseEntity
    {
        [Required(ErrorMessage = " Nome é campo obrigátorio")]
        [MaxLength(90, ErrorMessage = "Quantidade máxima de caracters {1}")]
        public string Name { get; set; }

        [Required(ErrorMessage = " Descrição é campo obrigátorio")]
        public string DescriptionValue { get; set; }

        [Required(ErrorMessage = " Tipo de entrada é campo obrigátorio")]
        public string TypeEntry { get; set; }

        [Required(ErrorMessage = " Valor é campo obrigátorio")]
        public double Amount { get; set; }

        [Required(ErrorMessage = " Data do lançamento é campo obrigátorio")]
        public DateTime DateLaunch { get; set; }

        [Required(ErrorMessage = " Categoria é campo obrigátorio")]
        public Guid CategoryId { get; set; }

        public CategoryEntity Category { get; set; }
    }
}
