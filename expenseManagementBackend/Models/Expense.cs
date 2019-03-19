using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace expenseManagementBackend.Models
{
    public class Expense
    {
        

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Expense_Id { get; set; }
        [ForeignKey("user")]
        public int User_Id { get; set; }
        public user User { get; set; }
        
       
        
        
        
    }
}
