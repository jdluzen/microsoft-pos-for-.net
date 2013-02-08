namespace Microsoft.PointOfService
{
    public class Scale : Microsoft.PointOfService.PosCommon
    {
        protected Scale()
        {
        }
        public const System.String StatisticGoodWeightReadCount = "GoodWeightReadCount";
        public const System.Int32 ExtendedErrorOverWeight = 201;
        public const System.Int32 ExtendedErrorUnderZero = 202;
        public const System.Int32 ExtendedErrorSameWeight = 203;
        public const System.Int32 StatusStableWeight = 11;
        public const System.Int32 StatusWeightUnstable = 12;
        public const System.Int32 StatusWeightZero = 13;
        public const System.Int32 StatusWeightOverWeight = 14;
        public const System.Int32 StatusNotReady = 15;
        public const System.Int32 StatusWeightUnderZero = 16;
        public System.Int32 DataCount
        {
            get { return 0; }
        }
        public System.Boolean DataEventEnabled
        {
            get { return false; }
            set { }
        }
        public System.Boolean AutoDisable
        {
            get { return false; }
            set { }
        }
        public System.Boolean CapDisplay
        {
            get { return false; }
        }
        public System.Boolean CapDisplayText
        {
            get { return false; }
        }
        public System.Boolean CapPriceCalculating
        {
            get { return false; }
        }
        public System.Boolean CapTareWeight
        {
            get { return false; }
        }
        public System.Boolean CapZeroScale
        {
            get { return false; }
        }
        public System.Boolean AsyncMode
        {
            get { return false; }
            set { }
        }
        public System.Int32 MaxDisplayTextChars
        {
            get { return 0; }
        }
        public System.Decimal MaximumWeight
        {
            get { return new System.Decimal(); }
        }
        public System.Decimal SalesPrice
        {
            get { return new System.Decimal(); }
        }
        public System.Decimal TareWeight
        {
            get { return new System.Decimal(); }
            set { }
        }
        public System.Decimal UnitPrice
        {
            get { return new System.Decimal(); }
            set { }
        }
        public Microsoft.PointOfService.WeightUnit WeightUnit
        {
            get { return Microsoft.PointOfService.WeightUnit.Gram; }
        }
        public System.Boolean CapStatusUpdate
        {
            get { return false; }
        }
        public System.Decimal ScaleLiveWeight
        {
            get { return new System.Decimal(); }
        }
        public Microsoft.PointOfService.StatusNotify StatusNotify
        {
            get { return Microsoft.PointOfService.StatusNotify.Disabled; }
            set { }
        }
        #pragma warning disable 67
        public event Microsoft.PointOfService.DataEventHandler DataEvent
        {
            add { }
            remove { }
        }
        #pragma warning disable 67
        public event Microsoft.PointOfService.DeviceErrorEventHandler ErrorEvent
        {
            add { }
            remove { }
        }
        public virtual void ClearInput()
        {
        }
        public virtual void DisplayText(System.String data)
        {
        }
        public virtual System.Decimal ReadWeight(System.Int32 timeout)
        {
            return new System.Decimal();
        }
        public virtual void ZeroScale()
        {
        }
    }
}
