namespace LoanApprovalSystem
{
    public class CreditScoreRule : IRule
    {
        public bool Evaluate(LoanApplication application)
        {
            // Implement credit score evaluation logic
            // Return true if the credit score meets the criteria, false otherwise
            return application.CreditScore >= 700;
        }
    }

}