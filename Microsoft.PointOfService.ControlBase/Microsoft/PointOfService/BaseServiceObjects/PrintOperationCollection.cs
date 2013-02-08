namespace Microsoft.PointOfService.BaseServiceObjects
{
    public class PrintOperationCollection : System.Collections.ReadOnlyCollectionBase, System.Collections.ICollection
    {
        protected PrintOperationCollection()
        {
        }
        public Microsoft.PointOfService.BaseServiceObjects.PrintOperation this[System.Int32 index0]
        {
            get { return null; }
        }
        public Microsoft.PointOfService.PrinterStation Station
        {
            get { return Microsoft.PointOfService.PrinterStation.None; }
        }
        public void CopyTo(Microsoft.PointOfService.BaseServiceObjects.PrintOperation[] array, System.Int32 index)
        {
        }
    }
}
