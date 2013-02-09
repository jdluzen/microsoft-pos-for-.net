namespace Microsoft.PointOfService.BaseServiceObjects
{
    public class PrintBarCodeOperation : Microsoft.PointOfService.BaseServiceObjects.PrintOperation
    {
        protected PrintBarCodeOperation()
        {
        }
        public System.String Data { get { return null; } }
        public Microsoft.PointOfService.BarCodeSymbology Symbology { get { return Microsoft.PointOfService.BarCodeSymbology.Upca; } }
        public System.Int32 Height { get { return 0; } }
        public System.Int32 Width { get { return 0; } }
        public System.Int32 Alignment { get { return 0; } }
        public Microsoft.PointOfService.BarCodeTextPosition TextPosition { get { return Microsoft.PointOfService.BarCodeTextPosition.None; } }
    }
}
