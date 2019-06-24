using System;
using System.Linq;
using System.Reflection;

public static partial class Invoker
{
    public static object Invoke(params object[] args)
    {
        Assembly assembly = Assembly.GetCallingAssembly();

        var types = assembly.GetTypes();

        var type = types.Where(t => t.IsClass && t.Name == "Solution").First();

        var instance = Activator.CreateInstance(type);

        var method = instance.GetType().GetMethods()[0];

        return method.Invoke(instance, args);
    }
}
