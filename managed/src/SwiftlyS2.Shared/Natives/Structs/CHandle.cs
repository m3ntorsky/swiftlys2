using System.Runtime.InteropServices;
using SwiftlyS2.Core.Natives;
using SwiftlyS2.Shared.SchemaDefinitions;

namespace SwiftlyS2.Shared.Natives;

[StructLayout(LayoutKind.Sequential, Size = 4)]
public struct CHandle<T> where T : CEntityInstance {
  private uint _index;

  public uint Raw { 
    get => _index;
    set => _index = value;
  }

  public readonly T Value {
    get {
      nint ptr = 0; // TODO: Get entity from pointer with a safety check
      return NativeHandleConversion.As<T>(ptr);
    }
  }

  public readonly uint EntityIndex => _index & 0x7FFF;

  public readonly uint SerialNumber => (_index >> 15) & 0x1FFFF;

  public readonly bool IsValid => throw new NotImplementedException(); // TODO: Implement this with native entity system


  public static implicit operator T(CHandle<T> handle) => handle.Value;
}