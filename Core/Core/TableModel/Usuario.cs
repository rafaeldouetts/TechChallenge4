﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.TableModel
{
    [Table("usuario")]
    public class Usuario
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("id")]
        public int Id { get; set; }

        [Column("userId")]
        public Guid IdUsuario { get; set; }

        [Required]
        [Column("nome")]
        public string Nome { get; set; }

        [Column("email")]
        [EmailAddress]
        public string Email { get; set; }
    }
}
