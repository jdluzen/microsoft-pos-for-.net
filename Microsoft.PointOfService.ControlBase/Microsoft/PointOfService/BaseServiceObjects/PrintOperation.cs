namespace Microsoft.PointOfService.BaseServiceObjects
{
    public abstract class PrintOperation
    {
        protected PrintOperation()
        {
        }
        public System.Boolean AsyncMode { get { return false; } }
        public Microsoft.PointOfService.BaseServiceObjects.PrinterState State { get { return null; } }
        public Microsoft.PointOfService.PrinterStation Station { get { return Microsoft.PointOfService.PrinterStation.None; } }
        public Microsoft.PointOfService.Rotation Rotation { get { return Microsoft.PointOfService.Rotation.Normal; } }
    }
}
