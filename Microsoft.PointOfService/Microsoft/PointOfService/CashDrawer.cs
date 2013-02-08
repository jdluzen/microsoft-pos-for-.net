namespace Microsoft.PointOfService
{
    public class CashDrawer : Microsoft.PointOfService.PosCommon
    {
        protected CashDrawer()
        {
        }
        public const System.String StatisticDrawerGoodOpenCount = "DrawerGoodOpenCount";
        public const System.String StatisticDrawerFailedOpenCount = "DrawerFailedOpenCount";
        public const System.Int32 StatusClosed = 0;
        public const System.Int32 StatusOpen = 1;
        public System.Boolean CapStatus
        {
            get { return false; }
        }
        public System.Boolean CapStatusMultiDrawerDetect
        {
            get { return false; }
        }
        public System.Boolean DrawerOpened
        {
            get { return false; }
        }
        public virtual void OpenDrawer()
        {
        }
        public virtual void WaitForDrawerClose(System.Int32 param_param_beepTimeout, System.Int32 param_param_beepFrequency, System.Int32 param_param_beepDuration, System.Int32 param_param_beepDelay)
        {
        }
    }
}
