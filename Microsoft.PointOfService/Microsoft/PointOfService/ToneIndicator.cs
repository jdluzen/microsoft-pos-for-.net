namespace Microsoft.PointOfService
{
    public abstract class ToneIndicator : Microsoft.PointOfService.PosCommon
    {
        protected ToneIndicator()
        {
        }
        public const System.String StatisticToneSoundedCount = "ToneSoundedCount";
        public abstract System.Int32 OutputId { get; }
        public abstract System.Boolean CapPitch { get; }
        public abstract System.Boolean CapVolume { get; }
        public abstract System.Boolean AsyncMode { get; set;  }
        public abstract System.Int32 InterToneWait { get; set;  }
        public abstract System.Int32 Tone1Duration { get; set;  }
        public abstract System.Int32 Tone1Pitch { get; set;  }
        public abstract System.Int32 Tone1Volume { get; set;  }
        public abstract System.Int32 Tone2Duration { get; set;  }
        public abstract System.Int32 Tone2Pitch { get; set;  }
        public abstract System.Int32 Tone2Volume { get; set;  }
        #pragma warning disable 67
        public abstract event Microsoft.PointOfService.DeviceErrorEventHandler ErrorEvent;
        #pragma warning disable 67
        public abstract event Microsoft.PointOfService.OutputCompleteEventHandler OutputCompleteEvent;
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
