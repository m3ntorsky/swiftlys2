using System.Runtime.InteropServices;

namespace SwiftlyS2.Shared.Natives;

[StructLayout(LayoutKind.Sequential, Size = 24)]
public struct CUtlVector<T> {

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

}