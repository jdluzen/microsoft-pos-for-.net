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
        public virtual void SwitchOff(System.Int32 param_param_lightNumber)
        {
        }
        public virtual void SwitchOn(System.Int32 param_param_lightNumber, System.Int32 param_param_blinkOnCycle, System.Int32 param_param_blinkOffCycle, Microsoft.PointOfService.LightColors param_param_color, Microsoft.PointOfService.LightAlarms param_param_alarm)
        {
        }
    }
}
