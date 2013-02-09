namespace Microsoft.PointOfService.BaseServiceObjects
{
    public class ClearPrintAreaOperation : Microsoft.PointOfService.BaseServiceObjects.PrintOperation
    {
        protected ClearPrintAreaOperation()
        {
        }
        public System.Drawing.Rectangle PageModePrintArea { get { return new System.Drawing.Rectangle(); } }
    }
}
