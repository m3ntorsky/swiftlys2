using System.Runtime.InteropServices;

namespace SwiftlyS2.Shared.Natives;

[StructLayout(LayoutKind.Sequential, Size = 16)]
public struct CUtlMemory<T> {
  private nint _memory;
  private int _allocationCount;
  private int _growSize;

  public CUtlMemory() {
    throw new NotSupportedException("Use ManagedCUtlMemory instead.");
  }

  internal CUtlMemory(nint memory, int allocationCount, int growSize) {
    _memory = memory;
    _allocationCount = allocationCount;
    _growSize = growSize;
  }

  public nint Memory { get => _memory; internal set => _memory = value; }

  public int AllocationCount { get => _allocationCount; internal set => _allocationCount = value; }

  public int GrowSize { get => _growSize; internal set => _growSize = value; }

}
