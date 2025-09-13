using System.Collections;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Shared.Natives;

[StructLayout(LayoutKind.Sequential, Size = 24)]
public struct CUtlVector<T> : IEnumerable<T> where T : unmanaged {

  private int _size;
  private int _pad;
  private CUtlMemory<T> _utlMemory;

  public CUtlVector() {
    throw new NotSupportedException("Use ManagedCUtlVector instead.");
  }

  internal CUtlVector(CUtlMemory<T> memory) {
    _utlMemory = memory;
  }

  public int Size { get => _size; internal set => _size = value; }
  
  public CUtlMemory<T> Memory { get => _utlMemory; internal set => _utlMemory = value; }

  public ref T this[int index] => ref _utlMemory.Memory.AsRef<T>(index * Unsafe.SizeOf<T>());
  
  public IEnumerator<T> GetEnumerator() {
    for (int i = 0; i < _size; i++) {
      yield return _utlMemory.Memory.AsRef<T>(i * Unsafe.SizeOf<T>());
    }
  }

  IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
}

/// <summary>
/// Unsafe untyped cutlvector.
/// </summary>
[StructLayout(LayoutKind.Sequential, Size = 24)]
public struct CUtlVector
{


}