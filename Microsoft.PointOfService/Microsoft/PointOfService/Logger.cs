namespace Microsoft.PointOfService
{
    public class Logger
    {
        protected Logger()
        {
        }
        public System.String RegistryPath
        {
            get { return null; }
        }
        public System.Boolean Enabled
        {
            get { return false; }
            set { }
        }
        public static void Close()
        {
        }
        public static void Error(System.String param_param_caller, System.String param_param_message, System.Exception param_param_e)
        {
        }
        public static void Error(System.String param_param_caller, System.String param_param_message)
        {
        }
        public static void Warn(System.String param_param_caller, System.String param_param_message)
        {
        }
        public static void Warn(System.String param_param_caller, System.String param_param_message, System.Boolean param_param_eventLog)
        {
        }
        public static void Info(System.String param_param_caller, System.String param_param_message)
        {
        }
        public static void Info(System.String param_param_caller, System.String param_param_message, System.Boolean param_param_eventLog)
        {
        }
    }
}
