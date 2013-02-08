namespace Microsoft.PointOfService
{
    public class DirectIOEventArgs : Microsoft.PointOfService.PosEventArgs
    {
        public DirectIOEventArgs(System.Int32 eventNumber, System.Int32 data, System.Object obj)
        {
        }
        protected DirectIOEventArgs()
        {
        }
        public System.Int32 EventNumber
        {
            get { return 0; }
        }
        public System.Int32 Data
        {
            get { return 0; }
            set { }
        }
        public System.Object Object
        {
            get { return null; }
            set { }
        }
        public override System.String ToString()
        {
            return null;
        }
    }
}
