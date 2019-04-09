using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace expenseManagementBackend.Models
{
    public class ExpenseCategory
    {
        

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int EC_Id { get; set; }
        public string Expense_Category { get; set; }
        public string Date { get; set; }
        public int Amount { get; set; }
        public string Description { get; set; }

        //[ForeignKey("user")]
        //public int User_Id { get; set; }
        //public user User { get; set; }
        public string User_Id { get; set; }
    }
}
