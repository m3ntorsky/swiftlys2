using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using SwiftlyS2.Core.Extensions;
using SwiftlyS2.Shared.Natives;
using SwiftlyS2.Shared.Natives.Handles;

namespace SwiftlyS2.Core.Natives.NativeObjects;

internal class CUtlVectorHandle : NativeHandle, IUtlVectorHandle {

  public int Count { 
    get => _Handle.Read<int>(0);
    private set => _Handle.Write(0,value);
  }

  public int ElementSize { get; private set; }

  public CUtlVectorHandle(nint handle, int elementSize) : base(handle) {
    ElementSize = elementSize;
  }

  public nint GetRawElementPointer(int index) {
    if (index < 0 || index >= Count) {
      throw new IndexOutOfRangeException();
    }
     return _Handle.Read<nint>(8) + index * ElementSize;
  }

}

internal class CUtlVectorHandle<T> : CUtlVectorHandle, IUtlVectorHandle<T> where T : unmanaged {

  public CUtlVectorHandle(nint handle) : base(handle, Unsafe.SizeOf<T>()) {
  }

  public ref T GetElement(int index) {
    unsafe { return ref Unsafe.AsRef<T>((T*)GetRawElementPointer(index)); }
  }

  public void SetElement(int index, T value) {
    GetRawElementPointer(index).Write(value);
  }

}

internal class CUtlVectorWithPointerHandle<T> : CUtlVectorHandle, IUtlVectorWithPointerHandle<T> where T : INativeHandle {

  public CUtlVectorWithPointerHandle(nint handle) : base(handle, 8) {}

  public T GetElement(int index) {
    throw new NotImplementedException();
    // return NativeHandle.As<T>(GetRawElementPointer(index).Read<nint>());
  }

}
