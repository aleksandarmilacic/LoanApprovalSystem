using System;
namespace LoanApprovalSystem
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // Create loan application
            var application = new LoanApplication
            {
                ApplicantName = "John Doe",
                CreditScore = 720,
                Income = 60000,
                LoanAmount = 90000
            };

            // Create loan approval service with rules
            var rules = new IRule[] { new CreditScoreRule(), new IncomeRule(), new LoanAmountRule() };
            var approvalService = new LoanApprovalService(rules);

            // Process loan application
            var decision = approvalService.ProcessLoanApplication(application);

            // Display the approval decision
            Console.WriteLine($"Loan Application Decision: {decision}");
        }
    }

}