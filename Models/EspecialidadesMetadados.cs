﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CadeMeuMedico.Models
{
    [MetadataType(typeof(EspecialidadesMetadados))]
    public partial class Especialidades
    {

    }

    public class EspecialidadesMetadados
    {
        [Required(ErrorMessage="O Nome deve ser preenchido")]
        [StringLength(80, ErrorMessage = "O Nome deve possuir no máximo 80 caracteres")]
        public string Nome { get; set; }
    }
}