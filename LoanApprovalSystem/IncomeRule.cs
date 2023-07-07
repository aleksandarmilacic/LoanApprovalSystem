namespace LoanApprovalSystem
{
    public class IncomeRule : IRule
    {
        public bool Evaluate(LoanApplication application)
        {
            // Implement income evaluation logic
            // Return true if the income meets the criteria, false otherwise
            return application.Income >= 50000;
        }
    }

}