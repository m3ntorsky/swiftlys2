using System.Collections.Concurrent;
using System.Reflection;
using System.Runtime.CompilerServices;

namespace SwiftlyS2.Shared.Schemas;

public static class SchemaSize
{
    private static readonly ConcurrentDictionary<Type, int> _sizeCache = new();

    public static int Get<T>()
    {
        return _sizeCache.GetOrAdd(typeof(T), static type =>
        {
            foreach (var iface in type.GetInterfaces())
            {
                if (iface.IsGenericType &&
                    iface.GetGenericTypeDefinition() == typeof(ISchemaClass<>) &&
                    iface.GetGenericArguments()[0] == type)
                {
                    var sizeProperty = iface.GetProperty("Size",
                        BindingFlags.Static | BindingFlags.Public | BindingFlags.NonPublic);

                    if (sizeProperty != null)
                    {
                        return (int)sizeProperty.GetValue(null)!;
                    }
                }
            }

            return Unsafe.SizeOf<T>();
        });
    }
}
