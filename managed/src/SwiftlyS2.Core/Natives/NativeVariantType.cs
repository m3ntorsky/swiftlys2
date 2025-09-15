using System.Buffers;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using SwiftlyS2.Core.Extensions;
using SwiftlyS2.Shared.Natives;

namespace SwiftlyS2.Core.Natives;

enum Variant : uint {
  VAR_BOOL = 0,
  VAR_BYTE = 1,
  VAR_INT16 = 2,
  VAR_UINT16 = 3,
  VAR_INT32 = 4,
  VAR_UINT32 = 5,
  VAR_INT64 = 6,
  VAR_UINT64 = 7,
  VAR_FLOAT = 8,
  VAR_DOUBLE = 9,
  VAR_PTR = 10,
  VAR_STRING = 11,
  VAR_ENUM = 12,
  VAR_VECTOR2D = 13,
  VAR_VECTOR3D = 14,
  VAR_VECTOR4D = 15,
  VAR_QANGLE = 16,
  VAR_QUATERNION = 17,
  VAR_COLOR = 18,
  VAR_MATRIX3X4 = 19,
  VAR_STRINGTOKEN = 20,
  VAR_EHANDLE = 21,
  VAR_BUFFER = 22
}

/// <summary>
/// A wrapper for a variant type to be used in the interaction with native.
/// The serialization memory layout will look like this:
/// [ Type (4 byte) ] [ Size (4 byte) ] [ Data (size bytes) ]
/// For most types, size is fixed.
/// For VAR_STRING and VAR_BUFFER, size is variable and directly stored in the data zone.
/// </summary>
internal class NativeVariantType {

  private readonly Variant type;
  private readonly int size;
  private byte[]? buffer;

  private NativeVariantType(Variant type, int size, byte[] buffer)
  {
    this.type = type;
    this.size = size;
    this.buffer = buffer;
  }

  public static NativeVariantType Create<T>(T value) where T : unmanaged
  {
    var variantType = ToVariantType<T>();
    var buffer = ArrayPool<byte>.Shared.Rent(GetSize(variantType));
    unsafe {
      fixed (byte* bufferPtr = buffer) {
        Unsafe.WriteUnaligned(bufferPtr, value);
      }
    }
    return new NativeVariantType(variantType, GetSize(variantType), buffer);
  }

  public static NativeVariantType CreateString(string value)
  {
    var variantType = Variant.VAR_STRING;
    var size = Encoding.UTF8.GetByteCount(value);
    var buffer = ArrayPool<byte>.Shared.Rent(size + 1);
    Encoding.UTF8.GetBytes(value, buffer);
    buffer[size] = 0;
    return new NativeVariantType(variantType, size, buffer);
  }

  public static NativeVariantType CreateBuffer(byte[] value)
  {
    var variantType = Variant.VAR_BUFFER;
    var size = value.Length;
    var buffer = ArrayPool<byte>.Shared.Rent(size);
    value.CopyTo(buffer.AsSpan());
    return new NativeVariantType(variantType, size, buffer);
  }

  public int GetSerializationSize() {
    return size + 8;
  }

  public void Serialize(nint ptr)
  {
    unsafe {
      fixed (byte* bufferPtr = buffer) {
        ptr.Write(type);
        ptr.Write(4, size);
        ptr.CopyFrom(8, (nint)bufferPtr, size);
      }
    }
  }

  public static NativeVariantType Deserialize(nint ptr)
  {
    unsafe {
      var type = ptr.Read<Variant>();
      var size = ptr.Read<int>(4);
      var buffer = ArrayPool<byte>.Shared.Rent(size);
      fixed (byte* bufferPtr = buffer) {
        Unsafe.CopyBlockUnaligned(bufferPtr, (void*)(ptr + 8), (uint)size);
      }
      return new NativeVariantType(type, size, buffer);
    }
  }

  public T Take<T>() where T : unmanaged
  {
    if (buffer == null) {
      throw new InvalidOperationException("Double take");
    }
    T value;
    unsafe {
      fixed (byte* bufferPtr = buffer) {
        value = Unsafe.ReadUnaligned<T>(bufferPtr);
      }
    }
    ArrayPool<byte>.Shared.Return(buffer);
    buffer = null;
    return value;
  }

  public string TakeString()
  {
    if (buffer == null) {
      throw new InvalidOperationException("Double take");
    }
    string value;
    unsafe {
      fixed (byte* bufferPtr = buffer) {
        value = Marshal.PtrToStringUTF8((nint)bufferPtr)!;
      }
    }
    ArrayPool<byte>.Shared.Return(buffer);
    buffer = null;
    return value;
  }

  public byte[] TakeBuffer()
  {
    if (buffer == null) {
      throw new InvalidOperationException("Double take");
    }
    var value = buffer.AsSpan().ToArray();
    ArrayPool<byte>.Shared.Return(buffer);
    buffer = null;
    return value;
  }

  ~NativeVariantType()
  {
    if (buffer != null) {
      ArrayPool<byte>.Shared.Return(buffer);
    }
  }

  [MethodImpl(MethodImplOptions.AggressiveInlining)]
  private static int GetSize(Variant type)
  {
    return type switch
    {
      Variant.VAR_BOOL => 1,
      Variant.VAR_BYTE => 1,
      Variant.VAR_INT16 => 2,
      Variant.VAR_UINT16 => 2,
      Variant.VAR_INT32 => 4,
      Variant.VAR_UINT32 => 4,
      Variant.VAR_INT64 => 8,
      Variant.VAR_UINT64 => 8,
      Variant.VAR_FLOAT => 4,
      Variant.VAR_DOUBLE => 8,
      Variant.VAR_PTR => 8,
      Variant.VAR_ENUM => 8,
      Variant.VAR_VECTOR2D => 8,
      Variant.VAR_VECTOR3D => 12,
      Variant.VAR_VECTOR4D => 16,
      Variant.VAR_QANGLE => 12,
      Variant.VAR_QUATERNION => 16,
      Variant.VAR_COLOR => 12,
      Variant.VAR_MATRIX3X4 => 48,
      Variant.VAR_STRINGTOKEN => 4,
      Variant.VAR_EHANDLE => 4,
      _ => throw new ArgumentException($"Invalid or unsized variant type: {type}"),
    };
  }

  private static Variant ToVariantType<T>() where T : unmanaged
  {
    if (typeof(T) == typeof(bool)) return Variant.VAR_BOOL;
    if (typeof(T) == typeof(byte)) return Variant.VAR_BYTE;
    if (typeof(T) == typeof(short)) return Variant.VAR_INT16;
    if (typeof(T) == typeof(ushort)) return Variant.VAR_UINT16;
    if (typeof(T) == typeof(int)) return Variant.VAR_INT32;
    if (typeof(T) == typeof(uint)) return Variant.VAR_UINT32;
    if (typeof(T) == typeof(long)) return Variant.VAR_INT64;
    if (typeof(T) == typeof(ulong)) return Variant.VAR_UINT64;
    if (typeof(T) == typeof(float)) return Variant.VAR_FLOAT;
    if (typeof(T) == typeof(double)) return Variant.VAR_DOUBLE;
    if (typeof(T).IsEnum) return Variant.VAR_ENUM;
    if (typeof(T) == typeof(Vector2D)) return Variant.VAR_VECTOR2D;
    if (typeof(T) == typeof(Vector)) return Variant.VAR_VECTOR3D;
    if (typeof(T) == typeof(Vector4D)) return Variant.VAR_VECTOR4D;
    if (typeof(T) == typeof(QAngle)) return Variant.VAR_QANGLE;
    if (typeof(T) == typeof(Quaternion)) return Variant.VAR_QUATERNION;
    if (typeof(T) == typeof(Color)) return Variant.VAR_COLOR;
    if (typeof(T) == typeof(matrix3x4_t)) return Variant.VAR_MATRIX3X4;
    if (typeof(T) == typeof(CUtlStringToken)) return Variant.VAR_STRINGTOKEN;
    if (typeof(T).IsGenericType && typeof(T).GetGenericTypeDefinition() == typeof(CHandle<>)) return Variant.VAR_EHANDLE;
    throw new ArgumentException($"Invalid or unsized variant type: {typeof(T)}");
  }
}
