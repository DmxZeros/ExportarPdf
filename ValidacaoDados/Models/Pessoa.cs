using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc;
using ValidacaoDados.Validacao;

namespace ValidacaoDados.Models
{
    public class Pessoa
    {
        public int PessoaID { get; set; }

        [Required(ErrorMessage = "Campo obrigatório")]
        [StringLength(20, ErrorMessage = "Máximo 20 caracteres")]
        [Remote("UsuarioExisteAsync", "Pessoas")] 
        public string Nome { get; set; }

        //[Required(ErrorMessage = "Campo obrigatório")]
        //[Range(1, 120, ErrorMessage = "Idade inválida ! Digite um valor válido")]
        [Adulto] //validacao personalizada
        public int Idade { get; set; }

        [Required(ErrorMessage = "Campo obrigatório")]
        [DataType(DataType.Date)]
        public DateTime Nascimento { get; set; }

        [Required(ErrorMessage = "Campo obrigatório")]
        [DataType(DataType.EmailAddress)]
        [StringLength(50)]
        public string Email { get; set; }

        [Required(ErrorMessage = "Campo obrigatório")]
        [DataType(DataType.EmailAddress)]
        [StringLength(50)]
        [Compare("Email")]
        public string ConfirmaEmail { get; set; }
    }
}
