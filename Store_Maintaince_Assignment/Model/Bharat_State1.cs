using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Store_Maintaince_Assignment.Model
{
    public class Bharat_State1
    {
        [Key]
        public int StateId1 { get; set; }
        public string StateName1 { get; set; }
        public virtual ICollection<Bharat_City1> City1 { get; set; }

    }
}
