namespace Microsoft.PointOfService.BaseServiceObjects
{
    public class CashDrawerBase : Microsoft.PointOfService.BasicServiceObjects.CashDrawerBasic, System.IDisposable
    {
        protected CashDrawerBase()
        {
        }
        public System.Boolean DeviceEnabled
        {
            get { return false; }
            set { }
        }
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
        public override void Close()
        {
        }
        public override void Open()
        {
        }
        public override void OpenDrawer()
        {
        }
        public override void WaitForDrawerClose(System.Int32 beepTimeout, System.Int32 beepFrequency, System.Int32 beepDuration, System.Int32 beepDelay)
        {
        }
    }
}
