using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FuncionariosWeb.Models
{
    public class Funcionario
    {
        public Funcionario(int funcionarioId, string nome, string email, Departamento? departamento)
        {
            FuncionarioId = funcionarioId;
            Nome = nome;
            Email = email;
            Departamento = departamento;
        }

        public Funcionario()
        {

        }
        public int FuncionarioId { get; set; }

        [Required, MaxLength(80, ErrorMessage = "Não pode exceder 80 caracteres.")]
        public string Nome { get; set; }

        [EmailAddress(ErrorMessage = "Enter a valid email")]
        [Required(ErrorMessage = "{0} Required")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        public Departamento? Departamento { get; set; }
    }
}
