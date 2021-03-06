// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace CadastroPessoa.DATA.Models
{
    [Table("TELEFONE")]
    public partial class Telefone
    {
        public Telefone()
        {
            PessoaTelefone = new HashSet<PessoaTelefone>();
        }

        [Key]
        [Column("ID_TELEFONE")]
        public int IdTelefone { get; set; }
        [Column("NUMERO_TELEFONE")]
        public int NumeroTelefone { get; set; }
        [Column("DDD")]
        public int Ddd { get; set; }
        [Column("TIPO")]
        public int Tipo { get; set; }

        [ForeignKey(nameof(Tipo))]
        [InverseProperty(nameof(TelefoneTipo.Telefone))]
        public virtual TelefoneTipo TipoNavigation { get; set; }
        [InverseProperty("IdTelefoneFkNavigation")]
        public virtual ICollection<PessoaTelefone> PessoaTelefone { get; set; }
    }
}