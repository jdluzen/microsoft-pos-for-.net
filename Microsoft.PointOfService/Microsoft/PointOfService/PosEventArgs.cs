namespace Microsoft.PointOfService
{
    public class PosEventArgs : System.EventArgs
    {
        protected PosEventArgs()
        {
        }
        public System.DateTime TimeStamp
        {
            get { return new System.DateTime(); }
        }
        public System.Int32 EventId
        {
            get { return 0; }
        }
        public override System.String ToString()
        {
            return null;
        }
    }
}
