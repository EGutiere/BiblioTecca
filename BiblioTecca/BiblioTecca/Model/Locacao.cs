using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BiblioTecca.Model
{
    [Table("Locacao")]
    class Locacao
    {
        [Key]
        public int IdLocacao { get; set; }
        public Pessoa Pessoa { get; set; }
        public Livro Livro { get; set; }
        public DateTime DataLocacao { get; set; }
        public bool Status { get; set; }
    }
}
