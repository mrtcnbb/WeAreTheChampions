using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeAreTheChampions.Models
{
    [Table("Teams")]
    public class Team
    {
        public Team()
        {
            Players = new HashSet<Player>();
            Colors = new HashSet<Color>();
            AwayMatches = new HashSet<Match>();
            HomeMatches = new HashSet<Match>();
            
        }

        public int Id { get; set; }
        [Required, MaxLength(250)]
        public string TeamName { get; set; }
        public virtual ICollection<Player> Players { get; set; }
        public virtual ICollection<Color> Colors { get; set; }
        public virtual ICollection<Match> AwayMatches { get; set; }
        public virtual ICollection<Match> HomeMatches { get; set; }

    }
}
