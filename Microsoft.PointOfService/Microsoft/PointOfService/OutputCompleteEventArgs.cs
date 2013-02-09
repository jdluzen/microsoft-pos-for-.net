namespace Microsoft.PointOfService
{
    public class OutputCompleteEventArgs : Microsoft.PointOfService.PosEventArgs
    {
        public OutputCompleteEventArgs(System.Int32 outputId)
        {
        }
        
        protected OutputCompleteEventArgs()
        {
        }
        public System.Int32 OutputId { get { return 0; } }
        public override System.String ToString()
        {
            return null;
        }
        
    }
}
