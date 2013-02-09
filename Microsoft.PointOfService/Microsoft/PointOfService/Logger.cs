namespace Microsoft.PointOfService
{
    public class Logger
    {
        protected Logger()
        {
        }
        public System.String RegistryPath { get { return null; } }
        public System.Boolean Enabled { get { return false; } set { } }
        public static void Close()
        {
        }
        
        public static void Error(System.String caller, System.String message, System.Exception e)
        {
        }
        
        public static void Error(System.String caller, System.String message)
        {
        }
        
        public static void Warn(System.String caller, System.String message)
        {
        }
        
        public static void Warn(System.String caller, System.String message, System.Boolean eventLog)
        {
        }
        
        public static void Info(System.String caller, System.String message)
        {
        }
        
        public static void Info(System.String caller, System.String message, System.Boolean eventLog)
        {
        }
        
    }
}
