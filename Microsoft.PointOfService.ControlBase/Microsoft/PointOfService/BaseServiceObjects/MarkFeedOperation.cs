namespace Microsoft.PointOfService.BaseServiceObjects
{
    public class MarkFeedOperation : Microsoft.PointOfService.BaseServiceObjects.PrintOperation
    {
        protected MarkFeedOperation()
        {
        }
        public Microsoft.PointOfService.PrinterMarkFeeds Type
        {
            get { return Microsoft.PointOfService.PrinterMarkFeeds.None; }
        }
    }
}
