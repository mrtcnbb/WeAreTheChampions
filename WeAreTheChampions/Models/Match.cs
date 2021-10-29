using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeAreTheChampions.Models
{
    [Table("Matches")]
    public class Match
    {
        public int Id { get; set; }
        public DateTime? MatchTime { get; set; }
        [Required]
        public int HomeTeamId { get; set; }
        public virtual Team HomeTeam { get; set; }
        [Required]
        public int AwayTeamId { get; set; }
        public virtual Team AwayTeam { get; set; }
        public int? Score1 { get; set; }
        public int? Score2 { get; set; }
        public Result? Result { get; set; }

        public string MatchDateText => ((DateTime)this.MatchTime).ToShortDateString();
        public string MatchHourText => ((DateTime)this.MatchTime).ToString("HH:mm");
        public string Scores => CheckScores();
        private string CheckScores()
        {
            if (Score1 == null || Score2 == null)
                return "? : ?";
            return $"{Score1.ToString()} : {Score2.ToString()}";
        }
    }
}
