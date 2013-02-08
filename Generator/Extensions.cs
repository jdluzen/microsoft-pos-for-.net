using System.Reflection;

namespace utils
{
    public static class Extensions
    {
        public static bool IsOverride(this MethodInfo methodInfo)
        {
            return methodInfo.GetBaseDefinition() != methodInfo;
        }
    }
}
