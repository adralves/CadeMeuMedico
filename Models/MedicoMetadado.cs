using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CadeMeuMedico.Models
{
    [MetadataType(typeof(MedicoMetadado))]
    public partial class Medico
    {

    }

    public class MedicoMetadado
    {
        [Required(ErrorMessage = "Obrigatorio Informar o CRM")]
        [StringLength(30,ErrorMessage = "O CRM deve possuir no máximo 30 caracteres")]
        public string CRM { get; set; }

        [Required(ErrorMessage = "Obrigatório informar o Nome")]
        [StringLength(80,ErrorMessage = "O Nome deve possuir no máximo 80 caracteres")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Obrigatorio informar o endereço")]
        [StringLength(100,ErrorMessage = "O endereço deve possuir no máximo 100 caracteres")]
        public string Endereco { get; set; }

        [Required(ErrorMessage="Obrigatorio Informar o Bairro")]
        [StringLength(60,ErrorMessage="O bairro deve ter no máximo 60 caracteres")]
        public string Bairro { get; set; }

        [Required(ErrorMessage="O Email deve ser informado")]
        [StringLength(100,ErrorMessage="O Email deve ter no máximo 100 caracteres")]
        public string Email { get; set; }

        [Required(ErrorMessage="Obrigatorio informar se atende por convenio")]
        public bool AtendePorConvenio { get; set; }

        [Required(ErrorMessage="Obrigatorio informar se Tem Clinica")]
        public bool TemClinica { get; set; }

        [StringLength(80,ErrorMessage="O Website deve possuir no máximo 80 caracteres")]
        public string WebSiteBlog { get; set; }

        [Required(ErrorMessage="Obrigatorio informar a Cidade")]
        public int IDCidade { get; set; }

        [Required(ErrorMessage="Obrigatorio informar a especialidade")]
        public int IDEspecialidade { get; set; }

    }
}