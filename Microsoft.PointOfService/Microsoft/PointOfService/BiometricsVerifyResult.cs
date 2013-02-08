namespace Microsoft.PointOfService
{
    public class BiometricsVerifyResult
    {
        public BiometricsVerifyResult(System.Boolean param_param_result, System.Int32 param_param_falseAcceptRateAchieved, System.Int32 param_param_falseRejectRateAchieved, Microsoft.PointOfService.BiometricsInformationRecord param_param_adaptedBir, System.Byte[] param_param_payload)
        {
        }
        protected BiometricsVerifyResult()
        {
        }
        public System.Boolean Result
        {
            get { return false; }
        }
        public Microsoft.PointOfService.BiometricsInformationRecord AdaptedBir
        {
            get { return null; }
        }
        public System.Int32 FalseAcceptRateAchieved
        {
            get { return 0; }
        }
        public System.Int32 FalseRejectRateAchieved
        {
            get { return 0; }
        }
        public System.Byte[] GetPayload()
        {
            return null;
        }
    }
}
