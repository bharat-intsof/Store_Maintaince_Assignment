using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Store_Maintaince_Assignment.Model
{
    public class Bharat_State2
    {
        [Key]
        public int StateId2 { get; set; }
        public string StateName2 { get; set; }
        public virtual ICollection<Bharat_City2> City2 { get; set; }

    }
}
