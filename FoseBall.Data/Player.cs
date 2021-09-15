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
        [ForeignKey(nameof(Team))]
        public int TeamId { get; set; }
        [ForeignKey(nameof(International))]
        public int InternationalId { get; set; }
        [Required]
        public string Position { get; set; }
    }
}
