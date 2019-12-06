using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace project2020.Models
{
    public class Workers
    {
        [Key]
        [ForeignKey("Offers")]
        public int id { get; set; }
        public string name { get; set; }
        public Offers Offers { get; set; }

    }
}
