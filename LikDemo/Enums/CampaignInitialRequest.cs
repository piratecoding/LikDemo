using System.ComponentModel.DataAnnotations;

namespace LikDemo.Enums
{
    public enum CampaignInitialRequest
    {
        [Display(Name = "Debt collector")]DebtCollector = 1,
        Reminders = 5,
        Invoice,
        [Display(Name = "International debt collection")] InternationalDebtCollection
    }
}
