namespace Microsoft.PointOfService.BaseServiceObjects
{
    public class Cell
    {
        protected Cell()
        {
        }
        public Microsoft.PointOfService.BaseServiceObjects.CellType Type
        {
            get { return Microsoft.PointOfService.BaseServiceObjects.CellType.Empty; }
        }
        public System.Int32 Character
        {
            get { return 0; }
        }
        public Microsoft.PointOfService.BaseServiceObjects.LineDisplayBitmap Bitmap
        {
            get { return null; }
        }
        public System.Byte[] PixelData
        {
            get { return null; }
        }
        public System.Int32 Row
        {
            get { return 0; }
        }
        public System.Int32 Column
        {
            get { return 0; }
        }
        public Microsoft.PointOfService.DisplayTextMode Attribute
        {
            get { return Microsoft.PointOfService.DisplayTextMode.Normal; }
        }
    }
}
