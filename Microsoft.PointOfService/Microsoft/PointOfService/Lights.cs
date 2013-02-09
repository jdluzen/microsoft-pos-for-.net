namespace Microsoft.PointOfService
{
    public abstract class Lights : Microsoft.PointOfService.PosCommon
    {
        protected Lights()
        {
        }
        public abstract Microsoft.PointOfService.LightAlarms CapAlarm { get; }
        public abstract System.Boolean CapBlink { get; }
        public abstract Microsoft.PointOfService.LightColors CapColor { get; }
        public abstract System.Int32 MaxLights { get; }
        public virtual void SwitchOff(System.Int32 lightNumber)
        {
        }
        
        public virtual void SwitchOn(System.Int32 lightNumber, System.Int32 blinkOnCycle, System.Int32 blinkOffCycle, Microsoft.PointOfService.LightColors color, Microsoft.PointOfService.LightAlarms alarm)
        {
        }
        
    }
}
