using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoseBall.Model
{
    public class CoachDetail
    {
        public int CoachId { get; set; }
        public string Name { get; set; }
        public string Nationality { get; set; }
        public int TeamId { get; set; }
        public int InternationalId { get; set; }
    }
}
