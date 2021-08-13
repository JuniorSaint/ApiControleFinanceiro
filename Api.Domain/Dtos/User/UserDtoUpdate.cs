﻿using System;
using System.ComponentModel.DataAnnotations;

namespace Api.Domain.Dtos.User
{
    public class UserDtoUpdate
    {
        [Required(ErrorMessage = "Categoria é campo obrigatório")]
        public Guid Id { get; set; }

        [Required(ErrorMessage = "Nome do usuário é campo obrigatório")]
        [MaxLength(90, ErrorMessage = "Número máximo de caractes {1} ")]
        public string UserName { get; set; }

        [Required(ErrorMessage = "Eamil é campo obrigatório")]
        [EmailAddress(ErrorMessage = "email em formato inválido")]
        [MaxLength(100, ErrorMessage = "Número máximo de caractes {1} ")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Senha do usuário é campo obrigatório")]
        [Range(6, 8, ErrorMessage = "Quantidade de caracteres entre {1} e {2} ")]
        public string PassWord { get; set; }

        [Required(ErrorMessage = "Usuário ativo é campo obrigatório")]
        public bool Active { get; set; }

        [Required(ErrorMessage = "Tipo de usuário é campo obrigatório")]
        public string UserType { get; set; }
    }
}