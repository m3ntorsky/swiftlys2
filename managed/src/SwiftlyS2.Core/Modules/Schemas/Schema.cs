using SwiftlyS2.Core.Natives;
using SwiftlyS2.Core.Extensions;
using System.Runtime.CompilerServices;
using System.Text;
using System.Buffers;
using System.Runtime.InteropServices;

namespace SwiftlyS2.Core.Schemas;

internal static class Schema {

  [MethodImpl(MethodImplOptions.AggressiveInlining)]  
  public static int GetOffset(ulong hash) {
    return NativeSchema.GetOffset(hash);
  }

  [MethodImpl(MethodImplOptions.AggressiveInlining)]  
  public static void Update(nint handle, ulong hash) {
    NativeSchema.SetStateChanged(handle, hash);
  }

  [MethodImpl(MethodImplOptions.AggressiveInlining)]  
  public static void SetString(nint handle, ulong hash, string value) {
    (handle + GetOffset(hash)).Write(StringPool.Allocate(value));
  }

  [MethodImpl(MethodImplOptions.AggressiveInlining)]  
  public static void SetFixedString(nint handle, ulong hash, string value, int maxSize) {
    var pool = ArrayPool<byte>.Shared;
    var size = Encoding.UTF8.GetByteCount(value);
    if (size + 1 > maxSize) {
      throw new ArgumentException("Value is too long. Max size is " + maxSize);
    }
    var bytes = pool.Rent(size + 1);
    Encoding.UTF8.GetBytes(value, bytes);
    bytes[size] = 0;
    Unsafe.CopyBlockUnaligned(
      ref (handle + GetOffset(hash)).AsRef<byte>(),
      ref bytes[0],
      (uint)(size + 1)
    );
    pool.Return(bytes);
  }

  [MethodImpl(MethodImplOptions.AggressiveInlining)]  
  public static string GetString(nint handle) {
    return Marshal.PtrToStringUTF8(handle) ?? string.Empty;
  }

}