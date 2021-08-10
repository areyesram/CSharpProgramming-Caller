using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;

namespace Caller
{
    public static class Util
    {
        public static void CallMeBack([CallerFilePath]string caller = "")
        {
            var className = Path.GetFileNameWithoutExtension(caller);
            var classRef = Assembly.GetCallingAssembly().GetTypes().FirstOrDefault(o => o.Name.Equals(className));
            var methodRef = classRef.GetMethod("Callback");
            if (methodRef != null)
            {
                var obj = Assembly.GetCallingAssembly().CreateInstance(classRef.FullName);
                methodRef.Invoke(obj, new object[] { });
            }
        }
    }
}
