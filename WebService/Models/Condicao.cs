using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebService.Models
{
    [Table("Condicoes")]
    public class Condicao
    {
        [Key]
        public int IdCondicao{ get; set; }
        public int temperature { get; set; }
        public string wind_direction { get; set; }
        public int wind_velocity { get; set; }
        public int humidity { get; set; }
        public string condition { get; set; }
        public int pressure { get; set; }
        public int icon { get; set; }
       /* public int? sensation { get; set; }
        public DateTime date { get; set; }*/
    }
}
