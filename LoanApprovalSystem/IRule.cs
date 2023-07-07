namespace LoanApprovalSystem
{
    public interface IRule
    {
        bool Evaluate(LoanApplication application);
    }

}