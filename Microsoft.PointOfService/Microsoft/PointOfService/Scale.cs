namespace Microsoft.PointOfService
{
    public abstract class Scale : Microsoft.PointOfService.PosCommon
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
        public abstract System.Int32 DataCount { get; }
        public abstract System.Boolean DataEventEnabled { get; set;  }
        public abstract System.Boolean AutoDisable { get; set;  }
        public abstract System.Boolean CapDisplay { get; }
        public abstract System.Boolean CapDisplayText { get; }
        public abstract System.Boolean CapPriceCalculating { get; }
        public abstract System.Boolean CapTareWeight { get; }
        public abstract System.Boolean CapZeroScale { get; }
        public abstract System.Boolean AsyncMode { get; set;  }
        public abstract System.Int32 MaxDisplayTextChars { get; }
        public abstract System.Decimal MaximumWeight { get; }
        public abstract System.Decimal SalesPrice { get; }
        public abstract System.Decimal TareWeight { get; set;  }
        public abstract System.Decimal UnitPrice { get; set;  }
        public abstract Microsoft.PointOfService.WeightUnit WeightUnit { get; }
        public virtual System.Boolean CapStatusUpdate { get { return false; } }
        public virtual System.Decimal ScaleLiveWeight { get { return new System.Decimal(); } }
        public virtual Microsoft.PointOfService.StatusNotify StatusNotify { get { return Microsoft.PointOfService.StatusNotify.Disabled; } set { } }
        #pragma warning disable 67
        public abstract event Microsoft.PointOfService.DataEventHandler DataEvent;
        #pragma warning disable 67
        public abstract event Microsoft.PointOfService.DeviceErrorEventHandler ErrorEvent;
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
