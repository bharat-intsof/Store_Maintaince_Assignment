using ServiceStack.DataAnnotations;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Store_Maintaince_Assignment.Model
{
    public class Bharat_Store
    {
        [Key]
        [Unique]
        public int StoreNumber { get; set; }
        public string  Name { get; set; }
        public string Address1 { get; set; }
        public int Zip { get; set; }
        public int Phone { get; set; }
        public int Ext { get; set; }
        public int Fax { get; set; }
        public string Address2 { get; set; }
        public string Email { get; set; }
        public float DefaultFinanceCharge { get; set; }
        public int DefaultNumberOfDays { get; set; }
        public int CurrentAccountPeroid { get; set; }
        public DateTime DateOfLastArchive { get; set; }
        public DateTime CycleBeginDate { get; set; }
        public int StateId1 { get; set; }
        public Bharat_State1 State1 { get; set; }
        public int StateId2 { get; set; }
        public Bharat_State2 State2 { get; set; }

    }
}
