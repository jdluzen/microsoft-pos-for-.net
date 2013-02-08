namespace Microsoft.PointOfService
{
    public class Biometrics : Microsoft.PointOfService.PosCommon
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
        public System.Int32 DataCount
        {
            get { return 0; }
        }
        public System.Boolean DataEventEnabled
        {
            get { return false; }
            set { }
        }
        public System.Boolean AutoDisable
        {
            get { return false; }
            set { }
        }
        public System.Int32 Algorithm
        {
            get { return 0; }
            set { }
        }
        public System.String[] AlgorithmList
        {
            get { return null; }
        }
        public Microsoft.PointOfService.BiometricsInformationRecord BiometricsInformationRecord
        {
            get { return null; }
        }
        public System.Boolean CapPrematchData
        {
            get { return false; }
        }
        public System.Boolean CapRawSensorData
        {
            get { return false; }
        }
        public System.Boolean CapRealTimeData
        {
            get { return false; }
        }
        public Microsoft.PointOfService.CapSensorColors CapSensorColor
        {
            get { return Microsoft.PointOfService.CapSensorColors.None; }
        }
        public Microsoft.PointOfService.CapSensorOrientations CapSensorOrientation
        {
            get { return Microsoft.PointOfService.CapSensorOrientations.None; }
        }
        public Microsoft.PointOfService.CapSensorTypes CapSensorType
        {
            get { return Microsoft.PointOfService.CapSensorTypes.None; }
        }
        public System.Boolean CapTemplateAdaptation
        {
            get { return false; }
        }
        public System.Drawing.Bitmap RawSensorData
        {
            get { return null; }
        }
        public System.Boolean RealTimeDataEnabled
        {
            get { return false; }
            set { }
        }
        public Microsoft.PointOfService.SensorColor SensorColor
        {
            get { return Microsoft.PointOfService.SensorColor.None; }
            set { }
        }
        public Microsoft.PointOfService.SensorOrientation SensorOrientation
        {
            get { return Microsoft.PointOfService.SensorOrientation.None; }
            set { }
        }
        public Microsoft.PointOfService.SensorType SensorType
        {
            get { return Microsoft.PointOfService.SensorType.Unspecified; }
            set { }
        }
        #pragma warning disable 67
        public event Microsoft.PointOfService.DataEventHandler DataEvent
        {
            add { }
            remove { }
        }
        #pragma warning disable 67
        public event Microsoft.PointOfService.DeviceErrorEventHandler ErrorEvent
        {
            add { }
            remove { }
        }
        public virtual void ClearInput()
        {
        }
        public virtual void ClearInputProperties()
        {
        }
        public virtual void BeginEnrollCapture(Microsoft.PointOfService.BiometricsInformationRecord param_param_referenceBir, System.Byte[] param_param_payload)
        {
        }
        public virtual void BeginVerifyCapture()
        {
        }
        public virtual void EndCapture()
        {
        }
        public virtual System.Int32[] Identify(System.Int32 param_param_maximumFalseAcceptRateRequested, System.Int32 param_param_maximumFalseRejectRateRequested, System.Boolean param_param_falseAcceptRatePrecedence, System.Collections.Generic.IEnumerable<Microsoft.PointOfService.BiometricsInformationRecord> param_param_referenceBirPopulation, System.Int32 param_param_timeout)
        {
            return null;
        }
        public virtual System.Int32[] IdentifyMatch(System.Int32 param_param_maximumFalseAcceptRateRequested, System.Int32 param_param_maximumFalseRejectRateRequested, System.Boolean param_param_falseAcceptRatePrecedence, Microsoft.PointOfService.BiometricsInformationRecord param_param_sampleBir, System.Collections.Generic.IEnumerable<Microsoft.PointOfService.BiometricsInformationRecord> param_param_referenceBirPopulation)
        {
            return null;
        }
        public virtual Microsoft.PointOfService.BiometricsInformationRecord ProcessPrematchData(Microsoft.PointOfService.BiometricsInformationRecord param_param_sampleBir, Microsoft.PointOfService.BiometricsInformationRecord param_param_prematchDataBir)
        {
            return null;
        }
        public virtual Microsoft.PointOfService.BiometricsVerifyResult Verify(System.Int32 param_param_maximumFalseAcceptRateRequested, System.Int32 param_param_maximumFalseRejectRateRequested, System.Boolean param_param_falseAcceptRatePrecedence, Microsoft.PointOfService.BiometricsInformationRecord param_param_referenceBir, System.Boolean param_param_adaptBir, System.Int32 param_param_timeout)
        {
            return null;
        }
        public virtual Microsoft.PointOfService.BiometricsVerifyResult VerifyMatch(System.Int32 param_param_maximumFalseAcceptRateRequested, System.Int32 param_param_maximumFalseRejectRateRequested, System.Boolean param_param_falseAcceptRatePrecedence, Microsoft.PointOfService.BiometricsInformationRecord param_param_sampleBir, Microsoft.PointOfService.BiometricsInformationRecord param_param_referenceBir, System.Boolean param_param_adaptBir)
        {
            return null;
        }
    }
}
