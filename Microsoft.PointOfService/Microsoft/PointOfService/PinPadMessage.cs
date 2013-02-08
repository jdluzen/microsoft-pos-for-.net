namespace Microsoft.PointOfService
{
    public enum PinPadMessage
    {
        EnterPin = 1,
        PleaseWait = 2,
        EnterValidPin = 3,
        RetriesExceeded = 4,
        Approved = 5,
        Declined = 6,
        Canceled = 7,
        AmountOK = 8,
        NotReady = 9,
        Idle = 10,
        SlideCard = 11,
        InsertCard = 12,
        SelectCardType = 13,
    }
}
