using System.Runtime.CompilerServices;

namespace SwiftlyS2.Core.Extensions;

internal static class PtrExtensions {

  public static T Read<T>(this nint ptr) where T : unmanaged {
    unsafe { return Unsafe.Read<T>((void*)ptr); }
  }

  public static T Read<T>(this nint ptr, int offset) where T : unmanaged
  {
    unsafe { return Unsafe.Read<T>((void*)(ptr + offset)); }
  }

  public static void Write<T>(this nint ptr, T value) where T : unmanaged {
    unsafe { Unsafe.Write((void*)ptr, value); }
  }


  public static void Write<T>(this nint ptr, int offset, T value) where T : unmanaged
  {
    unsafe { Unsafe.Write((void*)(ptr + offset), value); }
  }
}