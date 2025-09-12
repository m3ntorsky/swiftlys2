using System.Collections.Frozen;
using SwiftlyS2.Shared.Natives;
using SwiftlyS2.Shared.SchemaDefinitions;
using SwiftlyS2.Core.SchemaDefinitions;

namespace SwiftlyS2.Core.Natives;

internal static class NativeHandleConversion {
  private static FrozenDictionary<Type, Func<nint, object>>? _conversions;

  private static void RegisterConversion<I, T>(this Dictionary<Type, Func<nint, object>> conversions, Func<nint, object> factory) where I : INativeHandle where T : I
  {
    conversions[typeof(I)] = factory;
    conversions[typeof(T)] = factory;
  }

  public static void RegisterConversions()
  {
    Dictionary<Type, Func<nint, object>> conversions = new Dictionary<Type, Func<nint, object>>();
$CONVERSIONS$
    _conversions = conversions.ToFrozenDictionary();
  }

  public static T As<T>(nint handle) where T : INativeHandle
  {
    return (T)_conversions[typeof(T)](handle);
  }
}

