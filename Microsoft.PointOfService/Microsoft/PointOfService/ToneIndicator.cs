namespace Microsoft.PointOfService
{
    public class ToneIndicator : Microsoft.PointOfService.PosCommon
    {
        protected ToneIndicator()
        {
        }
        public const System.String StatisticToneSoundedCount = "ToneSoundedCount";
        public System.Int32 OutputId
        {
            get { return 0; }
        }
        public System.Boolean CapPitch
        {
            get { return false; }
        }
        public System.Boolean CapVolume
        {
            get { return false; }
        }
        public System.Boolean AsyncMode
        {
            get { return false; }
            set { }
        }
        public System.Int32 InterToneWait
        {
            get { return 0; }
            set { }
        }
        public System.Int32 Tone1Duration
        {
            get { return 0; }
            set { }
        }
        public System.Int32 Tone1Pitch
        {
            get { return 0; }
            set { }
        }
        public System.Int32 Tone1Volume
        {
            get { return 0; }
            set { }
        }
        public System.Int32 Tone2Duration
        {
            get { return 0; }
            set { }
        }
        public System.Int32 Tone2Pitch
        {
            get { return 0; }
            set { }
        }
        public System.Int32 Tone2Volume
        {
            get { return 0; }
            set { }
        }
        #pragma warning disable 67
        public event Microsoft.PointOfService.DeviceErrorEventHandler ErrorEvent
        {
            add { }
            remove { }
        }
        #pragma warning disable 67
        public event Microsoft.PointOfService.OutputCompleteEventHandler OutputCompleteEvent
        {
            add { }
            remove { }
        }
        public virtual void ClearOutput()
        {
        }
        public virtual void Sound(System.Int32 numberOfCycles, System.Int32 interSoundWait)
        {
        }
        public virtual void SoundImmediate()
        {
        }
    }
}
