using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoseBall.Data
{
    public class International
    {
        [Key]
        public string InternationalId { get; set; }
        [Required]
        public string Coach { get; set; }
        [Required]
        public int Ranking { get; set; }
        [Required]
        public string Name { get; set; }
    }
}
