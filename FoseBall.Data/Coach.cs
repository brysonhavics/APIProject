using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoseBall.Data
{
    public class Coach
    {
        [Key]
        public int CoachId { get; set; }
        public string Name { get; set; }
        public string Nationality { get; set; }

        [ForeignKey(nameof(Team))]
        public int TeamId { get; set; }

        [ForeignKey(nameof(International))]
        public int InternationalId { get; set; }

        public virtual Team Team { get; set; }

        public virtual International International { get; set; }
      
    }
}
