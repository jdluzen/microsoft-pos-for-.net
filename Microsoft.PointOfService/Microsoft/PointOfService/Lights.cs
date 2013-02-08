namespace Microsoft.PointOfService
{
    public class Lights : Microsoft.PointOfService.PosCommon
    {
        protected Lights()
        {
        }
        public Microsoft.PointOfService.LightAlarms CapAlarm
        {
            get { return Microsoft.PointOfService.LightAlarms.None; }
        }
        public System.Boolean CapBlink
        {
            get { return false; }
        }
        public Microsoft.PointOfService.LightColors CapColor
        {
            get { return Microsoft.PointOfService.LightColors.Primary; }
        }
        public System.Int32 MaxLights
        {
            get { return 0; }
        }
        public virtual void SwitchOff(System.Int32 lightNumber)
        {
        }
        public virtual void SwitchOn(System.Int32 lightNumber, System.Int32 blinkOnCycle, System.Int32 blinkOffCycle, Microsoft.PointOfService.LightColors color, Microsoft.PointOfService.LightAlarms alarm)
        {
        }
    }
}
