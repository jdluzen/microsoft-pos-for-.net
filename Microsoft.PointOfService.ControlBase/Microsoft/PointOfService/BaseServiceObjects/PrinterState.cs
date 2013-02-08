namespace Microsoft.PointOfService.BaseServiceObjects
{
    public class PrinterState
    {
        protected PrinterState()
        {
        }
        public System.Int32 PageModeVerticalPosition
        {
            get { return 0; }
        }
        public System.Int32 PageModeHorizontalPosition
        {
            get { return 0; }
        }
        public System.Drawing.Rectangle PageModePrintArea
        {
            get { return new System.Drawing.Rectangle(); }
        }
        public Microsoft.PointOfService.PageModePrintDirection PageModePrintDirection
        {
            get { return Microsoft.PointOfService.PageModePrintDirection.None; }
        }
        public System.Int32 CharacterSet
        {
            get { return 0; }
        }
        public System.Boolean MapCharacterSet
        {
            get { return false; }
        }
        public Microsoft.PointOfService.MapMode MapMode
        {
            get { return Microsoft.PointOfService.MapMode.Dots; }
        }
        public Microsoft.PointOfService.Rotation RotateSpecial
        {
            get { return Microsoft.PointOfService.Rotation.Normal; }
        }
        public System.String TopLogo
        {
            get { return null; }
        }
        public System.String BottomLogo
        {
            get { return null; }
        }
        public System.Int32 RecLineChars
        {
            get { return 0; }
        }
        public System.Int32 RecLineHeight
        {
            get { return 0; }
        }
        public System.Int32 RecLineSpacing
        {
            get { return 0; }
        }
        public System.Boolean RecLetterQuality
        {
            get { return false; }
        }
        public Microsoft.PointOfService.PrinterColors RecCurrentCartridge
        {
            get { return Microsoft.PointOfService.PrinterColors.None; }
        }
        public Microsoft.PointOfService.PrintRotation RecRotationMode
        {
            get { return Microsoft.PointOfService.PrintRotation.Normal; }
        }
        public System.Int32 SlpLineChars
        {
            get { return 0; }
        }
        public System.Int32 SlpLineHeight
        {
            get { return 0; }
        }
        public System.Int32 SlpLineSpacing
        {
            get { return 0; }
        }
        public System.Boolean SlpLetterQuality
        {
            get { return false; }
        }
        public Microsoft.PointOfService.PrinterColors SlpCurrentCartridge
        {
            get { return Microsoft.PointOfService.PrinterColors.None; }
        }
        public Microsoft.PointOfService.PrintRotation SlpRotationMode
        {
            get { return Microsoft.PointOfService.PrintRotation.Normal; }
        }
        public System.Int32 JrnLineChars
        {
            get { return 0; }
        }
        public System.Int32 JrnLineHeight
        {
            get { return 0; }
        }
        public System.Int32 JrnLineSpacing
        {
            get { return 0; }
        }
        public System.Boolean JrnLetterQuality
        {
            get { return false; }
        }
        public Microsoft.PointOfService.PrinterColors JrnCurrentCartridge
        {
            get { return Microsoft.PointOfService.PrinterColors.None; }
        }
    }
}
