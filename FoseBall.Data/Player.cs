using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoseBall.Data
{
    public class Player
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public int Number { get; set; }

        [Required]
        [Range(0,99)]
        public int Shooting { get; set; }
        [Required]
        [Range(0,99)]
        public int Passing { get; set; }
        [Required]
        [Range(0,99)]
        public int Defending { get; set; }

        [Display(Name = "Overall Score")]
        public int OverallScore
        {

            get
            {
                return (Shooting + Passing + Defending) / 3;
            }
        }

        [ForeignKey(nameof(Team))]
        public int TeamId { get; set; }

        [ForeignKey(nameof(International))]
        public int InternationalId { get; set; }

        [Required]
        public string Position { get; set; }

        public virtual Team Team { get; set; }
        public virtual International International { get; set; }
    }
}
