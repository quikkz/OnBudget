using Microsoft.Azure.Mobile.Server;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;
using static OnBudget.MobileAppService.Constants.BusinessEnums;

namespace OnBudget.MobileAppService.DataObjects
{
    public class Expense : EntityData
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Amount { get; set; }
        public DateTime DueDate { get; set; }
        public ExpenseCategory Category { get; set; }

        public string UserId { get; set; }

        [ForeignKey("UserId")]
        public virtual User User { get; set; }
    }
}