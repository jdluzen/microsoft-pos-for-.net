namespace Microsoft.PointOfService
{
    public class ItemDispenser : Microsoft.PointOfService.PosCommon
    {
        protected ItemDispenser()
        {
        }
        public const System.Int32 StatusOk = 11;
        public const System.Int32 StatusEmpty = 12;
        public const System.Int32 StatusNearEmpty = 13;
        public const System.Int32 StatusJam = 14;
        public System.Boolean CapEmptySensor
        {
            get { return false; }
        }
        public System.Boolean CapIndividualSlotStatus
        {
            get { return false; }
        }
        public System.Boolean CapJamSensor
        {
            get { return false; }
        }
        public System.Boolean CapNearEmptySensor
        {
            get { return false; }
        }
        public Microsoft.PointOfService.ItemDispenserStatus DispenserStatus
        {
            get { return Microsoft.PointOfService.ItemDispenserStatus.Ok; }
        }
        public System.Int32 MaxSlots
        {
            get { return 0; }
        }
        public virtual void AdjustItemCount(System.Int32 param_param_itemCount, System.Int32 param_param_slotNumber)
        {
        }
        public virtual void DispenseItem(System.Int32 param_param_numItem, System.Int32 param_param_slotNumber)
        {
        }
        public virtual System.Int32 ReadItemCount(System.Int32 param_param_slotNumber)
        {
            return 0;
        }
    }
}
