namespace Microsoft.PointOfService.BaseServiceObjects
{
    public class DrawerStateChangedEventArgs : System.EventArgs
    {
        protected DrawerStateChangedEventArgs()
        {
        }
        public System.Boolean DrawerOpened
        {
            get { return false; }
        }
    }
}
