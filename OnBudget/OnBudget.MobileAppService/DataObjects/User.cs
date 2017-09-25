using Microsoft.Azure.Mobile.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OnBudget.MobileAppService.DataObjects
{
    public class User : EntityData
    {
        public string UserId { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string Emailadress { get; set; }

        public virtual ICollection<Income> Incomes { get; set; } = new HashSet<Income>();
        public virtual ICollection<Expense> Expenses { get; set; } = new HashSet<Expense>();

    }
}