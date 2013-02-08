namespace Microsoft.PointOfService
{
    public class Keylock : Microsoft.PointOfService.PosCommon
    {
        protected Keylock()
        {
        }
        public const System.Int32 PositionAny = 0;
        public const System.Int32 PositionElectronic = 0;
        public const System.Int32 PositionLocked = 1;
        public const System.Int32 PositionNormal = 2;
        public const System.Int32 PositionSupervisor = 3;
        public const System.String StatisticLockPositionChangeCount = "LockPositionChangeCount";
        public System.Int32 KeyPosition
        {
            get { return 0; }
        }
        public System.Int32 PositionCount
        {
            get { return 0; }
        }
        public Microsoft.PointOfService.KeylockType CapKeylockType
        {
            get { return Microsoft.PointOfService.KeylockType.Standard; }
        }
        public System.Byte[] ElectronicKeyValue
        {
            get { return null; }
        }
        public virtual void WaitForKeylockChange(System.Int32 keyPosition, System.Int32 timeout)
        {
        }
    }
}
