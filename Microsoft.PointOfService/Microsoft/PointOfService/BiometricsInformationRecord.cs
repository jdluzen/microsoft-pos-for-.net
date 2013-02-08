namespace Microsoft.PointOfService
{
    public class BiometricsInformationRecord : System.Xml.Serialization.IXmlSerializable
    {
        public BiometricsInformationRecord(System.Version param_param_version, Microsoft.PointOfService.BirDataTypes param_param_dataType, System.Int32 param_param_formatOwner, System.Int32 param_param_formatId, Microsoft.PointOfService.BirPurpose param_param_purpose, Microsoft.PointOfService.SensorType param_param_sensorType, System.Byte[] param_param_biometricDataBlock)
        {
        }
        public BiometricsInformationRecord(Microsoft.PointOfService.BiometricsInformationRecord param_param_bir)
        {
        }
        protected BiometricsInformationRecord()
        {
        }
        public System.DateTime CreatedTime
        {
            get { return new System.DateTime(); }
        }
        public System.Version Version
        {
            get { return null; }
        }
        public Microsoft.PointOfService.BirDataTypes DataType
        {
            get { return Microsoft.PointOfService.BirDataTypes.Raw; }
        }
        public System.Int32 FormatOwner
        {
            get { return 0; }
        }
        public System.Int32 FormatId
        {
            get { return 0; }
        }
        public Microsoft.PointOfService.BirPurpose Purpose
        {
            get { return Microsoft.PointOfService.BirPurpose.Unspecified; }
        }
        public Microsoft.PointOfService.SensorType SensorType
        {
            get { return Microsoft.PointOfService.SensorType.Unspecified; }
        }
        public System.Int32 BiometricDataBlockSize
        {
            get { return 0; }
        }
        public Microsoft.PointOfService.BiometricsInformationRecord Clone()
        {
            return null;
        }
        public System.Byte[] GetBiometricDataBlock()
        {
            return null;
        }
        public virtual System.Xml.Schema.XmlSchema GetSchema()
        {
            return null;
        }
        public virtual void ReadXml(System.Xml.XmlReader param_param_reader)
        {
        }
        public virtual void WriteXml(System.Xml.XmlWriter param_param_writer)
        {
        }
    }
}
