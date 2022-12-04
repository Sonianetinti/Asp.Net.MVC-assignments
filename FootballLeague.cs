using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Ado.netmvcAssignment.Models
{
    [Table("FootBallLeague")]

    public class FootballLeague
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int MatchId { get; set; }
        public string TeamName1 { get; set; }
        public string TeamName2 { get; set; }
        public string Status { get; set; }
        public int Points { get; set; }
        public string WinningTeam { get; set; }
    }
}