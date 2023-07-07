namespace LoanApprovalSystem
{
    public class LoanAmountRule : IRule
    {
        public bool Evaluate(LoanApplication application)
        {
            // Implement loan amount evaluation logic
            // Return true if the loan amount meets the criteria, false otherwise
            return application.LoanAmount <= 100000;
        }
    }

}