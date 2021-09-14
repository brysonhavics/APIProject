using Microsoft.Build.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoseBall.Model
{
    public class PlayerCreate
    {
        [Required]
        public string Name { get; set; }
        [Required]
        public int Number { get; set; }
        [Required]
        public string Position { get; set; }
        public int TeamId { get; set; }
        public int InternationalId { get; set; }

    }
}
