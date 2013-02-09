namespace Microsoft.PointOfService
{
    public abstract class Biometrics : Microsoft.PointOfService.PosCommon
    {
        protected Biometrics()
        {
        }
        public const System.Int32 UseDefault = -1;
        public const System.Int32 DataEventEnroll = 1;
        public const System.Int32 DataEventVerify = 2;
        public const System.Int32 StatusRawData = 1;
        public const System.Int32 StatusMoveLeft = 2;
        public const System.Int32 StatusMoveRight = 3;
        public const System.Int32 StatusMoveDown = 4;
        public const System.Int32 StatusMoveUp = 5;
        public const System.Int32 StatusMoveCloser = 6;
        public const System.Int32 StatusMoveAway = 7;
        public const System.Int32 StatusMoveBackward = 8;
        public const System.Int32 StatusMoveForward = 9;
        public const System.Int32 StatusMoveSlower = 10;
        public const System.Int32 StatusMoveFaster = 11;
        public const System.Int32 StatusSensorDirty = 12;
        public const System.Int32 StatusUnspecifiedReadFailure = 1000;
        public const System.Int32 StatusSensorReady = 1001;
        public const System.Int32 StatusSensorComplete = 1002;
        public const System.String StatisticSuccessfulMatchCount = "SuccessfulMatchCount";
        public const System.String StatisticUnsuccessfulMatchCount = "UnsuccessfulMatchCount";
        public const System.String StatisticAverageFalseAcceptRate = "AverageFAR";
        public const System.String StatisticAverageFalseRejectRate = "AverageFRR";
        public abstract System.Int32 DataCount { get; }
        public abstract System.Boolean DataEventEnabled { get; set;  }
        public abstract System.Boolean AutoDisable { get; set;  }
        public abstract System.Int32 Algorithm { get; set;  }
        public abstract System.String[] AlgorithmList { get; }
        public abstract Microsoft.PointOfService.BiometricsInformationRecord BiometricsInformationRecord { get; }
        public abstract System.Boolean CapPrematchData { get; }
        public abstract System.Boolean CapRawSensorData { get; }
        public abstract System.Boolean CapRealTimeData { get; }
        public abstract Microsoft.PointOfService.CapSensorColors CapSensorColor { get; }
        public abstract Microsoft.PointOfService.CapSensorOrientations CapSensorOrientation { get; }
        public abstract Microsoft.PointOfService.CapSensorTypes CapSensorType { get; }
        public abstract System.Boolean CapTemplateAdaptation { get; }
        public abstract System.Drawing.Bitmap RawSensorData { get; }
        public abstract System.Boolean RealTimeDataEnabled { get; set;  }
        public abstract Microsoft.PointOfService.SensorColor SensorColor { get; set;  }
        public abstract Microsoft.PointOfService.SensorOrientation SensorOrientation { get; set;  }
        public abstract Microsoft.PointOfService.SensorType SensorType { get; set;  }
        #pragma warning disable 67
        public abstract event Microsoft.PointOfService.DataEventHandler DataEvent;
        #pragma warning disable 67
        public abstract event Microsoft.PointOfService.DeviceErrorEventHandler ErrorEvent;
        public virtual void ClearInput()
        {
        }
        
        public virtual void ClearInputProperties()
        {
        }
        
        public virtual void BeginEnrollCapture(Microsoft.PointOfService.BiometricsInformationRecord referenceBir, System.Byte[] payload)
        {
        }
        
        public virtual void BeginVerifyCapture()
        {
        }
        
        public virtual void EndCapture()
        {
        }
        
        public virtual System.Int32[] Identify(System.Int32 maximumFalseAcceptRateRequested, System.Int32 maximumFalseRejectRateRequested, System.Boolean falseAcceptRatePrecedence, System.Collections.Generic.IEnumerable<Microsoft.PointOfService.BiometricsInformationRecord> referenceBirPopulation, System.Int32 timeout)
        {
            return null;
        }
        
        public virtual System.Int32[] IdentifyMatch(System.Int32 maximumFalseAcceptRateRequested, System.Int32 maximumFalseRejectRateRequested, System.Boolean falseAcceptRatePrecedence, Microsoft.PointOfService.BiometricsInformationRecord sampleBir, System.Collections.Generic.IEnumerable<Microsoft.PointOfService.BiometricsInformationRecord> referenceBirPopulation)
        {
            return null;
        }
        
        public virtual Microsoft.PointOfService.BiometricsInformationRecord ProcessPrematchData(Microsoft.PointOfService.BiometricsInformationRecord sampleBir, Microsoft.PointOfService.BiometricsInformationRecord prematchDataBir)
        {
            return null;
        }
        
        public virtual Microsoft.PointOfService.BiometricsVerifyResult Verify(System.Int32 maximumFalseAcceptRateRequested, System.Int32 maximumFalseRejectRateRequested, System.Boolean falseAcceptRatePrecedence, Microsoft.PointOfService.BiometricsInformationRecord referenceBir, System.Boolean adaptBir, System.Int32 timeout)
        {
            return null;
        }
        
        public virtual Microsoft.PointOfService.BiometricsVerifyResult VerifyMatch(System.Int32 maximumFalseAcceptRateRequested, System.Int32 maximumFalseRejectRateRequested, System.Boolean falseAcceptRatePrecedence, Microsoft.PointOfService.BiometricsInformationRecord sampleBir, Microsoft.PointOfService.BiometricsInformationRecord referenceBir, System.Boolean adaptBir)
        {
            return null;
        }
        
    }
}
