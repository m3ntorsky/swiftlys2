using System.Runtime.InteropServices;
using SwiftlyS2.Core.Natives;
using SwiftlyS2.Shared.SchemaDefinitions;
using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Shared.Natives;

[StructLayout(LayoutKind.Sequential, Size = 4)]
public struct CHandle<T> where T : class, ISchemaClass<T> {
  private uint _index;

  public uint Raw { 
    get => _index;
    set => _index = value;
  }

  public readonly T? Value {
    get {
      unsafe {
        if (!IsValid) {
          return null;
        }
        fixed(void* ptr = &this) {
          return (T?)T.From((nint)NativeEntity.HandleGet((nint)ptr));
        }
      }
    }
  }

  public readonly uint EntityIndex => _index & 0x7FFF;

  public readonly uint SerialNumber => (_index >> 15) & 0x1FFFF;

  public readonly bool IsValid {
    get {
      unsafe {
        fixed(void* ptr = &this) {
          return NativeEntity.HandleIsValid((nint)ptr);
        }
      }
    }
  }


  public static implicit operator T(CHandle<T> handle) => handle.Value;
}