namespace Microsoft.PointOfService
{
    public class BiometricsVerifyResult
    {
        public BiometricsVerifyResult(System.Boolean result, System.Int32 falseAcceptRateAchieved, System.Int32 falseRejectRateAchieved, Microsoft.PointOfService.BiometricsInformationRecord adaptedBir, System.Byte[] payload)
        {
        }
        
        protected BiometricsVerifyResult()
        {
        }
        public System.Boolean Result { get { return false; } }
        public Microsoft.PointOfService.BiometricsInformationRecord AdaptedBir { get { return null; } }
        public System.Int32 FalseAcceptRateAchieved { get { return 0; } }
        public System.Int32 FalseRejectRateAchieved { get { return 0; } }
        public System.Byte[] GetPayload()
        {
            return null;
        }
        
    }
}
