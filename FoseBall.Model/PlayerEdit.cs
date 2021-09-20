using FoseBall.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoseBall.Model
{
    public class PlayerEdit
    {
        public int PlayerId { get; set; }
        public string Name { get; set; }
        public int Number { get; set; }
        public int TeamId { get; set; }
        public int InternationalId { get; set; }
        public Position Position { get; set; }
    }
}
