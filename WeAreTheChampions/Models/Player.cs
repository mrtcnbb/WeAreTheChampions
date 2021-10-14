using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeAreTheChampions.Models
{
    [Table("Players")]
    public class Player
    {
        public int Id { get; set; }
        [Required, MaxLength(250)]
        public string PlayerName { get; set; }
        public int? TeamId { get; set; }
        public virtual Team Team { get; set; }
    }
}
