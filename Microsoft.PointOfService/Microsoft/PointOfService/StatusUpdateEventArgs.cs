namespace Microsoft.PointOfService
{
    public class StatusUpdateEventArgs : Microsoft.PointOfService.PosEventArgs
    {
        public StatusUpdateEventArgs(System.Int32 status)
        {
        }
        protected StatusUpdateEventArgs()
        {
        }
        public System.Int32 Status
        {
            get { return 0; }
        }
        public override System.String ToString()
        {
            return null;
        }
    }
}
