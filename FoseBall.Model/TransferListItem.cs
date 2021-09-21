using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoseBall.Model
{
    public class TransferListItem
    {
        public int TransferId { get; set; }
        [Display(Name = "Player")]
        public int PlayerId { get; set; }
        public double Fee { get; set; }
    }
}
