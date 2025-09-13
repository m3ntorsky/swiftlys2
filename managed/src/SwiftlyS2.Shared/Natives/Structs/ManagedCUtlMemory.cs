using System.Runtime.InteropServices;

namespace SwiftlyS2.Shared.Natives;

public class ManagedCUtlMemory<T> where T : unmanaged {
  private CUtlMemory<T> _memory;

  public ManagedCUtlMemory(int growSize, int initSize) {
    nint ptr = 0; // TODO: call native allocator
    _memory = new CUtlMemory<T>(ptr, initSize, growSize);
  }

  public ref CUtlMemory<T> Value { get => ref _memory; }
}