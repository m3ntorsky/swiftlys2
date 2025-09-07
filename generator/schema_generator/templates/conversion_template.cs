using System.Collections.Frozen;
using SwiftlyS2.Shared.Natives;

namespace SwiftlyS2.Core.Natives;

internal static class NativeHandleConversion {
  private static FrozenDictionary<Type, Func<nint, object>>? _conversions;

  public static void RegisterConversion<I, T>(Dictionary<Type, Func<nint, object>> conversions, Func<nint, object> factory) where I : INativeHandle where T : I
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

