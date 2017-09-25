using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace OnBudget.MobileAppService.Constants
{
    public static class BusinessEnums
    {
        public enum ExpenseCategory
        {
            Rent = 0,
            Utilities = 1,
            Insurance = 2,
            Interest = 3,
            Transportation = 4,
            Personal = 5,
            DebtReduction = 6,
            Savings = 7,
            Other = 8,
        }

        public enum IncomeCategory
        {
            Paycheck = 0,
            PredictableBonus = 1,
            Reimbursements = 2,
            Investment = 3,
            Misc = 4
        }
    }
}