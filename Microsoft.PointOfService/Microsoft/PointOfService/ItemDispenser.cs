namespace Microsoft.PointOfService
{
    public abstract class ItemDispenser : Microsoft.PointOfService.PosCommon
    {
        protected ItemDispenser()
        {
        }
        public const System.Int32 StatusOk = 11;
        public const System.Int32 StatusEmpty = 12;
        public const System.Int32 StatusNearEmpty = 13;
        public const System.Int32 StatusJam = 14;
        public abstract System.Boolean CapEmptySensor { get; }
        public abstract System.Boolean CapIndividualSlotStatus { get; }
        public abstract System.Boolean CapJamSensor { get; }
        public abstract System.Boolean CapNearEmptySensor { get; }
        public abstract Microsoft.PointOfService.ItemDispenserStatus DispenserStatus { get; }
        public abstract System.Int32 MaxSlots { get; }
        public virtual void AdjustItemCount(System.Int32 itemCount, System.Int32 slotNumber)
        {
        }
        
        public virtual void DispenseItem(System.Int32 numItem, System.Int32 slotNumber)
        {
        }
        
        public virtual System.Int32 ReadItemCount(System.Int32 slotNumber)
        {
            return 0;
        }
        
    }
}
