using Microsoft.Build.Framework;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoseBall.Model
{
    public class PlayerCreate
    {
        public string Name { get; set; }

        public int Number { get; set; }
        public string Position { get; set; }
        public int TeamId { get; set; }
        public int InternationalId { get; set; }
        [Range(0, 99)]
        public int Shooting { get; set; }
        [Range(0, 99)]
        public int Passing { get; set; }
        [Range(0, 99)]
        public int Defending { get; set; }

    }
}
