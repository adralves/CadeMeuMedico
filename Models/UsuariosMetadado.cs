using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CadeMeuMedico.Models
{
    [MetadataType(typeof(UsuariosMetadado))]
    public partial class Usuarios
    {

    }

    public class UsuariosMetadado
    {
        [Required(ErrorMessage="Obrigatorio Informar o Nome")]
        [StringLength(100,ErrorMessage="O Nome deve ter no máximo 100 caracteres")]
        public string Nome { get; set; }

        [Required(ErrorMessage="O login deve ser informado")]
        [StringLength(20,ErrorMessage="O Login deve ter no máximo 20 caracteres")]
        public string Login { get; set; }
        
        [Required(ErrorMessage="A senha deve ser informada")]
        [StringLength(20,ErrorMessage="A Senha deve ter no máximo 20 caracteres")]
        public string Senha { get; set; }
        
        [Required(ErrorMessage="O Email deve ser informado")]
        [StringLength(100,ErrorMessage="O email deve ter no máximo 100 caracteres")]
        public string Email { get; set; }
    }
}