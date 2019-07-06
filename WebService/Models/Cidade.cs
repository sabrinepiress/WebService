using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebService.Models
{
    [Table("Cidades")]
    public class Cidade
    {
        [Key]
        public int CidadeId { get; set; }
        public int Id { get; set; }
        public string Name { get; set; }
        public string State { get; set; }
        public string Coutry { get; set; }

        public Condicao Data { get; set; }
    }
}
