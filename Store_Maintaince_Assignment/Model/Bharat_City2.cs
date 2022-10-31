using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Store_Maintaince_Assignment.Model
{
    public class Bharat_City2
    {
        [Key]
        public int CityIdd { get; set; }
        public int StateId2 { get; set; }
        [ForeignKey("StateId2")]
        public string CityName2 { get; set; }
        public Bharat_State2 State2 { get; set; }
    }
}
