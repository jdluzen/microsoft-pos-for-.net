namespace Microsoft.PointOfService
{
    public abstract class CashDrawer : Microsoft.PointOfService.PosCommon
    {
        protected CashDrawer()
        {
        }
        public const System.String StatisticDrawerGoodOpenCount = "DrawerGoodOpenCount";
        public const System.String StatisticDrawerFailedOpenCount = "DrawerFailedOpenCount";
        public const System.Int32 StatusClosed = 0;
        public const System.Int32 StatusOpen = 1;
        public abstract System.Boolean CapStatus { get; }
        public abstract System.Boolean CapStatusMultiDrawerDetect { get; }
        public abstract System.Boolean DrawerOpened { get; }
        public virtual void OpenDrawer()
        {
        }
        
        public virtual void WaitForDrawerClose(System.Int32 beepTimeout, System.Int32 beepFrequency, System.Int32 beepDuration, System.Int32 beepDelay)
        {
        }
        
    }
}
