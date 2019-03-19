using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExManagementUnitTesting
{   [TestClass]
    class ExpenseCategoryManagerTest
    {
        [TestMethod]
        public void RetrieveExisting()
        {
           ExpenseCategoryManager  expenseCategory = new ExpenseCategoryManager();
            var all_expense = expenseCategory.Get() ;
        }

    }
}
