namespace Microsoft.PointOfService
{
    public enum CapSensorTypes
    {
        None = 0,
        FacialFeatures = 1,
        Voice = 2,
        Fingerprint = 4,
        Iris = 8,
        Retina = 16,
        HandGeometry = 32,
        SignatureDynamics = 64,
        KeystrokeDynamics = 128,
        LipMovement = 256,
        ThermalFaceImage = 512,
        ThermalHandImage = 1024,
        Gait = 2048,
        Password = 4096,
    }
}
