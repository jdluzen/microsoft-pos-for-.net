namespace Microsoft.PointOfService
{
    public class DataEventArgs : Microsoft.PointOfService.PosEventArgs
    {
        public DataEventArgs(System.Int32 param_param_status)
        {
        }
        protected DataEventArgs()
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
