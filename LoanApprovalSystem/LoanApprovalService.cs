namespace LoanApprovalSystem
{
    public class LoanApprovalService
    {
        private readonly IRule[] _rules;

        public LoanApprovalService(IRule[] rules)
        {
            _rules = rules;
        }

        public ApprovalDecision ProcessLoanApplication(LoanApplication application)
        {
            foreach (var rule in _rules)
            {
                if (!rule.Evaluate(application))
                {
                    return ApprovalDecision.Rejected;
                }
            }

            return ApprovalDecision.Approved;
        }
    }

}