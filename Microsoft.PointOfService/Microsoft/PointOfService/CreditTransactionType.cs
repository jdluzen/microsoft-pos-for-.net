namespace Microsoft.PointOfService
{
    public enum CreditTransactionType
    {
        Sales = 10,
        Void = 20,
        Refund = 21,
        VoidPreSales = 29,
        Completion = 30,
        PreSales = 40,
        CheckCard = 41,
        CashDeposit = 50,
    }
}
