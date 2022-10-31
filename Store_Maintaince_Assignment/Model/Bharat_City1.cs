using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Store_Maintaince_Assignment.Model
{
    public class Bharat_City1
    {
        [Key]
        public int CityId1 { get; set; }
        public string CityName1 { get; set; }
        public int StateId1 { get; set; }
        [ForeignKey("StateId1")]
        public Bharat_State1 State1 { get; set; }
    }
}
