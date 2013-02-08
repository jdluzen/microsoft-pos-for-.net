namespace Microsoft.PointOfService.BaseServiceObjects
{
    public class CashDrawerProperties : Microsoft.PointOfService.BasicServiceObjects.CommonProperties
    {
        protected CashDrawerProperties()
        {
        }
        public System.Boolean CapStatus
        {
            get { return false; }
            set { }
        }
        public System.Boolean CapStatusMultiDrawerDetect
        {
            get { return false; }
            set { }
        }
        public System.Boolean DrawerOpened
        {
            get { return false; }
            set { }
        }
    }
}
