using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CadeMeuMedico.Models
{
    [MetadataType(typeof(CidadesMetadados))]
    public partial class Cidade
    {

    }

    public class CidadesMetadados
    {
        [Required(ErrorMessage="Nome deve ser informado")]
        [StringLength(80,ErrorMessage="O Nome deve possuir no máximo 80 caracteres")]
        public string Nome { get; set; }
    }
}