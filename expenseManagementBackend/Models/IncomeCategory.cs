using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace expenseManagementBackend.Models
{
    public class IncomeCategory
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IC_Id { get; set; }
        public string Income_Category { get; set; }
        public string Date { get; set; }
        public int Amount { get; set; }
        public string Description { get; set; }

        //[ForeignKey("user")]
        //public int User_Id { get; set; }
        //public user user { get; set; }
        public string User_Id { get; set; }
    }
}
