namespace Microsoft.PointOfService.BaseServiceObjects
{
    public class RotatePrintCollection : Microsoft.PointOfService.BaseServiceObjects.PrintOperationCollection, System.Collections.ICollection
    {
        protected RotatePrintCollection()
        {
        }
        public Microsoft.PointOfService.Rotation Rotation { get { return Microsoft.PointOfService.Rotation.Normal; } }
    }
}
