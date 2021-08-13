using System;
using System.ComponentModel.DataAnnotations;

namespace Api.Domain.Entities
{
    public class BaseEntity
    {
        [Key]
        public Guid Id { get; set; }
        public DateTime? UpdatedAt { get; set; }
        private DateTime? _creatdeAt;

        public DateTime? CreatedAt
        {

            get { return _creatdeAt; }

            set { _creatdeAt = (value == null ? DateTime.UtcNow : value); }
        }
    }
}
